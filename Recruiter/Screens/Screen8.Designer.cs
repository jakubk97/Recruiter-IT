namespace Recruiter
{
    partial class Screen8
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.End = new System.Windows.Forms.Button();
            this.RecruiterInfoLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Interests = new System.Windows.Forms.RichTextBox();
            this.InterestsLabel = new System.Windows.Forms.Label();
            this.Prev = new System.Windows.Forms.Button();
            this.RecruiterInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // End
            // 
            this.End.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.End.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.End.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.End.ForeColor = System.Drawing.Color.White;
            this.End.Location = new System.Drawing.Point(430, 647);
            this.End.Name = "End";
            this.End.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.End.Size = new System.Drawing.Size(140, 50);
            this.End.TabIndex = 49;
            this.End.Text = "Zakończ";
            this.End.UseVisualStyleBackColor = false;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // RecruiterInfoLabel
            // 
            this.RecruiterInfoLabel.AutoSize = true;
            this.RecruiterInfoLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.RecruiterInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.RecruiterInfoLabel.Location = new System.Drawing.Point(44, 114);
            this.RecruiterInfoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.RecruiterInfoLabel.Name = "RecruiterInfoLabel";
            this.RecruiterInfoLabel.Size = new System.Drawing.Size(246, 30);
            this.RecruiterInfoLabel.TabIndex = 38;
            this.RecruiterInfoLabel.Text = "Informacje dla rekrutera";
            this.RecruiterInfoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.Title.Location = new System.Drawing.Point(40, 40);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(101, 54);
            this.Title.TabIndex = 36;
            this.Title.Text = "Inne";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Interests
            // 
            this.Interests.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Interests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Interests.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Interests.Location = new System.Drawing.Point(49, 332);
            this.Interests.Name = "Interests";
            this.Interests.Size = new System.Drawing.Size(521, 149);
            this.Interests.TabIndex = 66;
            this.Interests.Text = "";
            // 
            // InterestsLabel
            // 
            this.InterestsLabel.AutoSize = true;
            this.InterestsLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.InterestsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.InterestsLabel.Location = new System.Drawing.Point(44, 299);
            this.InterestsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.InterestsLabel.Name = "InterestsLabel";
            this.InterestsLabel.Size = new System.Drawing.Size(170, 30);
            this.InterestsLabel.TabIndex = 65;
            this.InterestsLabel.Text = "Zainteresowania";
            this.InterestsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Prev
            // 
            this.Prev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Prev.ForeColor = System.Drawing.Color.White;
            this.Prev.Location = new System.Drawing.Point(284, 647);
            this.Prev.Name = "Prev";
            this.Prev.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Prev.Size = new System.Drawing.Size(140, 50);
            this.Prev.TabIndex = 67;
            this.Prev.Text = "Wstecz";
            this.Prev.UseVisualStyleBackColor = false;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // RecruiterInfo
            // 
            this.RecruiterInfo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RecruiterInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RecruiterInfo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.RecruiterInfo.Location = new System.Drawing.Point(49, 147);
            this.RecruiterInfo.Name = "RecruiterInfo";
            this.RecruiterInfo.Size = new System.Drawing.Size(521, 149);
            this.RecruiterInfo.TabIndex = 64;
            this.RecruiterInfo.Text = "";
            // 
            // Screen8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.Interests);
            this.Controls.Add(this.InterestsLabel);
            this.Controls.Add(this.RecruiterInfo);
            this.Controls.Add(this.End);
            this.Controls.Add(this.RecruiterInfoLabel);
            this.Controls.Add(this.Title);
            this.Name = "Screen8";
            this.Size = new System.Drawing.Size(1007, 725);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Label RecruiterInfoLabel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RichTextBox Interests;
        private System.Windows.Forms.Label InterestsLabel;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.RichTextBox RecruiterInfo;
    }
}
