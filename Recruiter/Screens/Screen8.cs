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
    public partial class Screen8 : UserControl
    {
        public Screen8()
        {
            InitializeComponent();
        }
        #region Events
        public event Action StartForm7;
        public event Action StartForm9;
        public event Action<string, string> UPLoadForm8;
        #endregion
        private void End_Click(object sender, EventArgs e)
        {
            if (StartForm9 != null)
                StartForm9();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (StartForm7 != null)
                StartForm7();
        }
    }
}
