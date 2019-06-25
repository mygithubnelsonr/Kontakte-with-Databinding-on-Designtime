using System;
using System.Windows.Forms;

namespace KontakteApp
{
    public partial class FormGrid : Form
    {
        public FormGrid()
        {
            InitializeComponent();
        }

        private void FormGrid_Load(object sender, EventArgs e)
        {
            this.personenTableAdapter.Fill(this.kontakteDBDataSet.Personen);
        }

        private void personenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kontakteDBDataSet);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
