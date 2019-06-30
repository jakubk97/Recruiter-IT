using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Recruiter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Forma model = Forma.Instance;
            IView view = new View();
            Presenter presenter = new Presenter(view, model);
            Application.Run((View)view);
        }
    }
}
