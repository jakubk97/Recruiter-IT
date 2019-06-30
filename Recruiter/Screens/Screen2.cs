﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Recruiter
{
    public partial class Screen2 : UserControl
    {
        public Screen2()
        {
            InitializeComponent();
        }

        #region Events
        public event Action StartForm3;
        public event Action<string, string, string, string, string, string, string, string> UPLoadForm2;
        #endregion

        private void Next_Click(object sender, EventArgs e)
        {
            if (UPLoadForm2 != null)
                UPLoadForm2(FirstName.Text,SecondName.Text, Surname.Text, dateTimePickerdataurodzenia.Value.ToShortDateString()
                    , Email.Text, Phone.Text, Address.Text, imageString);

            if (StartForm3 != null)
                StartForm3();
        }

        private string imageString = "";
        private void AddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(of.FileName);
                sciezka.Text = of.FileName.ToString();
                var stream = new MemoryStream();
                image.Save(stream, image.RawFormat);
                var bytes = stream.ToArray();

                imageString = Convert.ToBase64String(bytes);
            }
        }
    }
}