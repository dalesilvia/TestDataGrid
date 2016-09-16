namespace TestDataGrid
{
    partial class Details1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label hostNameLabel;
            System.Windows.Forms.Label imageStartDateLabel;
            System.Windows.Forms.Label imageCompleteDateLabel;
            System.Windows.Forms.Label goPostCompleteDateLabel;
            System.Windows.Forms.Label goPostReportErrorsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details1));
            this.oSDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.oSDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTOpsEngineeringDataSet = new TestDataGrid.ITOpsEngineeringDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.oSDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.hostNameTextBox = new System.Windows.Forms.TextBox();
            this.imageStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imageCompleteDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.goPostCompleteDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.goPostReportErrorsTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ViewLogsbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewClientLogsbutton = new System.Windows.Forms.Button();
            this.Netopbutton = new System.Windows.Forms.Button();
            this.oSDTableAdapter = new TestDataGrid.ITOpsEngineeringDataSetTableAdapters.OSDTableAdapter();
            this.tableAdapterManager = new TestDataGrid.ITOpsEngineeringDataSetTableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            hostNameLabel = new System.Windows.Forms.Label();
            imageStartDateLabel = new System.Windows.Forms.Label();
            imageCompleteDateLabel = new System.Windows.Forms.Label();
            goPostCompleteDateLabel = new System.Windows.Forms.Label();
            goPostReportErrorsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oSDBindingNavigator)).BeginInit();
            this.oSDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oSDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTOpsEngineeringDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(28, 71);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(28, 97);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "Status:";
            // 
            // hostNameLabel
            // 
            hostNameLabel.AutoSize = true;
            hostNameLabel.Location = new System.Drawing.Point(28, 123);
            hostNameLabel.Name = "hostNameLabel";
            hostNameLabel.Size = new System.Drawing.Size(63, 13);
            hostNameLabel.TabIndex = 6;
            hostNameLabel.Text = "Host Name:";
            // 
            // imageStartDateLabel
            // 
            imageStartDateLabel.AutoSize = true;
            imageStartDateLabel.Location = new System.Drawing.Point(28, 154);
            imageStartDateLabel.Name = "imageStartDateLabel";
            imageStartDateLabel.Size = new System.Drawing.Size(90, 13);
            imageStartDateLabel.TabIndex = 10;
            imageStartDateLabel.Text = "Image Start Date:";
            // 
            // imageCompleteDateLabel
            // 
            imageCompleteDateLabel.AutoSize = true;
            imageCompleteDateLabel.Location = new System.Drawing.Point(28, 180);
            imageCompleteDateLabel.Name = "imageCompleteDateLabel";
            imageCompleteDateLabel.Size = new System.Drawing.Size(112, 13);
            imageCompleteDateLabel.TabIndex = 12;
            imageCompleteDateLabel.Text = "Image Complete Date:";
            // 
            // goPostCompleteDateLabel
            // 
            goPostCompleteDateLabel.AutoSize = true;
            goPostCompleteDateLabel.Location = new System.Drawing.Point(28, 206);
            goPostCompleteDateLabel.Name = "goPostCompleteDateLabel";
            goPostCompleteDateLabel.Size = new System.Drawing.Size(121, 13);
            goPostCompleteDateLabel.TabIndex = 14;
            goPostCompleteDateLabel.Text = "Go Post Complete Date:";
            // 
            // goPostReportErrorsLabel
            // 
            goPostReportErrorsLabel.AutoSize = true;
            goPostReportErrorsLabel.Location = new System.Drawing.Point(28, 231);
            goPostReportErrorsLabel.Name = "goPostReportErrorsLabel";
            goPostReportErrorsLabel.Size = new System.Drawing.Size(113, 13);
            goPostReportErrorsLabel.TabIndex = 16;
            goPostReportErrorsLabel.Text = "Go Post Report Errors:";
            // 
            // oSDBindingNavigator
            // 
            this.oSDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oSDBindingNavigator.BindingSource = this.oSDBindingSource;
            this.oSDBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oSDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oSDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.oSDBindingNavigatorSaveItem});
            this.oSDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.oSDBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oSDBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oSDBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oSDBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oSDBindingNavigator.Name = "oSDBindingNavigator";
            this.oSDBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oSDBindingNavigator.Size = new System.Drawing.Size(714, 25);
            this.oSDBindingNavigator.TabIndex = 1;
            this.oSDBindingNavigator.Text = "bindingNavigator1";
            this.oSDBindingNavigator.Visible = false;
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
            // oSDBindingSource
            // 
            this.oSDBindingSource.DataMember = "OSD";
            this.oSDBindingSource.DataSource = this.iTOpsEngineeringDataSet;
            // 
            // iTOpsEngineeringDataSet
            // 
            this.iTOpsEngineeringDataSet.DataSetName = "ITOpsEngineeringDataSet";
            this.iTOpsEngineeringDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // oSDBindingNavigatorSaveItem
            // 
            this.oSDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oSDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oSDBindingNavigatorSaveItem.Image")));
            this.oSDBindingNavigatorSaveItem.Name = "oSDBindingNavigatorSaveItem";
            this.oSDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.oSDBindingNavigatorSaveItem.Text = "Save Data";
            this.oSDBindingNavigatorSaveItem.Click += new System.EventHandler(this.oSDBindingNavigatorSaveItem_Click_1);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oSDBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(155, 68);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oSDBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(155, 94);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.statusTextBox.TabIndex = 5;
            // 
            // hostNameTextBox
            // 
            this.hostNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oSDBindingSource, "HostName", true));
            this.hostNameTextBox.Location = new System.Drawing.Point(155, 120);
            this.hostNameTextBox.Name = "hostNameTextBox";
            this.hostNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.hostNameTextBox.TabIndex = 7;
            // 
            // imageStartDateDateTimePicker
            // 
            this.imageStartDateDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.imageStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.oSDBindingSource, "ImageStartDate", true));
            this.imageStartDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.imageStartDateDateTimePicker.Location = new System.Drawing.Point(155, 150);
            this.imageStartDateDateTimePicker.Name = "imageStartDateDateTimePicker";
            this.imageStartDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.imageStartDateDateTimePicker.TabIndex = 11;
            // 
            // imageCompleteDateDateTimePicker
            // 
            this.imageCompleteDateDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.imageCompleteDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.oSDBindingSource, "ImageCompleteDate", true));
            this.imageCompleteDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.imageCompleteDateDateTimePicker.Location = new System.Drawing.Point(155, 176);
            this.imageCompleteDateDateTimePicker.Name = "imageCompleteDateDateTimePicker";
            this.imageCompleteDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.imageCompleteDateDateTimePicker.TabIndex = 13;
            // 
            // goPostCompleteDateDateTimePicker
            // 
            this.goPostCompleteDateDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.goPostCompleteDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.oSDBindingSource, "GoPostCompleteDate", true));
            this.goPostCompleteDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.goPostCompleteDateDateTimePicker.Location = new System.Drawing.Point(155, 202);
            this.goPostCompleteDateDateTimePicker.Name = "goPostCompleteDateDateTimePicker";
            this.goPostCompleteDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.goPostCompleteDateDateTimePicker.TabIndex = 15;
            // 
            // goPostReportErrorsTextBox
            // 
            this.goPostReportErrorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oSDBindingSource, "GoPostReportErrors", true));
            this.goPostReportErrorsTextBox.Location = new System.Drawing.Point(155, 228);
            this.goPostReportErrorsTextBox.Name = "goPostReportErrorsTextBox";
            this.goPostReportErrorsTextBox.Size = new System.Drawing.Size(200, 20);
            this.goPostReportErrorsTextBox.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Location = new System.Drawing.Point(464, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Dart Remote Control";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewLogsbutton
            // 
            this.ViewLogsbutton.Location = new System.Drawing.Point(464, 129);
            this.ViewLogsbutton.Name = "ViewLogsbutton";
            this.ViewLogsbutton.Size = new System.Drawing.Size(103, 23);
            this.ViewLogsbutton.TabIndex = 19;
            this.ViewLogsbutton.Text = "View Server Logs";
            this.ViewLogsbutton.UseVisualStyleBackColor = true;
            this.ViewLogsbutton.Click += new System.EventHandler(this.ViewLogsbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 287);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(542, 94);
            this.textBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Status Messages";
            // 
            // ViewClientLogsbutton
            // 
            this.ViewClientLogsbutton.Location = new System.Drawing.Point(464, 158);
            this.ViewClientLogsbutton.Name = "ViewClientLogsbutton";
            this.ViewClientLogsbutton.Size = new System.Drawing.Size(103, 23);
            this.ViewClientLogsbutton.TabIndex = 22;
            this.ViewClientLogsbutton.Text = "View Client Logs";
            this.ViewClientLogsbutton.UseVisualStyleBackColor = true;
            this.ViewClientLogsbutton.Click += new System.EventHandler(this.ViewClientLogsbutton_Click);
            // 
            // Netopbutton
            // 
            this.Netopbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Netopbutton.Location = new System.Drawing.Point(464, 100);
            this.Netopbutton.Name = "Netopbutton";
            this.Netopbutton.Size = new System.Drawing.Size(103, 23);
            this.Netopbutton.TabIndex = 23;
            this.Netopbutton.Text = "Netop";
            this.Netopbutton.UseVisualStyleBackColor = true;
            this.Netopbutton.Click += new System.EventHandler(this.Netopbutton_Click);
            // 
            // oSDTableAdapter
            // 
            this.oSDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OSDTableAdapter = this.oSDTableAdapter;
            this.tableAdapterManager.UpdateOrder = TestDataGrid.ITOpsEngineeringDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Details1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 458);
            this.Controls.Add(this.Netopbutton);
            this.Controls.Add(this.ViewClientLogsbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ViewLogsbutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(hostNameLabel);
            this.Controls.Add(this.hostNameTextBox);
            this.Controls.Add(imageStartDateLabel);
            this.Controls.Add(this.imageStartDateDateTimePicker);
            this.Controls.Add(imageCompleteDateLabel);
            this.Controls.Add(this.imageCompleteDateDateTimePicker);
            this.Controls.Add(goPostCompleteDateLabel);
            this.Controls.Add(this.goPostCompleteDateDateTimePicker);
            this.Controls.Add(goPostReportErrorsLabel);
            this.Controls.Add(this.goPostReportErrorsTextBox);
            this.Controls.Add(this.oSDBindingNavigator);
            this.Name = "Details1";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oSDBindingNavigator)).EndInit();
            this.oSDBindingNavigator.ResumeLayout(false);
            this.oSDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oSDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTOpsEngineeringDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITOpsEngineeringDataSet iTOpsEngineeringDataSet;
        private System.Windows.Forms.BindingSource oSDBindingSource;
        private ITOpsEngineeringDataSetTableAdapters.OSDTableAdapter oSDTableAdapter;
        private ITOpsEngineeringDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator oSDBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton oSDBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox hostNameTextBox;
        private System.Windows.Forms.DateTimePicker imageStartDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker imageCompleteDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker goPostCompleteDateDateTimePicker;
        private System.Windows.Forms.TextBox goPostReportErrorsTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ViewLogsbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewClientLogsbutton;
        private System.Windows.Forms.Button Netopbutton;
    }
}