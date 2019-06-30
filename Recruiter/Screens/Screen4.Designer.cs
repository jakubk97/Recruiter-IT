namespace Recruiter
{
    partial class Languages
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
            this.Title = new System.Windows.Forms.Label();
            this.Prev = new System.Windows.Forms.Button();
            this.CBL_Language = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Next.ForeColor = System.Drawing.Color.White;
            this.Next.Location = new System.Drawing.Point(434, 649);
            this.Next.Margin = new System.Windows.Forms.Padding(6);
            this.Next.Name = "Next";
            this.Next.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.Next.Size = new System.Drawing.Size(140, 50);
            this.Next.TabIndex = 35;
            this.Next.Text = "Dalej";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.Title.Location = new System.Drawing.Point(73, 74);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(125, 54);
            this.Title.TabIndex = 19;
            this.Title.Text = "Języki";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Prev
            // 
            this.Prev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Prev.ForeColor = System.Drawing.Color.White;
            this.Prev.Location = new System.Drawing.Point(282, 649);
            this.Prev.Margin = new System.Windows.Forms.Padding(6);
            this.Prev.Name = "Prev";
            this.Prev.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.Prev.Size = new System.Drawing.Size(140, 50);
            this.Prev.TabIndex = 48;
            this.Prev.Text = "Wstecz";
            this.Prev.UseVisualStyleBackColor = false;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // CBL_Language
            // 
            this.CBL_Language.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CBL_Language.FormattingEnabled = true;
            this.CBL_Language.Location = new System.Drawing.Point(82, 173);
            this.CBL_Language.MultiColumn = true;
            this.CBL_Language.Name = "CBL_Language";
            this.CBL_Language.Size = new System.Drawing.Size(646, 244);
            this.CBL_Language.TabIndex = 50;
            // 
            // Languages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CBL_Language);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Languages";
            this.Size = new System.Drawing.Size(1007, 725);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.CheckedListBox CBL_Language;
    }
}
