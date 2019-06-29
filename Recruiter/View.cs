﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recruiter
{
    public partial class View : Form, IView
    {
        private Screen1 s1;
        private Screen2 s2;
        private Screen3 s3;
        private Screen4 s4;
        private Screen5 s5;
        private Screen6 s6;
        private Screen7 s7;
        private Screen8 s8;
        private Screen9 s9;

        public event Action StartForm2;
        public event Action StartForm3;
        public event Action StartForm4;
        public event Action StartForm5;
        public event Action StartForm6;
        public event Action StartForm7;
        public event Action StartForm8;
        public event Action StartForm9;

        public View()
        {
            InitializeComponent();
            s1 = new Screen1();
            panel1.Controls.Add(s1);
            s1.StartForm2 += S1_StartForm2;
        }
        private void S1_StartForm2()
        {
            panel1.Controls.Clear();
            s2 = new Screen2();
            s2.StartForm3 += S2_StartForm3;
            panel1.Controls.Add(s2);
            s2.BringToFront();
        }

        private void S2_StartForm3()
        {
            panel1.Controls.Clear();
            s3 = new Screen3();
            s3.StartForm2 += S1_StartForm2;
            s3.StartForm4 += S3_StartForm4;
            panel1.Controls.Add(s3);
            s3.BringToFront();
        }

        private void S3_StartForm4()
        {
            panel1.Controls.Clear();
            s4 = new Screen4();
            s4.StartForm3 += S2_StartForm3;
            s4.StartForm5 += S4_StartForm5;
            panel1.Controls.Add(s4);
            s4.BringToFront();
        }

        private void S4_StartForm5()
        {
            panel1.Controls.Clear();
            s5 = new Screen5();
            s5.StartForm4 += S3_StartForm4;
            s5.StartForm6 += S5_StartForm6;
            panel1.Controls.Add(s5);
            s5.BringToFront();
        }

        private void S5_StartForm6()
        {
            panel1.Controls.Clear();
            s6 = new Screen6();
            s6.StartForm5 += S4_StartForm5;
            s6.StartForm7 += S6_StartForm7;
            panel1.Controls.Add(s6);
            s6.BringToFront();
        }

        private void S6_StartForm7()
        {
            panel1.Controls.Clear();
            s7 = new Screen7();
            s7.StartForm6 += S5_StartForm6;
            s7.StartForm8 += S7_StartForm8;
            panel1.Controls.Add(s7);
            s7.BringToFront();
        }

        private void S7_StartForm8()
        {
            panel1.Controls.Clear();
            s8 = new Screen8();
            s8.StartForm7 += S6_StartForm7;
            s8.StartForm9 += S8_StartForm9;
            panel1.Controls.Add(s8);
            s8.BringToFront();
        }

        private void S8_StartForm9()
        {
            panel1.Controls.Clear();
            s9 = new Screen9();
            panel1.Controls.Add(s9);
            s9.BringToFront();
        }
    }
}
