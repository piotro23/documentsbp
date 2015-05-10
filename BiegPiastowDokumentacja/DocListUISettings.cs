using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiegPiastowDokumentacja
{
	public enum RecordSettingType {filter, group, sort}
	public interface RecordSettings
	{
		RecordSettingType Type { get;}
		string Name { get; set; }
		string QuerySortSchema { get; set; }
		//string getSubQueryString();
	}

	public class SortRecord : RecordSettings
	{
		public virtual RecordSettingType Type { get { return RecordSettingType.sort; } }
		//public string ALIAS_SCHEMA = " sort_";
		public virtual string ALIAS_SCHEMA { get { return " sort_"; } }
		public string Name { get; set; }
		public int SelectedIndex { get; set; }
		public int FieldsNumber { get; set; } // number of fields in generated singular sql string
		public string QuerySortSchema { get; set; }
		public string SortDirection { get; set; }

		public SortRecord() { }
		public SortRecord(string _name, int _selectedIndex, string _querySchema, int _fieldsNumber=1, string _sortDirection="asc"):this()
		{
			this.Name = _name;
			this.SelectedIndex = _selectedIndex;
			this.QuerySortSchema = _querySchema;
			this.FieldsNumber = _fieldsNumber;
			this.SortDirection = _sortDirection;
		}
		virtual public string[] getQeryParts(ref int _startValue, string vQuerySchema, string vAliasSchema, bool bSetSort = true)
		{
			int vAliasIndex = _startValue +1;
			if (vQuerySchema != "")
			{
				//preparing list of aliases
				object[] x = Enumerable.Range(vAliasIndex, this.FieldsNumber).ToList<int>().ConvertAll(i => (object)string.Concat(vAliasSchema, i.ToString())).ToArray<object>();
				string vSelectPart = string.Format(vQuerySchema, x);
				string vSortPart = "";
				if (bSetSort)
				{
					vSortPart = x.Select(vItem => string.Concat(vItem.ToString(), " ", this.SortDirection)).Aggregate("", (vTemp, vItem) => String.Concat(vTemp, vTemp != "" ? ", " : "", vItem));
				}
				_startValue += this.FieldsNumber;
				return (new string[] {vSelectPart, vSortPart});
			}
			else
			{
				return (new string[] {"", ""});
			}
		}
		/// <summary>
		/// Method generates string which is a part of field list in a select clasule (field definitions with aliases)
		/// </summary>
		/// <param name="_startValue"></param>
		/// <returns>Array of strings where [0] - list of fields definition of select part of query, [1] list of sort elements, [2] list of gropu by elements</returns>
		virtual public string[] getSelectQueryParts(ref int _startValue)
		{
			return getQeryParts(ref _startValue, this.QuerySortSchema, this.ALIAS_SCHEMA, true);
		}
	}

	public class GroupRecord : SortRecord
	{
		public override RecordSettingType Type { get { return RecordSettingType.group; } }
		//public new string ALIAS_SCHEMA = " group_";
		public override string ALIAS_SCHEMA { get { return " group_"; } }
		public string QueryGroupSchema { get; set; }

		public GroupRecord(string _name, int x) { }
		public GroupRecord(string _name, int _selectedIndex, string _querySortSchema, string _queryGroupSchema = "", int _fieldsNumber = 1, string _sortDirection = "asc")
			: base(_name, _selectedIndex, _querySortSchema, _fieldsNumber, _sortDirection)
		{
			this.QueryGroupSchema = _queryGroupSchema != _querySortSchema ? _queryGroupSchema : "";
		}
		virtual public string[] getSelectQueryParts(ref int _startSortValue, ref int _startGroupValue)
		{
			if (this.QueryGroupSchema == "" || this.QueryGroupSchema == this.QuerySortSchema)
			{
				return getQeryParts(ref _startGroupValue, this.QuerySortSchema, this.ALIAS_SCHEMA, true);
			}
			else
			{
				string[] aTmpRslt1 = getQeryParts(ref _startGroupValue, this.QueryGroupSchema, this.ALIAS_SCHEMA, false);
				string[] aTmpRslt2 = getQeryParts(ref _startSortValue, this.QuerySortSchema, base.ALIAS_SCHEMA, true);
				return new string[] { string.Concat(aTmpRslt1[0], ", ", aTmpRslt2[0]), aTmpRslt2[1] };
			}
		}
	}
	public struct FilterRecord : RecordSettings
	{
		public RecordSettingType Type { get { return RecordSettingType.filter; } }
		public string Name { get; set; }
		public List<string> Args { get; set; }
		public string QuerySortSchema { get; set; }
		public string ElementWrapper { get; set; }
		public string ElementSeparator { get; set; }

		public FilterRecord(string _name, List<string> _args, string _querySchema ="{0}", string _elementWrapper = "'", string _elementSeparator = ", "):this()
		{
			this.Name = _name;
			this.Args = _args;
			this.QuerySortSchema = _querySchema;
			this.ElementWrapper = _elementWrapper;
			this.ElementSeparator = _elementSeparator;
		}
		public FilterRecord(string _name, string _querySchema ="{0}", string _elementWrapper = "'", string _elementSeparator = ", ")
			:this(_name, new List<string>(), _querySchema, _elementWrapper, _elementSeparator){ }

		public string getSubQueryString()
		{
			if (Args.Count>0)
			{
				string vSep = this.ElementSeparator;
				string vWrap = this.ElementWrapper;
				return string.Format(QuerySortSchema, Args.Aggregate("", (a, b) => String.Concat(a, (a!=""?vSep:"") , vWrap, b, vWrap)));
			}
			else
			{
				return "";
			}
		}
	}
}
