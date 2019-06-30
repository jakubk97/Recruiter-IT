using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recruiter
{
    public partial class Screen3 : UserControl
    {
        public Screen3()
        {
            InitializeComponent();

            Mode.DataSource = TS();
            WorkTitle.DataSource = WT();
            Mode.Text = "";
            WorkTitle.Text = "";
        }
        #region Events
        public event Action StartForm2;
        public event Action StartForm4;

        public event Action<Screen3> WczytajUczelnie;
        public event Action<Screen3> WczytajKierunki;

        public event Action<string, string, string, string> UPLoadForm3;
        #endregion

        private string[] TS()
        {
            List<string> lista = new List<string> { "stacjonarne", "niestacjonarne", "eksternistyczne", "insywidualne", "kursy" };
            return lista.ToArray();
        }

        private string[] WT()
        {
            List<string> lista = new List<string> { "licencjat", "inżynier", "magister", "doktor", "profesor", "brak" };
            return lista.ToArray();
        }

        public string[] CollageN
        {
            set
            {
                CollageName.Items.Clear();
                foreach (var d in value)
                    CollageName.Items.Add(d);
            }
        }

        public string[] CollageK
        {
            set
            {
                CollageKier.Items.Clear();
                foreach (var d in value)
                    CollageKier.Items.Add(d);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (CollageName.SelectedIndex != -1 && CollageKier.SelectedIndex != -1 &&
                    Mode.SelectedIndex != -1 && WorkTitle.SelectedIndex != -1)
            {
                errorProvider1.Clear();
                if (UPLoadForm3 != null)
                    UPLoadForm3(CollageName.SelectedItem.ToString(), CollageKier.SelectedItem.ToString(),
                        Mode.SelectedItem.ToString(), WorkTitle.SelectedItem.ToString());

                if (StartForm4 != null)
                    StartForm4();
            }
            else
            {
                errorProvider1.SetError(Next, "Należy zaznaczyć wszystkie pola!");
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (StartForm2 != null)
                StartForm2();
        }

        private void CollageName_DropDown(object sender, EventArgs e)
        {
            if (WczytajUczelnie != null)
                WczytajUczelnie(this);
        }

        private void CollageKier_DropDown(object sender, EventArgs e)
        {
            if (WczytajKierunki != null)
                WczytajKierunki(this);
        }
    }
}
