using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BetterControls;
//using System.Threading;
namespace BiegPiastowDokumentacja
{
	public partial class frmMain : Form
	{
		private static int vOnChangeFieldCount = 0;
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			frmMain.vOnChangeFieldCount++;
			// TODO: This line of code loads data into the 'bP_dataset.bp_user' table. You can move, or remove it, as needed.
			this.bp_userTableAdapter.Fill(this.bP_dataset.bp_user);
			// TODO: This line of code loads data into the 'bP_dataset.bp_object' table. You can move, or remove it, as needed.
			this.bp_objectTableAdapter.Fill(this.bP_dataset.bp_object);
			// TODO: This line of code loads data into the 'bP_dataset1.bpObjectsLis' table. You can move, or remove it, as needed.
			this.bpObjectsLisTableAdapter.Fill(this.bP_dataset.bpObjectsLis);
			// TODO: This line of code loads data into the 'bP_dataset.bp_dict_type_level' table. You can move, or remove it, as needed.
			this.bp_dict_type_levelTableAdapter.Fill(this.bP_dataset.bp_dict_type_level);
			// TODO: This line of code loads data into the 'bP_dataset.yearsList' table. You can move, or remove it, as needed.
			this.yearsListTableAdapter.Fill(this.bP_dataset.yearsList);
			// TODO: This line of code loads data into the 'bP_dataset.bp_dict_listorder' table. You can move, or remove it, as needed.
			this.bp_dict_listorderTableAdapter.Fill(this.bP_dataset.bp_dict_listorder);
			// TODO: This line of code loads data into the 'bP_dataset.bp_document' table. You can move, or remove it, as needed.
			this.bp_documentTableAdapter.Fill(this.bP_dataset.bp_document);
			// TODO: This line of code loads data into the 'bP_dataset.bp_group' table. You can move, or remove it, as needed.
			this.bp_groupTableAdapter.Fill(this.bP_dataset.bp_group);
			// TODO: This line of code loads data into the 'bP_dataset.bp_document_group' table. You can move, or remove it, as needed.
			this.bp_document_groupTableAdapter.Fill(this.bP_dataset.bp_document_group);
			frmMain.vOnChangeFieldCount--;
			clearFilterParameters();
		}

		private void setLevelFilterLists(BetterControls.MultivalueListBox thisItem, bool useExtendFilter)
		{
			BetterControls.MultivalueListBox nextItem = (BetterControls.MultivalueListBox)thisItem.Parent.Controls[thisItem.descName];
			if (thisItem._filtering)
			{
				return;
			}
			if (nextItem != null)
			{
				nextItem._filtering = true;
				string vFilter = nextItem.BaseFilter;
				if (useExtendFilter)
				{
					if (thisItem.SelectedItems.Count > 0)
					{
						vFilter += " " + nextItem.ExtFilter + " " + thisItem.selectedValuesString(elementWrapper: nextItem.isFilterElementString ? "'" : "");
					}
					else
					{
						vFilter = "0=1";
					}
				}
				//preserve previous selection after set filter
				object[] aSelectionStorage = new object[nextItem.SelectedItems.Count];
				nextItem.SelectedItems.CopyTo(aSelectionStorage, 0);
				((BindingSource)nextItem.DataSource).Filter = vFilter;
				nextItem.ClearSelected();
				foreach (object xItem in aSelectionStorage)
				{
					if (nextItem.Items.Contains(xItem))
					{
						nextItem.SelectedItems.Add(xItem);
					}
				}
				nextItem._filtering = false;
				if (nextItem.descName != "")
				{
					setLevelFilterLists(nextItem, useExtendFilter);
				}
			}
		}
		private void TreeView1_BeforeSelect(Object sender, TreeViewCancelEventArgs e)
		{
			if (e.Node.Nodes.Count > 0)
				e.Cancel = true;
		}

		private void TreeNodeGenerate()
		{
			if (frmMain.vOnChangeFieldCount > 0)
			{
				return;
			}
			int NodesNumber;
			DataTable dt = getDecisionListTreeData(out NodesNumber);
			bool _OnlyNodesExpand = dt.AsEnumerable().Count() > 100;
			TreeNode mainNode = new TreeNode("Root");

			for (int i = 1; i <= NodesNumber; i++)
			{

				DataTable nodes = dt.DefaultView.ToTable(true, Enumerable.Range(1, i).Select(el => "group_" + el.ToString()).ToArray<string>());
				AddNodeToCol(mainNode, nodes, _OnlyNodesExpand);
			}

			AddDocumentToNode(mainNode, dt);
			treeView1.Nodes.Clear();
			bpdocumentBindingSource.Filter = " 0=1 ";
			foreach (TreeNode vNode in mainNode.Nodes)
			{
				treeView1.Nodes.Add(vNode);
			}

			if (!_OnlyNodesExpand)
				treeView1.ExpandAll();
			if (treeView1.Nodes.Count > 0)
			{
				treeView1.Nodes[0].EnsureVisible();
				TreeNode currNode = treeView1.Nodes[0];
				while (currNode.FirstNode != null)
				{
					currNode = currNode.FirstNode;
				};
				treeView1.SelectedNode = currNode;
			}



			treeView1.BeforeSelect += new TreeViewCancelEventHandler(TreeView1_BeforeSelect);
		}

