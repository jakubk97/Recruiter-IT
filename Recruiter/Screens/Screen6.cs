﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recruiter
{
    public partial class Screen6 : UserControl
    {
        public Screen6()
        {
            InitializeComponent();
        }
        #region Events
        public event Action StartForm5;
        public event Action StartForm7;

        public event Action<Screen6> WczytajTechnologie;

        public event Action<string,string> UPLoadForm6;
        #endregion
        public string[] Technologies
        {
            set
            {
                comboBox1.Items.Clear();
                foreach (var d in value)
                    comboBox1.Items.Add(d);
            }
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItems.Count != 0)
            {
                errorProvider1.Clear();
                if (UPLoadForm6 != null)
                {
                    string technologie = "";
                    foreach (string li1 in comboBox1.CheckedItems)
                    {
                        technologie += li1 + " ; ";
                    }
                    UPLoadForm6(technologie, Links.Text);
                }
                if (StartForm7 != null)
                    StartForm7();
            }
            else
            {
                errorProvider1.SetError(Next, "Należy zaznaczyć przynajmniej jedno pole!");
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (StartForm5 != null)
                StartForm5();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            if (WczytajTechnologie != null)
                WczytajTechnologie(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WczytajTechnologie != null)
                WczytajTechnologie(this);
        }
    }
}
