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
            this.components = new System.ComponentModel.Container();
            this.Next = new System.Windows.Forms.Button();
            this.CompanyKnowledgeLabel = new System.Windows.Forms.Label();
            this.CompanyKnowledge = new System.Windows.Forms.TextBox();
            this.PrefStartDateLabel = new System.Windows.Forms.Label();
            this.PrefSalaryLabel = new System.Windows.Forms.Label();
            this.PrefSalary = new System.Windows.Forms.TextBox();
            this.PrefWorktimeLabel = new System.Windows.Forms.Label();
            this.PrefWorktime = new System.Windows.Forms.TextBox();
            this.PrefBranchLabel = new System.Windows.Forms.Label();
            this.PrefBranch = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.Prev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.CompanyKnowledgeLabel.Location = new System.Drawing.Point(44, 441);
            this.CompanyKnowledgeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CompanyKnowledgeLabel.Name = "CompanyKnowledgeLabel";
            this.CompanyKnowledgeLabel.Size = new System.Drawing.Size(209, 30);
            this.CompanyKnowledgeLabel.TabIndex = 31;
            this.CompanyKnowledgeLabel.Text = "Skąd wiesz o firmie?";
            this.CompanyKnowledgeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CompanyKnowledge
            // 
            this.CompanyKnowledge.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CompanyKnowledge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyKnowledge.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.CompanyKnowledge.Location = new System.Drawing.Point(368, 443);
            this.CompanyKnowledge.Name = "CompanyKnowledge";
            this.CompanyKnowledge.Size = new System.Drawing.Size(215, 32);
            this.CompanyKnowledge.TabIndex = 30;
            // 
            // PrefStartDateLabel
            // 
            this.PrefStartDateLabel.AutoSize = true;
            this.PrefStartDateLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.PrefStartDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.PrefStartDateLabel.Location = new System.Drawing.Point(44, 380);
            this.PrefStartDateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PrefStartDateLabel.Name = "PrefStartDateLabel";
            this.PrefStartDateLabel.Size = new System.Drawing.Size(260, 30);
            this.PrefStartDateLabel.TabIndex = 29;
            this.PrefStartDateLabel.Text = "Kiedy możesz rozpocząć?";
            this.PrefStartDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrefSalaryLabel
            // 
            this.PrefSalaryLabel.AutoSize = true;
            this.PrefSalaryLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.PrefSalaryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.PrefSalaryLabel.Location = new System.Drawing.Point(44, 319);
            this.PrefSalaryLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PrefSalaryLabel.Name = "PrefSalaryLabel";
            this.PrefSalaryLabel.Size = new System.Drawing.Size(319, 30);
            this.PrefSalaryLabel.TabIndex = 27;
            this.PrefSalaryLabel.Text = "Oczekiwane wynagrodzenie (zł)";
            this.PrefSalaryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrefSalary
            // 
            this.PrefSalary.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PrefSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrefSalary.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.PrefSalary.Location = new System.Drawing.Point(368, 321);
            this.PrefSalary.Name = "PrefSalary";
            this.PrefSalary.Size = new System.Drawing.Size(215, 32);
            this.PrefSalary.TabIndex = 26;
            this.PrefSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrefSalary_KeyPress);
            // 
            // PrefWorktimeLabel
            // 
            this.PrefWorktimeLabel.AutoSize = true;
            this.PrefWorktimeLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.PrefWorktimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.PrefWorktimeLabel.Location = new System.Drawing.Point(44, 258);
            this.PrefWorktimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PrefWorktimeLabel.Name = "PrefWorktimeLabel";
            this.PrefWorktimeLabel.Size = new System.Drawing.Size(240, 30);
            this.PrefWorktimeLabel.TabIndex = 25;
            this.PrefWorktimeLabel.Text = "Preferowany czas pracy";
            this.PrefWorktimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrefWorktime
            // 
            this.PrefWorktime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PrefWorktime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrefWorktime.Cursor = System.Windows.Forms.Cursors.Default;
            this.PrefWorktime.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.PrefWorktime.Location = new System.Drawing.Point(368, 260);
            this.PrefWorktime.Name = "PrefWorktime";
            this.PrefWorktime.Size = new System.Drawing.Size(215, 32);
            this.PrefWorktime.TabIndex = 24;
            this.PrefWorktime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrefWorktime_KeyPress);
            // 
            // PrefBranchLabel
            // 
            this.PrefBranchLabel.AutoSize = true;
            this.PrefBranchLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.PrefBranchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.PrefBranchLabel.Location = new System.Drawing.Point(44, 197);
            this.PrefBranchLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PrefBranchLabel.Name = "PrefBranchLabel";
            this.PrefBranchLabel.Size = new System.Drawing.Size(268, 30);
            this.PrefBranchLabel.TabIndex = 23;
            this.PrefBranchLabel.Text = "Preferowany oddział firmy";
            this.PrefBranchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PrefBranch
            // 
            this.PrefBranch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PrefBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrefBranch.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.PrefBranch.Location = new System.Drawing.Point(368, 199);
            this.PrefBranch.Name = "PrefBranch";
            this.PrefBranch.Size = new System.Drawing.Size(215, 32);
            this.PrefBranch.TabIndex = 22;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(44, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 46;
            this.label1.Text = "Preferowana pozycja";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(370, 130);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(213, 32);
            this.comboBoxPosition.TabIndex = 47;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(368, 381);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(412, 29);
            this.dateTimePicker1.TabIndex = 48;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // Screen7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.CompanyKnowledgeLabel);
            this.Controls.Add(this.CompanyKnowledge);
            this.Controls.Add(this.PrefStartDateLabel);
            this.Controls.Add(this.PrefSalaryLabel);
            this.Controls.Add(this.PrefSalary);
            this.Controls.Add(this.PrefWorktimeLabel);
            this.Controls.Add(this.PrefWorktime);
            this.Controls.Add(this.PrefBranchLabel);
            this.Controls.Add(this.PrefBranch);
            this.Controls.Add(this.Title);
            this.Name = "Screen7";
            this.Size = new System.Drawing.Size(1007, 725);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label CompanyKnowledgeLabel;
        private System.Windows.Forms.TextBox CompanyKnowledge;
        private System.Windows.Forms.Label PrefStartDateLabel;
        private System.Windows.Forms.Label PrefSalaryLabel;
        private System.Windows.Forms.TextBox PrefSalary;
        private System.Windows.Forms.Label PrefWorktimeLabel;
        private System.Windows.Forms.TextBox PrefWorktime;
        private System.Windows.Forms.Label PrefBranchLabel;
        private System.Windows.Forms.TextBox PrefBranch;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