		private void AddNodeToCol(TreeNode nodeRoot, DataTable nodesTable, bool _OnlyNodesExpand)
		{
			foreach (DataRow nodeRow in nodesTable.AsEnumerable())
			{
				int nodePointer = nodeRow.ItemArray.Count() - 1;
				string vTxt = nodeRow.ItemArray[nodePointer].ToString();
				string vKey = vTxt + "_stg_" + nodePointer.ToString();
				if (vTxt != "")
				{
					TreeNode currNode = nodeRoot;
					string currNodeName = "";
					for (int i = 0; i < nodePointer; i++)
					{
						currNodeName = nodeRow.ItemArray[i].ToString();
						currNode = currNodeName != "" ? currNode.Nodes[currNodeName + "_stg_" + i.ToString()] : currNode;
					}
					if (_OnlyNodesExpand)
					{
						currNode.Expand();
					}
					currNode.Nodes.Add(vKey, vTxt);

				}
			}
		}
		private void AddDocumentToNode(TreeNode nodeRoot, DataTable DocListTable)
		{
			int vShift = 2; //Two first fields aren't goup_XX field
			foreach (DataRow nodeRow in DocListTable.AsEnumerable())
			{
				int nodePointer = nodeRow.ItemArray.Count();
				string vTxt = nodeRow.ItemArray[0].ToString();
				string vKey = nodeRow.ItemArray[1].ToString();
				TreeNode currNode = nodeRoot;
				string currNodeName = "";
				for (int i = vShift; i < nodePointer; i++)
				{
					currNodeName = nodeRow.ItemArray[i].ToString();
					currNode = currNodeName != "" ? currNode.Nodes[currNodeName + "_stg_" + (i - vShift).ToString()] : currNode;
				}
				currNode.Nodes.Add(vKey, vTxt);
			}
		}
		private DataTable getDecisionListTreeData(out int vNodesNumber)
		{
			#region Generate query string for getting list of documents from RDB


			string vQuery =
@"
SELECT
	doctxt, docid{4}
FROM
(
	SELECT
		CONCAT(to_char(bp_document.document_date, 'YYYY-MM-DD'),' (', bp_document.id, ')', bp_document.title) as doctxt,
		bp_document.id as docid
	--List field for grouping documents:
		{1}

	FROM
		bp_document LEFT JOIN
		bp_dict_type_level  l1 ON bp_document.level1_id=l1.id LEFT JOIN
		bp_dict_type_level  l2 ON bp_document.level2_id=l2.id LEFT JOIN
		bp_dict_type_level  l3 ON bp_document.level3_id=l3.id LEFT JOIN
		bp_object on bp_document.object_id = bp_object.id LEFT JOIN
		bp_document_group ON bp_document.id = bp_document_group.document_id LEFT JOIN
		bp_group ON bp_document_group.group_id = bp_group.id
	{0}

	GROUP BY
		doctxt, docid{3}
) as x
ORDER BY
	{2} docid desc
";
			#endregion
			#region query's parameters format
			List<RecordSettings> vParams = getDocListSetQuery();
			//parameters for WHERE
			string vFilterQuery = vParams.OfType<FilterRecord>().Aggregate("", (a, b) => a + (((a != "" & b.getSubQueryString() != "") ? " AND " : "") + b.getSubQueryString()));
			string[] aQueriesParts = new string[2] { "", "" };

			string[] QueryItems = new string[2] { "", "" };
			int ItemSortCount = 0;
			int ItemGroupCount = 0;
			string vSepearator = ", ";
			foreach (SortRecord Item in vParams.OfType<SortRecord>())
			{
				switch (Item.Type)
				{
					case RecordSettingType.sort:
						aQueriesParts = Item.getSelectQueryParts(ref ItemSortCount);
						//ItemSortCount += (aQueriesParts[0] != "") ? Item.FieldsNumber : 0;
						break;
					case RecordSettingType.group:
						aQueriesParts = ((GroupRecord)Item).getSelectQueryParts(ref ItemSortCount, ref ItemGroupCount);
						break;
				}

				if (aQueriesParts[0] != "") //then other rows aren't empty
				{
					QueryItems[0] = string.Concat(QueryItems[0], vSepearator, aQueriesParts[0]);
					QueryItems[1] = string.Concat(QueryItems[1], aQueriesParts[1], vSepearator);
				}
			}
			vNodesNumber = ItemGroupCount;
			string vGroupByQueryPart = "";
			string vFinalFieldSelector = "";
			if (ItemGroupCount > 0)
			{
				vGroupByQueryPart = ", " + Enumerable.Range(1, ItemGroupCount).Select(Item => string.Format(" group_{0}", Item)).Aggregate("", (vTxt, vItem) => string.Concat(vTxt, vTxt != "" ? ", " : "", vItem));
				vFinalFieldSelector = vGroupByQueryPart;
			}
			if (ItemSortCount > 0)
			{
				vGroupByQueryPart += ", " + Enumerable.Range(1, ItemSortCount).Select(Item => string.Format(" sort_{0}", Item)).Aggregate("", (vTxt, vItem) => string.Concat(vTxt, vTxt != "" ? ", " : "", vItem));
			}


			vQuery = string.Format(vQuery,
				(
					vFilterQuery != "" ? " WHERE " + vFilterQuery : ""),
					QueryItems[0],
					QueryItems[1],
					vGroupByQueryPart,
					vFinalFieldSelector
				);
			#endregion


			OdbcCommand sqlcmd = new OdbcCommand(vQuery, odbcConnection1);
			OdbcDataAdapter sqlda = new OdbcDataAdapter(sqlcmd);
			DataTable dt = new DataTable();
			sqlda.Fill(dt);
			return dt;
		}

