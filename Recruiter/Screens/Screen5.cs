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
    public partial class Screen5 : UserControl
    {
        public Screen5()
        {
            InitializeComponent();
        }
        #region Events
        public event Action StartForm6;
        public event Action StartForm4;

        public event Action<string, string, string, string> UPLoadForm5;
        #endregion
        private void Next_Click(object sender, EventArgs e)
        {
            if (StartForm6 != null)
                StartForm6();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (StartForm4 != null)
                StartForm4();
        }
    }
}
