using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repo_checker
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);

    public class ModelEventArgs : EventArgs
    {
        public int newrepository_name;

        public ModelEventArgs(int i)
        {
            newrepository_name = i;
        }
    }

    public interface IModelObserver
    {
        void repository_nameFunctioned(IModel model, ModelEventArgs e);
    }

    public interface IModel
    {
        void attach(IModelObserver imo);
        void function_repository_name();
        void setrepository_name(int i);
    }

    public class Model : IModel
    {
        public event ModelHandler<Model> changed;
        int repository_name;

        public Model()
        {
            repository_name = 0;
        }

        public void setrepository_name(int i)
        {
            repository_name = i;
        }

        public void function_repository_name()
        {
            repository_name++;
            changed.Invoke(this, new ModelEventArgs(repository_name));
        }

        public void attach(IModelObserver imo)
        {
            changed += new ModelHandler<Model>(imo.repository_nameFunctioned);
        }
    }
}
