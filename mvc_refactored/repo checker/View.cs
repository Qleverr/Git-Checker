using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repo_checker
{
    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);

    public class ViewEventArgs : EventArgs
    {
        public int repository_name;
        public ViewEventArgs(int v) { repository_name = v; }
    }

    public interface IView
    {
        event ViewHandler<IView> changed;
        void setController(IController cont);
    }
}