		public List<RecordSettings> getDocListSetQuery()
		{
			List<RecordSettings> vFilters;

			//get filter data

			vFilters = new List<RecordSettings>();
			//List<int> xx = this.docsrchYear.Items.OfType<int>().ToList();
			//List<string> a = this.DocsrchLev1.SelectedItems.Cast<string>().Select(ax => ax.ToString()).ToList<string>();
			vFilters.Add(new FilterRecord("byYear", this.docsrchYear.SelectedItems.Cast<DataRowView>().Select(x => x.Row.ItemArray[0].ToString()).OrderBy(x => x).ToList<string>(), " date_part('year', document_date) IN ({0}) ", ""));
			vFilters.Add(new FilterRecord("byType1", this.DocsrchLev1.SelectedItems.Cast<DataRowView>().Select(x => x.Row.ItemArray[0].ToString()).ToList<string>(), " level1_id in ({0}) ", ""));
			vFilters.Add(new FilterRecord("byType2", this.DocsrchLev2.SelectedItems.Cast<DataRowView>().Select(x => x.Row.ItemArray[0].ToString()).ToList<string>(), " level2_id in ({0}) ", ""));
			vFilters.Add(new FilterRecord("byType3", this.DocsrchLev3.SelectedItems.Cast<DataRowView>().Select(x => x.Row.ItemArray[0].ToString()).ToList<string>(), " level3_id in ({0}) ", ""));
			vFilters.Add(new FilterRecord("byTag", this.docsrchTags.SelectedItems.Cast<DataRowView>().Select(x => x.Row.ItemArray[0].ToString()).ToList<string>(), " bp_document.id IN (select document_id FROM bp_document_group WHERE group_id IN ({0})) ", ""));
			//vFilters.Add(new FilterRecord("byPerson", this.docsrchPrsns.SelectedItems.Cast<DataRowView>().Select(x => x.Row.ItemArray[0].ToString()).ToList<string>()));
			int TestInt;
			if (int.TryParse(this.txtDocSrchFree.Text, out TestInt))
			{
				vFilters.Add(new FilterRecord("byText", new List<string> { this.txtDocSrchFree.Text }, "bp_document.id={0}", "", ""));
			}
			else if (this.txtDocSrchFree.Text != "")
			{
				vFilters.Add(new FilterRecord("byText", new List<string> { this.txtDocSrchFree.Text }, "(UPPER(bp_document.title) like UPPER('%{0}%') OR UPPER(bp_document.description) like UPPER('%{0}%'))", "", ""));
			}
			if (this.cmbDocListGrp1.SelectedIndex > 0)
				vFilters.Add(new GroupRecord("grp1", Convert.ToInt16(this.cmbDocListGrp1.SelectedValue), ((DataRowView)this.cmbDocListGrp1.SelectedItem).Row.ItemArray[4].ToString(), ((DataRowView)this.cmbDocListGrp1.SelectedItem).Row.ItemArray[6].ToString(), Convert.ToInt16(((DataRowView)this.cmbDocListGrp1.SelectedItem).Row.ItemArray[5]), ((DataRowView)this.cmbDocListGrp1.SelectedItem).Row.ItemArray[7].ToString()));
			if (this.cmbDocListGrp2.SelectedIndex > 0)
				vFilters.Add(new GroupRecord("grp2", Convert.ToInt16(this.cmbDocListGrp2.SelectedValue), ((DataRowView)this.cmbDocListGrp2.SelectedItem).Row.ItemArray[4].ToString(), ((DataRowView)this.cmbDocListGrp2.SelectedItem).Row.ItemArray[6].ToString(), Convert.ToInt16(((DataRowView)this.cmbDocListGrp2.SelectedItem).Row.ItemArray[5]), ((DataRowView)this.cmbDocListGrp2.SelectedItem).Row.ItemArray[7].ToString()));
			if (this.cmbDocListGrp3.SelectedIndex > 0)
				vFilters.Add(new GroupRecord("grp3", Convert.ToInt16(this.cmbDocListGrp3.SelectedValue), ((DataRowView)this.cmbDocListGrp3.SelectedItem).Row.ItemArray[4].ToString(), ((DataRowView)this.cmbDocListGrp3.SelectedItem).Row.ItemArray[6].ToString(), Convert.ToInt16(((DataRowView)this.cmbDocListGrp3.SelectedItem).Row.ItemArray[5]), ((DataRowView)this.cmbDocListGrp3.SelectedItem).Row.ItemArray[7].ToString()));

			if ((this.cmbDocListSort1.SelectedIndex > 0) && (vFilters.Where(item => item.QuerySortSchema == ((DataRowView)this.cmbDocListSort1.SelectedItem).Row.ItemArray[4].ToString()).Count() == 0))
				vFilters.Add(new SortRecord("sort1", Convert.ToInt16(this.cmbDocListSort1.SelectedValue), ((DataRowView)this.cmbDocListSort1.SelectedItem).Row.ItemArray[4].ToString(), Convert.ToInt16(((DataRowView)this.cmbDocListSort1.SelectedItem).Row.ItemArray[5]), ((DataRowView)this.cmbDocListSort1.SelectedItem).Row.ItemArray[7].ToString()));
			if ((this.cmbDocListSort2.SelectedIndex > 0) && (vFilters.Where(item => item.QuerySortSchema == ((DataRowView)this.cmbDocListSort2.SelectedItem).Row.ItemArray[4].ToString()).Count() == 0))
				vFilters.Add(new SortRecord("sort2", Convert.ToInt16(this.cmbDocListSort2.SelectedValue), ((DataRowView)this.cmbDocListSort2.SelectedItem).Row.ItemArray[4].ToString(), Convert.ToInt16(((DataRowView)this.cmbDocListSort2.SelectedItem).Row.ItemArray[5]), ((DataRowView)this.cmbDocListSort2.SelectedItem).Row.ItemArray[7].ToString()));
			if ((this.cmbDocListSort3.SelectedIndex > 0) && (vFilters.Where(item => item.QuerySortSchema == ((DataRowView)this.cmbDocListSort3.SelectedItem).Row.ItemArray[4].ToString()).Count() == 0))
				vFilters.Add(new SortRecord("sort3", Convert.ToInt16(this.cmbDocListSort3.SelectedValue), ((DataRowView)this.cmbDocListSort3.SelectedItem).Row.ItemArray[4].ToString(), Convert.ToInt16(((DataRowView)this.cmbDocListSort3.SelectedItem).Row.ItemArray[5]), ((DataRowView)this.cmbDocListSort3.SelectedItem).Row.ItemArray[7].ToString()));
			return vFilters;
		}

