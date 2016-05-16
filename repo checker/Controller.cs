using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;
using Octokit.Helpers;
using Octokit.Internal;

namespace repo_checker
{
    class Controller
    {
        private Form1 _view;

        public Controller(Form1 view)
        {
            this._view = view;
            this._view.PrintRepositoriesByUser += GetRepositoriesByUser;
            this._view.repositories = new List<Repository>();
        }

        private async void GetRepositoriesByUser()
        {
            var ghe = new Uri("https://github.com/");
            this._view.client = new GitHubClient(new ProductHeaderValue(_view.GetUsername()), ghe);

            this._view.repositories = await this._view.client.Repository.GetAllForUser(_view.GetUsername());

            //DateTimeOffset data;
            foreach (var repository in this._view.repositories)
            {
                _view.GetUserRepositoriesListBox().Items.Add(repository.Name);
            }
        }
        
    }
}

