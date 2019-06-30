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
    public partial class Screen7 : UserControl
    {
        public Screen7()
        {
            InitializeComponent();
            comboBoxPosition.DataSource = Positions();
        }
        #region Events
        public event Action StartForm6;
        public event Action StartForm8;
        public event Action<string, string, string, string, string, string> UPLoadForm7;
        #endregion

        private string[] Positions()
        {
            List<string> lista = new List<string> { "staż", "praktyki", "praca" };
            return lista.ToArray();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (StartForm8 != null)
                StartForm8();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (StartForm6 != null)
                StartForm6();
        }
    }
}
