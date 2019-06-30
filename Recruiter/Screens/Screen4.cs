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
    public partial class Screen4 : UserControl
    {
        public Screen4()
        {
            InitializeComponent();
        }

        #region Events
        public event Action StartForm3;
        public event Action StartForm5;

        public event Action<string> UPLoadForm4;
        #endregion

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
