namespace BiegPiastowDokumentacja
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.tabApplication = new System.Windows.Forms.TabControl();
			this.tpgDocs = new System.Windows.Forms.TabPage();
			this.laypan_docMain = new System.Windows.Forms.TableLayoutPanel();
			this.laypan_docLeft = new System.Windows.Forms.TableLayoutPanel();
			this.pnlDocData = new System.Windows.Forms.Panel();
			this.txtLastModifiedPerson = new System.Windows.Forms.TextBox();
			this.bp_modifier = new System.Windows.Forms.BindingSource(this.components);
			this.bP_dataset = new BiegPiastowDokumentacja.Properties.DataSources.BP_dataset();
			this.txtLastModifaiedDate = new System.Windows.Forms.TextBox();
			this.lblLastModified = new System.Windows.Forms.Label();
			this.txtDocCreatePerson = new System.Windows.Forms.TextBox();
			this.bp_creator = new System.Windows.Forms.BindingSource(this.components);
			this.txtDocCreateData = new System.Windows.Forms.TextBox();
			this.bpdocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblDocCreated = new System.Windows.Forms.Label();
			this.grd_tags = new System.Windows.Forms.DataGridView();
			this.group = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.bpgroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.documentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fKbpdocumentgroupbpdocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnDocAttachAdd = new System.Windows.Forms.Button();
			this.dtpickDocData = new System.Windows.Forms.DateTimePicker();
			this.txtDocNumber = new System.Windows.Forms.TextBox();
			this.lblDocAttachment = new System.Windows.Forms.Label();
			this.pnlDocAttachment = new System.Windows.Forms.Panel();
			this.lblDocMoneyOut = new System.Windows.Forms.Label();
			this.lblDocDescription = new System.Windows.Forms.Label();
			this.txtDocDescription = new System.Windows.Forms.TextBox();
			this.txtDocMoneyOut = new System.Windows.Forms.TextBox();
			this.lblDocMoneyIn = new System.Windows.Forms.Label();
			this.pnlDocType = new System.Windows.Forms.Panel();
			this.cmbDocTypeLevel3 = new System.Windows.Forms.ComboBox();
			this.doclevel_l3 = new System.Windows.Forms.BindingSource(this.components);
			this.cmbDocTypeLevel2 = new System.Windows.Forms.ComboBox();
			this.doclevel_l2 = new System.Windows.Forms.BindingSource(this.components);
			this.cmbDocTypeLevel1 = new System.Windows.Forms.ComboBox();
			this.doclevel_l1 = new System.Windows.Forms.BindingSource(this.components);
			this.txtDocMoneyIn = new System.Windows.Forms.TextBox();
			this.pnlPerson = new System.Windows.Forms.Panel();
			this.cmbPersonName = new System.Windows.Forms.ComboBox();
			this.bpObjectsLisBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblPersonEmail = new System.Windows.Forms.Label();
			this.txtPersonEmail = new System.Windows.Forms.TextBox();
			this.bp_objectBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblPersonPhone = new System.Windows.Forms.Label();
			this.txtPersonPhone = new System.Windows.Forms.TextBox();
			this.lblPersonAdress = new System.Windows.Forms.Label();
			this.txtPersonAdress = new System.Windows.Forms.TextBox();
			this.lblPersonName = new System.Windows.Forms.Label();
			this.txtPersonName = new System.Windows.Forms.TextBox();
			this.txtDocTile = new System.Windows.Forms.TextBox();
			this.pnlDocFilter = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.DocsrchLev1 = new BetterControls.MultivalueListBox();
			this.docfilter_l1 = new System.Windows.Forms.BindingSource(this.components);
			this.docsrchYear = new System.Windows.Forms.ListBox();
			this.docfilter_year = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.docsrchPrsns = new System.Windows.Forms.ListBox();
			this.docsrchTags = new BetterControls.MultivalueListBox();
			this.bp_tagfilter = new System.Windows.Forms.BindingSource(this.components);
			this.DocsrchLev3 = new BetterControls.MultivalueListBox();
			this.docfilter_l3 = new System.Windows.Forms.BindingSource(this.components);
			this.DocsrchLev2 = new BetterControls.MultivalueListBox();
			this.docfilter_l2 = new System.Windows.Forms.BindingSource(this.components);
			this.pnlDoFiltercCommands = new System.Windows.Forms.TableLayoutPanel();
			this.chck_LevelsListFiltering = new System.Windows.Forms.CheckBox();
			this.btnClearFilter = new System.Windows.Forms.Button();
			this.txtDocSrchFree = new System.Windows.Forms.TextBox();
			this.cmbDocSrchPreSets = new System.Windows.Forms.ComboBox();
			this.pnlDocCommands = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.laypan_docRight = new System.Windows.Forms.TableLayoutPanel();
			this.laypanDocRightDown = new System.Windows.Forms.TableLayoutPanel();
			this.lblSort = new System.Windows.Forms.Label();
			this.cmbDocListGrp2 = new System.Windows.Forms.ComboBox();
			this.doclist_grp2 = new System.Windows.Forms.BindingSource(this.components);
			this.cmbDocListSort2 = new System.Windows.Forms.ComboBox();
			this.doclist_sort2 = new System.Windows.Forms.BindingSource(this.components);
			this.cmbDocListGrp1 = new System.Windows.Forms.ComboBox();
			this.doclist_grp1 = new System.Windows.Forms.BindingSource(this.components);
			this.cmbDocListSort1 = new System.Windows.Forms.ComboBox();
			this.doclist_sort1 = new System.Windows.Forms.BindingSource(this.components);
			this.cmbDocListGrp3 = new System.Windows.Forms.ComboBox();
			this.doclist_grp3 = new System.Windows.Forms.BindingSource(this.components);
			this.cmbDocListSort3 = new System.Windows.Forms.ComboBox();
			this.doclist_sort3 = new System.Windows.Forms.BindingSource(this.components);
			this.lblGroup = new System.Windows.Forms.Label();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.odbcConnection1 = new System.Data.Odbc.OdbcConnection();
			this.bp_dict_listorderTableAdapter = new BiegPiastowDokumentacja.Properties.DataSources.BP_datasetTableAdapters.bp_dict_listorderTableAdapter();
			this.yearsListTableAdapter = new BiegPiastowDokumentacja.Properties.DataSources.BP_datasetTableAdapters.yearsListTableAdapter();
			this.bp_dict_type_levelTableAdapter = new BiegPiastowDokumentacja.Properties.DataSources.BP_datasetTableAdapters.bp_dict_type_levelTableAdapter();
			this.bp_documentTableAdapter = new BiegPiastowDokumentacja.Properties.DataSources.BP_datasetTableAdapters.bp_documentTableAdapter();
			this.bp_document_groupTableAdapter = new BiegPiastowDokumentacja.Properties.DataSources.BP_datasetTableAdapters.bp_document_groupTableAdapter();
			this.fKbpdocumentgroupbpdocumentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.bp_groupTableAdapter = new BiegPiastowDokumentacja.Properties.DataSources.BP_datasetTableAdapters.bp_groupTableAdapter();
			this.bpObjectsLisTableAdapter = new BiegPiastowDokumentacja.Properties.DataSources.BP_datasetTableAdapters.bpObjectsLisTableAdapter();
			this.bp_objectTableAdapter = new BiegPiastowDokumentacja.Properties.DataSources.BP_datasetTableAdapters.bp_objectTableAdapter();
			this.fKbpdocumentgroupbpgroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bp_userTableAdapter = new BiegPiastowDokumentacja.Properties.DataSources.BP_datasetTableAdapters.bp_userTableAdapter();
			this.tabApplication.SuspendLayout();
			this.tpgDocs.SuspendLayout();
			this.laypan_docMain.SuspendLayout();
			this.laypan_docLeft.SuspendLayout();
			this.pnlDocData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bp_modifier)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bP_dataset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bp_creator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bpdocumentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grd_tags)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bpgroupBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKbpdocumentgroupbpdocumentBindingSource)).BeginInit();
			this.pnlDocType.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.doclevel_l3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doclevel_l2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doclevel_l1)).BeginInit();
			this.pnlPerson.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bpObjectsLisBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bp_objectBindingSource)).BeginInit();
			this.pnlDocFilter.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.docfilter_l1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.docfilter_year)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bp_tagfilter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.docfilter_l3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.docfilter_l2)).BeginInit();
			this.pnlDoFiltercCommands.SuspendLayout();
			this.pnlDocCommands.SuspendLayout();
			this.laypan_docRight.SuspendLayout();
			this.laypanDocRightDown.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.doclist_grp2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doclist_sort2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doclist_grp1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doclist_sort1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doclist_grp3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doclist_sort3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKbpdocumentgroupbpdocumentBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKbpdocumentgroupbpgroupBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabApplication
			// 
			this.tabApplication.Controls.Add(this.tpgDocs);
			this.tabApplication.Controls.Add(this.tabPage2);
			this.tabApplication.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabApplication.Location = new System.Drawing.Point(0, 0);
			this.tabApplication.Name = "tabApplication";
			this.tabApplication.SelectedIndex = 0;
			this.tabApplication.Size = new System.Drawing.Size(1040, 676);
			this.tabApplication.TabIndex = 0;
			// 
			// tpgDocs
			// 
			this.tpgDocs.Controls.Add(this.laypan_docMain);
			this.tpgDocs.Location = new System.Drawing.Point(4, 22);
			this.tpgDocs.Name = "tpgDocs";
			this.tpgDocs.Padding = new System.Windows.Forms.Padding(3);
			this.tpgDocs.Size = new System.Drawing.Size(1032, 650);
			this.tpgDocs.TabIndex = 0;
			this.tpgDocs.Text = "Dokumenty";
			this.tpgDocs.UseVisualStyleBackColor = true;
			// 
			// laypan_docMain
			// 
			this.laypan_docMain.ColumnCount = 2;
			this.laypan_docMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.laypan_docMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.laypan_docMain.Controls.Add(this.laypan_docLeft, 0, 0);
			this.laypan_docMain.Controls.Add(this.laypan_docRight, 1, 0);
			this.laypan_docMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.laypan_docMain.Location = new System.Drawing.Point(3, 3);
			this.laypan_docMain.Name = "laypan_docMain";
			this.laypan_docMain.RowCount = 1;
			this.laypan_docMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.laypan_docMain.Size = new System.Drawing.Size(1026, 644);
			this.laypan_docMain.TabIndex = 1;
			// 
			// laypan_docLeft
			// 
			this.laypan_docLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.laypan_docLeft.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.laypan_docLeft.ColumnCount = 1;
			this.laypan_docLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.laypan_docLeft.Controls.Add(this.pnlDocData, 0, 0);
			this.laypan_docLeft.Controls.Add(this.pnlDocFilter, 0, 2);
			this.laypan_docLeft.Controls.Add(this.pnlDoFiltercCommands, 0, 3);
			this.laypan_docLeft.Controls.Add(this.pnlDocCommands, 0, 1);
			this.laypan_docLeft.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.laypan_docLeft.Location = new System.Drawing.Point(3, 3);
			this.laypan_docLeft.Name = "laypan_docLeft";
			this.laypan_docLeft.RowCount = 4;
			this.laypan_docLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.laypan_docLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.laypan_docLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.laypan_docLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.laypan_docLeft.Size = new System.Drawing.Size(627, 639);
			this.laypan_docLeft.TabIndex = 0;
			// 
			// pnlDocData
			// 
			this.pnlDocData.AutoScroll = true;
			this.pnlDocData.Controls.Add(this.txtLastModifiedPerson);
			this.pnlDocData.Controls.Add(this.txtLastModifaiedDate);
			this.pnlDocData.Controls.Add(this.lblLastModified);
			this.pnlDocData.Controls.Add(this.txtDocCreatePerson);
			this.pnlDocData.Controls.Add(this.txtDocCreateData);
			this.pnlDocData.Controls.Add(this.lblDocCreated);
			this.pnlDocData.Controls.Add(this.grd_tags);
			this.pnlDocData.Controls.Add(this.btnDocAttachAdd);
			this.pnlDocData.Controls.Add(this.dtpickDocData);
			this.pnlDocData.Controls.Add(this.txtDocNumber);
			this.pnlDocData.Controls.Add(this.lblDocAttachment);
			this.pnlDocData.Controls.Add(this.pnlDocAttachment);
			this.pnlDocData.Controls.Add(this.lblDocMoneyOut);
			this.pnlDocData.Controls.Add(this.lblDocDescription);
			this.pnlDocData.Controls.Add(this.txtDocDescription);
			this.pnlDocData.Controls.Add(this.txtDocMoneyOut);
			this.pnlDocData.Controls.Add(this.lblDocMoneyIn);
			this.pnlDocData.Controls.Add(this.pnlDocType);
			this.pnlDocData.Controls.Add(this.txtDocMoneyIn);
			this.pnlDocData.Controls.Add(this.pnlPerson);
			this.pnlDocData.Controls.Add(this.txtDocTile);
			this.pnlDocData.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDocData.Location = new System.Drawing.Point(4, 4);
			this.pnlDocData.MinimumSize = new System.Drawing.Size(620, 320);
			this.pnlDocData.Name = "pnlDocData";
			this.pnlDocData.Size = new System.Drawing.Size(620, 350);
			this.pnlDocData.TabIndex = 1;
			// 
			// txtLastModifiedPerson
			// 
			this.txtLastModifiedPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtLastModifiedPerson.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bp_modifier, "shortcut", true));
			this.txtLastModifiedPerson.Enabled = false;
			this.txtLastModifiedPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtLastModifiedPerson.Location = new System.Drawing.Point(566, 325);
			this.txtLastModifiedPerson.Name = "txtLastModifiedPerson";
			this.txtLastModifiedPerson.Size = new System.Drawing.Size(42, 11);
			this.txtLastModifiedPerson.TabIndex = 27;
			// 
			// bp_modifier
			// 
			this.bp_modifier.DataMember = "bp_user";
			this.bp_modifier.DataSource = this.bP_dataset;
			this.bp_modifier.Filter = "0=1";
			// 
			// bP_dataset
			// 
			this.bP_dataset.DataSetName = "BP_dataset";
			this.bP_dataset.Locale = new System.Globalization.CultureInfo("pl-PL");
			this.bP_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// txtLastModifaiedDate
			// 
			this.txtLastModifaiedDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtLastModifaiedDate.Enabled = false;
			this.txtLastModifaiedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtLastModifaiedDate.Location = new System.Drawing.Point(482, 325);
			this.txtLastModifaiedDate.Name = "txtLastModifaiedDate";
			this.txtLastModifaiedDate.Size = new System.Drawing.Size(81, 11);
			this.txtLastModifaiedDate.TabIndex = 26;
			// 
			// lblLastModified
			// 
			this.lblLastModified.AutoSize = true;
			this.lblLastModified.Location = new System.Drawing.Point(361, 325);
			this.lblLastModified.Name = "lblLastModified";
			this.lblLastModified.Size = new System.Drawing.Size(121, 13);
			this.lblLastModified.TabIndex = 25;
			this.lblLastModified.Text = "Ostatnio zmodyfikowany";
			// 
			// txtDocCreatePerson
			// 
			this.txtDocCreatePerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDocCreatePerson.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bp_creator, "shortcut", true));
			this.txtDocCreatePerson.Enabled = false;
			this.txtDocCreatePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtDocCreatePerson.Location = new System.Drawing.Point(299, 325);
			this.txtDocCreatePerson.Name = "txtDocCreatePerson";
			this.txtDocCreatePerson.Size = new System.Drawing.Size(42, 11);
			this.txtDocCreatePerson.TabIndex = 24;
			// 
			// bp_creator
			// 
			this.bp_creator.DataMember = "bp_user";
			this.bp_creator.DataSource = this.bP_dataset;
			this.bp_creator.Filter = "0=1";
			// 
			// txtDocCreateData
			// 
			this.txtDocCreateData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDocCreateData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bpdocumentBindingSource, "stat_creation_date", true));
			this.txtDocCreateData.Enabled = false;
			this.txtDocCreateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtDocCreateData.Location = new System.Drawing.Point(212, 325);
			this.txtDocCreateData.Name = "txtDocCreateData";
			this.txtDocCreateData.Size = new System.Drawing.Size(81, 11);
			this.txtDocCreateData.TabIndex = 23;
			// 
			// bpdocumentBindingSource
			// 
			this.bpdocumentBindingSource.DataMember = "bp_document";
			this.bpdocumentBindingSource.DataSource = this.bP_dataset;
			this.bpdocumentBindingSource.Filter = "0=1";
			this.bpdocumentBindingSource.CurrentChanged += new System.EventHandler(this.bpdocumentBindingSource_CurrentChanged);
			// 
			// lblDocCreated
			// 
			this.lblDocCreated.AutoSize = true;
			this.lblDocCreated.Location = new System.Drawing.Point(154, 325);
			this.lblDocCreated.Name = "lblDocCreated";
			this.lblDocCreated.Size = new System.Drawing.Size(57, 13);
			this.lblDocCreated.TabIndex = 22;
			this.lblDocCreated.Text = "Utworzony";
			// 
			// grd_tags
			// 
			this.grd_tags.AutoGenerateColumns = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grd_tags.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.grd_tags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_tags.ColumnHeadersVisible = false;
			this.grd_tags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.group,
            this.idDataGridViewTextBoxColumn,
            this.documentidDataGridViewTextBoxColumn,
            this.groupidDataGridViewTextBoxColumn});
			this.grd_tags.DataSource = this.fKbpdocumentgroupbpdocumentBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grd_tags.DefaultCellStyle = dataGridViewCellStyle2;
			this.grd_tags.Location = new System.Drawing.Point(419, 101);
			this.grd_tags.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.grd_tags.Name = "grd_tags";
			this.grd_tags.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grd_tags.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.grd_tags.RowHeadersWidth = 20;
			this.grd_tags.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.grd_tags.RowTemplate.Height = 18;
			this.grd_tags.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.grd_tags.Size = new System.Drawing.Size(189, 115);
			this.grd_tags.TabIndex = 18;
			// 
			// group
			// 
			this.group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.group.DataPropertyName = "group_id";
			this.group.DataSource = this.bpgroupBindingSource;
			this.group.DisplayMember = "title";
			this.group.HeaderText = "group";
			this.group.MaxDropDownItems = 50;
			this.group.Name = "group";
			this.group.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.group.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.group.ValueMember = "id";
			// 
			// bpgroupBindingSource
			// 
			this.bpgroupBindingSource.DataMember = "bp_group";
			this.bpgroupBindingSource.DataSource = this.bP_dataset;
			this.bpgroupBindingSource.Filter = "";
			this.bpgroupBindingSource.Sort = "";
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// documentidDataGridViewTextBoxColumn
			// 
			this.documentidDataGridViewTextBoxColumn.DataPropertyName = "document_id";
			this.documentidDataGridViewTextBoxColumn.HeaderText = "document_id";
			this.documentidDataGridViewTextBoxColumn.Name = "documentidDataGridViewTextBoxColumn";
			this.documentidDataGridViewTextBoxColumn.Visible = false;
			// 
			// groupidDataGridViewTextBoxColumn
			// 
			this.groupidDataGridViewTextBoxColumn.DataPropertyName = "group_id";
			this.groupidDataGridViewTextBoxColumn.HeaderText = "group_id";
			this.groupidDataGridViewTextBoxColumn.Name = "groupidDataGridViewTextBoxColumn";
			this.groupidDataGridViewTextBoxColumn.Visible = false;
			// 
			// fKbpdocumentgroupbpdocumentBindingSource
			// 
			this.fKbpdocumentgroupbpdocumentBindingSource.DataMember = "FK_bp_document_group_bp_document";
			this.fKbpdocumentgroupbpdocumentBindingSource.DataSource = this.bpdocumentBindingSource;
			// 
			// btnDocAttachAdd
			// 
			this.btnDocAttachAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnDocAttachAdd.Location = new System.Drawing.Point(567, 240);
			this.btnDocAttachAdd.Name = "btnDocAttachAdd";
			this.btnDocAttachAdd.Size = new System.Drawing.Size(47, 16);
			this.btnDocAttachAdd.TabIndex = 16;
			this.btnDocAttachAdd.Text = "Dodaj";
			this.btnDocAttachAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btnDocAttachAdd.UseVisualStyleBackColor = true;
			// 
			// dtpickDocData
			// 
			this.dtpickDocData.CustomFormat = "dd-MMM-yyyy";
			this.dtpickDocData.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bpdocumentBindingSource, "document_date", true));
			this.dtpickDocData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dtpickDocData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpickDocData.Location = new System.Drawing.Point(85, 12);
			this.dtpickDocData.Name = "dtpickDocData";
			this.dtpickDocData.Size = new System.Drawing.Size(160, 29);
			this.dtpickDocData.TabIndex = 0;
			// 
			// txtDocNumber
			// 
			this.txtDocNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bpdocumentBindingSource, "id", true));
			this.txtDocNumber.Enabled = false;
			this.txtDocNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtDocNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.txtDocNumber.Location = new System.Drawing.Point(13, 10);
			this.txtDocNumber.Name = "txtDocNumber";
			this.txtDocNumber.Size = new System.Drawing.Size(67, 31);
			this.txtDocNumber.TabIndex = 0;
			this.txtDocNumber.TabStop = false;
			// 
			// lblDocAttachment
			// 
			this.lblDocAttachment.AutoSize = true;
			this.lblDocAttachment.Location = new System.Drawing.Point(353, 239);
			this.lblDocAttachment.Name = "lblDocAttachment";
			this.lblDocAttachment.Size = new System.Drawing.Size(57, 13);
			this.lblDocAttachment.TabIndex = 14;
			this.lblDocAttachment.Text = "Załączniki";
			// 
			// pnlDocAttachment
			// 
			this.pnlDocAttachment.BackColor = System.Drawing.Color.Transparent;
			this.pnlDocAttachment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlDocAttachment.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnlDocAttachment.Location = new System.Drawing.Point(349, 255);
			this.pnlDocAttachment.Name = "pnlDocAttachment";
			this.pnlDocAttachment.Size = new System.Drawing.Size(265, 58);
			this.pnlDocAttachment.TabIndex = 13;
			// 
			// lblDocMoneyOut
			// 
			this.lblDocMoneyOut.AutoSize = true;
			this.lblDocMoneyOut.Location = new System.Drawing.Point(352, 129);
			this.lblDocMoneyOut.Name = "lblDocMoneyOut";
			this.lblDocMoneyOut.Size = new System.Drawing.Size(40, 13);
			this.lblDocMoneyOut.TabIndex = 8;
			this.lblDocMoneyOut.Text = "Winien";
			// 
			// lblDocDescription
			// 
			this.lblDocDescription.AutoSize = true;
			this.lblDocDescription.Location = new System.Drawing.Point(15, 240);
			this.lblDocDescription.Name = "lblDocDescription";
			this.lblDocDescription.Size = new System.Drawing.Size(28, 13);
			this.lblDocDescription.TabIndex = 4;
			this.lblDocDescription.Text = "Opis";
			// 
			// txtDocDescription
			// 
			this.txtDocDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bpdocumentBindingSource, "description", true));
			this.txtDocDescription.Location = new System.Drawing.Point(12, 255);
			this.txtDocDescription.Multiline = true;
			this.txtDocDescription.Name = "txtDocDescription";
			this.txtDocDescription.Size = new System.Drawing.Size(326, 59);
			this.txtDocDescription.TabIndex = 5;
			// 
			// txtDocMoneyOut
			// 
			this.txtDocMoneyOut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bpdocumentBindingSource, "outcome", true));
			this.txtDocMoneyOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtDocMoneyOut.ForeColor = System.Drawing.Color.DarkRed;
			this.txtDocMoneyOut.Location = new System.Drawing.Point(349, 145);
			this.txtDocMoneyOut.Name = "txtDocMoneyOut";
			this.txtDocMoneyOut.Size = new System.Drawing.Size(67, 22);
			this.txtDocMoneyOut.TabIndex = 9;
			// 
			// lblDocMoneyIn
			// 
			this.lblDocMoneyIn.AutoSize = true;
			this.lblDocMoneyIn.Location = new System.Drawing.Point(352, 90);
			this.lblDocMoneyIn.Name = "lblDocMoneyIn";
			this.lblDocMoneyIn.Size = new System.Drawing.Size(22, 13);
			this.lblDocMoneyIn.TabIndex = 6;
			this.lblDocMoneyIn.Text = "Ma";
			// 
			// pnlDocType
			// 
			this.pnlDocType.Controls.Add(this.cmbDocTypeLevel3);
			this.pnlDocType.Controls.Add(this.cmbDocTypeLevel2);
			this.pnlDocType.Controls.Add(this.cmbDocTypeLevel1);
			this.pnlDocType.Location = new System.Drawing.Point(12, 50);
			this.pnlDocType.Name = "pnlDocType";
			this.pnlDocType.Size = new System.Drawing.Size(457, 30);
			this.pnlDocType.TabIndex = 2;
			// 
			// cmbDocTypeLevel3
			// 
			this.cmbDocTypeLevel3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bpdocumentBindingSource, "level3_id", true));
			this.cmbDocTypeLevel3.DataSource = this.doclevel_l3;
			this.cmbDocTypeLevel3.DisplayMember = "title";
			this.cmbDocTypeLevel3.FormattingEnabled = true;
			this.cmbDocTypeLevel3.Location = new System.Drawing.Point(305, 3);
			this.cmbDocTypeLevel3.Name = "cmbDocTypeLevel3";
			this.cmbDocTypeLevel3.Size = new System.Drawing.Size(145, 21);
			this.cmbDocTypeLevel3.TabIndex = 4;
			this.cmbDocTypeLevel3.ValueMember = "id";
			// 
			// doclevel_l3
			// 
			this.doclevel_l3.DataMember = "bp_dict_type_level";
			this.doclevel_l3.DataSource = this.bP_dataset;
			this.doclevel_l3.Filter = "level=3";
			// 
			// cmbDocTypeLevel2
			// 
			this.cmbDocTypeLevel2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bpdocumentBindingSource, "level2_id", true));
			this.cmbDocTypeLevel2.DataSource = this.doclevel_l2;
			this.cmbDocTypeLevel2.DisplayMember = "title";
			this.cmbDocTypeLevel2.FormattingEnabled = true;
			this.cmbDocTypeLevel2.Location = new System.Drawing.Point(154, 3);
			this.cmbDocTypeLevel2.Name = "cmbDocTypeLevel2";
			this.cmbDocTypeLevel2.Size = new System.Drawing.Size(145, 21);
			this.cmbDocTypeLevel2.TabIndex = 3;
			this.cmbDocTypeLevel2.ValueMember = "id";
			this.cmbDocTypeLevel2.SelectedIndexChanged += new System.EventHandler(this.cmbDocTypeLevel2_SelectedIndexChanged);
			// 
			// doclevel_l2
			// 
			this.doclevel_l2.DataMember = "bp_dict_type_level";
			this.doclevel_l2.DataSource = this.bP_dataset;
			this.doclevel_l2.Filter = "level=2";
			// 
			// cmbDocTypeLevel1
			// 
			this.cmbDocTypeLevel1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bpdocumentBindingSource, "level1_id", true));
			this.cmbDocTypeLevel1.DataSource = this.doclevel_l1;
			this.cmbDocTypeLevel1.DisplayMember = "title";
			this.cmbDocTypeLevel1.FormattingEnabled = true;
			this.cmbDocTypeLevel1.Location = new System.Drawing.Point(0, 3);
			this.cmbDocTypeLevel1.Name = "cmbDocTypeLevel1";
			this.cmbDocTypeLevel1.Size = new System.Drawing.Size(148, 21);
			this.cmbDocTypeLevel1.TabIndex = 2;
			this.cmbDocTypeLevel1.ValueMember = "id";
			this.cmbDocTypeLevel1.SelectedIndexChanged += new System.EventHandler(this.cmbDocTypeLevel1_SelectedIndexChanged);
			// 
			// doclevel_l1
			// 
			this.doclevel_l1.DataMember = "bp_dict_type_level";
			this.doclevel_l1.DataSource = this.bP_dataset;
			this.doclevel_l1.Filter = "level=1";
			// 
			// txtDocMoneyIn
			// 
			this.txtDocMoneyIn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bpdocumentBindingSource, "income", true));
			this.txtDocMoneyIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtDocMoneyIn.ForeColor = System.Drawing.Color.Green;
			this.txtDocMoneyIn.Location = new System.Drawing.Point(349, 106);
			this.txtDocMoneyIn.Name = "txtDocMoneyIn";
			this.txtDocMoneyIn.Size = new System.Drawing.Size(67, 22);
			this.txtDocMoneyIn.TabIndex = 7;
			// 
			// pnlPerson
			// 
			this.pnlPerson.Controls.Add(this.cmbPersonName);
			this.pnlPerson.Controls.Add(this.lblPersonEmail);
			this.pnlPerson.Controls.Add(this.txtPersonEmail);
			this.pnlPerson.Controls.Add(this.lblPersonPhone);
			this.pnlPerson.Controls.Add(this.txtPersonPhone);
			this.pnlPerson.Controls.Add(this.lblPersonAdress);
			this.pnlPerson.Controls.Add(this.txtPersonAdress);
			this.pnlPerson.Controls.Add(this.lblPersonName);
			this.pnlPerson.Controls.Add(this.txtPersonName);
			this.pnlPerson.Location = new System.Drawing.Point(12, 85);
			this.pnlPerson.Name = "pnlPerson";
			this.pnlPerson.Size = new System.Drawing.Size(334, 171);
			this.pnlPerson.TabIndex = 3;
			// 
			// cmbPersonName
			// 
			this.cmbPersonName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bpdocumentBindingSource, "object_id", true));
			this.cmbPersonName.DataSource = this.bpObjectsLisBindingSource;
			this.cmbPersonName.DisplayMember = "title";
			this.cmbPersonName.FormattingEnabled = true;
			this.cmbPersonName.Location = new System.Drawing.Point(1, 21);
			this.cmbPersonName.Name = "cmbPersonName";
			this.cmbPersonName.Size = new System.Drawing.Size(135, 21);
			this.cmbPersonName.TabIndex = 20;
			this.cmbPersonName.ValueMember = "id";
			this.cmbPersonName.SelectedIndexChanged += new System.EventHandler(this.cmbPersonName_SelectedIndexChanged);
			// 
			// bpObjectsLisBindingSource
			// 
			this.bpObjectsLisBindingSource.DataMember = "bpObjectsLis";
			this.bpObjectsLisBindingSource.DataSource = this.bP_dataset;
			// 
			// lblPersonEmail
			// 
			this.lblPersonEmail.AutoSize = true;
			this.lblPersonEmail.Location = new System.Drawing.Point(3, 115);
			this.lblPersonEmail.Name = "lblPersonEmail";
			this.lblPersonEmail.Size = new System.Drawing.Size(34, 13);
			this.lblPersonEmail.TabIndex = 4;
			this.lblPersonEmail.Text = "e-mail";
			// 
			// txtPersonEmail
			// 
			this.txtPersonEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bp_objectBindingSource, "email", true));
			this.txtPersonEmail.Location = new System.Drawing.Point(0, 131);
			this.txtPersonEmail.Name = "txtPersonEmail";
			this.txtPersonEmail.Size = new System.Drawing.Size(136, 20);
			this.txtPersonEmail.TabIndex = 5;
			// 
			// bp_objectBindingSource
			// 
			this.bp_objectBindingSource.DataMember = "bp_object";
			this.bp_objectBindingSource.DataSource = this.bP_dataset;
			// 
			// lblPersonPhone
			// 
			this.lblPersonPhone.AutoSize = true;
			this.lblPersonPhone.Location = new System.Drawing.Point(3, 76);
			this.lblPersonPhone.Name = "lblPersonPhone";
			this.lblPersonPhone.Size = new System.Drawing.Size(43, 13);
			this.lblPersonPhone.TabIndex = 2;
			this.lblPersonPhone.Text = "Telefon";
			// 
			// txtPersonPhone
			// 
			this.txtPersonPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bp_objectBindingSource, "phone", true));
			this.txtPersonPhone.Location = new System.Drawing.Point(0, 92);
			this.txtPersonPhone.Name = "txtPersonPhone";
			this.txtPersonPhone.Size = new System.Drawing.Size(136, 20);
			this.txtPersonPhone.TabIndex = 3;
			// 
			// lblPersonAdress
			// 
			this.lblPersonAdress.AutoSize = true;
			this.lblPersonAdress.Location = new System.Drawing.Point(144, 5);
			this.lblPersonAdress.Name = "lblPersonAdress";
			this.lblPersonAdress.Size = new System.Drawing.Size(34, 13);
			this.lblPersonAdress.TabIndex = 6;
			this.lblPersonAdress.Text = "Adres";
			// 
			// txtPersonAdress
			// 
			this.txtPersonAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bp_objectBindingSource, "address", true));
			this.txtPersonAdress.Location = new System.Drawing.Point(140, 21);
			this.txtPersonAdress.Multiline = true;
			this.txtPersonAdress.Name = "txtPersonAdress";
			this.txtPersonAdress.Size = new System.Drawing.Size(186, 130);
			this.txtPersonAdress.TabIndex = 7;
			// 
			// lblPersonName
			// 
			this.lblPersonName.AutoSize = true;
			this.lblPersonName.Location = new System.Drawing.Point(3, 5);
			this.lblPersonName.Name = "lblPersonName";
			this.lblPersonName.Size = new System.Drawing.Size(68, 13);
			this.lblPersonName.TabIndex = 0;
			this.lblPersonName.Text = "Osoba/Firma";
			// 
			// txtPersonName
			// 
			this.txtPersonName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bp_objectBindingSource, "title", true));
			this.txtPersonName.Location = new System.Drawing.Point(0, 53);
			this.txtPersonName.Name = "txtPersonName";
			this.txtPersonName.Size = new System.Drawing.Size(136, 20);
			this.txtPersonName.TabIndex = 1;
			// 
			// txtDocTile
			// 
			this.txtDocTile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bpdocumentBindingSource, "title", true));
			this.txtDocTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtDocTile.Location = new System.Drawing.Point(251, 12);
			this.txtDocTile.Name = "txtDocTile";
			this.txtDocTile.Size = new System.Drawing.Size(363, 29);
			this.txtDocTile.TabIndex = 1;
			// 
			// pnlDocFilter
			// 
			this.pnlDocFilter.Controls.Add(this.tableLayoutPanel1);
			this.pnlDocFilter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDocFilter.Location = new System.Drawing.Point(4, 392);
			this.pnlDocFilter.Name = "pnlDocFilter";
			this.pnlDocFilter.Size = new System.Drawing.Size(619, 208);
			this.pnlDocFilter.TabIndex = 2;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
			this.tableLayoutPanel1.Controls.Add(this.DocsrchLev1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.docsrchYear, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.DocsrchLev3, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.DocsrchLev2, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 208);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// DocsrchLev1
			// 
			this.DocsrchLev1._filtering = false;
			this.DocsrchLev1.BaseFilter = "";
			this.DocsrchLev1.DataSource = this.docfilter_l1;
			this.DocsrchLev1.descName = "DocsrchLev2";
			this.DocsrchLev1.DisplayMember = "title";
			this.DocsrchLev1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DocsrchLev1.ExtFilter = "AND parent_id IN";
			this.DocsrchLev1.FormattingEnabled = true;
			this.DocsrchLev1.isFilterElementString = false;
			this.DocsrchLev1.Location = new System.Drawing.Point(73, 3);
			this.DocsrchLev1.Name = "DocsrchLev1";
			this.DocsrchLev1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.DocsrchLev1.Size = new System.Drawing.Size(114, 202);
			this.DocsrchLev1.TabIndex = 18;
			this.DocsrchLev1.Tag = "xxx";
			this.DocsrchLev1.ValueMember = "id";
			this.DocsrchLev1.SelectedIndexChanged += new System.EventHandler(this.FilterParameterChanged);
			// 
			// docfilter_l1
			// 
			this.docfilter_l1.DataMember = "bp_dict_type_level";
			this.docfilter_l1.DataSource = this.bP_dataset;
			this.docfilter_l1.Filter = "level=1";
			// 
			// docsrchYear
			// 
			this.docsrchYear.DataSource = this.docfilter_year;
			this.docsrchYear.DisplayMember = "rok";
			this.docsrchYear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.docsrchYear.FormattingEnabled = true;
			this.docsrchYear.Location = new System.Drawing.Point(3, 3);
			this.docsrchYear.Name = "docsrchYear";
			this.docsrchYear.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.docsrchYear.Size = new System.Drawing.Size(64, 202);
			this.docsrchYear.TabIndex = 8;
			this.docsrchYear.ValueMember = "rok";
			this.docsrchYear.SelectedIndexChanged += new System.EventHandler(this.FilterParameterChanged);
			// 
			// docfilter_year
			// 
			this.docfilter_year.DataMember = "yearsList";
			this.docfilter_year.DataSource = this.bP_dataset;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.docsrchPrsns, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.docsrchTags, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(433, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 167);
			this.tableLayoutPanel2.TabIndex = 17;
			// 
			// docsrchPrsns
			// 
			this.docsrchPrsns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.docsrchPrsns.FormattingEnabled = true;
			this.docsrchPrsns.Location = new System.Drawing.Point(3, 86);
			this.docsrchPrsns.MinimumSize = new System.Drawing.Size(4, 80);
			this.docsrchPrsns.Name = "docsrchPrsns";
			this.docsrchPrsns.Size = new System.Drawing.Size(194, 69);
			this.docsrchPrsns.TabIndex = 18;
			// 
			// docsrchTags
			// 
			this.docsrchTags._filtering = false;
			this.docsrchTags.BaseFilter = null;
			this.docsrchTags.DataSource = this.bp_tagfilter;
			this.docsrchTags.descName = null;
			this.docsrchTags.DisplayMember = "title";
			this.docsrchTags.ExtFilter = null;
			this.docsrchTags.FormattingEnabled = true;
			this.docsrchTags.isFilterElementString = false;
			this.docsrchTags.Location = new System.Drawing.Point(3, 3);
			this.docsrchTags.Name = "docsrchTags";
			this.docsrchTags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.docsrchTags.Size = new System.Drawing.Size(183, 69);
			this.docsrchTags.TabIndex = 19;
			this.docsrchTags.ValueMember = "id";
			this.docsrchTags.SelectedIndexChanged += new System.EventHandler(this.FilterParameterChanged);
			// 
			// bp_tagfilter
			// 
			this.bp_tagfilter.DataMember = "bp_group";
			this.bp_tagfilter.DataSource = this.bP_dataset;
			this.bp_tagfilter.Filter = "";
			this.bp_tagfilter.Sort = "title";
			// 
			// DocsrchLev3
			// 
			this.DocsrchLev3._filtering = false;
			this.DocsrchLev3.BaseFilter = "Level=3";
			this.DocsrchLev3.DataSource = this.docfilter_l3;
			this.DocsrchLev3.descName = "";
			this.DocsrchLev3.DisplayMember = "title";
			this.DocsrchLev3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DocsrchLev3.ExtFilter = "AND parent_id IN";
			this.DocsrchLev3.FormattingEnabled = true;
			this.DocsrchLev3.isFilterElementString = false;
			this.DocsrchLev3.Location = new System.Drawing.Point(313, 3);
			this.DocsrchLev3.Name = "DocsrchLev3";
			this.DocsrchLev3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.DocsrchLev3.Size = new System.Drawing.Size(114, 202);
			this.DocsrchLev3.TabIndex = 16;
			this.DocsrchLev3.Tag = "xxx";
			this.DocsrchLev3.ValueMember = "id";
			this.DocsrchLev3.SelectedIndexChanged += new System.EventHandler(this.FilterParameterChanged);
			// 
			// docfilter_l3
			// 
			this.docfilter_l3.DataMember = "bp_dict_type_level";
			this.docfilter_l3.DataSource = this.bP_dataset;
			this.docfilter_l3.Filter = "0=1";
			// 
			// DocsrchLev2
			// 
			this.DocsrchLev2._filtering = false;
			this.DocsrchLev2.BaseFilter = "Level=2";
			this.DocsrchLev2.DataSource = this.docfilter_l2;
			this.DocsrchLev2.descName = "DocsrchLev3";
			this.DocsrchLev2.DisplayMember = "title";
			this.DocsrchLev2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DocsrchLev2.ExtFilter = "AND parent_id IN";
			this.DocsrchLev2.FormattingEnabled = true;
			this.DocsrchLev2.isFilterElementString = false;
			this.DocsrchLev2.Location = new System.Drawing.Point(193, 3);
			this.DocsrchLev2.Name = "DocsrchLev2";
			this.DocsrchLev2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.DocsrchLev2.Size = new System.Drawing.Size(114, 202);
			this.DocsrchLev2.TabIndex = 15;
			this.DocsrchLev2.Tag = "xxx";
			this.DocsrchLev2.ValueMember = "id";
			this.DocsrchLev2.SelectedIndexChanged += new System.EventHandler(this.FilterParameterChanged);
			// 
			// docfilter_l2
			// 
			this.docfilter_l2.DataMember = "bp_dict_type_level";
			this.docfilter_l2.DataSource = this.bP_dataset;
			this.docfilter_l2.Filter = "0=1";
			// 
			// pnlDoFiltercCommands
			// 
			this.pnlDoFiltercCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlDoFiltercCommands.ColumnCount = 5;
			this.pnlDoFiltercCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.54144F));
			this.pnlDoFiltercCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.45856F));
			this.pnlDoFiltercCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
			this.pnlDoFiltercCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
			this.pnlDoFiltercCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
			this.pnlDoFiltercCommands.Controls.Add(this.chck_LevelsListFiltering, 0, 0);
			this.pnlDoFiltercCommands.Controls.Add(this.btnClearFilter, 4, 0);
			this.pnlDoFiltercCommands.Controls.Add(this.txtDocSrchFree, 2, 0);
			this.pnlDoFiltercCommands.Controls.Add(this.cmbDocSrchPreSets, 3, 0);
			this.pnlDoFiltercCommands.Location = new System.Drawing.Point(2, 605);
			this.pnlDoFiltercCommands.Margin = new System.Windows.Forms.Padding(1);
			this.pnlDoFiltercCommands.Name = "pnlDoFiltercCommands";
			this.pnlDoFiltercCommands.RowCount = 1;
			this.pnlDoFiltercCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.pnlDoFiltercCommands.Size = new System.Drawing.Size(623, 32);
			this.pnlDoFiltercCommands.TabIndex = 3;
			// 
			// chck_LevelsListFiltering
			// 
			this.chck_LevelsListFiltering.AutoSize = true;
			this.chck_LevelsListFiltering.Checked = true;
			this.chck_LevelsListFiltering.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chck_LevelsListFiltering.Location = new System.Drawing.Point(3, 3);
			this.chck_LevelsListFiltering.Name = "chck_LevelsListFiltering";
			this.chck_LevelsListFiltering.Size = new System.Drawing.Size(39, 17);
			this.chck_LevelsListFiltering.TabIndex = 3;
			this.chck_LevelsListFiltering.Text = "Filtruj listy poziomów";
			this.chck_LevelsListFiltering.UseVisualStyleBackColor = true;
			this.chck_LevelsListFiltering.CheckedChanged += new System.EventHandler(this.FilterParameterChanged);
			// 
			// btnClearFilter
			// 
			this.btnClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearFilter.Location = new System.Drawing.Point(545, 3);
			this.btnClearFilter.Name = "btnClearFilter";
			this.btnClearFilter.Size = new System.Drawing.Size(75, 20);
			this.btnClearFilter.TabIndex = 4;
			this.btnClearFilter.Text = "Wyczyść";
			this.btnClearFilter.UseVisualStyleBackColor = true;
			this.btnClearFilter.Click += new System.EventHandler(this.FilterParameterChanged);
			// 
			// txtDocSrchFree
			// 
			this.txtDocSrchFree.Location = new System.Drawing.Point(109, 3);
			this.txtDocSrchFree.Name = "txtDocSrchFree";
			this.txtDocSrchFree.Size = new System.Drawing.Size(192, 20);
			this.txtDocSrchFree.TabIndex = 5;
			this.txtDocSrchFree.TextChanged += new System.EventHandler(this.FilterParameterChanged);
			// 
			// cmbDocSrchPreSets
			// 
			this.cmbDocSrchPreSets.FormattingEnabled = true;
			this.cmbDocSrchPreSets.Location = new System.Drawing.Point(315, 3);
			this.cmbDocSrchPreSets.Name = "cmbDocSrchPreSets";
			this.cmbDocSrchPreSets.Size = new System.Drawing.Size(146, 21);
			this.cmbDocSrchPreSets.TabIndex = 6;
			// 
			// pnlDocCommands
			// 
			this.pnlDocCommands.ColumnCount = 4;
			this.pnlDocCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.pnlDocCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
			this.pnlDocCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 439F));
			this.pnlDocCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
			this.pnlDocCommands.Controls.Add(this.button1, 1, 0);
			this.pnlDocCommands.Controls.Add(this.btnSave, 3, 0);
			this.pnlDocCommands.Controls.Add(this.button2, 0, 0);
			this.pnlDocCommands.Controls.Add(this.button3, 2, 0);
			this.pnlDocCommands.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDocCommands.Location = new System.Drawing.Point(1, 358);
			this.pnlDocCommands.Margin = new System.Windows.Forms.Padding(0);
			this.pnlDocCommands.Name = "pnlDocCommands";
			this.pnlDocCommands.RowCount = 1;
			this.pnlDocCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.pnlDocCommands.Size = new System.Drawing.Size(625, 30);
			this.pnlDocCommands.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(63, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(50, 23);
			this.button1.TabIndex = 29;
			this.button1.Text = "Nowy";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnSave.Location = new System.Drawing.Point(572, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(50, 24);
			this.btnSave.TabIndex = 28;
			this.btnSave.Text = "Zapisz";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(3, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(50, 23);
			this.button2.TabIndex = 30;
			this.button2.Text = "Usuń";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Dock = System.Windows.Forms.DockStyle.Right;
			this.button3.Location = new System.Drawing.Point(508, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(50, 24);
			this.button3.TabIndex = 31;
			this.button3.Text = "Cofnij";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// laypan_docRight
			// 
			this.laypan_docRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.laypan_docRight.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.laypan_docRight.ColumnCount = 1;
			this.laypan_docRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.laypan_docRight.Controls.Add(this.laypanDocRightDown, 0, 1);
			this.laypan_docRight.Controls.Add(this.treeView1, 0, 0);
			this.laypan_docRight.Location = new System.Drawing.Point(636, 3);
			this.laypan_docRight.Name = "laypan_docRight";
			this.laypan_docRight.RowCount = 2;
			this.laypan_docRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.laypan_docRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.laypan_docRight.Size = new System.Drawing.Size(387, 639);
			this.laypan_docRight.TabIndex = 1;
			// 
			// laypanDocRightDown
			// 
			this.laypanDocRightDown.ColumnCount = 2;
			this.laypanDocRightDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.laypanDocRightDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.laypanDocRightDown.Controls.Add(this.lblSort, 1, 0);
			this.laypanDocRightDown.Controls.Add(this.cmbDocListGrp2, 0, 2);
			this.laypanDocRightDown.Controls.Add(this.cmbDocListSort2, 1, 2);
			this.laypanDocRightDown.Controls.Add(this.cmbDocListGrp1, 0, 1);
			this.laypanDocRightDown.Controls.Add(this.cmbDocListSort1, 1, 1);
			this.laypanDocRightDown.Controls.Add(this.cmbDocListGrp3, 0, 3);
			this.laypanDocRightDown.Controls.Add(this.cmbDocListSort3, 1, 3);
			this.laypanDocRightDown.Controls.Add(this.lblGroup, 0, 0);
			this.laypanDocRightDown.Dock = System.Windows.Forms.DockStyle.Fill;
			this.laypanDocRightDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.laypanDocRightDown.Location = new System.Drawing.Point(4, 541);
			this.laypanDocRightDown.Name = "laypanDocRightDown";
			this.laypanDocRightDown.RowCount = 4;
			this.laypanDocRightDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
			this.laypanDocRightDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.laypanDocRightDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.laypanDocRightDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.laypanDocRightDown.Size = new System.Drawing.Size(379, 94);
			this.laypanDocRightDown.TabIndex = 0;
			// 
			// lblSort
			// 
			this.lblSort.AutoSize = true;
			this.lblSort.Location = new System.Drawing.Point(192, 0);
			this.lblSort.Name = "lblSort";
			this.lblSort.Size = new System.Drawing.Size(52, 12);
			this.lblSort.TabIndex = 7;
			this.lblSort.Text = "Sortowanie";
			// 
			// cmbDocListGrp2
			// 
			this.cmbDocListGrp2.DataSource = this.doclist_grp2;
			this.cmbDocListGrp2.DisplayMember = "title";
			this.cmbDocListGrp2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbDocListGrp2.FormattingEnabled = true;
			this.cmbDocListGrp2.Location = new System.Drawing.Point(3, 43);
			this.cmbDocListGrp2.Name = "cmbDocListGrp2";
			this.cmbDocListGrp2.Size = new System.Drawing.Size(183, 20);
			this.cmbDocListGrp2.TabIndex = 1;
			this.cmbDocListGrp2.ValueMember = "id";
			this.cmbDocListGrp2.SelectedIndexChanged += new System.EventHandler(this.FilterParameterChanged);
			// 
			// doclist_grp2
			// 
			this.doclist_grp2.DataMember = "bp_dict_listorder";
			this.doclist_grp2.DataSource = this.bP_dataset;
			this.doclist_grp2.Filter = "grouppriority>0";
			this.doclist_grp2.Sort = "grouppriority";
			// 
			// cmbDocListSort2
			// 
			this.cmbDocListSort2.DataSource = this.doclist_sort2;
			this.cmbDocListSort2.DisplayMember = "title";
			this.cmbDocListSort2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbDocListSort2.FormattingEnabled = true;
			this.cmbDocListSort2.Location = new System.Drawing.Point(192, 43);
			this.cmbDocListSort2.Name = "cmbDocListSort2";
			this.cmbDocListSort2.Size = new System.Drawing.Size(184, 20);
			this.cmbDocListSort2.TabIndex = 3;
			this.cmbDocListSort2.ValueMember = "id";
			this.cmbDocListSort2.SelectedIndexChanged += new System.EventHandler(this.FilterParameterChanged);
			// 
			// doclist_sort2
			// 
			this.doclist_sort2.DataMember = "bp_dict_listorder";
			this.doclist_sort2.DataSource = this.bP_dataset;
			this.doclist_sort2.Filter = "sortpriority >0";
			this.doclist_sort2.Sort = "sortpriority";
			// 
			// cmbDocListGrp1
			// 
			this.cmbDocListGrp1.DataSource = this.doclist_grp1;
			this.cmbDocListGrp1.DisplayMember = "title";
			this.cmbDocListGrp1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbDocListGrp1.FormattingEnabled = true;
			this.cmbDocListGrp1.Location = new System.Drawing.Point(3, 19);
			this.cmbDocListGrp1.Name = "cmbDocListGrp1";
			this.cmbDocListGrp1.Size = new System.Drawing.Size(183, 20);
			this.cmbDocListGrp1.TabIndex = 0;
			this.cmbDocListGrp1.ValueMember = "id";
			this.cmbDocListGrp1.SelectedIndexChanged += new System.EventHandler(this.FilterParameterChanged);
			// 
			// doclist_grp1
			// 
			this.doclist_grp1.DataMember = "bp_dict_listorder";
			this.doclist_grp1.DataSource = this.bP_dataset;
			this.doclist_grp1.Filter = "grouppriority>0";
			this.doclist_grp1.Sort = "grouppriority";
			// 
			// cmbDocListSort1
			// 
			this.cmbDocListSort1.DataSource = this.doclist_sort1;
			this.cmbDocListSort1.DisplayMember = "title";
			this.cmbDocListSort1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbDocListSort1.FormattingEnabled = true;
			this.cmbDocListSort1.Location = new System.Drawing.Point(192, 19);
			this.cmbDocListSort1.Name = "cmbDocListSort1";
			this.cmbDocListSort1.Size = new System.Drawing.Size(184, 20);
			this.cmbDocListSort1.TabIndex = 2;
			this.cmbDocListSort1.ValueMember = "id";
			this.cmbDocListSort1.SelectedIndexChanged += new System.EventHandler(this.FilterParameterChanged);
			// 
			// doclist_sort1
			// 
			this.doclist_sort1.DataMember = "bp_dict_listorder";
			this.doclist_sort1.DataSource = this.bP_dataset;
			this.doclist_sort1.Filter = "sortpriority >0";
			this.doclist_sort1.Sort = "sortpriority";
			// 
			// cmbDocListGrp3
			// 
			this.cmbDocListGrp3.DataSource = this.doclist_grp3;
			this.cmbDocListGrp3.DisplayMember = "title";
			this.cmbDocListGrp3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbDocListGrp3.FormattingEnabled = true;
			this.cmbDocListGrp3.Location = new System.Drawing.Point(3, 67);
			this.cmbDocListGrp3.Name = "cmbDocListGrp3";
			this.cmbDocListGrp3.Size = new System.Drawing.Size(183, 20);
			this.cmbDocListGrp3.TabIndex = 4;
			this.cmbDocListGrp3.ValueMember = "id";
			this.cmbDocListGrp3.SelectedIndexChanged += new System.EventHandler(this.FilterParameterChanged);
			// 
			// doclist_grp3
			// 
			this.doclist_grp3.DataMember = "bp_dict_listorder";
			this.doclist_grp3.DataSource = this.bP_dataset;
			this.doclist_grp3.Filter = "grouppriority >0";
			this.doclist_grp3.Sort = "grouppriority";
			// 
			// cmbDocListSort3
			// 
			this.cmbDocListSort3.DataSource = this.doclist_sort3;
			this.cmbDocListSort3.DisplayMember = "title";
			this.cmbDocListSort3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbDocListSort3.FormattingEnabled = true;
			this.cmbDocListSort3.Location = new System.Drawing.Point(192, 67);
			this.cmbDocListSort3.Name = "cmbDocListSort3";
			this.cmbDocListSort3.Size = new System.Drawing.Size(184, 20);
			this.cmbDocListSort3.TabIndex = 5;
			this.cmbDocListSort3.ValueMember = "id";
			this.cmbDocListSort3.SelectedIndexChanged += new System.EventHandler(this.FilterParameterChanged);
			// 
			// doclist_sort3
			// 
			this.doclist_sort3.DataMember = "bp_dict_listorder";
			this.doclist_sort3.DataSource = this.bP_dataset;
			this.doclist_sort3.Filter = "sortpriority >0";
			this.doclist_sort3.Sort = "sortpriority";
			// 
			// lblGroup
			// 
			this.lblGroup.AutoSize = true;
			this.lblGroup.Location = new System.Drawing.Point(3, 0);
			this.lblGroup.Name = "lblGroup";
			this.lblGroup.Size = new System.Drawing.Size(55, 12);
			this.lblGroup.TabIndex = 6;
			this.lblGroup.Text = "Grupowanie";
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.HideSelection = false;
			this.treeView1.Location = new System.Drawing.Point(4, 4);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(379, 530);
			this.treeView1.TabIndex = 2;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1032, 650);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tpgAdmin";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// odbcConnection1
			// 
			this.odbcConnection1.ConnectionString = resources.GetString("odbcConnection1.ConnectionString");
			// 
			// bp_dict_listorderTableAdapter
			// 
			this.bp_dict_listorderTableAdapter.ClearBeforeFill = true;
			// 
			// yearsListTableAdapter
			// 
			this.yearsListTableAdapter.ClearBeforeFill = true;
			// 
			// bp_dict_type_levelTableAdapter
			// 
			this.bp_dict_type_levelTableAdapter.ClearBeforeFill = true;
			// 
			// bp_documentTableAdapter
			// 
			this.bp_documentTableAdapter.ClearBeforeFill = true;
			// 
			// bp_document_groupTableAdapter
			// 
			this.bp_document_groupTableAdapter.ClearBeforeFill = true;
			// 
			// fKbpdocumentgroupbpdocumentBindingSource1
			// 
			this.fKbpdocumentgroupbpdocumentBindingSource1.DataMember = "FK_bp_document_group_bp_document";
			this.fKbpdocumentgroupbpdocumentBindingSource1.DataSource = this.bpdocumentBindingSource;
			// 
			// bp_groupTableAdapter
			// 
			this.bp_groupTableAdapter.ClearBeforeFill = true;
			// 
			// bpObjectsLisTableAdapter
			// 
			this.bpObjectsLisTableAdapter.ClearBeforeFill = true;
			// 
			// bp_objectTableAdapter
			// 
			this.bp_objectTableAdapter.ClearBeforeFill = true;
			// 
			// fKbpdocumentgroupbpgroupBindingSource
			// 
			this.fKbpdocumentgroupbpgroupBindingSource.DataMember = "FK_bp_document_group_bp_group";
			this.fKbpdocumentgroupbpgroupBindingSource.DataSource = this.bpgroupBindingSource;
			// 
			// bp_userTableAdapter
			// 
			this.bp_userTableAdapter.ClearBeforeFill = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1040, 676);
			this.Controls.Add(this.tabApplication);
			this.MinimumSize = new System.Drawing.Size(958, 500);
			this.Name = "frmMain";
			this.Text = "Dokumenty Biegu Piastów";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.tabApplication.ResumeLayout(false);
			this.tpgDocs.ResumeLayout(false);
			this.laypan_docMain.ResumeLayout(false);
			this.laypan_docLeft.ResumeLayout(false);
			this.pnlDocData.ResumeLayout(false);
			this.pnlDocData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bp_modifier)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bP_dataset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bp_creator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bpdocumentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grd_tags)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bpgroupBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKbpdocumentgroupbpdocumentBindingSource)).EndInit();
			this.pnlDocType.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.doclevel_l3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doclevel_l2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doclevel_l1)).EndInit();
			this.pnlPerson.ResumeLayout(false);
			this.pnlPerson.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bpObjectsLisBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bp_objectBindingSource)).EndInit();
			this.pnlDocFilter.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.docfilter_l1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.docfilter_year)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bp_tagfilter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.docfilter_l3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.docfilter_l2)).EndInit();
			this.pnlDoFiltercCommands.ResumeLayout(false);
			this.pnlDoFiltercCommands.PerformLayout();
			this.pnlDocCommands.ResumeLayout(false);
			this.laypan_docRight.ResumeLayout(false);
			this.laypanDocRightDown.ResumeLayout(false);
			this.laypanDocRightDown.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.doclist_grp2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doclist_sort2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doclist_grp1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doclist_sort1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doclist_grp3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doclist_sort3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKbpdocumentgroupbpdocumentBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKbpdocumentgroupbpgroupBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabApplication;
        private System.Windows.Forms.TabPage tpgDocs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Data.Odbc.OdbcConnection odbcConnection1;
        private System.Windows.Forms.TableLayoutPanel laypan_docMain;
        private System.Windows.Forms.TableLayoutPanel laypan_docLeft;
        private System.Windows.Forms.Panel pnlDocData;
        private System.Windows.Forms.Button btnDocAttachAdd;
        private System.Windows.Forms.DateTimePicker dtpickDocData;
        private System.Windows.Forms.TextBox txtDocNumber;
        private System.Windows.Forms.Label lblDocAttachment;
		private System.Windows.Forms.Panel pnlDocAttachment;
        private System.Windows.Forms.Label lblDocMoneyOut;
        private System.Windows.Forms.Label lblDocDescription;
        private System.Windows.Forms.TextBox txtDocDescription;
		private System.Windows.Forms.TextBox txtDocMoneyOut;
        private System.Windows.Forms.Label lblDocMoneyIn;
        private System.Windows.Forms.Panel pnlDocType;
        private System.Windows.Forms.ComboBox cmbDocTypeLevel3;
        private System.Windows.Forms.ComboBox cmbDocTypeLevel2;
        private System.Windows.Forms.ComboBox cmbDocTypeLevel1;
        private System.Windows.Forms.TextBox txtDocMoneyIn;
        private System.Windows.Forms.Panel pnlPerson;
        private System.Windows.Forms.Label lblPersonEmail;
        private System.Windows.Forms.TextBox txtPersonEmail;
        private System.Windows.Forms.Label lblPersonPhone;
        private System.Windows.Forms.TextBox txtPersonPhone;
        private System.Windows.Forms.Label lblPersonAdress;
        private System.Windows.Forms.TextBox txtPersonAdress;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.TextBox txtDocTile;
        private System.Windows.Forms.Panel pnlDocFilter;
		private System.Windows.Forms.TableLayoutPanel laypan_docRight;
        private System.Windows.Forms.TableLayoutPanel laypanDocRightDown;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cmbDocListGrp2;
        private System.Windows.Forms.ComboBox cmbDocListSort2;
        private System.Windows.Forms.ComboBox cmbDocListGrp1;
        private System.Windows.Forms.ComboBox cmbDocListSort1;
        private System.Windows.Forms.ComboBox cmbDocListGrp3;
        private System.Windows.Forms.ComboBox cmbDocListSort3;
		private System.Windows.Forms.Label lblGroup;
		private System.Windows.Forms.BindingSource docfilter_l1;
        private System.Windows.Forms.BindingSource docfilter_l2;
		private System.Windows.Forms.BindingSource docfilter_l3;
        private System.Windows.Forms.CheckBox chck_LevelsListFiltering;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BetterControls.MultivalueListBox DocsrchLev3;
		private BetterControls.MultivalueListBox DocsrchLev2;
        private System.Windows.Forms.ListBox docsrchYear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ListBox docsrchPrsns;
        private System.Windows.Forms.TableLayoutPanel pnlDoFiltercCommands;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.TextBox txtDocSrchFree;
		private System.Windows.Forms.ComboBox cmbDocSrchPreSets;
		private BetterControls.MultivalueListBox DocsrchLev1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.BindingSource doclist_sort1;
		private System.Windows.Forms.BindingSource doclist_grp1;
		private System.Windows.Forms.BindingSource doclist_sort2;
		private System.Windows.Forms.BindingSource doclist_sort3;
		private System.Windows.Forms.BindingSource doclist_grp2;
		private System.Windows.Forms.BindingSource doclist_grp3;
		private System.Windows.Forms.DataGridView grd_tags;
		private Properties.DataSources.BP_dataset bP_dataset;
		private Properties.DataSources.BP_datasetTableAdapters.bp_dict_listorderTableAdapter bp_dict_listorderTableAdapter;
		private System.Windows.Forms.BindingSource docfilter_year;
		private Properties.DataSources.BP_datasetTableAdapters.yearsListTableAdapter yearsListTableAdapter;
		private Properties.DataSources.BP_datasetTableAdapters.bp_dict_type_levelTableAdapter bp_dict_type_levelTableAdapter;
		private System.Windows.Forms.BindingSource bpdocumentBindingSource;
		private Properties.DataSources.BP_datasetTableAdapters.bp_documentTableAdapter bp_documentTableAdapter;
		private System.Windows.Forms.BindingSource doclevel_l3;
		private System.Windows.Forms.BindingSource doclevel_l2;
		private System.Windows.Forms.BindingSource doclevel_l1;
		private System.Windows.Forms.BindingSource fKbpdocumentgroupbpdocumentBindingSource;
		private Properties.DataSources.BP_datasetTableAdapters.bp_document_groupTableAdapter bp_document_groupTableAdapter;
		private System.Windows.Forms.BindingSource fKbpdocumentgroupbpdocumentBindingSource1;
		private System.Windows.Forms.BindingSource bpgroupBindingSource;
		private Properties.DataSources.BP_datasetTableAdapters.bp_groupTableAdapter bp_groupTableAdapter;
		private System.Windows.Forms.DataGridViewComboBoxColumn group;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn documentidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupidDataGridViewTextBoxColumn;
		private System.Windows.Forms.ComboBox cmbPersonName;
		private System.Windows.Forms.BindingSource bpObjectsLisBindingSource;
		private Properties.DataSources.BP_datasetTableAdapters.bpObjectsLisTableAdapter bpObjectsLisTableAdapter;
		private System.Windows.Forms.BindingSource bp_objectBindingSource;
		private Properties.DataSources.BP_datasetTableAdapters.bp_objectTableAdapter bp_objectTableAdapter;
		private BetterControls.MultivalueListBox docsrchTags;
		private System.Windows.Forms.BindingSource bp_tagfilter;
		private System.Windows.Forms.BindingSource fKbpdocumentgroupbpgroupBindingSource;
		private System.Windows.Forms.BindingSource bp_creator;
		private Properties.DataSources.BP_datasetTableAdapters.bp_userTableAdapter bp_userTableAdapter;
		private System.Windows.Forms.BindingSource bp_modifier;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtLastModifiedPerson;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtLastModifaiedDate;
		private System.Windows.Forms.Label lblLastModified;
		private System.Windows.Forms.TextBox txtDocCreatePerson;
		private System.Windows.Forms.TextBox txtDocCreateData;
		private System.Windows.Forms.Label lblDocCreated;
		private System.Windows.Forms.TableLayoutPanel pnlDocCommands;
		private System.Windows.Forms.Button button3;
    }
}

