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
            comboBoxPosition.Text = "";
        }
        #region Events
        public event Action StartForm6;
        public event Action StartForm8;
        public event Action<string, string, string, string, string> UPLoadForm7;
        #endregion

        private string[] Positions()
        {
            List<string> lista = new List<string> { "staż", "praktyki", "praca" };
            return lista.ToArray();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (comboBoxPosition.SelectedIndex != -1 && PrefWorktime.Text != "" &&
                PrefSalary.Text !="" && CompanyKnowledge.Text !="")
            {
                errorProvider1.Clear();
                if (UPLoadForm7 != null)
                {
                    UPLoadForm7(comboBoxPosition.SelectedItem.ToString(), PrefWorktime.Text, PrefSalary.Text,
                        dateTimePicker1.Value.ToShortDateString(), CompanyKnowledge.Text);
                }
                if (StartForm8 != null)
                    StartForm8();
            }
            else
            {
                errorProvider1.SetError(Next, "Należy wypełnić wszystkie pola!");
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (StartForm6 != null)
                StartForm6();
        }

        private void PrefWorktime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void PrefSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
