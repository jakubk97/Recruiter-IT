namespace Recruiter
{
    partial class Screen3
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
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.WorkTitleLabel = new System.Windows.Forms.Label();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.SpecializationLabel = new System.Windows.Forms.Label();
            this.UniversityNameLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.ComboBox();
            this.WorkTitle = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Prev = new System.Windows.Forms.Button();
            this.CollageKier = new System.Windows.Forms.ComboBox();
            this.CollageName = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.StartDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.StartDateLabel.Location = new System.Drawing.Point(46, 433);
            this.StartDateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(259, 30);
            this.StartDateLabel.TabIndex = 32;
            this.StartDateLabel.Text = "Data rozpoczęcia studiów";
            this.StartDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WorkTitleLabel
            // 
            this.WorkTitleLabel.AutoSize = true;
            this.WorkTitleLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.WorkTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.WorkTitleLabel.Location = new System.Drawing.Point(44, 368);
            this.WorkTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.WorkTitleLabel.Name = "WorkTitleLabel";
            this.WorkTitleLabel.Size = new System.Drawing.Size(169, 30);
            this.WorkTitleLabel.TabIndex = 31;
            this.WorkTitleLabel.Text = "Tytuł zawodowy";
            this.WorkTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.ModeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.ModeLabel.Location = new System.Drawing.Point(44, 299);
            this.ModeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(136, 30);
            this.ModeLabel.TabIndex = 29;
            this.ModeLabel.Text = "Tryb studiów";
            this.ModeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SpecializationLabel
            // 
            this.SpecializationLabel.AutoSize = true;
            this.SpecializationLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.SpecializationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.SpecializationLabel.Location = new System.Drawing.Point(44, 238);
            this.SpecializationLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SpecializationLabel.Name = "SpecializationLabel";
            this.SpecializationLabel.Size = new System.Drawing.Size(98, 30);
            this.SpecializationLabel.TabIndex = 27;
            this.SpecializationLabel.Text = "Kierunek";
            this.SpecializationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UniversityNameLabel
            // 
            this.UniversityNameLabel.AutoSize = true;
            this.UniversityNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.UniversityNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.UniversityNameLabel.Location = new System.Drawing.Point(44, 175);
            this.UniversityNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.UniversityNameLabel.Name = "UniversityNameLabel";
            this.UniversityNameLabel.Size = new System.Drawing.Size(149, 30);
            this.UniversityNameLabel.TabIndex = 23;
            this.UniversityNameLabel.Text = "Nazwa uczelni";
            this.UniversityNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.Title.Location = new System.Drawing.Point(40, 40);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(272, 54);
            this.Title.TabIndex = 19;
            this.Title.Text = "Wykształcenie";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.EndDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.EndDateLabel.Location = new System.Drawing.Point(44, 498);
            this.EndDateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(261, 30);
            this.EndDateLabel.TabIndex = 37;
            this.EndDateLabel.Text = "Data zakończenia studiów";
            this.EndDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Mode
            // 
            this.Mode.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mode.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Mode.FormattingEnabled = true;
            this.Mode.Location = new System.Drawing.Point(284, 300);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(414, 33);
            this.Mode.TabIndex = 39;
            // 
            // WorkTitle
            // 
            this.WorkTitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.WorkTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkTitle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.WorkTitle.FormattingEnabled = true;
            this.WorkTitle.Location = new System.Drawing.Point(284, 369);
            this.WorkTitle.Name = "WorkTitle";
            this.WorkTitle.Size = new System.Drawing.Size(414, 33);
            this.WorkTitle.TabIndex = 40;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(49, 466);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(412, 29);
            this.dateTimePicker1.TabIndex = 41;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker2.Location = new System.Drawing.Point(49, 531);
            this.dateTimePicker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(412, 29);
            this.dateTimePicker2.TabIndex = 42;
            this.dateTimePicker2.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
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
            this.Prev.TabIndex = 43;
            this.Prev.Text = "Wstecz";
            this.Prev.UseVisualStyleBackColor = false;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // CollageKier
            // 
            this.CollageKier.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CollageKier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollageKier.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.CollageKier.FormattingEnabled = true;
            this.CollageKier.Location = new System.Drawing.Point(284, 239);
            this.CollageKier.Name = "CollageKier";
            this.CollageKier.Size = new System.Drawing.Size(414, 33);
            this.CollageKier.TabIndex = 45;
            this.CollageKier.DropDown += new System.EventHandler(this.CollageKier_DropDown);
            // 
            // CollageName
            // 
            this.CollageName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CollageName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollageName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.CollageName.FormattingEnabled = true;
            this.CollageName.Location = new System.Drawing.Point(284, 176);
            this.CollageName.Name = "CollageName";
            this.CollageName.Size = new System.Drawing.Size(414, 33);
            this.CollageName.TabIndex = 44;
            this.CollageName.DropDown += new System.EventHandler(this.CollageName_DropDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Screen3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CollageKier);
            this.Controls.Add(this.CollageName);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.WorkTitle);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.WorkTitleLabel);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.SpecializationLabel);
            this.Controls.Add(this.UniversityNameLabel);
            this.Controls.Add(this.Title);
            this.Name = "Screen3";
            this.Size = new System.Drawing.Size(1007, 725);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label WorkTitleLabel;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.Label SpecializationLabel;
        private System.Windows.Forms.Label UniversityNameLabel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.ComboBox Mode;
        private System.Windows.Forms.ComboBox WorkTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.ComboBox CollageKier;
        private System.Windows.Forms.ComboBox CollageName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
