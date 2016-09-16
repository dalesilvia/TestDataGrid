namespace TestDataGrid
{
    partial class StoreData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreData));
            System.Windows.Forms.Label sTORE_NUMLabel;
            System.Windows.Forms.Label sTORE_NAMELabel;
            System.Windows.Forms.Label cOMPANY_NAMELabel;
            System.Windows.Forms.Label bEARITORY_NAMELabel;
            System.Windows.Forms.Label rEGION_NAMELabel;
            System.Windows.Forms.Label tIME_ZONELabel;
            System.Windows.Forms.Label cOUNTRY_ABBRVLabel;
            System.Windows.Forms.Label cOUNTRY_NAMELabel;
            System.Windows.Forms.Label sTATE_PROVINCE_ABBRVLabel;
            System.Windows.Forms.Label sTATE_PROVINCE_NAMELabel;
            System.Windows.Forms.Label lONGITUDELabel;
            System.Windows.Forms.Label lATITUDELabel;
            System.Windows.Forms.Label sTR_OPEN_DTLabel;
            System.Windows.Forms.Label sTR_CLOSE_DTLabel;
            this.bABWMstrDataDataSet = new TestDataGrid.BABWMstrDataDataSet();
            this.vwStoreDimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwStoreDimTableAdapter = new TestDataGrid.BABWMstrDataDataSetTableAdapters.vwStoreDimTableAdapter();
            this.tableAdapterManager = new TestDataGrid.BABWMstrDataDataSetTableAdapters.TableAdapterManager();
            this.vwStoreDimBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.vwStoreDimBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sTORE_NUMTextBox = new System.Windows.Forms.TextBox();
            this.sTORE_NAMETextBox = new System.Windows.Forms.TextBox();
            this.cOMPANY_NAMETextBox = new System.Windows.Forms.TextBox();
            this.bEARITORY_NAMETextBox = new System.Windows.Forms.TextBox();
            this.rEGION_NAMETextBox = new System.Windows.Forms.TextBox();
            this.tIME_ZONETextBox = new System.Windows.Forms.TextBox();
            this.cOUNTRY_ABBRVTextBox = new System.Windows.Forms.TextBox();
            this.cOUNTRY_NAMETextBox = new System.Windows.Forms.TextBox();
            this.sTATE_PROVINCE_ABBRVTextBox = new System.Windows.Forms.TextBox();
            this.sTATE_PROVINCE_NAMETextBox = new System.Windows.Forms.TextBox();
            this.lONGITUDETextBox = new System.Windows.Forms.TextBox();
            this.lATITUDETextBox = new System.Windows.Forms.TextBox();
            this.sTR_OPEN_DTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sTR_CLOSE_DTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            sTORE_NUMLabel = new System.Windows.Forms.Label();
            sTORE_NAMELabel = new System.Windows.Forms.Label();
            cOMPANY_NAMELabel = new System.Windows.Forms.Label();
            bEARITORY_NAMELabel = new System.Windows.Forms.Label();
            rEGION_NAMELabel = new System.Windows.Forms.Label();
            tIME_ZONELabel = new System.Windows.Forms.Label();
            cOUNTRY_ABBRVLabel = new System.Windows.Forms.Label();
            cOUNTRY_NAMELabel = new System.Windows.Forms.Label();
            sTATE_PROVINCE_ABBRVLabel = new System.Windows.Forms.Label();
            sTATE_PROVINCE_NAMELabel = new System.Windows.Forms.Label();
            lONGITUDELabel = new System.Windows.Forms.Label();
            lATITUDELabel = new System.Windows.Forms.Label();
            sTR_OPEN_DTLabel = new System.Windows.Forms.Label();
            sTR_CLOSE_DTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bABWMstrDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwStoreDimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwStoreDimBindingNavigator)).BeginInit();
            this.vwStoreDimBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bABWMstrDataDataSet
            // 
            this.bABWMstrDataDataSet.DataSetName = "BABWMstrDataDataSet";
            this.bABWMstrDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwStoreDimBindingSource
            // 
            this.vwStoreDimBindingSource.DataMember = "vwStoreDim";
            this.vwStoreDimBindingSource.DataSource = this.bABWMstrDataDataSet;
            // 
            // vwStoreDimTableAdapter
            // 
            this.vwStoreDimTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TestDataGrid.BABWMstrDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vwStoreDimBindingNavigator
            // 
            this.vwStoreDimBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vwStoreDimBindingNavigator.BindingSource = this.vwStoreDimBindingSource;
            this.vwStoreDimBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vwStoreDimBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vwStoreDimBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vwStoreDimBindingNavigatorSaveItem});
            this.vwStoreDimBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vwStoreDimBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vwStoreDimBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vwStoreDimBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vwStoreDimBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vwStoreDimBindingNavigator.Name = "vwStoreDimBindingNavigator";
            this.vwStoreDimBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vwStoreDimBindingNavigator.Size = new System.Drawing.Size(413, 25);
            this.vwStoreDimBindingNavigator.TabIndex = 0;
            this.vwStoreDimBindingNavigator.Text = "bindingNavigator1";
            this.vwStoreDimBindingNavigator.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // vwStoreDimBindingNavigatorSaveItem
            // 
            this.vwStoreDimBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vwStoreDimBindingNavigatorSaveItem.Enabled = false;
            this.vwStoreDimBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vwStoreDimBindingNavigatorSaveItem.Image")));
            this.vwStoreDimBindingNavigatorSaveItem.Name = "vwStoreDimBindingNavigatorSaveItem";
            this.vwStoreDimBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.vwStoreDimBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // sTORE_NUMLabel
            // 
            sTORE_NUMLabel.AutoSize = true;
            sTORE_NUMLabel.Location = new System.Drawing.Point(12, 27);
            sTORE_NUMLabel.Name = "sTORE_NUMLabel";
            sTORE_NUMLabel.Size = new System.Drawing.Size(75, 13);
            sTORE_NUMLabel.TabIndex = 3;
            sTORE_NUMLabel.Text = "STORE NUM:";
            // 
            // sTORE_NUMTextBox
            // 
            this.sTORE_NUMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwStoreDimBindingSource, "STORE_NUM", true));
            this.sTORE_NUMTextBox.Location = new System.Drawing.Point(160, 24);
            this.sTORE_NUMTextBox.Name = "sTORE_NUMTextBox";
            this.sTORE_NUMTextBox.Size = new System.Drawing.Size(200, 20);
            this.sTORE_NUMTextBox.TabIndex = 4;
            // 
            // sTORE_NAMELabel
            // 
            sTORE_NAMELabel.AutoSize = true;
            sTORE_NAMELabel.Location = new System.Drawing.Point(12, 53);
            sTORE_NAMELabel.Name = "sTORE_NAMELabel";
            sTORE_NAMELabel.Size = new System.Drawing.Size(81, 13);
            sTORE_NAMELabel.TabIndex = 5;
            sTORE_NAMELabel.Text = "STORE NAME:";
            // 
            // sTORE_NAMETextBox
            // 
            this.sTORE_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwStoreDimBindingSource, "STORE_NAME", true));
            this.sTORE_NAMETextBox.Location = new System.Drawing.Point(160, 50);
            this.sTORE_NAMETextBox.Name = "sTORE_NAMETextBox";
            this.sTORE_NAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.sTORE_NAMETextBox.TabIndex = 6;
            // 
            // cOMPANY_NAMELabel
            // 
            cOMPANY_NAMELabel.AutoSize = true;
            cOMPANY_NAMELabel.Location = new System.Drawing.Point(12, 79);
            cOMPANY_NAMELabel.Name = "cOMPANY_NAMELabel";
            cOMPANY_NAMELabel.Size = new System.Drawing.Size(97, 13);
            cOMPANY_NAMELabel.TabIndex = 7;
            cOMPANY_NAMELabel.Text = "COMPANY NAME:";
            // 
            // cOMPANY_NAMETextBox
            // 
            this.cOMPANY_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwStoreDimBindingSource, "COMPANY_NAME", true));
            this.cOMPANY_NAMETextBox.Location = new System.Drawing.Point(160, 76);
            this.cOMPANY_NAMETextBox.Name = "cOMPANY_NAMETextBox";
            this.cOMPANY_NAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.cOMPANY_NAMETextBox.TabIndex = 8;
            // 
            // bEARITORY_NAMELabel
            // 
            bEARITORY_NAMELabel.AutoSize = true;
            bEARITORY_NAMELabel.Location = new System.Drawing.Point(12, 105);
            bEARITORY_NAMELabel.Name = "bEARITORY_NAMELabel";
            bEARITORY_NAMELabel.Size = new System.Drawing.Size(106, 13);
            bEARITORY_NAMELabel.TabIndex = 9;
            bEARITORY_NAMELabel.Text = "BEARITORY NAME:";
            // 
            // bEARITORY_NAMETextBox
            // 
            this.bEARITORY_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwStoreDimBindingSource, "BEARITORY_NAME", true));
            this.bEARITORY_NAMETextBox.Location = new System.Drawing.Point(160, 102);
            this.bEARITORY_NAMETextBox.Name = "bEARITORY_NAMETextBox";
            this.bEARITORY_NAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.bEARITORY_NAMETextBox.TabIndex = 10;
            // 
            // rEGION_NAMELabel
            // 
            rEGION_NAMELabel.AutoSize = true;
            rEGION_NAMELabel.Location = new System.Drawing.Point(12, 131);
            rEGION_NAMELabel.Name = "rEGION_NAMELabel";
            rEGION_NAMELabel.Size = new System.Drawing.Size(86, 13);
            rEGION_NAMELabel.TabIndex = 11;
            rEGION_NAMELabel.Text = "REGION NAME:";
            // 
            // rEGION_NAMETextBox
            // 
            this.rEGION_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwStoreDimBindingSource, "REGION_NAME", true));
            this.rEGION_NAMETextBox.Location = new System.Drawing.Point(160, 128);
            this.rEGION_NAMETextBox.Name = "rEGION_NAMETextBox";
            this.rEGION_NAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.rEGION_NAMETextBox.TabIndex = 12;
            // 
            // tIME_ZONELabel
            // 
            tIME_ZONELabel.AutoSize = true;
            tIME_ZONELabel.Location = new System.Drawing.Point(12, 157);
            tIME_ZONELabel.Name = "tIME_ZONELabel";
            tIME_ZONELabel.Size = new System.Drawing.Size(69, 13);
            tIME_ZONELabel.TabIndex = 13;
            tIME_ZONELabel.Text = "TIME ZONE:";
            // 
            // tIME_ZONETextBox
            // 
            this.tIME_ZONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwStoreDimBindingSource, "TIME_ZONE", true));
            this.tIME_ZONETextBox.Location = new System.Drawing.Point(160, 154);
            this.tIME_ZONETextBox.Name = "tIME_ZONETextBox";
            this.tIME_ZONETextBox.Size = new System.Drawing.Size(200, 20);
            this.tIME_ZONETextBox.TabIndex = 14;
            // 
            // cOUNTRY_ABBRVLabel
            // 
            cOUNTRY_ABBRVLabel.AutoSize = true;
            cOUNTRY_ABBRVLabel.Location = new System.Drawing.Point(12, 183);
            cOUNTRY_ABBRVLabel.Name = "cOUNTRY_ABBRVLabel";
            cOUNTRY_ABBRVLabel.Size = new System.Drawing.Size(102, 13);
            cOUNTRY_ABBRVLabel.TabIndex = 15;
            cOUNTRY_ABBRVLabel.Text = "COUNTRY ABBRV:";
            // 
            // cOUNTRY_ABBRVTextBox
            // 
            this.cOUNTRY_ABBRVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwStoreDimBindingSource, "COUNTRY_ABBRV", true));
            this.cOUNTRY_ABBRVTextBox.Location = new System.Drawing.Point(160, 180);
            this.cOUNTRY_ABBRVTextBox.Name = "cOUNTRY_ABBRVTextBox";
            this.cOUNTRY_ABBRVTextBox.Size = new System.Drawing.Size(200, 20);
            this.cOUNTRY_ABBRVTextBox.TabIndex = 16;
            // 
            // cOUNTRY_NAMELabel
            // 
            cOUNTRY_NAMELabel.AutoSize = true;
            cOUNTRY_NAMELabel.Location = new System.Drawing.Point(12, 209);
            cOUNTRY_NAMELabel.Name = "cOUNTRY_NAMELabel";
            cOUNTRY_NAMELabel.Size = new System.Drawing.Size(97, 13);
            cOUNTRY_NAMELabel.TabIndex = 17;
            cOUNTRY_NAMELabel.Text = "COUNTRY NAME:";
            // 
            // cOUNTRY_NAMETextBox
            // 
            this.cOUNTRY_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwStoreDimBindingSource, "COUNTRY_NAME", true));
            this.cOUNTRY_NAMETextBox.Location = new System.Drawing.Point(160, 206);
            this.cOUNTRY_NAMETextBox.Name = "cOUNTRY_NAMETextBox";
            this.cOUNTRY_NAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.cOUNTRY_NAMETextBox.TabIndex = 18;
            // 
            // sTATE_PROVINCE_ABBRVLabel
            // 
            sTATE_PROVINCE_ABBRVLabel.AutoSize = true;
            sTATE_PROVINCE_ABBRVLabel.Location = new System.Drawing.Point(12, 235);
            sTATE_PROVINCE_ABBRVLabel.Name = "sTATE_PROVINCE_ABBRVLabel";
            sTATE_PROVINCE_ABBRVLabel.Size = new System.Drawing.Size(142, 13);
            sTATE_PROVINCE_ABBRVLabel.TabIndex = 19;
            sTATE_PROVINCE_ABBRVLabel.Text = "STATE PROVINCE ABBRV:";
            // 
            // sTATE_PROVINCE_ABBRVTextBox
            // 
            this.sTATE_PROVINCE_ABBRVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwStoreDimBindingSource, "STATE_PROVINCE_ABBRV", true));
            this.sTATE_PROVINCE_ABBRVTextBox.Location = new System.Drawing.Point(160, 232);
            this.sTATE_PROVINCE_ABBRVTextBox.Name = "sTATE_PROVINCE_ABBRVTextBox";
            this.sTATE_PROVINCE_ABBRVTextBox.Size = new System.Drawing.Size(200, 20);
            this.sTATE_PROVINCE_ABBRVTextBox.TabIndex = 20;
            // 
            // sTATE_PROVINCE_NAMELabel
            // 
            sTATE_PROVINCE_NAMELabel.AutoSize = true;
            sTATE_PROVINCE_NAMELabel.Location = new System.Drawing.Point(12, 261);
            sTATE_PROVINCE_NAMELabel.Name = "sTATE_PROVINCE_NAMELabel";
            sTATE_PROVINCE_NAMELabel.Size = new System.Drawing.Size(137, 13);
            sTATE_PROVINCE_NAMELabel.TabIndex = 21;
            sTATE_PROVINCE_NAMELabel.Text = "STATE PROVINCE NAME:";
            // 
            // sTATE_PROVINCE_NAMETextBox
            // 
            this.sTATE_PROVINCE_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwStoreDimBindingSource, "STATE_PROVINCE_NAME", true));
            this.sTATE_PROVINCE_NAMETextBox.Location = new System.Drawing.Point(160, 258);
            this.sTATE_PROVINCE_NAMETextBox.Name = "sTATE_PROVINCE_NAMETextBox";
            this.sTATE_PROVINCE_NAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.sTATE_PROVINCE_NAMETextBox.TabIndex = 22;
            // 
            // lONGITUDELabel
            // 
            lONGITUDELabel.AutoSize = true;
            lONGITUDELabel.Location = new System.Drawing.Point(12, 287);
            lONGITUDELabel.Name = "lONGITUDELabel";
            lONGITUDELabel.Size = new System.Drawing.Size(73, 13);
            lONGITUDELabel.TabIndex = 23;
            lONGITUDELabel.Text = "LONGITUDE:";
            // 
            // lONGITUDETextBox
            // 
            this.lONGITUDETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwStoreDimBindingSource, "LONGITUDE", true));
            this.lONGITUDETextBox.Location = new System.Drawing.Point(160, 284);
            this.lONGITUDETextBox.Name = "lONGITUDETextBox";
            this.lONGITUDETextBox.Size = new System.Drawing.Size(200, 20);
            this.lONGITUDETextBox.TabIndex = 24;
            // 
            // lATITUDELabel
            // 
            lATITUDELabel.AutoSize = true;
            lATITUDELabel.Location = new System.Drawing.Point(12, 313);
            lATITUDELabel.Name = "lATITUDELabel";
            lATITUDELabel.Size = new System.Drawing.Size(63, 13);
            lATITUDELabel.TabIndex = 25;
            lATITUDELabel.Text = "LATITUDE:";
            // 
            // lATITUDETextBox
            // 
            this.lATITUDETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwStoreDimBindingSource, "LATITUDE", true));
            this.lATITUDETextBox.Location = new System.Drawing.Point(160, 310);
            this.lATITUDETextBox.Name = "lATITUDETextBox";
            this.lATITUDETextBox.Size = new System.Drawing.Size(200, 20);
            this.lATITUDETextBox.TabIndex = 26;
            // 
            // sTR_OPEN_DTLabel
            // 
            sTR_OPEN_DTLabel.AutoSize = true;
            sTR_OPEN_DTLabel.Location = new System.Drawing.Point(12, 340);
            sTR_OPEN_DTLabel.Name = "sTR_OPEN_DTLabel";
            sTR_OPEN_DTLabel.Size = new System.Drawing.Size(83, 13);
            sTR_OPEN_DTLabel.TabIndex = 27;
            sTR_OPEN_DTLabel.Text = "STR OPEN DT:";
            // 
            // sTR_OPEN_DTDateTimePicker
            // 
            this.sTR_OPEN_DTDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vwStoreDimBindingSource, "STR_OPEN_DT", true));
            this.sTR_OPEN_DTDateTimePicker.Location = new System.Drawing.Point(160, 336);
            this.sTR_OPEN_DTDateTimePicker.Name = "sTR_OPEN_DTDateTimePicker";
            this.sTR_OPEN_DTDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.sTR_OPEN_DTDateTimePicker.TabIndex = 28;
            // 
            // sTR_CLOSE_DTLabel
            // 
            sTR_CLOSE_DTLabel.AutoSize = true;
            sTR_CLOSE_DTLabel.Location = new System.Drawing.Point(12, 366);
            sTR_CLOSE_DTLabel.Name = "sTR_CLOSE_DTLabel";
            sTR_CLOSE_DTLabel.Size = new System.Drawing.Size(88, 13);
            sTR_CLOSE_DTLabel.TabIndex = 29;
            sTR_CLOSE_DTLabel.Text = "STR CLOSE DT:";
            // 
            // sTR_CLOSE_DTDateTimePicker
            // 
            this.sTR_CLOSE_DTDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vwStoreDimBindingSource, "STR_CLOSE_DT", true));
            this.sTR_CLOSE_DTDateTimePicker.Location = new System.Drawing.Point(160, 362);
            this.sTR_CLOSE_DTDateTimePicker.Name = "sTR_CLOSE_DTDateTimePicker";
            this.sTR_CLOSE_DTDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.sTR_CLOSE_DTDateTimePicker.TabIndex = 30;
            // 
            // StoreData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 405);
            this.Controls.Add(sTORE_NUMLabel);
            this.Controls.Add(this.sTORE_NUMTextBox);
            this.Controls.Add(sTORE_NAMELabel);
            this.Controls.Add(this.sTORE_NAMETextBox);
            this.Controls.Add(cOMPANY_NAMELabel);
            this.Controls.Add(this.cOMPANY_NAMETextBox);
            this.Controls.Add(bEARITORY_NAMELabel);
            this.Controls.Add(this.bEARITORY_NAMETextBox);
            this.Controls.Add(rEGION_NAMELabel);
            this.Controls.Add(this.rEGION_NAMETextBox);
            this.Controls.Add(tIME_ZONELabel);
            this.Controls.Add(this.tIME_ZONETextBox);
            this.Controls.Add(cOUNTRY_ABBRVLabel);
            this.Controls.Add(this.cOUNTRY_ABBRVTextBox);
            this.Controls.Add(cOUNTRY_NAMELabel);
            this.Controls.Add(this.cOUNTRY_NAMETextBox);
            this.Controls.Add(sTATE_PROVINCE_ABBRVLabel);
            this.Controls.Add(this.sTATE_PROVINCE_ABBRVTextBox);
            this.Controls.Add(sTATE_PROVINCE_NAMELabel);
            this.Controls.Add(this.sTATE_PROVINCE_NAMETextBox);
            this.Controls.Add(lONGITUDELabel);
            this.Controls.Add(this.lONGITUDETextBox);
            this.Controls.Add(lATITUDELabel);
            this.Controls.Add(this.lATITUDETextBox);
            this.Controls.Add(sTR_OPEN_DTLabel);
            this.Controls.Add(this.sTR_OPEN_DTDateTimePicker);
            this.Controls.Add(sTR_CLOSE_DTLabel);
            this.Controls.Add(this.sTR_CLOSE_DTDateTimePicker);
            this.Controls.Add(this.vwStoreDimBindingNavigator);
            this.Name = "StoreData";
            this.Text = "StoreData";
            this.Load += new System.EventHandler(this.StoreData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bABWMstrDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwStoreDimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwStoreDimBindingNavigator)).EndInit();
            this.vwStoreDimBindingNavigator.ResumeLayout(false);
            this.vwStoreDimBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BABWMstrDataDataSet bABWMstrDataDataSet;
        private System.Windows.Forms.BindingSource vwStoreDimBindingSource;
        private BABWMstrDataDataSetTableAdapters.vwStoreDimTableAdapter vwStoreDimTableAdapter;
        private BABWMstrDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vwStoreDimBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vwStoreDimBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox sTORE_NUMTextBox;
        private System.Windows.Forms.TextBox sTORE_NAMETextBox;
        private System.Windows.Forms.TextBox cOMPANY_NAMETextBox;
        private System.Windows.Forms.TextBox bEARITORY_NAMETextBox;
        private System.Windows.Forms.TextBox rEGION_NAMETextBox;
        private System.Windows.Forms.TextBox tIME_ZONETextBox;
        private System.Windows.Forms.TextBox cOUNTRY_ABBRVTextBox;
        private System.Windows.Forms.TextBox cOUNTRY_NAMETextBox;
        private System.Windows.Forms.TextBox sTATE_PROVINCE_ABBRVTextBox;
        private System.Windows.Forms.TextBox sTATE_PROVINCE_NAMETextBox;
        private System.Windows.Forms.TextBox lONGITUDETextBox;
        private System.Windows.Forms.TextBox lATITUDETextBox;
        private System.Windows.Forms.DateTimePicker sTR_OPEN_DTDateTimePicker;
        private System.Windows.Forms.DateTimePicker sTR_CLOSE_DTDateTimePicker;
    }
}