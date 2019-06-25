using System;
using System.Windows.Forms;

namespace KontakteApp
{
    public partial class FormKontakte : Form
    {
        private string _conn = "";
        private string _caption = "";
        public FormKontakte()
        {
            InitializeComponent();
        }

        private void FormKontakte_Load(object sender, EventArgs e)
        {
            try
            {
                this.personenTableAdapter.Fill(this.kontakteDBDataSet.Personen);
            }
            catch
            {
                MessageBox.Show("Die Datenbank 'Kontakte' wurde nicht gefunden!\n" +
                    "Bitte die Datei 'KontakteApp.exe.config.deploy' anpassen.\n" +
                    "Das Programm wird jetzt beendet.");
                this.Close();
            }
        }

        private void FormKontakte_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.personenTableAdapter.Dispose();
        }

        private void personenBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.personenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kontakteDBDataSet);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            personenBindingSource.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            personenBindingSource.MoveNext();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showGridFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formGrid = new FormGrid();
            formGrid.ShowDialog();
        }
    }
}
