namespace Recruiter
{
    partial class Screen2
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
            this.Title = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.PhotoLabel = new System.Windows.Forms.Label();
            this.AddPhoto = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.dateTimePickerdataurodzenia = new System.Windows.Forms.DateTimePicker();
            this.sciezka = new System.Windows.Forms.Label();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(322, 54);
            this.Title.TabIndex = 1;
            this.Title.Text = "Dane personalne";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.FirstName.Location = new System.Drawing.Point(337, 70);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(215, 32);
            this.FirstName.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.FirstNameLabel.Location = new System.Drawing.Point(44, 68);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(55, 30);
            this.FirstNameLabel.TabIndex = 3;
            this.FirstNameLabel.Text = "Imię";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.SurnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.SurnameLabel.Location = new System.Drawing.Point(44, 136);
            this.SurnameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(104, 30);
            this.SurnameLabel.TabIndex = 5;
            this.SurnameLabel.Text = "Nazwisko";
            this.SurnameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Surname
            // 
            this.Surname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Surname.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Surname.Location = new System.Drawing.Point(337, 138);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(215, 32);
            this.Surname.TabIndex = 4;
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.BirthdateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.BirthdateLabel.Location = new System.Drawing.Point(44, 204);
            this.BirthdateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(159, 30);
            this.BirthdateLabel.TabIndex = 7;
            this.BirthdateLabel.Text = "Data urodzenia";
            this.BirthdateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.EmailLabel.Location = new System.Drawing.Point(44, 272);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(73, 30);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "E-mail";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Email.Location = new System.Drawing.Point(337, 274);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(215, 32);
            this.Email.TabIndex = 8;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.PhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.PhoneLabel.Location = new System.Drawing.Point(44, 340);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(84, 30);
            this.PhoneLabel.TabIndex = 11;
            this.PhoneLabel.Text = "Telefon";
            this.PhoneLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Phone.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Phone.Location = new System.Drawing.Point(337, 342);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(215, 32);
            this.Phone.TabIndex = 10;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.AddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.AddressLabel.Location = new System.Drawing.Point(44, 408);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(259, 30);
            this.AddressLabel.TabIndex = 13;
            this.AddressLabel.Text = "Adres (Kraj, Miasto, Ulica)";
            this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Address.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Address.Location = new System.Drawing.Point(337, 410);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(411, 32);
            this.Address.TabIndex = 12;
            // 
            // PhotoLabel
            // 
            this.PhotoLabel.AutoSize = true;
            this.PhotoLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.PhotoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.PhotoLabel.Location = new System.Drawing.Point(44, 476);
            this.PhotoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PhotoLabel.Name = "PhotoLabel";
            this.PhotoLabel.Size = new System.Drawing.Size(83, 30);
            this.PhotoLabel.TabIndex = 15;
            this.PhotoLabel.Text = "Zdjęcie";
            this.PhotoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddPhoto
            // 
            this.AddPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.AddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPhoto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddPhoto.ForeColor = System.Drawing.Color.White;
            this.AddPhoto.Location = new System.Drawing.Point(337, 476);
            this.AddPhoto.Margin = new System.Windows.Forms.Padding(0);
            this.AddPhoto.Name = "AddPhoto";
            this.AddPhoto.Size = new System.Drawing.Size(117, 46);
            this.AddPhoto.TabIndex = 16;
            this.AddPhoto.Text = "Dodaj";
            this.AddPhoto.UseVisualStyleBackColor = false;
            this.AddPhoto.Click += new System.EventHandler(this.AddPhoto_Click);
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
            this.Next.TabIndex = 18;
            this.Next.Text = "Dalej";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // dateTimePickerdataurodzenia
            // 
            this.dateTimePickerdataurodzenia.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePickerdataurodzenia.CustomFormat = "MM/dd/yy";
            this.dateTimePickerdataurodzenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerdataurodzenia.Location = new System.Drawing.Point(337, 205);
            this.dateTimePickerdataurodzenia.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerdataurodzenia.Name = "dateTimePickerdataurodzenia";
            this.dateTimePickerdataurodzenia.Size = new System.Drawing.Size(412, 29);
            this.dateTimePickerdataurodzenia.TabIndex = 19;
            this.dateTimePickerdataurodzenia.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // sciezka
            // 
            this.sciezka.AutoSize = true;
            this.sciezka.Location = new System.Drawing.Point(457, 476);
            this.sciezka.Name = "sciezka";
            this.sciezka.Size = new System.Drawing.Size(0, 13);
            this.sciezka.TabIndex = 20;
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.SecondNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.SecondNameLabel.Location = new System.Drawing.Point(636, 68);
            this.SecondNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(78, 30);
            this.SecondNameLabel.TabIndex = 22;
            this.SecondNameLabel.Text = "Drugie";
            this.SecondNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SecondName
            // 
            this.SecondName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.SecondName.Location = new System.Drawing.Point(744, 70);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(215, 32);
            this.SecondName.TabIndex = 21;
            // 
            // Screen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SecondNameLabel);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.sciezka);
            this.Controls.Add(this.dateTimePickerdataurodzenia);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.AddPhoto);
            this.Controls.Add(this.PhotoLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.BirthdateLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Title);
            this.Name = "Screen2";
            this.Size = new System.Drawing.Size(1008, 729);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label BirthdateLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label PhotoLabel;
        private System.Windows.Forms.Button AddPhoto;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.DateTimePicker dateTimePickerdataurodzenia;
        private System.Windows.Forms.Label sciezka;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.TextBox SecondName;
    }
}
