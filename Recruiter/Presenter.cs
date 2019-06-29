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
        Model model;
        public Presenter(IView view, Model model)
        {
            this.model = model;
            this.view = view;
            //view.LoadCards += View_LoadCards;
            //view.PullCard += View_PullCard;
            //view.Stop += View_Stop;
        }
    }
}
