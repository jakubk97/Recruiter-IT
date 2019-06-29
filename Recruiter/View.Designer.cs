namespace Recruiter
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.screen12 = new Recruiter.Screen1();
            this.SuspendLayout();
            // 
            // screen12
            // 
            this.screen12.BackColor = System.Drawing.Color.White;
            this.screen12.Location = new System.Drawing.Point(-1, 1);
            this.screen12.Name = "screen12";
            this.screen12.Size = new System.Drawing.Size(1007, 725);
            this.screen12.TabIndex = 0;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.screen12);
            this.Name = "View";
            this.Text = "IT Recruiter";
            this.ResumeLayout(false);

        }

        #endregion

        private Screen1 screen11;
        private Screen2 screen21;
        private Screen1 screen12;
    }
}

