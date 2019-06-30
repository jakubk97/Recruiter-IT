using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiter
{
    class Presenter
    {
        IView view;
        Forma f;
        public Presenter(IView view, Forma f)
        {
            this.f = f;
            this.view = view;
            view.UPLoadForm2 += View_UPLoadForm2;
            view.UPLoadForm3 += View_UPLoadForm3;
            view.UPLoadForm4 += View_UPLoadForm4;
            view.UPLoadForm5 += View_UPLoadForm5;
            view.UPLoadForm6 += View_UPLoadForm6;
            view.UPLoadForm7 += View_UPLoadForm7;
            view.UPLoadForm8 += View_UPLoadForm8;

            view.GetUczelnie += View_GetUczelnie;
            view.GetKierunki += View_GetKierunki;
            view.GetTechnologie += View_GetTechnologie;
        }

        private void View_GetTechnologie()
        {
            view.Technologie = f.GetTechnologie();
        }

        private void View_GetKierunki()
        {
            view.Kierunki = f.GetKierunki();
        }

        private void View_GetUczelnie()
        {
            view.Uczelnie = f.GetUczelnie();
        }

        private void View_UPLoadForm8(string zainteresowania, string infodlarekrutera)
        {
            f.Form8(zainteresowania, infodlarekrutera);
        }

        private void View_UPLoadForm7(string prefstanowisko, string prefoddzial, string prefczaspracy
            , string wynagrodzenie, string pracaodkiedy, string skadwiesz)
        {
            f.Form7(prefstanowisko, prefoddzial, prefczaspracy
            , wynagrodzenie, pracaodkiedy, skadwiesz);
        }

        private void View_UPLoadForm6(string technologie, string linki)
        {
            f.Form6(technologie, linki);
        }

        private void View_UPLoadForm5(string nazwa, string stanowisko, string data_od, string data_do)
        {
            f.Form5(nazwa, stanowisko, data_od, data_do);
        }

        private void View_UPLoadForm4(string jezyki)
        {
            f.Form4(jezyki);
        }

        private void View_UPLoadForm3(string nazwauczelni, string kierunek
            , string trybstudiow, string tytzawodowy, string d_roz_studiow, string d_zak_studiow)
        {
            f.Form3(nazwauczelni, kierunek, trybstudiow, tytzawodowy, d_roz_studiow, d_zak_studiow);
        }

        private void View_UPLoadForm2(string imie, string drugie, string nazwisko, string data_urodzenia, string email
            , string telefon, string adres, string zdjecie)
        {
            f.Form2(imie, drugie, nazwisko, data_urodzenia, email, telefon, adres, zdjecie);
        }
    }
}
