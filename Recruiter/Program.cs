using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Recruiter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Model model = new Model();
            IView view = new View();
            Presenter presenter = new Presenter(view, model);
            Application.Run((View)view);
        }
    }
}
