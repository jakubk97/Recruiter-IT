﻿namespace Recruiter
{
    partial class Screen9
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
            this.Title = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.KnownTechLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.Title.Location = new System.Drawing.Point(348, 42);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(305, 72);
            this.Title.TabIndex = 1;
            this.Title.Text = "Dziękujemy";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.FirstNameLabel.Location = new System.Drawing.Point(262, 244);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(477, 30);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "Dziękujemy za złożone podanie do naszej firmy.";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KnownTechLabel2
            // 
            this.KnownTechLabel2.AutoSize = true;
            this.KnownTechLabel2.BackColor = System.Drawing.Color.White;
            this.KnownTechLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.KnownTechLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.KnownTechLabel2.Location = new System.Drawing.Point(785, 702);
            this.KnownTechLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.KnownTechLabel2.Name = "KnownTechLabel2";
            this.KnownTechLabel2.Size = new System.Drawing.Size(210, 13);
            this.KnownTechLabel2.TabIndex = 60;
            this.KnownTechLabel2.Text = "2019 Jakub Karmański & Michał Grzyśka";
            this.KnownTechLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KnownTechLabel2.UseMnemonic = false;
            // 
            // Screen9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.KnownTechLabel2);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.Title);
            this.Name = "Screen9";
            this.Size = new System.Drawing.Size(1000, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label KnownTechLabel2;
    }
}