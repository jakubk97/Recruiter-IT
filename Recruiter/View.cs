using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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


        //public event Action<Forma> StartForm2Load;
        //public event Action<Forma> StartForm3Load;
        //public event Action<Forma> StartForm4Load;
        //public event Action<Forma> StartForm5Load;
        //public event Action<Forma> StartForm6Load;
        //public event Action<Forma> StartForm7Load;
        //public event Action<Forma> StartForm8Load;
        //public event Action<Forma> StartForm9Load;



        public event Action<string, string, string, string, string, string, string, string> UPLoadForm2;
        public event Action<string, string, string, string, string, string, string, string> UPLoadForm3;
        public event Action<string> UPLoadForm4;
        public event Action<string, string, string, string> UPLoadForm5;
        public event Action<string, string> UPLoadForm6;
        public event Action<string, string, string, string, string, string> UPLoadForm7;
        public event Action<string, string> UPLoadForm8;

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
            s2.UPLoadForm2 += S2_UPLoadForm2;

            panel1.Controls.Add(s2);
            s2.BringToFront();
            UploadControls(panel1, Forma.Instance);
        }

        private void UploadControls(Panel pan, Forma f)
        {
            TextBox t1 = pan.Parent.Controls.Find("FirstName", true)[0] as TextBox;
            t1.Text = f.Imie;
            TextBox t2 = pan.Parent.Controls.Find("SecondName", true)[0] as TextBox;
            t2.Text = f.Drugie;
            TextBox t3 = pan.Parent.Controls.Find("Surname", true)[0] as TextBox;
            t3.Text = f.Nazwisko;
            TextBox t4 = pan.Parent.Controls.Find("Email", true)[0] as TextBox;
            t4.Text = f.Email;
            TextBox t5 = pan.Parent.Controls.Find("Phone", true)[0] as TextBox;
            t5.Text = f.Telefon;
            TextBox t6 = pan.Parent.Controls.Find("Address", true)[0] as TextBox;
            t6.Text = f.Adres;
            DateTimePicker dtp = pan.Parent.Controls.Find("dateTimePickerdataurodzenia", true)[0] as DateTimePicker;
            DateTime parsedDate;
            if (f.Data_urodzenia != "")
            {
                DateTime.TryParseExact(f.Data_urodzenia, "dd.MM.yyyy", null, DateTimeStyles.None, out parsedDate);
                dtp.Value = parsedDate;
            }
            Label lab = pan.Parent.Controls.Find("sciezka", true)[0] as Label;
            if (f.Zdjecie != "")
                lab.Text = "Wybrano";
            else
                lab.Text = "Brak";
        }

        private void S2_UPLoadForm2(string imie, string drugie, string nazwisko, string data_urodzenia, string email
            , string telefon, string adres, string zdjecie)
        {
            if (UPLoadForm2 != null)
                UPLoadForm2(imie, drugie, nazwisko, data_urodzenia, email
            , telefon, adres, zdjecie);
        }

        private void S2_StartForm3()
        {
            panel1.Controls.Clear();
            s3 = new Screen3();
            s3.StartForm2 += S1_StartForm2;
            s3.StartForm4 += S3_StartForm4;
            s3.UPLoadForm3 += S3_UPLoadForm3;
            panel1.Controls.Add(s3);
            s3.BringToFront();
        }


        private void S3_UPLoadForm3(string krajstudiow, string nazwauczelni, string wydzial, string kierunek
            , string trybstudiow, string tytzawodowy, string d_roz_studiow, string d_zak_studiow)
        {
            if (UPLoadForm3 != null)
                UPLoadForm3(krajstudiow, nazwauczelni, wydzial, kierunek
            , trybstudiow, tytzawodowy, d_roz_studiow, d_zak_studiow);
        }

        private void S3_StartForm4()
        {
            panel1.Controls.Clear();
            s4 = new Screen4();
            s4.StartForm3 += S2_StartForm3;
            s4.StartForm5 += S4_StartForm5;
            s4.UPLoadForm4 += S4_UPLoadForm4;
            panel1.Controls.Add(s4);
            s4.BringToFront();
        }

        private void S4_UPLoadForm4(string jezyki)
        {
            if (UPLoadForm4 != null)
                UPLoadForm4(jezyki);
        }

        private void S4_StartForm5()
        {
            panel1.Controls.Clear();
            s5 = new Screen5();
            s5.StartForm4 += S3_StartForm4;
            s5.StartForm6 += S5_StartForm6;
            s5.UPLoadForm5 += S5_UPLoadForm5;
            panel1.Controls.Add(s5);
            s5.BringToFront();
        }

        private void S5_UPLoadForm5(string nazwa, string stanowisko, string data_od, string data_do)
        {
            if (UPLoadForm5 != null)
                UPLoadForm5(nazwa, stanowisko, data_od, data_do);
        }

        private void S5_StartForm6()
        {
            panel1.Controls.Clear();
            s6 = new Screen6();
            s6.StartForm5 += S4_StartForm5;
            s6.StartForm7 += S6_StartForm7;
            s6.UPLoadForm6 += S6_UPLoadForm6;
            panel1.Controls.Add(s6);
            s6.BringToFront();
        }

        private void S6_UPLoadForm6(string technologie, string linki)
        {
            if (UPLoadForm6 != null)
                UPLoadForm6(technologie, linki);
        }

        private void S6_StartForm7()
        {
            panel1.Controls.Clear();
            s7 = new Screen7();
            s7.StartForm6 += S5_StartForm6;
            s7.StartForm8 += S7_StartForm8;
            s7.UPLoadForm7 += S7_UPLoadForm7;
            panel1.Controls.Add(s7);
            s7.BringToFront();
        }

        private void S7_UPLoadForm7(string prefstanowisko, string prefoddzial, string prefczaspracy
            , string wynagrodzenie, string pracaodkiedy, string skadwiesz)
        {
            if (UPLoadForm7 != null)
                UPLoadForm7(prefstanowisko, prefoddzial, prefczaspracy, wynagrodzenie, pracaodkiedy, skadwiesz);
        }

        private void S7_StartForm8()
        {
            panel1.Controls.Clear();
            s8 = new Screen8();
            s8.StartForm7 += S6_StartForm7;
            s8.StartForm9 += S8_StartForm9;
            s8.UPLoadForm8 += S8_UPLoadForm8;
            panel1.Controls.Add(s8);
            s8.BringToFront();
        }

        private void S8_UPLoadForm8(string zainteresowania, string infodlarekrutera)
        {
            if (UPLoadForm8 != null)
                UPLoadForm8(zainteresowania, infodlarekrutera);
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
