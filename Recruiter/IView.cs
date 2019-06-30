using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiter
{
    interface IView
    {

        string[] Uczelnie { get; set; }
        string[] Kierunki { get; set; }
        string[] Technologie { get; set; }

        #region Events
        event Action GetUczelnie;
        event Action GetKierunki;
        event Action GetTechnologie;

        event Action StartForm2;
        event Action StartForm3;
        event Action StartForm4;
        event Action StartForm5;
        event Action StartForm6;
        event Action StartForm7;
        event Action StartForm8;
        event Action StartForm9;

        event Action<string, string, string, string, string, string, string, string> UPLoadForm2;
        event Action<string, string, string, string> UPLoadForm3;
        event Action<string> UPLoadForm4;
        event Action<string, string, string, string> UPLoadForm5;
        event Action<string, string> UPLoadForm6;
        event Action<string, string, string, string, string, string> UPLoadForm7;
        event Action<string, string> UPLoadForm8;
        #endregion
    }
}
