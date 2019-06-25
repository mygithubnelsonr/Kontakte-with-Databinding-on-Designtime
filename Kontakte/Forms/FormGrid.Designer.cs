namespace KontakteApp
{
    partial class FormGrid
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
            System.Windows.Forms.Label kontakt_IDLabel;
            System.Windows.Forms.Label vornameLabel;
            System.Windows.Forms.Label nachnameLabel;
            System.Windows.Forms.Label firmaLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label kundeLabel;
            System.Windows.Forms.Label anrufLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrid));
            this.kontakteDBDataSet = new KontakteApp.KontakteDBDataSet();
            this.tableAdapterManager = new KontakteApp.KontakteDBDataSetTableAdapters.TableAdapterManager();
            this.personenTableAdapter = new KontakteApp.KontakteDBDataSetTableAdapters.PersonenTableAdapter();
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
            this.personen2BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.personenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.personenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.personenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontakt_IDTextBox = new System.Windows.Forms.TextBox();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.nachnameTextBox = new System.Windows.Forms.TextBox();
            this.firmaTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.kundeCheckBox = new System.Windows.Forms.CheckBox();
            this.anrufDateTimePicker = new System.Windows.Forms.DateTimePicker();
            kontakt_IDLabel = new System.Windows.Forms.Label();
            vornameLabel = new System.Windows.Forms.Label();
            nachnameLabel = new System.Windows.Forms.Label();
            firmaLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            kundeLabel = new System.Windows.Forms.Label();
            anrufLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kontakteDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personenBindingNavigator)).BeginInit();
            this.personenBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personenDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kontakt_IDLabel
            // 
            kontakt_IDLabel.AutoSize = true;
            kontakt_IDLabel.Location = new System.Drawing.Point(26, 54);
            kontakt_IDLabel.Name = "kontakt_IDLabel";
            kontakt_IDLabel.Size = new System.Drawing.Size(61, 13);
            kontakt_IDLabel.TabIndex = 3;
            kontakt_IDLabel.Text = "Kontakt ID:";
            // 
            // vornameLabel
            // 
            vornameLabel.AutoSize = true;
            vornameLabel.Location = new System.Drawing.Point(26, 80);
            vornameLabel.Name = "vornameLabel";
            vornameLabel.Size = new System.Drawing.Size(52, 13);
            vornameLabel.TabIndex = 5;
            vornameLabel.Text = "Vorname:";
            // 
            // nachnameLabel
            // 
            nachnameLabel.AutoSize = true;
            nachnameLabel.Location = new System.Drawing.Point(26, 106);
            nachnameLabel.Name = "nachnameLabel";
            nachnameLabel.Size = new System.Drawing.Size(62, 13);
            nachnameLabel.TabIndex = 7;
            nachnameLabel.Text = "Nachname:";
            // 
            // firmaLabel
            // 
            firmaLabel.AutoSize = true;
            firmaLabel.Location = new System.Drawing.Point(26, 132);
            firmaLabel.Name = "firmaLabel";
            firmaLabel.Size = new System.Drawing.Size(35, 13);
            firmaLabel.TabIndex = 9;
            firmaLabel.Text = "Firma:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(26, 158);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 11;
            telefonLabel.Text = "Telefon:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(26, 184);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // kundeLabel
            // 
            kundeLabel.AutoSize = true;
            kundeLabel.Location = new System.Drawing.Point(26, 212);
            kundeLabel.Name = "kundeLabel";
            kundeLabel.Size = new System.Drawing.Size(41, 13);
            kundeLabel.TabIndex = 15;
            kundeLabel.Text = "Kunde:";
            // 
            // anrufLabel
            // 
            anrufLabel.AutoSize = true;
            anrufLabel.Location = new System.Drawing.Point(26, 241);
            anrufLabel.Name = "anrufLabel";
            anrufLabel.Size = new System.Drawing.Size(35, 13);
            anrufLabel.TabIndex = 17;
            anrufLabel.Text = "Anruf:";
            // 
            // kontakteDBDataSet
            // 
            this.kontakteDBDataSet.DataSetName = "KontakteDBDataSet";
            this.kontakteDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PersonenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KontakteApp.KontakteDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personenTableAdapter
            // 
            this.personenTableAdapter.ClearBeforeFill = true;
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
            // personen2BindingNavigatorSaveItem
            // 
            this.personen2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personen2BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personen2BindingNavigatorSaveItem.Image")));
            this.personen2BindingNavigatorSaveItem.Name = "personen2BindingNavigatorSaveItem";
            this.personen2BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personen2BindingNavigatorSaveItem.Text = "Save Data";
            this.personen2BindingNavigatorSaveItem.Click += new System.EventHandler(this.personenBindingNavigatorSaveItem_Click);
            // 
            // personenBindingNavigator
            // 
            this.personenBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personenBindingNavigator.BindingSource = this.personenBindingSource;
            this.personenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personenBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personenBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.personenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.personen2BindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.personenBindingNavigator.Location = new System.Drawing.Point(0, 360);
            this.personenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personenBindingNavigator.Name = "personenBindingNavigator";
            this.personenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personenBindingNavigator.Size = new System.Drawing.Size(914, 25);
            this.personenBindingNavigator.TabIndex = 0;
            this.personenBindingNavigator.Text = "bindingNavigator1";
            // 
            // personenBindingSource
            // 
            this.personenBindingSource.DataMember = "Personen";
            this.personenBindingSource.DataSource = this.kontakteDBDataSet;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // personenDataGridView
            // 
            this.personenDataGridView.AutoGenerateColumns = false;
            this.personenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn8});
            this.personenDataGridView.DataSource = this.personenBindingSource;
            this.personenDataGridView.Location = new System.Drawing.Point(315, 27);
            this.personenDataGridView.Name = "personenDataGridView";
            this.personenDataGridView.Size = new System.Drawing.Size(588, 313);
            this.personenDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Kontakt_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kontakt_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Vorname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vorname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nachname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nachname";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Firma";
            this.dataGridViewTextBoxColumn5.HeaderText = "Firma";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn7.HeaderText = "Email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Kunde";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Kunde";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Anruf";
            this.dataGridViewTextBoxColumn8.HeaderText = "Anruf";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AutoSize = false;
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // kontakt_IDTextBox
            // 
            this.kontakt_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Kontakt_ID", true));
            this.kontakt_IDTextBox.Location = new System.Drawing.Point(94, 51);
            this.kontakt_IDTextBox.Name = "kontakt_IDTextBox";
            this.kontakt_IDTextBox.Size = new System.Drawing.Size(78, 20);
            this.kontakt_IDTextBox.TabIndex = 4;
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Vorname", true));
            this.vornameTextBox.Location = new System.Drawing.Point(94, 77);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.Size = new System.Drawing.Size(200, 20);
            this.vornameTextBox.TabIndex = 6;
            // 
            // nachnameTextBox
            // 
            this.nachnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Nachname", true));
            this.nachnameTextBox.Location = new System.Drawing.Point(94, 103);
            this.nachnameTextBox.Name = "nachnameTextBox";
            this.nachnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nachnameTextBox.TabIndex = 8;
            // 
            // firmaTextBox
            // 
            this.firmaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Firma", true));
            this.firmaTextBox.Location = new System.Drawing.Point(94, 129);
            this.firmaTextBox.Name = "firmaTextBox";
            this.firmaTextBox.Size = new System.Drawing.Size(200, 20);
            this.firmaTextBox.TabIndex = 10;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(94, 155);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(94, 181);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 14;
            // 
            // kundeCheckBox
            // 
            this.kundeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personenBindingSource, "Kunde", true));
            this.kundeCheckBox.Location = new System.Drawing.Point(94, 207);
            this.kundeCheckBox.Name = "kundeCheckBox";
            this.kundeCheckBox.Size = new System.Drawing.Size(200, 24);
            this.kundeCheckBox.TabIndex = 16;
            this.kundeCheckBox.Text = "checkBox1";
            this.kundeCheckBox.UseVisualStyleBackColor = true;
            // 
            // anrufDateTimePicker
            // 
            this.anrufDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personenBindingSource, "Anruf", true));
            this.anrufDateTimePicker.Location = new System.Drawing.Point(94, 237);
            this.anrufDateTimePicker.Name = "anrufDateTimePicker";
            this.anrufDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.anrufDateTimePicker.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 385);
            this.Controls.Add(kontakt_IDLabel);
            this.Controls.Add(this.kontakt_IDTextBox);
            this.Controls.Add(vornameLabel);
            this.Controls.Add(this.vornameTextBox);
            this.Controls.Add(nachnameLabel);
            this.Controls.Add(this.nachnameTextBox);
            this.Controls.Add(firmaLabel);
            this.Controls.Add(this.firmaTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(kundeLabel);
            this.Controls.Add(this.kundeCheckBox);
            this.Controls.Add(anrufLabel);
            this.Controls.Add(this.anrufDateTimePicker);
            this.Controls.Add(this.personenDataGridView);
            this.Controls.Add(this.personenBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(930, 424);
            this.MinimumSize = new System.Drawing.Size(930, 424);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papierfabrik Objekthausen - Kontakte";
            this.Load += new System.EventHandler(this.FormGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kontakteDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personenBindingNavigator)).EndInit();
            this.personenBindingNavigator.ResumeLayout(false);
            this.personenBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personenDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KontakteDBDataSet kontakteDBDataSet;
        private KontakteDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton personen2BindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator personenBindingNavigator;
        private System.Windows.Forms.DataGridView personenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.BindingSource personenBindingSource;
        private KontakteDBDataSetTableAdapters.PersonenTableAdapter personenTableAdapter;
        private System.Windows.Forms.TextBox kontakt_IDTextBox;
        private System.Windows.Forms.TextBox vornameTextBox;
        private System.Windows.Forms.TextBox nachnameTextBox;
        private System.Windows.Forms.TextBox firmaTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox kundeCheckBox;
        private System.Windows.Forms.DateTimePicker anrufDateTimePicker;
    }
}