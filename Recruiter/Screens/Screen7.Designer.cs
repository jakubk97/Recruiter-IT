namespace Recruiter
{
    partial class Screen7
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
            this.Next = new System.Windows.Forms.Button();
            this.CompanyKnowledgeLabel = new System.Windows.Forms.Label();
            this.CompanyKnowledge = new System.Windows.Forms.TextBox();
            this.PrefStartDateLabel = new System.Windows.Forms.Label();
            this.PrefStartDate = new System.Windows.Forms.TextBox();
            this.PrefSalaryLabel = new System.Windows.Forms.Label();
            this.PrefSalary = new System.Windows.Forms.TextBox();
            this.PrefWorktimeLabel = new System.Windows.Forms.Label();
            this.PrefWorktime = new System.Windows.Forms.TextBox();
            this.PrefBranchLabel = new System.Windows.Forms.Label();
            this.PrefBranch = new System.Windows.Forms.TextBox();
            this.PrefPositionLabel = new System.Windows.Forms.Label();
            this.PrefPosition = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.Prev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Next.ForeColor = System.Drawing.Color.White;
            this.Next.Location = new System.Drawing.Point(430, 647);
            this.Next.Name = "Next";
            this.Next.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Next.Size = new System.Drawing.Size(140, 50);
            this.Next.TabIndex = 35;
            this.Next.Text = "Dalej";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // CompanyKnowledgeLabel
            // 
            this.CompanyKnowledgeLabel.AutoSize = true;
            this.CompanyKnowledgeLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.CompanyKnowledgeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.CompanyKnowledgeLabel.Location = new System.Drawing.Point(44, 419);
            this.CompanyKnowledgeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CompanyKnowledgeLabel.Name = "CompanyKnowledgeLabel";
            this.CompanyKnowledgeLabel.Size = new System.Drawing.Size(209, 30);
            this.CompanyKnowledgeLabel.TabIndex = 31;
            this.CompanyKnowledgeLabel.Text = "Skąd wiesz o firmie?";
            this.CompanyKnowledgeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CompanyKnowledge
            // 
            this.CompanyKnowledge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyKnowledge.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.CompanyKnowledge.Location = new System.Drawing.Point(49, 452);
            this.CompanyKnowledge.Name = "CompanyKnowledge";
            this.CompanyKnowledge.Size = new System.Drawing.Size(411, 25);
            this.CompanyKnowledge.TabIndex = 30;
            // 
            // PrefStartDateLabel
            // 
            this.PrefStartDateLabel.AutoSize = true;
            this.PrefStartDateLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.PrefStartDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.PrefStartDateLabel.Location = new System.Drawing.Point(44, 358);
            this.PrefStartDateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PrefStartDateLabel.Name = "PrefStartDateLabel";
            this.PrefStartDateLabel.Size = new System.Drawing.Size(420, 30);
            this.PrefStartDateLabel.TabIndex = 29;
            this.PrefStartDateLabel.Text = "Kiedy możesz rozpocząć? (DD-MM-RRRR)";
            this.PrefStartDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrefStartDate
            // 
            this.PrefStartDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrefStartDate.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.PrefStartDate.Location = new System.Drawing.Point(49, 391);
            this.PrefStartDate.Name = "PrefStartDate";
            this.PrefStartDate.Size = new System.Drawing.Size(215, 25);
            this.PrefStartDate.TabIndex = 28;
            // 
            // PrefSalaryLabel
            // 
            this.PrefSalaryLabel.AutoSize = true;
            this.PrefSalaryLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.PrefSalaryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.PrefSalaryLabel.Location = new System.Drawing.Point(44, 297);
            this.PrefSalaryLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PrefSalaryLabel.Name = "PrefSalaryLabel";
            this.PrefSalaryLabel.Size = new System.Drawing.Size(319, 30);
            this.PrefSalaryLabel.TabIndex = 27;
            this.PrefSalaryLabel.Text = "Oczekiwane wynagrodzenie (zł)";
            this.PrefSalaryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrefSalary
            // 
            this.PrefSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrefSalary.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.PrefSalary.Location = new System.Drawing.Point(49, 330);
            this.PrefSalary.Name = "PrefSalary";
            this.PrefSalary.Size = new System.Drawing.Size(215, 25);
            this.PrefSalary.TabIndex = 26;
            // 
            // PrefWorktimeLabel
            // 
            this.PrefWorktimeLabel.AutoSize = true;
            this.PrefWorktimeLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.PrefWorktimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.PrefWorktimeLabel.Location = new System.Drawing.Point(44, 236);
            this.PrefWorktimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PrefWorktimeLabel.Name = "PrefWorktimeLabel";
            this.PrefWorktimeLabel.Size = new System.Drawing.Size(419, 30);
            this.PrefWorktimeLabel.TabIndex = 25;
            this.PrefWorktimeLabel.Text = "Preferowany czas pracy (GG:MM-GG:MM)";
            this.PrefWorktimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrefWorktime
            // 
            this.PrefWorktime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrefWorktime.Cursor = System.Windows.Forms.Cursors.Default;
            this.PrefWorktime.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.PrefWorktime.Location = new System.Drawing.Point(49, 269);
            this.PrefWorktime.Name = "PrefWorktime";
            this.PrefWorktime.Size = new System.Drawing.Size(215, 25);
            this.PrefWorktime.TabIndex = 24;
            // 
            // PrefBranchLabel
            // 
            this.PrefBranchLabel.AutoSize = true;
            this.PrefBranchLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.PrefBranchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.PrefBranchLabel.Location = new System.Drawing.Point(44, 175);
            this.PrefBranchLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PrefBranchLabel.Name = "PrefBranchLabel";
            this.PrefBranchLabel.Size = new System.Drawing.Size(268, 30);
            this.PrefBranchLabel.TabIndex = 23;
            this.PrefBranchLabel.Text = "Preferowany oddział firmy";
            this.PrefBranchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrefBranch
            // 
            this.PrefBranch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrefBranch.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.PrefBranch.Location = new System.Drawing.Point(49, 208);
            this.PrefBranch.Name = "PrefBranch";
            this.PrefBranch.Size = new System.Drawing.Size(215, 25);
            this.PrefBranch.TabIndex = 22;
            // 
            // PrefPositionLabel
            // 
            this.PrefPositionLabel.AutoSize = true;
            this.PrefPositionLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.PrefPositionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.PrefPositionLabel.Location = new System.Drawing.Point(44, 114);
            this.PrefPositionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PrefPositionLabel.Name = "PrefPositionLabel";
            this.PrefPositionLabel.Size = new System.Drawing.Size(248, 30);
            this.PrefPositionLabel.TabIndex = 21;
            this.PrefPositionLabel.Text = "Preferowane stanowisko";
            this.PrefPositionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrefPosition
            // 
            this.PrefPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrefPosition.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.PrefPosition.Location = new System.Drawing.Point(49, 147);
            this.PrefPosition.Name = "PrefPosition";
            this.PrefPosition.Size = new System.Drawing.Size(215, 25);
            this.PrefPosition.TabIndex = 20;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.Title.Location = new System.Drawing.Point(40, 40);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(221, 54);
            this.Title.TabIndex = 19;
            this.Title.Text = "Preferencje";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.Prev.TabIndex = 44;
            this.Prev.Text = "Wstecz";
            this.Prev.UseVisualStyleBackColor = false;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Screen7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.CompanyKnowledgeLabel);
            this.Controls.Add(this.CompanyKnowledge);
            this.Controls.Add(this.PrefStartDateLabel);
            this.Controls.Add(this.PrefStartDate);
            this.Controls.Add(this.PrefSalaryLabel);
            this.Controls.Add(this.PrefSalary);
            this.Controls.Add(this.PrefWorktimeLabel);
            this.Controls.Add(this.PrefWorktime);
            this.Controls.Add(this.PrefBranchLabel);
            this.Controls.Add(this.PrefBranch);
            this.Controls.Add(this.PrefPositionLabel);
            this.Controls.Add(this.PrefPosition);
            this.Controls.Add(this.Title);
            this.Name = "Screen7";
            this.Size = new System.Drawing.Size(1007, 725);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label CompanyKnowledgeLabel;
        private System.Windows.Forms.TextBox CompanyKnowledge;
        private System.Windows.Forms.Label PrefStartDateLabel;
        private System.Windows.Forms.TextBox PrefStartDate;
        private System.Windows.Forms.Label PrefSalaryLabel;
        private System.Windows.Forms.TextBox PrefSalary;
        private System.Windows.Forms.Label PrefWorktimeLabel;
        private System.Windows.Forms.TextBox PrefWorktime;
        private System.Windows.Forms.Label PrefBranchLabel;
        private System.Windows.Forms.TextBox PrefBranch;
        private System.Windows.Forms.Label PrefPositionLabel;
        private System.Windows.Forms.TextBox PrefPosition;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Prev;
    }
}
