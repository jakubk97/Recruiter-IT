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
        }
        #region Events
        public event Action StartForm2;
        public event Action StartForm4;

        //public event Action<Forma> StartForm2Load;

        public event Action<string, string, string, string, string, string, string, string> UPLoadForm3;
        #endregion

        private string[] TS()
        {
            List<string> lista = new List<string> { "stacjonarne", "niestacjonarne", "eksternistyczne", "insywidualne","kursy" };
            return lista.ToArray();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (StartForm4 != null)
                StartForm4();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (StartForm2 != null)
                StartForm2();
        }
    }
}