		private void SetFilterParameter(object sender)
		{
			frmMain.vOnChangeFieldCount++;
			switch (((Control)sender).Name)
			{
				case "DocsrchLev1":
				case "DocsrchLev2":
					setLevelFilterLists((BetterControls.MultivalueListBox)sender, chck_LevelsListFiltering.Checked);
					break;
				case "chck_LevelsListFiltering":
					setLevelFilterLists(DocsrchLev1, ((CheckBox)sender).Checked);
					break;
				case "btnClearFilter":
					clearFilterParameters();
					break;
			}
			frmMain.vOnChangeFieldCount--;
		}
		private void clearFilterParameters()
		{
			docsrchYear.SelectedItems.Clear();
			docsrchTags.SelectedItems.Clear();
			DocsrchLev1.SelectedItems.Clear();
			this.docsrchTags.ClearSelected();
			chck_LevelsListFiltering.Checked = true;
			cmbDocListGrp1.SelectedIndex = 3;
			cmbDocListGrp2.SelectedIndex = 0;
			cmbDocListGrp3.SelectedIndex = 0;
			cmbDocListSort1.SelectedIndex = 1;
			cmbDocListSort2.SelectedIndex = 0;
			cmbDocListSort3.SelectedIndex = 0;
			txtDocSrchFree.Text = "";
		}
		private void FilterParameterChanged(object sender, EventArgs e)
		{
			SetFilterParameter(sender);
			TreeNodeGenerate();
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			bpdocumentBindingSource.Filter = e.Node == null ? "0 = 1" : string.Format(" id = {0} ", e.Node.Name);
			//txtDocDescription.Text = string.Format("{0}{3}<<<<<<<<<<<<<<<<{3}{1}{3}>>>>>>>>>>>>>>>>>>>>{3}{2}", e.Node.PrevNode.Text, e.Node.Text, e.Node.NextNode.Text, Environment.NewLine);
		}

