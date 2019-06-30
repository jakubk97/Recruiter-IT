using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiter
{

    public sealed class Forma
    {
        private string imie="", drugie = "", nazwisko = "", data_urodzenia = "", email = "", telefon = "", adres = "", zdjecie = "", ID = "";

        private string krajstudiow="", nazwauczelni="", wydzial="", kierunek="", trybstudiow="", tytzawodowy="";

        private string jezyki = "";

        private string nazwa="", stanowisko="", data_od="", data_do = "";

        private string technologie="", linki="";

        private string prefstanowisko="", prefoddzial="", prefczaspracy="", wynagrodzenie="", pracaodkiedy="", skadwiesz = "";

        private string zainteresowania="", infodlarekrutera = "";


        private static Forma instance = null;
        public static Forma Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Forma();
                }
                return instance;
            }
        }

        public string[] GetUczelnie()
        {
            return Repository.GetUczelnie();
        }

        public string[] GetKierunki()
        {
            return Repository.GetKierunki();
        }

        public string[] GetTechnologie()
        {
            return Repository.GetTechnologie();
        }

        public void Form2(string imie, string drugie, string nazwisko, string data_urodzenia, string email
            , string telefon, string adres, string zdjecie)
        {
            this.imie = imie;
            this.drugie = drugie;
            this.nazwisko = nazwisko;
            this.data_urodzenia = data_urodzenia;
            this.email = email;
            this.telefon = telefon;
            this.adres = adres;
            this.zdjecie = zdjecie;
        }
        public void Form3(string nazwauczelni, string kierunek
            , string trybstudiow, string tytzawodowy)
        {
            this.nazwauczelni = nazwauczelni;
            this.kierunek = kierunek;
            this.trybstudiow = trybstudiow;
            this.tytzawodowy = tytzawodowy;
        }
        public void Form4(string jezyki)
        {
            this.jezyki = jezyki;
        }
        public void Form5(string nazwa, string stanowisko, string data_od, string data_do)
        {
            this.nazwa = nazwa;
            this.stanowisko = stanowisko;
            this.data_od = data_od;
            this.data_do = data_do;
        }
        public void Form6(string technologie, string linki)
        {
            this.technologie = technologie;
            this.linki = linki;
        }
        public void Form7(string prefstanowisko, string prefoddzial, string prefczaspracy
            , string wynagrodzenie, string pracaodkiedy, string skadwiesz)
        {
            this.prefstanowisko = prefstanowisko;
            this.prefoddzial = prefoddzial;
            this.prefczaspracy = prefczaspracy;
            this.wynagrodzenie = wynagrodzenie;
            this.pracaodkiedy = pracaodkiedy;
            this.skadwiesz = skadwiesz;
        }
        public void Form8(string zainteresowania, string infodlarekrutera)
        {
            this.zainteresowania = zainteresowania;
            this.infodlarekrutera = infodlarekrutera;
            Repository.SendPersonalData();
            Repository.SendEducation();
            Repository.SendPrevWork();
            Repository.SendLinks();
            Repository.SendAddInfo();
            Repository.CreateFormul();
        }

        public string Imie
        {
            get
            {
                return imie;
            }
        }

        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
        }

        public string Data_urodzenia
        {
            get
            {
                return data_urodzenia;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
        }

        public string Telefon
        {
            get
            {
                return telefon;
            }
        }

        public string Adres
        {
            get
            {
                return adres;
            }
        }

        public string Zdjecie
        {
            get
            {
                return zdjecie;
            }
        }

        public string ID1
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        public string Krajstudiow
        {
            get
            {
                return krajstudiow;
            }
        }

        public string Nazwauczelni
        {
            get
            {
                return nazwauczelni;
            }
        }

        public string Wydzial
        {
            get
            {
                return wydzial;
            }
        }

        public string Kierunek
        {
            get
            {
                return kierunek;
            }
        }

        public string Trybstudiow
        {
            get
            {
                return trybstudiow;
            }
        }

        public string Tytzawodowy
        {
            get
            {
                return tytzawodowy;
            }
        }

        public string Jezyki
        {
            get
            {
                return jezyki;
            }
        }

        public string Nazwa
        {
            get
            {
                return nazwa;
            }
        }

        public string Stanowisko
        {
            get
            {
                return stanowisko;
            }
        }

        public string Data_od
        {
            get
            {
                return data_od;
            }
        }

        public string Data_do
        {
            get
            {
                return data_do;
            }
        }

        public string Prefstanowisko
        {
            get
            {
                return prefstanowisko;
            }
        }

        public string Prefoddzial
        {
            get
            {
                return prefoddzial;
            }
        }

        public string Prefczaspracy
        {
            get
            {
                return prefczaspracy;
            }
        }

        public string Wynagrodzenie
        {
            get
            {
                return wynagrodzenie;
            }
        }

        public string Pracaodkiedy
        {
            get
            {
                return pracaodkiedy;
            }
        }

        public string Skadwiesz
        {
            get
            {
                return skadwiesz;
            }
        }

        public string Zainteresowania
        {
            get
            {
                return zainteresowania;
            }
        }

        public string Infodlarekrutera
        {
            get
            {
                return infodlarekrutera;
            }
        }

        public string Drugie
        {
            get
            {
                return drugie;
            }
        }

        public string Technologie
        {
            get
            {
                return technologie;
            }
        }

        public string Linki
        {
            get
            {
                return linki;
            }
        }
    }
}
