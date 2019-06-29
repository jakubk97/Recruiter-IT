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
    public partial class Screen1 : UserControl
    {
        public Screen1()
        {
            InitializeComponent();
        }

        #region Events
        public event Action StartForm2;

        #endregion

        private void Start_Click(object sender, EventArgs e)
        {
            if (StartForm2 != null)
                StartForm2();
        }
    }
}
