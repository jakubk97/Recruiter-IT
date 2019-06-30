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
    public partial class Languages : UserControl
    {
        public Languages()
        {
            InitializeComponent();

            CBL_Language.DataSource = LanguagesLoad();
            CBL_Language.ClearSelected();
        }

        #region Events
        public event Action StartForm3;
        public event Action StartForm5;

        public event Action<string> UPLoadForm4;
        #endregion

        private string[] LanguagesLoad()
        {
            List<string> lista = new List<string> { "angielski", "niemiecki", "włoski", "hiszpański", "chiński","fiński","portugalski" };
            return lista.ToArray();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (CBL_Language.SelectedItems.Count != 0)
            {
                errorProvider1.Clear();
                if (UPLoadForm4 != null)
                {
                    string jezyk = "";
                    foreach (string li1 in CBL_Language.CheckedItems)
                    {
                        jezyk += " " + li1;
                    }

                    UPLoadForm4(jezyk);
                }
                if (StartForm5 != null)
                    StartForm5();
            }
            else
            {
                errorProvider1.SetError(Next, "Należy zaznaczyć przynajmniej jedno pole!");
            }



        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (StartForm3 != null)
                StartForm3();
        }
    }
}
