namespace PixisAirProject
{
    partial class FormJosh1
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
            System.Windows.Forms.Label custNoLabel;
            System.Windows.Forms.Label cFNAMELabel;
            System.Windows.Forms.Label caddrLabel;
            System.Windows.Forms.Label cLNAMELabel;
            System.Windows.Forms.Label ccityLabel;
            System.Windows.Forms.Label cstateLabel;
            System.Windows.Forms.Label czipLabel;
            System.Windows.Forms.Label cphoneLabel;
            System.Windows.Forms.Label cemailLabel;
            System.Windows.Forms.Label cdobLabel;
            System.Windows.Forms.Label cgenderLabel;
            System.Windows.Forms.Label cpwordLabel;
            System.Windows.Forms.Label csccardnoLabel;
            System.Windows.Forms.Label cspymtstlLabel;
            System.Windows.Forms.Label cpwordhashLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJosh1));
            this.pixisAirDataSet = new PixisAirProject.PixisAirDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new PixisAirProject.PixisAirDataSetTableAdapters.customersTableAdapter();
            this.tableAdapterManager = new PixisAirProject.PixisAirDataSetTableAdapters.TableAdapterManager();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.customersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.custNoTextBox = new System.Windows.Forms.TextBox();
            this.cFNAMETextBox = new System.Windows.Forms.TextBox();
            this.caddrTextBox = new System.Windows.Forms.TextBox();
            this.cLNAMETextBox = new System.Windows.Forms.TextBox();
            this.ccityTextBox = new System.Windows.Forms.TextBox();
            this.cstateTextBox = new System.Windows.Forms.TextBox();
            this.czipTextBox = new System.Windows.Forms.TextBox();
            this.cphoneTextBox = new System.Windows.Forms.TextBox();
            this.cemailTextBox = new System.Windows.Forms.TextBox();
            this.cdobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cgenderTextBox = new System.Windows.Forms.TextBox();
            this.cpwordTextBox = new System.Windows.Forms.TextBox();
            this.csccardnoTextBox = new System.Windows.Forms.TextBox();
            this.cspymtstlTextBox = new System.Windows.Forms.TextBox();
            this.cpwordhashTextBox = new System.Windows.Forms.TextBox();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.displayBtn = new System.Windows.Forms.Button();
            custNoLabel = new System.Windows.Forms.Label();
            cFNAMELabel = new System.Windows.Forms.Label();
            caddrLabel = new System.Windows.Forms.Label();
            cLNAMELabel = new System.Windows.Forms.Label();
            ccityLabel = new System.Windows.Forms.Label();
            cstateLabel = new System.Windows.Forms.Label();
            czipLabel = new System.Windows.Forms.Label();
            cphoneLabel = new System.Windows.Forms.Label();
            cemailLabel = new System.Windows.Forms.Label();
            cdobLabel = new System.Windows.Forms.Label();
            cgenderLabel = new System.Windows.Forms.Label();
            cpwordLabel = new System.Windows.Forms.Label();
            csccardnoLabel = new System.Windows.Forms.Label();
            cspymtstlLabel = new System.Windows.Forms.Label();
            cpwordhashLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pixisAirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // custNoLabel
            // 
            custNoLabel.AutoSize = true;
            custNoLabel.Location = new System.Drawing.Point(17, 31);
            custNoLabel.Name = "custNoLabel";
            custNoLabel.Size = new System.Drawing.Size(48, 13);
            custNoLabel.TabIndex = 1;
            custNoLabel.Text = "Cust No:";
            // 
            // cFNAMELabel
            // 
            cFNAMELabel.AutoSize = true;
            cFNAMELabel.Location = new System.Drawing.Point(194, 31);
            cFNAMELabel.Name = "cFNAMELabel";
            cFNAMELabel.Size = new System.Drawing.Size(54, 13);
            cFNAMELabel.TabIndex = 3;
            cFNAMELabel.Text = "CFNAME:";
            // 
            // caddrLabel
            // 
            caddrLabel.AutoSize = true;
            caddrLabel.Location = new System.Drawing.Point(554, 31);
            caddrLabel.Name = "caddrLabel";
            caddrLabel.Size = new System.Drawing.Size(38, 13);
            caddrLabel.TabIndex = 5;
            caddrLabel.Text = "Caddr:";
            // 
            // cLNAMELabel
            // 
            cLNAMELabel.AutoSize = true;
            cLNAMELabel.Location = new System.Drawing.Point(365, 31);
            cLNAMELabel.Name = "cLNAMELabel";
            cLNAMELabel.Size = new System.Drawing.Size(54, 13);
            cLNAMELabel.TabIndex = 7;
            cLNAMELabel.Text = "CLNAME:";
            // 
            // ccityLabel
            // 
            ccityLabel.AutoSize = true;
            ccityLabel.Location = new System.Drawing.Point(32, 57);
            ccityLabel.Name = "ccityLabel";
            ccityLabel.Size = new System.Drawing.Size(33, 13);
            ccityLabel.TabIndex = 9;
            ccityLabel.Text = "Ccity:";
            // 
            // cstateLabel
            // 
            cstateLabel.AutoSize = true;
            cstateLabel.Location = new System.Drawing.Point(208, 60);
            cstateLabel.Name = "cstateLabel";
            cstateLabel.Size = new System.Drawing.Size(40, 13);
            cstateLabel.TabIndex = 11;
            cstateLabel.Text = "Cstate:";
            // 
            // czipLabel
            // 
            czipLabel.AutoSize = true;
            czipLabel.Location = new System.Drawing.Point(389, 60);
            czipLabel.Name = "czipLabel";
            czipLabel.Size = new System.Drawing.Size(30, 13);
            czipLabel.TabIndex = 13;
            czipLabel.Text = "Czip:";
            // 
            // cphoneLabel
            // 
            cphoneLabel.AutoSize = true;
            cphoneLabel.Location = new System.Drawing.Point(545, 60);
            cphoneLabel.Name = "cphoneLabel";
            cphoneLabel.Size = new System.Drawing.Size(47, 13);
            cphoneLabel.TabIndex = 15;
            cphoneLabel.Text = "Cphone:";
            // 
            // cemailLabel
            // 
            cemailLabel.AutoSize = true;
            cemailLabel.Location = new System.Drawing.Point(24, 83);
            cemailLabel.Name = "cemailLabel";
            cemailLabel.Size = new System.Drawing.Size(41, 13);
            cemailLabel.TabIndex = 17;
            cemailLabel.Text = "Cemail:";
            // 
            // cdobLabel
            // 
            cdobLabel.AutoSize = true;
            cdobLabel.Location = new System.Drawing.Point(384, 113);
            cdobLabel.Name = "cdobLabel";
            cdobLabel.Size = new System.Drawing.Size(35, 13);
            cdobLabel.TabIndex = 19;
            cdobLabel.Text = "Cdob:";
            // 
            // cgenderLabel
            // 
            cgenderLabel.AutoSize = true;
            cgenderLabel.Location = new System.Drawing.Point(199, 86);
            cgenderLabel.Name = "cgenderLabel";
            cgenderLabel.Size = new System.Drawing.Size(49, 13);
            cgenderLabel.TabIndex = 21;
            cgenderLabel.Text = "cgender:";
            // 
            // cpwordLabel
            // 
            cpwordLabel.AutoSize = true;
            cpwordLabel.Location = new System.Drawing.Point(374, 86);
            cpwordLabel.Name = "cpwordLabel";
            cpwordLabel.Size = new System.Drawing.Size(45, 13);
            cpwordLabel.TabIndex = 23;
            cpwordLabel.Text = "cpword:";
            // 
            // csccardnoLabel
            // 
            csccardnoLabel.AutoSize = true;
            csccardnoLabel.Location = new System.Drawing.Point(5, 109);
            csccardnoLabel.Name = "csccardnoLabel";
            csccardnoLabel.Size = new System.Drawing.Size(60, 13);
            csccardnoLabel.TabIndex = 25;
            csccardnoLabel.Text = "csccardno:";
            // 
            // cspymtstlLabel
            // 
            cspymtstlLabel.AutoSize = true;
            cspymtstlLabel.Location = new System.Drawing.Point(539, 89);
            cspymtstlLabel.Name = "cspymtstlLabel";
            cspymtstlLabel.Size = new System.Drawing.Size(53, 13);
            cspymtstlLabel.TabIndex = 27;
            cspymtstlLabel.Text = "cspymtstl:";
            // 
            // cpwordhashLabel
            // 
            cpwordhashLabel.AutoSize = true;
            cpwordhashLabel.Location = new System.Drawing.Point(180, 112);
            cpwordhashLabel.Name = "cpwordhashLabel";
            cpwordhashLabel.Size = new System.Drawing.Size(68, 13);
            cpwordhashLabel.TabIndex = 29;
            cpwordhashLabel.Text = "cpwordhash:";
            // 
            // pixisAirDataSet
            // 
            this.pixisAirDataSet.DataSetName = "PixisAirDataSet";
            this.pixisAirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.pixisAirDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = PixisAirProject.PixisAirDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customersBindingNavigatorSaveItem});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customersBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
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
            // customersBindingNavigatorSaveItem
            // 
            this.customersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingNavigatorSaveItem.Image")));
            this.customersBindingNavigatorSaveItem.Name = "customersBindingNavigatorSaveItem";
            this.customersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customersBindingNavigatorSaveItem.Text = "Save Data";
            this.customersBindingNavigatorSaveItem.Click += new System.EventHandler(this.customersBindingNavigatorSaveItem_Click);
            // 
            // custNoTextBox
            // 
            this.custNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustNo", true));
            this.custNoTextBox.Location = new System.Drawing.Point(71, 28);
            this.custNoTextBox.Name = "custNoTextBox";
            this.custNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.custNoTextBox.TabIndex = 2;
            // 
            // cFNAMETextBox
            // 
            this.cFNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CFNAME", true));
            this.cFNAMETextBox.Location = new System.Drawing.Point(254, 28);
            this.cFNAMETextBox.Name = "cFNAMETextBox";
            this.cFNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.cFNAMETextBox.TabIndex = 4;
            // 
            // caddrTextBox
            // 
            this.caddrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Caddr", true));
            this.caddrTextBox.Location = new System.Drawing.Point(598, 28);
            this.caddrTextBox.Name = "caddrTextBox";
            this.caddrTextBox.Size = new System.Drawing.Size(100, 20);
            this.caddrTextBox.TabIndex = 6;
            // 
            // cLNAMETextBox
            // 
            this.cLNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CLNAME", true));
            this.cLNAMETextBox.Location = new System.Drawing.Point(425, 28);
            this.cLNAMETextBox.Name = "cLNAMETextBox";
            this.cLNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.cLNAMETextBox.TabIndex = 8;
            // 
            // ccityTextBox
            // 
            this.ccityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Ccity", true));
            this.ccityTextBox.Location = new System.Drawing.Point(71, 54);
            this.ccityTextBox.Name = "ccityTextBox";
            this.ccityTextBox.Size = new System.Drawing.Size(100, 20);
            this.ccityTextBox.TabIndex = 10;
            // 
            // cstateTextBox
            // 
            this.cstateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Cstate", true));
            this.cstateTextBox.Location = new System.Drawing.Point(254, 57);
            this.cstateTextBox.Name = "cstateTextBox";
            this.cstateTextBox.Size = new System.Drawing.Size(100, 20);
            this.cstateTextBox.TabIndex = 12;
            // 
            // czipTextBox
            // 
            this.czipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Czip", true));
            this.czipTextBox.Location = new System.Drawing.Point(425, 57);
            this.czipTextBox.Name = "czipTextBox";
            this.czipTextBox.Size = new System.Drawing.Size(100, 20);
            this.czipTextBox.TabIndex = 14;
            // 
            // cphoneTextBox
            // 
            this.cphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Cphone", true));
            this.cphoneTextBox.Location = new System.Drawing.Point(598, 57);
            this.cphoneTextBox.Name = "cphoneTextBox";
            this.cphoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.cphoneTextBox.TabIndex = 16;
            // 
            // cemailTextBox
            // 
            this.cemailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Cemail", true));
            this.cemailTextBox.Location = new System.Drawing.Point(71, 80);
            this.cemailTextBox.Name = "cemailTextBox";
            this.cemailTextBox.Size = new System.Drawing.Size(100, 20);
            this.cemailTextBox.TabIndex = 18;
            // 
            // cdobDateTimePicker
            // 
            this.cdobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customersBindingSource, "Cdob", true));
            this.cdobDateTimePicker.Location = new System.Drawing.Point(425, 109);
            this.cdobDateTimePicker.Name = "cdobDateTimePicker";
            this.cdobDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.cdobDateTimePicker.TabIndex = 20;
            // 
            // cgenderTextBox
            // 
            this.cgenderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "cgender", true));
            this.cgenderTextBox.Location = new System.Drawing.Point(254, 83);
            this.cgenderTextBox.Name = "cgenderTextBox";
            this.cgenderTextBox.Size = new System.Drawing.Size(100, 20);
            this.cgenderTextBox.TabIndex = 22;
            // 
            // cpwordTextBox
            // 
            this.cpwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "cpword", true));
            this.cpwordTextBox.Location = new System.Drawing.Point(425, 83);
            this.cpwordTextBox.Name = "cpwordTextBox";
            this.cpwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.cpwordTextBox.TabIndex = 24;
            // 
            // csccardnoTextBox
            // 
            this.csccardnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "csccardno", true));
            this.csccardnoTextBox.Location = new System.Drawing.Point(71, 106);
            this.csccardnoTextBox.Name = "csccardnoTextBox";
            this.csccardnoTextBox.Size = new System.Drawing.Size(100, 20);
            this.csccardnoTextBox.TabIndex = 26;
            // 
            // cspymtstlTextBox
            // 
            this.cspymtstlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "cspymtstl", true));
            this.cspymtstlTextBox.Location = new System.Drawing.Point(598, 86);
            this.cspymtstlTextBox.Name = "cspymtstlTextBox";
            this.cspymtstlTextBox.Size = new System.Drawing.Size(100, 20);
            this.cspymtstlTextBox.TabIndex = 28;
            // 
            // cpwordhashTextBox
            // 
            this.cpwordhashTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "cpwordhash", true));
            this.cpwordhashTextBox.Location = new System.Drawing.Point(254, 109);
            this.cpwordhashTextBox.Name = "cpwordhashTextBox";
            this.cpwordhashTextBox.Size = new System.Drawing.Size(100, 20);
            this.cpwordhashTextBox.TabIndex = 30;
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.Location = new System.Drawing.Point(8, 152);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(302, 290);
            this.displayListBox.TabIndex = 31;
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(316, 152);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(89, 46);
            this.displayBtn.TabIndex = 32;
            this.displayBtn.Text = "Display Database";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(cpwordhashLabel);
            this.Controls.Add(this.cpwordhashTextBox);
            this.Controls.Add(cspymtstlLabel);
            this.Controls.Add(this.cspymtstlTextBox);
            this.Controls.Add(csccardnoLabel);
            this.Controls.Add(this.csccardnoTextBox);
            this.Controls.Add(cpwordLabel);
            this.Controls.Add(this.cpwordTextBox);
            this.Controls.Add(cgenderLabel);
            this.Controls.Add(this.cgenderTextBox);
            this.Controls.Add(cdobLabel);
            this.Controls.Add(this.cdobDateTimePicker);
            this.Controls.Add(cemailLabel);
            this.Controls.Add(this.cemailTextBox);
            this.Controls.Add(cphoneLabel);
            this.Controls.Add(this.cphoneTextBox);
            this.Controls.Add(czipLabel);
            this.Controls.Add(this.czipTextBox);
            this.Controls.Add(cstateLabel);
            this.Controls.Add(this.cstateTextBox);
            this.Controls.Add(ccityLabel);
            this.Controls.Add(this.ccityTextBox);
            this.Controls.Add(cLNAMELabel);
            this.Controls.Add(this.cLNAMETextBox);
            this.Controls.Add(caddrLabel);
            this.Controls.Add(this.caddrTextBox);
            this.Controls.Add(cFNAMELabel);
            this.Controls.Add(this.cFNAMETextBox);
            this.Controls.Add(custNoLabel);
            this.Controls.Add(this.custNoTextBox);
            this.Controls.Add(this.customersBindingNavigator);
            this.Name = "Form1";
            this.Text = "SQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pixisAirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PixisAirDataSet pixisAirDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private PixisAirDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private PixisAirDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox custNoTextBox;
        private System.Windows.Forms.TextBox cFNAMETextBox;
        private System.Windows.Forms.TextBox caddrTextBox;
        private System.Windows.Forms.TextBox cLNAMETextBox;
        private System.Windows.Forms.TextBox ccityTextBox;
        private System.Windows.Forms.TextBox cstateTextBox;
        private System.Windows.Forms.TextBox czipTextBox;
        private System.Windows.Forms.TextBox cphoneTextBox;
        private System.Windows.Forms.TextBox cemailTextBox;
        private System.Windows.Forms.DateTimePicker cdobDateTimePicker;
        private System.Windows.Forms.TextBox cgenderTextBox;
        private System.Windows.Forms.TextBox cpwordTextBox;
        private System.Windows.Forms.TextBox csccardnoTextBox;
        private System.Windows.Forms.TextBox cspymtstlTextBox;
        private System.Windows.Forms.TextBox cpwordhashTextBox;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.Button displayBtn;
    }
}

