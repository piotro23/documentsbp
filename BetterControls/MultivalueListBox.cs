using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BetterControls
{
    
    public partial class MultivalueListBox : ListBox
    {
        public bool _filtering { get; set; }

        [Category("Changes cascade")]
        [Description("Show settings for descendant")]
        public string descName { get; set; }
        [Category("Changes cascade")]
        [Description("Show settings for descendant")]        
        public string BaseFilter{get; set;}
        [Category("Changes cascade")]
        [Description("Show settings for descendant")]
        public string ExtFilter { get; set; }
        [Category("Changes cascade")]
        [Description("Show settings for descendant")]
        [DefaultValue(true)]
        public bool isFilterElementString { get; set; }

        public MultivalueListBox()
        {
            InitializeComponent();
            _filtering = false;
        }
        /// <summary>
        /// Change collection of selected items into text string
        /// </summary>
        /// <param name="separator">Text string between items</param>
        /// <param name="_parenthesis">If string must be rounded by parenthesis</param>
        /// <param name="isElementString">False value prevent item against wraping by 'elementWraper'</param>
        /// <param name="elementWrapper">String text for wraping item element</param>
        /// <returns></returns>
        public string selectedValuesString(string separator = ", ",  bool _parenthesis=true, bool isElementString = false, string elementWrapper="'")
        {
            if (this.SelectedItems.Count > 0)
            {
                string buffer = "";
                foreach (System.Data.DataRowView xItem in this.SelectedItems)
                {
                    if (isElementString)
                    {
                        buffer += elementWrapper + xItem.Row.Field<string>(1) + elementWrapper + separator;
                    }
                    else
                    {
                        Int64 buffer2 = xItem.Row.Field<Int64>(0);
                        buffer += elementWrapper + buffer2.ToString() + elementWrapper + separator;
                    }
                }
                buffer = buffer.Substring(0, buffer.Length - separator.Length);
                return (_parenthesis ? "(" + buffer + ")" : buffer);
            }
            else
            {
                return "";
            }
        }

		


        /*

                private object m_LastAcceptedSelectedIndex;
                private bool m_IgnoreNullPreviousIndexChanging = false;
                [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
                [Browsable(false)]
                public object LastAcceptedSelectedIndex
                {
                    get { return m_LastAcceptedSelectedIndex; }
                    private set { m_LastAcceptedSelectedIndex = value; }
                }

                [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
                [Browsable(true)]
                public bool IgnoreNullPreviousIndexChanging
                {
                    get { return m_IgnoreNullPreviousIndexChanging; }
                    set { m_IgnoreNullPreviousIndexChanging = value; }
                }

                protected void OnSelectedIndexChanging(CancelEventArgs e)
                {
                    if (SelectedIndexChanging != null)
                        SelectedIndexChanging(this, e);
                }
                protected override void OnSelectedIndexChanged(EventArgs e)
                {
                    if (SelectedIndexChanging != null)
                    {
                        if (
                                (
                                    !m_IgnoreNullPreviousIndexChanging ||
                                    LastAcceptedSelectedIndex != null
                                ) &&
                                (LastAcceptedSelectedIndex ?? string.Empty).ToString() != ((SelectedIndex > 0 ? SelectedValue : null) ?? string.Empty).ToString()
                           )
                        {
                            CancelEventArgs cancelEventArgs = new CancelEventArgs();
                            OnSelectedIndexChanging(cancelEventArgs);

                            if (!cancelEventArgs.Cancel)
                            {
                                LastAcceptedSelectedIndex = SelectedValue;
                                base.OnSelectedValueChanged(e);
                            }
                            else
                                SelectedValue = LastAcceptedSelectedIndex;
                        }
                        else if (m_IgnoreNullPreviousIndexChanging &&
                                    LastAcceptedSelectedIndex == null
                                    && SelectedValue != null)
                        {
                            LastAcceptedSelectedIndex = SelectedValue;
                        }
                    }
                    else
                    {
                        base.OnSelectedIndexChanged(e);
                    }
                }
        */

    }
}
