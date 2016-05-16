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
using System.Net;
using Octokit.Helpers;
using Octokit.Internal;

namespace repo_checker
{
    class Controller
    {
        private Form1 _view;
        public IReadOnlyList<Repository> repositories;
        public GitHubClient client;
        public Uri ghe = new Uri("https://github.com/");

        public Controller(Form1 view)
        {
            this._view = view;
            this._view.PrintRepositoriesByUser += GetRepositoriesByUser;
            this._view.PrintRepositoryCommits += GetRepositoryCommits;
            this._view.SaveZip += Save;
        }

        private async void GetRepositoriesByUser()
        {
            client = new GitHubClient(new ProductHeaderValue(_view.GetUsername()), ghe);
            repositories = await client.Repository.GetAllForUser(_view.GetUsername());

            foreach (var r in repositories)
            {
                _view.GetUserRepositoriesListBox().Items.Add(r.Name);
            }
        }

        private async void Save()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowserDialog.ShowDialog();

            var rep = repositories[this._view.GetUserRepositoriesListBox().SelectedIndex];
            var commits = await client.Repository.Commits.GetAll(rep.Owner.Login, rep.Name);

            var releases = await client.Release.GetAll(rep.Owner.Login, rep.Name);

            var wc = new WebClient();
            wc.DownloadFile(ghe + _view.GetUsername() + "/" + rep.Name + "/archive/master.zip", folderBrowserDialog.SelectedPath + "/" + rep.Name + ".zip");
        }

        //private async void GetRepositoryInfo()
        //{
        //    var client = new GitHubClient(new ProductHeaderValue(_view.GetUsername()), new Uri("https://github.com/"));
        //    var repositories = await client.Repository.GetAllForUser(_view.GetUsername());

        //    var rep = repositories[_view.GetUserRepositoriesListBox().SelectedIndex];
        //    var content = await client.Repository.Content.GetAllContents(rep.Owner.Login, rep.Name);

        //    foreach (var element in content)
        //    {
        //        _view.GetRepositoryInfoListBox().Items.Add(element.Content.ToString());
        //    }
        //}

        private async void GetRepositoryCommits()
        {
            ListBox commitsListBox = _view.GetCommitsListBox();

            commitsListBox.Items.Clear();
            var rep = repositories[_view.GetUserRepositoriesListBox().SelectedIndex];
            var commits = await client.Repository.Commits.GetAll(rep.Owner.Login, rep.Name);

            foreach (var c in commits)
            {
                commitsListBox.Items.Add("Commit: " + c.Commit.Message);
                commitsListBox.Items.Add("Posted by: " + c.Committer.Login);
                commitsListBox.Items.Add("Date: " + c.Commit.Author.Date.ToString());
                commitsListBox.Items.Add("");
            }
        }
    }
}

