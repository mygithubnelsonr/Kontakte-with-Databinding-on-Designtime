namespace KontakteApp
{
    partial class FormKontakte
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label vornameLabel;
            System.Windows.Forms.Label nachnameLabel;
            System.Windows.Forms.Label firmaLabel;
            System.Windows.Forms.Label kundeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label kontakt_IDLabel;
            System.Windows.Forms.Label anrufLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKontakte));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kontakteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.personenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kontakteDBDataSet = new KontakteApp.KontakteDBDataSet();
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
            this.personenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.nachnameTextBox = new System.Windows.Forms.TextBox();
            this.firmaTextBox = new System.Windows.Forms.TextBox();
            this.kundeCheckBox = new System.Windows.Forms.CheckBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.personenTableAdapter = new KontakteApp.KontakteDBDataSetTableAdapters.PersonenTableAdapter();
            this.tableAdapterManager = new KontakteApp.KontakteDBDataSetTableAdapters.TableAdapterManager();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.kontakt_IDTextBox = new System.Windows.Forms.TextBox();
            this.anrufDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGridFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            vornameLabel = new System.Windows.Forms.Label();
            nachnameLabel = new System.Windows.Forms.Label();
            firmaLabel = new System.Windows.Forms.Label();
            kundeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            kontakt_IDLabel = new System.Windows.Forms.Label();
            anrufLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontakteBindingNavigator)).BeginInit();
            this.kontakteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontakteDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vornameLabel
            // 
            vornameLabel.AutoSize = true;
            vornameLabel.Location = new System.Drawing.Point(22, 79);
            vornameLabel.Name = "vornameLabel";
            vornameLabel.Size = new System.Drawing.Size(52, 13);
            vornameLabel.TabIndex = 2;
            vornameLabel.Text = "Vorname:";
            // 
            // nachnameLabel
            // 
            nachnameLabel.AutoSize = true;
            nachnameLabel.Location = new System.Drawing.Point(12, 119);
            nachnameLabel.Name = "nachnameLabel";
            nachnameLabel.Size = new System.Drawing.Size(62, 13);
            nachnameLabel.TabIndex = 4;
            nachnameLabel.Text = "Nachname:";
            // 
            // firmaLabel
            // 
            firmaLabel.AutoSize = true;
            firmaLabel.Location = new System.Drawing.Point(39, 159);
            firmaLabel.Name = "firmaLabel";
            firmaLabel.Size = new System.Drawing.Size(35, 13);
            firmaLabel.TabIndex = 6;
            firmaLabel.Text = "Firma:";
            // 
            // kundeLabel
            // 
            kundeLabel.AutoSize = true;
            kundeLabel.Location = new System.Drawing.Point(33, 282);
            kundeLabel.Name = "kundeLabel";
            kundeLabel.Size = new System.Drawing.Size(41, 13);
            kundeLabel.TabIndex = 8;
            kundeLabel.Text = "Kunde:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(39, 239);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(33, 199);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 15;
            telefonLabel.Text = "Telefon:";
            // 
            // kontakt_IDLabel
            // 
            kontakt_IDLabel.AutoSize = true;
            kontakt_IDLabel.Location = new System.Drawing.Point(13, 39);
            kontakt_IDLabel.Name = "kontakt_IDLabel";
            kontakt_IDLabel.Size = new System.Drawing.Size(61, 13);
            kontakt_IDLabel.TabIndex = 17;
            kontakt_IDLabel.Text = "Kontakt ID:";
            // 
            // anrufLabel
            // 
            anrufLabel.AutoSize = true;
            anrufLabel.Location = new System.Drawing.Point(137, 281);
            anrufLabel.Name = "anrufLabel";
            anrufLabel.Size = new System.Drawing.Size(35, 13);
            anrufLabel.TabIndex = 18;
            anrufLabel.Text = "Anruf:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(272, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kontakteBindingNavigator
            // 
            this.kontakteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kontakteBindingNavigator.BindingSource = this.personenBindingSource;
            this.kontakteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kontakteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kontakteBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kontakteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.personenBindingNavigatorSaveItem});
            this.kontakteBindingNavigator.Location = new System.Drawing.Point(0, 320);
            this.kontakteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kontakteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kontakteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kontakteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kontakteBindingNavigator.Name = "kontakteBindingNavigator";
            this.kontakteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kontakteBindingNavigator.Size = new System.Drawing.Size(522, 25);
            this.kontakteBindingNavigator.TabIndex = 1;
            this.kontakteBindingNavigator.Text = "bindingNavigator1";
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
            // personenBindingSource
            // 
            this.personenBindingSource.DataMember = "Personen";
            this.personenBindingSource.DataSource = this.kontakteDBDataSet;
            // 
            // kontakteDBDataSet
            // 
            this.kontakteDBDataSet.DataSetName = "KontakteDBDataSet";
            this.kontakteDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // personenBindingNavigatorSaveItem
            // 
            this.personenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personenBindingNavigatorSaveItem.Image")));
            this.personenBindingNavigatorSaveItem.Name = "personenBindingNavigatorSaveItem";
            this.personenBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personenBindingNavigatorSaveItem.Text = "Save Data";
            this.personenBindingNavigatorSaveItem.Click += new System.EventHandler(this.personenBindingNavigatorSaveItem_Click_1);
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Vorname", true));
            this.vornameTextBox.Location = new System.Drawing.Point(89, 76);
            this.vornameTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.Size = new System.Drawing.Size(140, 20);
            this.vornameTextBox.TabIndex = 3;
            // 
            // nachnameTextBox
            // 
            this.nachnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Nachname", true));
            this.nachnameTextBox.Location = new System.Drawing.Point(89, 116);
            this.nachnameTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.nachnameTextBox.Name = "nachnameTextBox";
            this.nachnameTextBox.Size = new System.Drawing.Size(140, 20);
            this.nachnameTextBox.TabIndex = 5;
            // 
            // firmaTextBox
            // 
            this.firmaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Firma", true));
            this.firmaTextBox.Location = new System.Drawing.Point(89, 156);
            this.firmaTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.firmaTextBox.Name = "firmaTextBox";
            this.firmaTextBox.Size = new System.Drawing.Size(140, 20);
            this.firmaTextBox.TabIndex = 7;
            // 
            // kundeCheckBox
            // 
            this.kundeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personenBindingSource, "Kunde", true));
            this.kundeCheckBox.Location = new System.Drawing.Point(89, 276);
            this.kundeCheckBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.kundeCheckBox.Name = "kundeCheckBox";
            this.kundeCheckBox.Size = new System.Drawing.Size(24, 24);
            this.kundeCheckBox.TabIndex = 9;
            this.kundeCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(89, 236);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(299, 20);
            this.emailTextBox.TabIndex = 11;
            // 
            // personenTableAdapter
            // 
            this.personenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonenTableAdapter = this.personenTableAdapter;
            this.tableAdapterManager.UpdateOrder = KontakteApp.KontakteDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(89, 196);
            this.telefonTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(140, 20);
            this.telefonTextBox.TabIndex = 16;
            // 
            // kontakt_IDTextBox
            // 
            this.kontakt_IDTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.kontakt_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personenBindingSource, "Kontakt_ID", true));
            this.kontakt_IDTextBox.Enabled = false;
            this.kontakt_IDTextBox.Location = new System.Drawing.Point(89, 36);
            this.kontakt_IDTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.kontakt_IDTextBox.Name = "kontakt_IDTextBox";
            this.kontakt_IDTextBox.Size = new System.Drawing.Size(65, 20);
            this.kontakt_IDTextBox.TabIndex = 18;
            // 
            // anrufDateTimePicker
            // 
            this.anrufDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personenBindingSource, "Anruf", true));
            this.anrufDateTimePicker.Location = new System.Drawing.Point(188, 276);
            this.anrufDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.anrufDateTimePicker.Name = "anrufDateTimePicker";
            this.anrufDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.anrufDateTimePicker.TabIndex = 19;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(263, 156);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(28, 20);
            this.buttonPrevious.TabIndex = 21;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(313, 156);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(28, 20);
            this.buttonNext.TabIndex = 22;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.showGridFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // showGridFormToolStripMenuItem
            // 
            this.showGridFormToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.showGridFormToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.showGridFormToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.showGridFormToolStripMenuItem.Name = "showGridFormToolStripMenuItem";
            this.showGridFormToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.showGridFormToolStripMenuItem.Text = "Show Grid Form";
            this.showGridFormToolStripMenuItem.Click += new System.EventHandler(this.showGridFormToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 345);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(anrufLabel);
            this.Controls.Add(this.anrufDateTimePicker);
            this.Controls.Add(this.kontakt_IDTextBox);
            this.Controls.Add(kontakt_IDLabel);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(kundeLabel);
            this.Controls.Add(this.kundeCheckBox);
            this.Controls.Add(firmaLabel);
            this.Controls.Add(this.firmaTextBox);
            this.Controls.Add(nachnameLabel);
            this.Controls.Add(this.nachnameTextBox);
            this.Controls.Add(vornameLabel);
            this.Controls.Add(this.vornameTextBox);
            this.Controls.Add(this.kontakteBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(538, 384);
            this.MinimumSize = new System.Drawing.Size(538, 384);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papierfabrik Objekthausen - Kontakte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKontakte_FormClosing);
            this.Load += new System.EventHandler(this.FormKontakte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontakteBindingNavigator)).EndInit();
            this.kontakteBindingNavigator.ResumeLayout(false);
            this.kontakteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontakteDBDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private KontakteApp.KontakteDBDataSet kontakteDBDataSet;
        private System.Windows.Forms.BindingSource personenBindingSource;
        private KontakteApp.KontakteDBDataSetTableAdapters.PersonenTableAdapter personenTableAdapter;
        private KontakteApp.KontakteDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kontakteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton personenBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vornameTextBox;
        private System.Windows.Forms.TextBox nachnameTextBox;
        private System.Windows.Forms.TextBox firmaTextBox;
        private System.Windows.Forms.CheckBox kundeCheckBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox kontakt_IDTextBox;
        private System.Windows.Forms.DateTimePicker anrufDateTimePicker;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGridFormToolStripMenuItem;
    }
}

