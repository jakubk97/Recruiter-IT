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
            if (RadioButtonYes.Checked == true && Firm1Name.Text != "" && Firm1Position.Text != "")
            {
                errorProvider1.Clear();
                if (UPLoadForm5 != null)
                {
                    UPLoadForm5(Firm1Name.Text, Firm1Position.Text, dateTimePickerod.Value.ToShortDateString(), dateTimePickerdo.Value.ToShortDateString());
                }
                if (StartForm6 != null)
                    StartForm6();
            }
            else if (RadioButtonNo.Checked == true)
            {
                errorProvider1.Clear();
                if (UPLoadForm5 != null)
                {
                    UPLoadForm5("", "", "", "");
                }
                if (StartForm6 != null)
                    StartForm6();
            }
            else
            {
                errorProvider1.SetError(Next, "Należy zaznaczyć przynajmniej jedno pole!");
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (StartForm4 != null)
                StartForm4();
        }

        private void RadioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonYes.Checked = false;
            FirmPanel.Visible = false;
        }

        private void RadioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonNo.Checked = false;
            FirmPanel.Visible = true;
        }
    }
}
