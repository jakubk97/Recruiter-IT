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
        }

        #region Events
        public event Action StartForm3;
        public event Action StartForm5;

        public event Action<string> UPLoadForm4;
        #endregion

        private string[] LanguagesLoad()
        {
            List<string> lista = new List<string> { "angielski", "niemiecki", "włoski", "hiszpański", "chiński" };
            return lista.ToArray();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (StartForm5 != null)
                StartForm5();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (StartForm3 != null)
                StartForm3();
        }
    }
}
