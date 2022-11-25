<<<<<<< HEAD
﻿namespace PixisAirProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label cUSTNOLabel;
            System.Windows.Forms.Label cFNAMELabel;
            System.Windows.Forms.Label cLNAMELabel;
            System.Windows.Forms.Label cADDRLabel;
            System.Windows.Forms.Label cCITYLabel;
            System.Windows.Forms.Label cSTATELabel;
            System.Windows.Forms.Label cZIPLabel;
            System.Windows.Forms.Label cPHONELabel;
            System.Windows.Forms.Label cEMAILLabel;
            System.Windows.Forms.Label cDOBLabel;
            System.Windows.Forms.Label cGENDERLabel;
            System.Windows.Forms.Label cPWORDLabel;
            System.Windows.Forms.Label cSCCARDNOLabel;
            System.Windows.Forms.Label cSPYMTSTLLabel;
            System.Windows.Forms.Label cPWORDHASHLabel;
            this.dataSet1 = new PixisAirProject.DataSet1();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new PixisAirProject.DataSet1TableAdapters.CUSTOMERTableAdapter();
            this.tableAdapterManager = new PixisAirProject.DataSet1TableAdapters.TableAdapterManager();
            this.cUSTOMERBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cUSTOMERBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cUSTNOTextBox = new System.Windows.Forms.TextBox();
            this.cFNAMETextBox = new System.Windows.Forms.TextBox();
            this.cLNAMETextBox = new System.Windows.Forms.TextBox();
            this.cADDRTextBox = new System.Windows.Forms.TextBox();
            this.cCITYTextBox = new System.Windows.Forms.TextBox();
            this.cSTATETextBox = new System.Windows.Forms.TextBox();
            this.cZIPTextBox = new System.Windows.Forms.TextBox();
            this.cPHONETextBox = new System.Windows.Forms.TextBox();
            this.cEMAILTextBox = new System.Windows.Forms.TextBox();
            this.cDOBTextBox = new System.Windows.Forms.TextBox();
            this.cGENDERTextBox = new System.Windows.Forms.TextBox();
            this.cPWORDTextBox = new System.Windows.Forms.TextBox();
            this.cSCCARDNOTextBox = new System.Windows.Forms.TextBox();
            this.cSPYMTSTLTextBox = new System.Windows.Forms.TextBox();
            this.cPWORDHASHTextBox = new System.Windows.Forms.TextBox();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.displayBtn = new System.Windows.Forms.Button();
            cUSTNOLabel = new System.Windows.Forms.Label();
            cFNAMELabel = new System.Windows.Forms.Label();
            cLNAMELabel = new System.Windows.Forms.Label();
            cADDRLabel = new System.Windows.Forms.Label();
            cCITYLabel = new System.Windows.Forms.Label();
            cSTATELabel = new System.Windows.Forms.Label();
            cZIPLabel = new System.Windows.Forms.Label();
            cPHONELabel = new System.Windows.Forms.Label();
            cEMAILLabel = new System.Windows.Forms.Label();
            cDOBLabel = new System.Windows.Forms.Label();
            cGENDERLabel = new System.Windows.Forms.Label();
            cPWORDLabel = new System.Windows.Forms.Label();
            cSCCARDNOLabel = new System.Windows.Forms.Label();
            cSPYMTSTLLabel = new System.Windows.Forms.Label();
            cPWORDHASHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingNavigator)).BeginInit();
            this.cUSTOMERBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.dataSet1;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERTableAdapter = this.cUSTOMERTableAdapter;
            this.tableAdapterManager.UpdateOrder = PixisAirProject.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cUSTOMERBindingNavigator
            // 
            this.cUSTOMERBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cUSTOMERBindingNavigator.BindingSource = this.cUSTOMERBindingSource;
            this.cUSTOMERBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cUSTOMERBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cUSTOMERBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cUSTOMERBindingNavigatorSaveItem});
            this.cUSTOMERBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cUSTOMERBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cUSTOMERBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cUSTOMERBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cUSTOMERBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cUSTOMERBindingNavigator.Name = "cUSTOMERBindingNavigator";
            this.cUSTOMERBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cUSTOMERBindingNavigator.Size = new System.Drawing.Size(777, 25);
            this.cUSTOMERBindingNavigator.TabIndex = 0;
            this.cUSTOMERBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cUSTOMERBindingNavigatorSaveItem
            // 
            this.cUSTOMERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cUSTOMERBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cUSTOMERBindingNavigatorSaveItem.Image")));
            this.cUSTOMERBindingNavigatorSaveItem.Name = "cUSTOMERBindingNavigatorSaveItem";
            this.cUSTOMERBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cUSTOMERBindingNavigatorSaveItem.Text = "Save Data";
            this.cUSTOMERBindingNavigatorSaveItem.Click += new System.EventHandler(this.cUSTOMERBindingNavigatorSaveItem_Click);
            // 
            // cUSTNOLabel
            // 
            cUSTNOLabel.AutoSize = true;
            cUSTNOLabel.Location = new System.Drawing.Point(30, 44);
            cUSTNOLabel.Name = "cUSTNOLabel";
            cUSTNOLabel.Size = new System.Drawing.Size(55, 13);
            cUSTNOLabel.TabIndex = 1;
            cUSTNOLabel.Text = "CUSTNO:";
            // 
            // cUSTNOTextBox
            // 
            this.cUSTNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUSTNO", true));
            this.cUSTNOTextBox.Location = new System.Drawing.Point(91, 41);
            this.cUSTNOTextBox.Name = "cUSTNOTextBox";
            this.cUSTNOTextBox.Size = new System.Drawing.Size(100, 20);
            this.cUSTNOTextBox.TabIndex = 2;
            // 
            // cFNAMELabel
            // 
            cFNAMELabel.AutoSize = true;
            cFNAMELabel.Location = new System.Drawing.Point(221, 44);
            cFNAMELabel.Name = "cFNAMELabel";
            cFNAMELabel.Size = new System.Drawing.Size(54, 13);
            cFNAMELabel.TabIndex = 3;
            cFNAMELabel.Text = "CFNAME:";
            // 
            // cFNAMETextBox
            // 
            this.cFNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CFNAME", true));
            this.cFNAMETextBox.Location = new System.Drawing.Point(281, 41);
            this.cFNAMETextBox.Name = "cFNAMETextBox";
            this.cFNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.cFNAMETextBox.TabIndex = 4;
            // 
            // cLNAMELabel
            // 
            cLNAMELabel.AutoSize = true;
            cLNAMELabel.Location = new System.Drawing.Point(424, 47);
            cLNAMELabel.Name = "cLNAMELabel";
            cLNAMELabel.Size = new System.Drawing.Size(54, 13);
            cLNAMELabel.TabIndex = 5;
            cLNAMELabel.Text = "CLNAME:";
            // 
            // cLNAMETextBox
            // 
            this.cLNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CLNAME", true));
            this.cLNAMETextBox.Location = new System.Drawing.Point(484, 44);
            this.cLNAMETextBox.Name = "cLNAMETextBox";
            this.cLNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.cLNAMETextBox.TabIndex = 6;
            // 
            // cADDRLabel
            // 
            cADDRLabel.AutoSize = true;
            cADDRLabel.Location = new System.Drawing.Point(604, 47);
            cADDRLabel.Name = "cADDRLabel";
            cADDRLabel.Size = new System.Drawing.Size(48, 13);
            cADDRLabel.TabIndex = 7;
            cADDRLabel.Text = "CADDR:";
            // 
            // cADDRTextBox
            // 
            this.cADDRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CADDR", true));
            this.cADDRTextBox.Location = new System.Drawing.Point(658, 44);
            this.cADDRTextBox.Name = "cADDRTextBox";
            this.cADDRTextBox.Size = new System.Drawing.Size(100, 20);
            this.cADDRTextBox.TabIndex = 8;
            // 
            // cCITYLabel
            // 
            cCITYLabel.AutoSize = true;
            cCITYLabel.Location = new System.Drawing.Point(44, 72);
            cCITYLabel.Name = "cCITYLabel";
            cCITYLabel.Size = new System.Drawing.Size(41, 13);
            cCITYLabel.TabIndex = 9;
            cCITYLabel.Text = "CCITY:";
            // 
            // cCITYTextBox
            // 
            this.cCITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CCITY", true));
            this.cCITYTextBox.Location = new System.Drawing.Point(91, 69);
            this.cCITYTextBox.Name = "cCITYTextBox";
            this.cCITYTextBox.Size = new System.Drawing.Size(100, 20);
            this.cCITYTextBox.TabIndex = 10;
            // 
            // cSTATELabel
            // 
            cSTATELabel.AutoSize = true;
            cSTATELabel.Location = new System.Drawing.Point(223, 72);
            cSTATELabel.Name = "cSTATELabel";
            cSTATELabel.Size = new System.Drawing.Size(52, 13);
            cSTATELabel.TabIndex = 11;
            cSTATELabel.Text = "CSTATE:";
            // 
            // cSTATETextBox
            // 
            this.cSTATETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CSTATE", true));
            this.cSTATETextBox.Location = new System.Drawing.Point(281, 69);
            this.cSTATETextBox.Name = "cSTATETextBox";
            this.cSTATETextBox.Size = new System.Drawing.Size(100, 20);
            this.cSTATETextBox.TabIndex = 12;
            // 
            // cZIPLabel
            // 
            cZIPLabel.AutoSize = true;
            cZIPLabel.Location = new System.Drawing.Point(444, 75);
            cZIPLabel.Name = "cZIPLabel";
            cZIPLabel.Size = new System.Drawing.Size(34, 13);
            cZIPLabel.TabIndex = 13;
            cZIPLabel.Text = "CZIP:";
            // 
            // cZIPTextBox
            // 
            this.cZIPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CZIP", true));
            this.cZIPTextBox.Location = new System.Drawing.Point(484, 72);
            this.cZIPTextBox.Name = "cZIPTextBox";
            this.cZIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.cZIPTextBox.TabIndex = 14;
            // 
            // cPHONELabel
            // 
            cPHONELabel.AutoSize = true;
            cPHONELabel.Location = new System.Drawing.Point(597, 75);
            cPHONELabel.Name = "cPHONELabel";
            cPHONELabel.Size = new System.Drawing.Size(55, 13);
            cPHONELabel.TabIndex = 15;
            cPHONELabel.Text = "CPHONE:";
            // 
            // cPHONETextBox
            // 
            this.cPHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CPHONE", true));
            this.cPHONETextBox.Location = new System.Drawing.Point(658, 72);
            this.cPHONETextBox.Name = "cPHONETextBox";
            this.cPHONETextBox.Size = new System.Drawing.Size(100, 20);
            this.cPHONETextBox.TabIndex = 16;
            // 
            // cEMAILLabel
            // 
            cEMAILLabel.AutoSize = true;
            cEMAILLabel.Location = new System.Drawing.Point(36, 105);
            cEMAILLabel.Name = "cEMAILLabel";
            cEMAILLabel.Size = new System.Drawing.Size(49, 13);
            cEMAILLabel.TabIndex = 17;
            cEMAILLabel.Text = "CEMAIL:";
            // 
            // cEMAILTextBox
            // 
            this.cEMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CEMAIL", true));
            this.cEMAILTextBox.Location = new System.Drawing.Point(91, 102);
            this.cEMAILTextBox.Name = "cEMAILTextBox";
            this.cEMAILTextBox.Size = new System.Drawing.Size(100, 20);
            this.cEMAILTextBox.TabIndex = 18;
            // 
            // cDOBLabel
            // 
            cDOBLabel.AutoSize = true;
            cDOBLabel.Location = new System.Drawing.Point(235, 105);
            cDOBLabel.Name = "cDOBLabel";
            cDOBLabel.Size = new System.Drawing.Size(40, 13);
            cDOBLabel.TabIndex = 19;
            cDOBLabel.Text = "CDOB:";
            // 
            // cDOBTextBox
            // 
            this.cDOBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CDOB", true));
            this.cDOBTextBox.Location = new System.Drawing.Point(281, 102);
            this.cDOBTextBox.Name = "cDOBTextBox";
            this.cDOBTextBox.Size = new System.Drawing.Size(100, 20);
            this.cDOBTextBox.TabIndex = 20;
            // 
            // cGENDERLabel
            // 
            cGENDERLabel.AutoSize = true;
            cGENDERLabel.Location = new System.Drawing.Point(414, 108);
            cGENDERLabel.Name = "cGENDERLabel";
            cGENDERLabel.Size = new System.Drawing.Size(63, 13);
            cGENDERLabel.TabIndex = 21;
            cGENDERLabel.Text = "CGENDER:";
            // 
            // cGENDERTextBox
            // 
            this.cGENDERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CGENDER", true));
            this.cGENDERTextBox.Location = new System.Drawing.Point(483, 105);
            this.cGENDERTextBox.Name = "cGENDERTextBox";
            this.cGENDERTextBox.Size = new System.Drawing.Size(100, 20);
            this.cGENDERTextBox.TabIndex = 22;
            // 
            // cPWORDLabel
            // 
            cPWORDLabel.AutoSize = true;
            cPWORDLabel.Location = new System.Drawing.Point(593, 108);
            cPWORDLabel.Name = "cPWORDLabel";
            cPWORDLabel.Size = new System.Drawing.Size(59, 13);
            cPWORDLabel.TabIndex = 23;
            cPWORDLabel.Text = "CPWORD:";
            // 
            // cPWORDTextBox
            // 
            this.cPWORDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CPWORD", true));
            this.cPWORDTextBox.Location = new System.Drawing.Point(658, 105);
            this.cPWORDTextBox.Name = "cPWORDTextBox";
            this.cPWORDTextBox.Size = new System.Drawing.Size(100, 20);
            this.cPWORDTextBox.TabIndex = 24;
            // 
            // cSCCARDNOLabel
            // 
            cSCCARDNOLabel.AutoSize = true;
            cSCCARDNOLabel.Location = new System.Drawing.Point(8, 134);
            cSCCARDNOLabel.Name = "cSCCARDNOLabel";
            cSCCARDNOLabel.Size = new System.Drawing.Size(77, 13);
            cSCCARDNOLabel.TabIndex = 25;
            cSCCARDNOLabel.Text = "CSCCARDNO:";
            // 
            // cSCCARDNOTextBox
            // 
            this.cSCCARDNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CSCCARDNO", true));
            this.cSCCARDNOTextBox.Location = new System.Drawing.Point(91, 131);
            this.cSCCARDNOTextBox.Name = "cSCCARDNOTextBox";
            this.cSCCARDNOTextBox.Size = new System.Drawing.Size(100, 20);
            this.cSCCARDNOTextBox.TabIndex = 26;
            // 
            // cSPYMTSTLLabel
            // 
            cSPYMTSTLLabel.AutoSize = true;
            cSPYMTSTLLabel.Location = new System.Drawing.Point(201, 134);
            cSPYMTSTLLabel.Name = "cSPYMTSTLLabel";
            cSPYMTSTLLabel.Size = new System.Drawing.Size(74, 13);
            cSPYMTSTLLabel.TabIndex = 27;
            cSPYMTSTLLabel.Text = "CSPYMTSTL:";
            // 
            // cSPYMTSTLTextBox
            // 
            this.cSPYMTSTLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CSPYMTSTL", true));
            this.cSPYMTSTLTextBox.Location = new System.Drawing.Point(281, 131);
            this.cSPYMTSTLTextBox.Name = "cSPYMTSTLTextBox";
            this.cSPYMTSTLTextBox.Size = new System.Drawing.Size(100, 20);
            this.cSPYMTSTLTextBox.TabIndex = 28;
            // 
            // cPWORDHASHLabel
            // 
            cPWORDHASHLabel.AutoSize = true;
            cPWORDHASHLabel.Location = new System.Drawing.Point(389, 134);
            cPWORDHASHLabel.Name = "cPWORDHASHLabel";
            cPWORDHASHLabel.Size = new System.Drawing.Size(89, 13);
            cPWORDHASHLabel.TabIndex = 29;
            cPWORDHASHLabel.Text = "CPWORDHASH:";
            // 
            // cPWORDHASHTextBox
            // 
            this.cPWORDHASHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CPWORDHASH", true));
            this.cPWORDHASHTextBox.Location = new System.Drawing.Point(484, 131);
            this.cPWORDHASHTextBox.Name = "cPWORDHASHTextBox";
            this.cPWORDHASHTextBox.Size = new System.Drawing.Size(100, 20);
            this.cPWORDHASHTextBox.TabIndex = 30;
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.Location = new System.Drawing.Point(12, 181);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(640, 264);
            this.displayListBox.TabIndex = 31;
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(659, 181);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(83, 55);
            this.displayBtn.TabIndex = 32;
            this.displayBtn.Text = "Display IBM Database";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(cPWORDHASHLabel);
            this.Controls.Add(this.cPWORDHASHTextBox);
            this.Controls.Add(cSPYMTSTLLabel);
            this.Controls.Add(this.cSPYMTSTLTextBox);
            this.Controls.Add(cSCCARDNOLabel);
            this.Controls.Add(this.cSCCARDNOTextBox);
            this.Controls.Add(cPWORDLabel);
            this.Controls.Add(this.cPWORDTextBox);
            this.Controls.Add(cGENDERLabel);
            this.Controls.Add(this.cGENDERTextBox);
            this.Controls.Add(cDOBLabel);
            this.Controls.Add(this.cDOBTextBox);
            this.Controls.Add(cEMAILLabel);
            this.Controls.Add(this.cEMAILTextBox);
            this.Controls.Add(cPHONELabel);
            this.Controls.Add(this.cPHONETextBox);
            this.Controls.Add(cZIPLabel);
            this.Controls.Add(this.cZIPTextBox);
            this.Controls.Add(cSTATELabel);
            this.Controls.Add(this.cSTATETextBox);
            this.Controls.Add(cCITYLabel);
            this.Controls.Add(this.cCITYTextBox);
            this.Controls.Add(cADDRLabel);
            this.Controls.Add(this.cADDRTextBox);
            this.Controls.Add(cLNAMELabel);
            this.Controls.Add(this.cLNAMETextBox);
            this.Controls.Add(cFNAMELabel);
            this.Controls.Add(this.cFNAMETextBox);
            this.Controls.Add(cUSTNOLabel);
            this.Controls.Add(this.cUSTNOTextBox);
            this.Controls.Add(this.cUSTOMERBindingNavigator);
            this.Name = "Form2";
            this.Text = "IBM";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingNavigator)).EndInit();
            this.cUSTOMERBindingNavigator.ResumeLayout(false);
            this.cUSTOMERBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private DataSet1TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cUSTOMERBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cUSTOMERBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cUSTNOTextBox;
        private System.Windows.Forms.TextBox cFNAMETextBox;
        private System.Windows.Forms.TextBox cLNAMETextBox;
        private System.Windows.Forms.TextBox cADDRTextBox;
        private System.Windows.Forms.TextBox cCITYTextBox;
        private System.Windows.Forms.TextBox cSTATETextBox;
        private System.Windows.Forms.TextBox cZIPTextBox;
        private System.Windows.Forms.TextBox cPHONETextBox;
        private System.Windows.Forms.TextBox cEMAILTextBox;
        private System.Windows.Forms.TextBox cDOBTextBox;
        private System.Windows.Forms.TextBox cGENDERTextBox;
        private System.Windows.Forms.TextBox cPWORDTextBox;
        private System.Windows.Forms.TextBox cSCCARDNOTextBox;
        private System.Windows.Forms.TextBox cSPYMTSTLTextBox;
        private System.Windows.Forms.TextBox cPWORDHASHTextBox;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.Button displayBtn;
    }
