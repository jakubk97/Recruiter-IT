namespace Recruiter
{
    partial class Screen5
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
            this.Email = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.RadioButtonsPanel = new System.Windows.Forms.Panel();
            this.RadioButtonYes = new System.Windows.Forms.RadioButton();
            this.Prev = new System.Windows.Forms.Button();
            this.FirmPanel = new System.Windows.Forms.Panel();
            this.dateTimePickerdo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerod = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Firm1WorkDatesLabel = new System.Windows.Forms.Label();
            this.Firm1Name = new System.Windows.Forms.TextBox();
            this.Firm1Position = new System.Windows.Forms.TextBox();
            this.Firm1PositionLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.RadioButtonNo = new System.Windows.Forms.RadioButton();
            this.RadioButtonsPanel.SuspendLayout();
            this.FirmPanel.SuspendLayout();
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
            // Email
            // 
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Email.Location = new System.Drawing.Point(52, 346);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(215, 25);
            this.Email.TabIndex = 26;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.FirstNameLabel.Location = new System.Drawing.Point(44, 114);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(206, 30);
            this.FirstNameLabel.TabIndex = 21;
            this.FirstNameLabel.Text = "Czy już pracowałeś?";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Title
            // 
            this.Title.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.Title.Location = new System.Drawing.Point(40, 40);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(285, 54);
            this.Title.TabIndex = 19;
            this.Title.Text = "Doświadczenie";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RadioButtonsPanel
            // 
            this.RadioButtonsPanel.Controls.Add(this.RadioButtonNo);
            this.RadioButtonsPanel.Controls.Add(this.RadioButtonYes);
            this.RadioButtonsPanel.Location = new System.Drawing.Point(49, 147);
            this.RadioButtonsPanel.Name = "RadioButtonsPanel";
            this.RadioButtonsPanel.Size = new System.Drawing.Size(138, 41);
            this.RadioButtonsPanel.TabIndex = 36;
            // 
            // RadioButtonYes
            // 
            this.RadioButtonYes.AutoSize = true;
            this.RadioButtonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioButtonYes.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.RadioButtonYes.Location = new System.Drawing.Point(3, 3);
            this.RadioButtonYes.Name = "RadioButtonYes";
            this.RadioButtonYes.Size = new System.Drawing.Size(62, 34);
            this.RadioButtonYes.TabIndex = 0;
            this.RadioButtonYes.TabStop = true;
            this.RadioButtonYes.Text = "Tak";
            this.RadioButtonYes.UseVisualStyleBackColor = true;
            this.RadioButtonYes.CheckedChanged += new System.EventHandler(this.RadioButtonYes_CheckedChanged);
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
            this.Prev.TabIndex = 57;
            this.Prev.Text = "Wstecz";
            this.Prev.UseVisualStyleBackColor = false;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // FirmPanel
            // 
            this.FirmPanel.Controls.Add(this.dateTimePickerdo);
            this.FirmPanel.Controls.Add(this.dateTimePickerod);
            this.FirmPanel.Controls.Add(this.label1);
            this.FirmPanel.Controls.Add(this.label2);
            this.FirmPanel.Controls.Add(this.Firm1WorkDatesLabel);
            this.FirmPanel.Controls.Add(this.Firm1Name);
            this.FirmPanel.Controls.Add(this.Firm1Position);
            this.FirmPanel.Controls.Add(this.Firm1PositionLabel);
            this.FirmPanel.Location = new System.Drawing.Point(49, 194);
            this.FirmPanel.Name = "FirmPanel";
            this.FirmPanel.Size = new System.Drawing.Size(895, 401);
            this.FirmPanel.TabIndex = 55;
            this.FirmPanel.Visible = false;
            // 
            // dateTimePickerdo
            // 
            this.dateTimePickerdo.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePickerdo.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerdo.Location = new System.Drawing.Point(393, 219);
            this.dateTimePickerdo.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerdo.Name = "dateTimePickerdo";
            this.dateTimePickerdo.Size = new System.Drawing.Size(412, 29);
            this.dateTimePickerdo.TabIndex = 59;
            this.dateTimePickerdo.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerod
            // 
            this.dateTimePickerod.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePickerod.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerod.Location = new System.Drawing.Point(393, 149);
            this.dateTimePickerod.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerod.Name = "dateTimePickerod";
            this.dateTimePickerod.Size = new System.Drawing.Size(412, 29);
            this.dateTimePickerod.TabIndex = 58;
            this.dateTimePickerod.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(18, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 30);
            this.label1.TabIndex = 57;
            this.label1.Text = "Praca do:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 30);
            this.label2.TabIndex = 56;
            this.label2.Text = "Nazwa twojej poprzedniej pracy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Firm1WorkDatesLabel
            // 
            this.Firm1WorkDatesLabel.AutoSize = true;
            this.Firm1WorkDatesLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Firm1WorkDatesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.Firm1WorkDatesLabel.Location = new System.Drawing.Point(18, 147);
            this.Firm1WorkDatesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.Firm1WorkDatesLabel.Name = "Firm1WorkDatesLabel";
            this.Firm1WorkDatesLabel.Size = new System.Drawing.Size(102, 30);
            this.Firm1WorkDatesLabel.TabIndex = 54;
            this.Firm1WorkDatesLabel.Text = "Praca od:";
            this.Firm1WorkDatesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Firm1Name
            // 
            this.Firm1Name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Firm1Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Firm1Name.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Firm1Name.Location = new System.Drawing.Point(393, 12);
            this.Firm1Name.Name = "Firm1Name";
            this.Firm1Name.Size = new System.Drawing.Size(499, 32);
            this.Firm1Name.TabIndex = 50;
            // 
            // Firm1Position
            // 
            this.Firm1Position.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Firm1Position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Firm1Position.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Firm1Position.Location = new System.Drawing.Point(393, 73);
            this.Firm1Position.Name = "Firm1Position";
            this.Firm1Position.Size = new System.Drawing.Size(499, 32);
            this.Firm1Position.TabIndex = 51;
            // 
            // Firm1PositionLabel
            // 
            this.Firm1PositionLabel.AutoSize = true;
            this.Firm1PositionLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Firm1PositionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.Firm1PositionLabel.Location = new System.Drawing.Point(18, 71);
            this.Firm1PositionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.Firm1PositionLabel.Name = "Firm1PositionLabel";
            this.Firm1PositionLabel.Size = new System.Drawing.Size(121, 30);
            this.Firm1PositionLabel.TabIndex = 52;
            this.Firm1PositionLabel.Text = "Stanowisko";
            this.Firm1PositionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RadioButtonNo
            // 
            this.RadioButtonNo.AutoSize = true;
            this.RadioButtonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioButtonNo.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.RadioButtonNo.Location = new System.Drawing.Point(71, 3);
            this.RadioButtonNo.Name = "RadioButtonNo";
            this.RadioButtonNo.Size = new System.Drawing.Size(63, 34);
            this.RadioButtonNo.TabIndex = 1;
            this.RadioButtonNo.TabStop = true;
            this.RadioButtonNo.Text = "Nie";
            this.RadioButtonNo.UseVisualStyleBackColor = true;
            this.RadioButtonNo.CheckedChanged += new System.EventHandler(this.RadioButtonNo_CheckedChanged);
            // 
            // Screen5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.FirmPanel);
            this.Controls.Add(this.RadioButtonsPanel);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.Title);
            this.Name = "Screen5";
            this.Size = new System.Drawing.Size(1007, 725);
            this.RadioButtonsPanel.ResumeLayout(false);
            this.RadioButtonsPanel.PerformLayout();
            this.FirmPanel.ResumeLayout(false);
            this.FirmPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel RadioButtonsPanel;
        private System.Windows.Forms.RadioButton RadioButtonYes;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Panel FirmPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Firm1WorkDatesLabel;
        private System.Windows.Forms.TextBox Firm1Name;
        private System.Windows.Forms.TextBox Firm1Position;
        private System.Windows.Forms.Label Firm1PositionLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerdo;
        private System.Windows.Forms.DateTimePicker dateTimePickerod;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton RadioButtonNo;
    }
}