		private void treeView1_KeyDown(object sender, KeyEventArgs e)
		{
			TreeNode currdNode = ((TreeView)sender).SelectedNode;
			if (e.Modifiers == Keys.None)
			{
				switch (e.KeyCode)
				{
					case Keys.Down:
						if (currdNode.NextNode == null)
						{
							while ((currdNode = currdNode.Parent) != null)
							{
								if (currdNode.NextNode != null)
								{
									currdNode = currdNode.NextNode;
									while (currdNode.GetNodeCount(false) > 0)
									{
										currdNode = currdNode.Nodes[0];
									}
									treeView1.SelectedNode = currdNode;
									e.SuppressKeyPress = true;
									return;
								}
							}

						}

						break;
					case Keys.Up:
						if (currdNode.PrevNode == null)
						{
							while ((currdNode = currdNode.Parent) != null)
							{
								if (currdNode.PrevNode != null)
								{
									currdNode = currdNode.PrevNode;
									while (currdNode.GetNodeCount(false) > 0)
									{
										currdNode = currdNode.LastNode;// [currdNode.GetNodeCount(false)-1];
									}
									treeView1.SelectedNode = currdNode;
									e.SuppressKeyPress = true;
									return;
								}
							}

						}

						break;
				}
			}

		}

		private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
		{

		}

		private void cmbDocTypeLevel1_SelectedIndexChanged(object sender, EventArgs e)
		{
			doclevel_l2.Filter = string.Format("parent_id = 0{0}", cmbDocTypeLevel1.SelectedValue);
			cmbDocTypeLevel2.Visible = doclevel_l2.Count == 0 ? false : true;
			cmbDocTypeLevel2.SelectedIndex = -1;
		}

		private void cmbDocTypeLevel2_SelectedIndexChanged(object sender, EventArgs e)
		{
			doclevel_l3.Filter = string.Format("parent_id = 0{0}", cmbDocTypeLevel2.SelectedValue);
			cmbDocTypeLevel3.Visible = doclevel_l3.Count == 0 ? false : true;
			cmbDocTypeLevel3.SelectedIndex = -1;
		}



		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			frmMain.vOnChangeFieldCount++;
			SetFilterParameter(this.btnClearFilter);
		}

		private void cmbPersonName_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool _block;
			int currObjectIndex = ((ComboBox)sender).SelectedIndex;
			if (currObjectIndex == -1)
			{
				((ComboBox)sender).SelectedIndex = 0;
				return;
			}
			_block = currObjectIndex == 0 ? false : true;
			txtPersonName.Visible = !_block;
			txtPersonAdress.Enabled = !_block;
			txtPersonEmail.Enabled = !_block;
			txtPersonName.Enabled = !_block;
			txtPersonPhone.Enabled = !_block;
			bp_objectBindingSource.Filter = string.Format(" id={0} ", ((ComboBox)sender).SelectedValue);


		}

		private void bpdocumentBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			string vItemId;
			vItemId = bpdocumentBindingSource.Current != null ? ((DataRowView)bpdocumentBindingSource.Current).Row["stat_creator_id"].ToString() : "-1 ";
			bp_creator.Filter = "id = " + vItemId;
			vItemId = bpdocumentBindingSource.Current != null ? ((DataRowView)bpdocumentBindingSource.Current).Row["stat_lastmodifier_id"].ToString() : "-1 ";
			bp_modifier.Filter = "id = " + vItemId;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

		}
	}
    }