=======
﻿namespace PixisAirProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label cUSTNOLabel;
            System.Windows.Forms.Label cFNAMELabel;
            System.Windows.Forms.Label cLNAMELabel;
            System.Windows.Forms.Label cADDRLabel;
            System.Windows.Forms.Label cCITYLabel;
            System.Windows.Forms.Label cSTATELabel;
            System.Windows.Forms.Label cZIPLabel;
            System.Windows.Forms.Label cPHONELabel;
            System.Windows.Forms.Label cEMAILLabel;
            System.Windows.Forms.Label cDOBLabel;
            System.Windows.Forms.Label cGENDERLabel;
            System.Windows.Forms.Label cPWORDLabel;
            System.Windows.Forms.Label cSCCARDNOLabel;
            System.Windows.Forms.Label cSPYMTSTLLabel;
            System.Windows.Forms.Label cPWORDHASHLabel;
            this.dataSet1 = new PixisAirProject.DataSet1();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new PixisAirProject.DataSet1TableAdapters.CUSTOMERTableAdapter();
            this.tableAdapterManager = new PixisAirProject.DataSet1TableAdapters.TableAdapterManager();
            this.cUSTOMERBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cUSTOMERBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cUSTNOTextBox = new System.Windows.Forms.TextBox();
            this.cFNAMETextBox = new System.Windows.Forms.TextBox();
            this.cLNAMETextBox = new System.Windows.Forms.TextBox();
            this.cADDRTextBox = new System.Windows.Forms.TextBox();
            this.cCITYTextBox = new System.Windows.Forms.TextBox();
            this.cSTATETextBox = new System.Windows.Forms.TextBox();
            this.cZIPTextBox = new System.Windows.Forms.TextBox();
            this.cPHONETextBox = new System.Windows.Forms.TextBox();
            this.cEMAILTextBox = new System.Windows.Forms.TextBox();
            this.cDOBTextBox = new System.Windows.Forms.TextBox();
            this.cGENDERTextBox = new System.Windows.Forms.TextBox();
            this.cPWORDTextBox = new System.Windows.Forms.TextBox();
            this.cSCCARDNOTextBox = new System.Windows.Forms.TextBox();
            this.cSPYMTSTLTextBox = new System.Windows.Forms.TextBox();
            this.cPWORDHASHTextBox = new System.Windows.Forms.TextBox();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.displayBtn = new System.Windows.Forms.Button();
            cUSTNOLabel = new System.Windows.Forms.Label();
            cFNAMELabel = new System.Windows.Forms.Label();
            cLNAMELabel = new System.Windows.Forms.Label();
            cADDRLabel = new System.Windows.Forms.Label();
            cCITYLabel = new System.Windows.Forms.Label();
            cSTATELabel = new System.Windows.Forms.Label();
            cZIPLabel = new System.Windows.Forms.Label();
            cPHONELabel = new System.Windows.Forms.Label();
            cEMAILLabel = new System.Windows.Forms.Label();
            cDOBLabel = new System.Windows.Forms.Label();
            cGENDERLabel = new System.Windows.Forms.Label();
            cPWORDLabel = new System.Windows.Forms.Label();
            cSCCARDNOLabel = new System.Windows.Forms.Label();
            cSPYMTSTLLabel = new System.Windows.Forms.Label();
            cPWORDHASHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingNavigator)).BeginInit();
            this.cUSTOMERBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.dataSet1;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CUSTOMERTableAdapter = this.cUSTOMERTableAdapter;
            this.tableAdapterManager.UpdateOrder = PixisAirProject.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cUSTOMERBindingNavigator
            // 
            this.cUSTOMERBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cUSTOMERBindingNavigator.BindingSource = this.cUSTOMERBindingSource;
            this.cUSTOMERBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cUSTOMERBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cUSTOMERBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cUSTOMERBindingNavigatorSaveItem});
            this.cUSTOMERBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cUSTOMERBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cUSTOMERBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cUSTOMERBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cUSTOMERBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cUSTOMERBindingNavigator.Name = "cUSTOMERBindingNavigator";
            this.cUSTOMERBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cUSTOMERBindingNavigator.Size = new System.Drawing.Size(777, 25);
            this.cUSTOMERBindingNavigator.TabIndex = 0;
            this.cUSTOMERBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cUSTOMERBindingNavigatorSaveItem
            // 
            this.cUSTOMERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cUSTOMERBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cUSTOMERBindingNavigatorSaveItem.Image")));
            this.cUSTOMERBindingNavigatorSaveItem.Name = "cUSTOMERBindingNavigatorSaveItem";
            this.cUSTOMERBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cUSTOMERBindingNavigatorSaveItem.Text = "Save Data";
            this.cUSTOMERBindingNavigatorSaveItem.Click += new System.EventHandler(this.cUSTOMERBindingNavigatorSaveItem_Click);
            // 
            // cUSTNOLabel
            // 
            cUSTNOLabel.AutoSize = true;
            cUSTNOLabel.Location = new System.Drawing.Point(30, 44);
            cUSTNOLabel.Name = "cUSTNOLabel";
            cUSTNOLabel.Size = new System.Drawing.Size(55, 13);
            cUSTNOLabel.TabIndex = 1;
            cUSTNOLabel.Text = "CUSTNO:";
            // 
            // cUSTNOTextBox
            // 
            this.cUSTNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CUSTNO", true));
            this.cUSTNOTextBox.Location = new System.Drawing.Point(91, 41);
            this.cUSTNOTextBox.Name = "cUSTNOTextBox";
            this.cUSTNOTextBox.Size = new System.Drawing.Size(100, 20);
            this.cUSTNOTextBox.TabIndex = 2;
            // 
            // cFNAMELabel
            // 
            cFNAMELabel.AutoSize = true;
            cFNAMELabel.Location = new System.Drawing.Point(221, 44);
            cFNAMELabel.Name = "cFNAMELabel";
            cFNAMELabel.Size = new System.Drawing.Size(54, 13);
            cFNAMELabel.TabIndex = 3;
            cFNAMELabel.Text = "CFNAME:";
            // 
            // cFNAMETextBox
            // 
            this.cFNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CFNAME", true));
            this.cFNAMETextBox.Location = new System.Drawing.Point(281, 41);
            this.cFNAMETextBox.Name = "cFNAMETextBox";
            this.cFNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.cFNAMETextBox.TabIndex = 4;
            // 
            // cLNAMELabel
            // 
            cLNAMELabel.AutoSize = true;
            cLNAMELabel.Location = new System.Drawing.Point(424, 47);
            cLNAMELabel.Name = "cLNAMELabel";
            cLNAMELabel.Size = new System.Drawing.Size(54, 13);
            cLNAMELabel.TabIndex = 5;
            cLNAMELabel.Text = "CLNAME:";
            // 
            // cLNAMETextBox
            // 
            this.cLNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CLNAME", true));
            this.cLNAMETextBox.Location = new System.Drawing.Point(484, 44);
            this.cLNAMETextBox.Name = "cLNAMETextBox";
            this.cLNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.cLNAMETextBox.TabIndex = 6;
            // 
            // cADDRLabel
            // 
            cADDRLabel.AutoSize = true;
            cADDRLabel.Location = new System.Drawing.Point(604, 47);
            cADDRLabel.Name = "cADDRLabel";
            cADDRLabel.Size = new System.Drawing.Size(48, 13);
            cADDRLabel.TabIndex = 7;
            cADDRLabel.Text = "CADDR:";
            // 
            // cADDRTextBox
            // 
            this.cADDRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CADDR", true));
            this.cADDRTextBox.Location = new System.Drawing.Point(658, 44);
            this.cADDRTextBox.Name = "cADDRTextBox";
            this.cADDRTextBox.Size = new System.Drawing.Size(100, 20);
            this.cADDRTextBox.TabIndex = 8;
            // 
            // cCITYLabel
            // 
            cCITYLabel.AutoSize = true;
            cCITYLabel.Location = new System.Drawing.Point(44, 72);
            cCITYLabel.Name = "cCITYLabel";
            cCITYLabel.Size = new System.Drawing.Size(41, 13);
            cCITYLabel.TabIndex = 9;
            cCITYLabel.Text = "CCITY:";
            // 
            // cCITYTextBox
            // 
            this.cCITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CCITY", true));
            this.cCITYTextBox.Location = new System.Drawing.Point(91, 69);
            this.cCITYTextBox.Name = "cCITYTextBox";
            this.cCITYTextBox.Size = new System.Drawing.Size(100, 20);
            this.cCITYTextBox.TabIndex = 10;
            // 
            // cSTATELabel
            // 
            cSTATELabel.AutoSize = true;
            cSTATELabel.Location = new System.Drawing.Point(223, 72);
            cSTATELabel.Name = "cSTATELabel";
            cSTATELabel.Size = new System.Drawing.Size(52, 13);
            cSTATELabel.TabIndex = 11;
            cSTATELabel.Text = "CSTATE:";
            // 
            // cSTATETextBox
            // 
            this.cSTATETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CSTATE", true));
            this.cSTATETextBox.Location = new System.Drawing.Point(281, 69);
            this.cSTATETextBox.Name = "cSTATETextBox";
            this.cSTATETextBox.Size = new System.Drawing.Size(100, 20);
            this.cSTATETextBox.TabIndex = 12;
            // 
            // cZIPLabel
            // 
            cZIPLabel.AutoSize = true;
            cZIPLabel.Location = new System.Drawing.Point(444, 75);
            cZIPLabel.Name = "cZIPLabel";
            cZIPLabel.Size = new System.Drawing.Size(34, 13);
            cZIPLabel.TabIndex = 13;
            cZIPLabel.Text = "CZIP:";
            // 
            // cZIPTextBox
            // 
            this.cZIPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CZIP", true));
            this.cZIPTextBox.Location = new System.Drawing.Point(484, 72);
            this.cZIPTextBox.Name = "cZIPTextBox";
            this.cZIPTextBox.Size = new System.Drawing.Size(100, 20);
            this.cZIPTextBox.TabIndex = 14;
            // 
            // cPHONELabel
            // 
            cPHONELabel.AutoSize = true;
            cPHONELabel.Location = new System.Drawing.Point(597, 75);
            cPHONELabel.Name = "cPHONELabel";
            cPHONELabel.Size = new System.Drawing.Size(55, 13);
            cPHONELabel.TabIndex = 15;
            cPHONELabel.Text = "CPHONE:";
            // 
            // cPHONETextBox
            // 
            this.cPHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CPHONE", true));
            this.cPHONETextBox.Location = new System.Drawing.Point(658, 72);
            this.cPHONETextBox.Name = "cPHONETextBox";
            this.cPHONETextBox.Size = new System.Drawing.Size(100, 20);
            this.cPHONETextBox.TabIndex = 16;
            // 
            // cEMAILLabel
            // 
            cEMAILLabel.AutoSize = true;
            cEMAILLabel.Location = new System.Drawing.Point(36, 105);
            cEMAILLabel.Name = "cEMAILLabel";
            cEMAILLabel.Size = new System.Drawing.Size(49, 13);
            cEMAILLabel.TabIndex = 17;
            cEMAILLabel.Text = "CEMAIL:";
            // 
            // cEMAILTextBox
            // 
            this.cEMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CEMAIL", true));
            this.cEMAILTextBox.Location = new System.Drawing.Point(91, 102);
            this.cEMAILTextBox.Name = "cEMAILTextBox";
            this.cEMAILTextBox.Size = new System.Drawing.Size(100, 20);
            this.cEMAILTextBox.TabIndex = 18;
            // 
            // cDOBLabel
            // 
            cDOBLabel.AutoSize = true;
            cDOBLabel.Location = new System.Drawing.Point(235, 105);
            cDOBLabel.Name = "cDOBLabel";
            cDOBLabel.Size = new System.Drawing.Size(40, 13);
            cDOBLabel.TabIndex = 19;
            cDOBLabel.Text = "CDOB:";
            // 
            // cDOBTextBox
            // 
            this.cDOBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CDOB", true));
            this.cDOBTextBox.Location = new System.Drawing.Point(281, 102);
            this.cDOBTextBox.Name = "cDOBTextBox";
            this.cDOBTextBox.Size = new System.Drawing.Size(100, 20);
            this.cDOBTextBox.TabIndex = 20;
            // 
            // cGENDERLabel
            // 
            cGENDERLabel.AutoSize = true;
            cGENDERLabel.Location = new System.Drawing.Point(414, 108);
            cGENDERLabel.Name = "cGENDERLabel";
            cGENDERLabel.Size = new System.Drawing.Size(63, 13);
            cGENDERLabel.TabIndex = 21;
            cGENDERLabel.Text = "CGENDER:";
            // 
            // cGENDERTextBox
            // 
            this.cGENDERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CGENDER", true));
            this.cGENDERTextBox.Location = new System.Drawing.Point(483, 105);
            this.cGENDERTextBox.Name = "cGENDERTextBox";
            this.cGENDERTextBox.Size = new System.Drawing.Size(100, 20);
            this.cGENDERTextBox.TabIndex = 22;
            // 
            // cPWORDLabel
            // 
            cPWORDLabel.AutoSize = true;
            cPWORDLabel.Location = new System.Drawing.Point(593, 108);
            cPWORDLabel.Name = "cPWORDLabel";
            cPWORDLabel.Size = new System.Drawing.Size(59, 13);
            cPWORDLabel.TabIndex = 23;
            cPWORDLabel.Text = "CPWORD:";
            // 
            // cPWORDTextBox
            // 
            this.cPWORDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CPWORD", true));
            this.cPWORDTextBox.Location = new System.Drawing.Point(658, 105);
            this.cPWORDTextBox.Name = "cPWORDTextBox";
            this.cPWORDTextBox.Size = new System.Drawing.Size(100, 20);
            this.cPWORDTextBox.TabIndex = 24;
            // 
            // cSCCARDNOLabel
            // 
            cSCCARDNOLabel.AutoSize = true;
            cSCCARDNOLabel.Location = new System.Drawing.Point(8, 134);
            cSCCARDNOLabel.Name = "cSCCARDNOLabel";
            cSCCARDNOLabel.Size = new System.Drawing.Size(77, 13);
            cSCCARDNOLabel.TabIndex = 25;
            cSCCARDNOLabel.Text = "CSCCARDNO:";
            // 
            // cSCCARDNOTextBox
            // 
            this.cSCCARDNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CSCCARDNO", true));
            this.cSCCARDNOTextBox.Location = new System.Drawing.Point(91, 131);
            this.cSCCARDNOTextBox.Name = "cSCCARDNOTextBox";
            this.cSCCARDNOTextBox.Size = new System.Drawing.Size(100, 20);
            this.cSCCARDNOTextBox.TabIndex = 26;
            // 
            // cSPYMTSTLLabel
            // 
            cSPYMTSTLLabel.AutoSize = true;
            cSPYMTSTLLabel.Location = new System.Drawing.Point(201, 134);
            cSPYMTSTLLabel.Name = "cSPYMTSTLLabel";
            cSPYMTSTLLabel.Size = new System.Drawing.Size(74, 13);
            cSPYMTSTLLabel.TabIndex = 27;
            cSPYMTSTLLabel.Text = "CSPYMTSTL:";
            // 
            // cSPYMTSTLTextBox
            // 
            this.cSPYMTSTLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CSPYMTSTL", true));
            this.cSPYMTSTLTextBox.Location = new System.Drawing.Point(281, 131);
            this.cSPYMTSTLTextBox.Name = "cSPYMTSTLTextBox";
            this.cSPYMTSTLTextBox.Size = new System.Drawing.Size(100, 20);
            this.cSPYMTSTLTextBox.TabIndex = 28;
            // 
            // cPWORDHASHLabel
            // 
            cPWORDHASHLabel.AutoSize = true;
            cPWORDHASHLabel.Location = new System.Drawing.Point(389, 134);
            cPWORDHASHLabel.Name = "cPWORDHASHLabel";
            cPWORDHASHLabel.Size = new System.Drawing.Size(89, 13);
            cPWORDHASHLabel.TabIndex = 29;
            cPWORDHASHLabel.Text = "CPWORDHASH:";
            // 
            // cPWORDHASHTextBox
            // 
            this.cPWORDHASHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource, "CPWORDHASH", true));
            this.cPWORDHASHTextBox.Location = new System.Drawing.Point(484, 131);
            this.cPWORDHASHTextBox.Name = "cPWORDHASHTextBox";
            this.cPWORDHASHTextBox.Size = new System.Drawing.Size(100, 20);
            this.cPWORDHASHTextBox.TabIndex = 30;
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.Location = new System.Drawing.Point(12, 181);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(640, 264);
            this.displayListBox.TabIndex = 31;
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(659, 181);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(83, 55);
            this.displayBtn.TabIndex = 32;
            this.displayBtn.Text = "Display IBM Database";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(cPWORDHASHLabel);
            this.Controls.Add(this.cPWORDHASHTextBox);
            this.Controls.Add(cSPYMTSTLLabel);
            this.Controls.Add(this.cSPYMTSTLTextBox);
            this.Controls.Add(cSCCARDNOLabel);
            this.Controls.Add(this.cSCCARDNOTextBox);
            this.Controls.Add(cPWORDLabel);
            this.Controls.Add(this.cPWORDTextBox);
            this.Controls.Add(cGENDERLabel);
            this.Controls.Add(this.cGENDERTextBox);
            this.Controls.Add(cDOBLabel);
            this.Controls.Add(this.cDOBTextBox);
            this.Controls.Add(cEMAILLabel);
            this.Controls.Add(this.cEMAILTextBox);
            this.Controls.Add(cPHONELabel);
            this.Controls.Add(this.cPHONETextBox);
            this.Controls.Add(cZIPLabel);
            this.Controls.Add(this.cZIPTextBox);
            this.Controls.Add(cSTATELabel);
            this.Controls.Add(this.cSTATETextBox);
            this.Controls.Add(cCITYLabel);
            this.Controls.Add(this.cCITYTextBox);
            this.Controls.Add(cADDRLabel);
            this.Controls.Add(this.cADDRTextBox);
            this.Controls.Add(cLNAMELabel);
            this.Controls.Add(this.cLNAMETextBox);
            this.Controls.Add(cFNAMELabel);
            this.Controls.Add(this.cFNAMETextBox);
            this.Controls.Add(cUSTNOLabel);
            this.Controls.Add(this.cUSTNOTextBox);
            this.Controls.Add(this.cUSTOMERBindingNavigator);
            this.Name = "Form2";
            this.Text = "IBM";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingNavigator)).EndInit();
            this.cUSTOMERBindingNavigator.ResumeLayout(false);
            this.cUSTOMERBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private DataSet1TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cUSTOMERBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cUSTOMERBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cUSTNOTextBox;
        private System.Windows.Forms.TextBox cFNAMETextBox;
        private System.Windows.Forms.TextBox cLNAMETextBox;
        private System.Windows.Forms.TextBox cADDRTextBox;
        private System.Windows.Forms.TextBox cCITYTextBox;
        private System.Windows.Forms.TextBox cSTATETextBox;
        private System.Windows.Forms.TextBox cZIPTextBox;
        private System.Windows.Forms.TextBox cPHONETextBox;
        private System.Windows.Forms.TextBox cEMAILTextBox;
        private System.Windows.Forms.TextBox cDOBTextBox;
        private System.Windows.Forms.TextBox cGENDERTextBox;
        private System.Windows.Forms.TextBox cPWORDTextBox;
        private System.Windows.Forms.TextBox cSCCARDNOTextBox;
        private System.Windows.Forms.TextBox cSPYMTSTLTextBox;
        private System.Windows.Forms.TextBox cPWORDHASHTextBox;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.Button displayBtn;
    }
>>>>>>> 96a3aa0a3015466f44ff57df8dc372d154c4fbfc
}