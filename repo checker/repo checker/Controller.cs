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
using System.IO;

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
            this._view.PrintCommitedChanges += GetCommitedInfo;
            this._view.SaveZip += Save;
            this._view.DeleteLogins += DeleteBase;
        }

        private async void GetRepositoriesByUser()
        {
            _view.ClearAllListBoxes();
            _view.GetSaveButton().Enabled = false;

            if (_view.GetRepositoriesListBox().Items.Count == 0)
            {
                if (InternetIsConnected())
                {
                    try
                    { 
                      client = new GitHubClient(new ProductHeaderValue(_view.GetUsername()), ghe);
                      repositories = await client.Repository.GetAllForUser(_view.GetUsername());

                       foreach (var r in repositories)
                       {
                         _view.GetRepositoriesListBox().Items.Add(r.Name);
                       }
                    }
                    catch (Exception ex)
                    {
                       MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Нет интернет-соединения.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void Save()
        {
            var rep = repositories[this._view.GetRepositoriesListBox().SelectedIndex];
            var commits = await client.Repository.Commits.GetAll(rep.Owner.Login, rep.Name);

            var releases = await client.Release.GetAll(rep.Owner.Login, rep.Name);

            var save = new SaveFileDialog();
            save.FileName = rep.Name + ".zip";
            save.Filter = "Zip Files|*.zip;*.rar";
            var wc = new WebClient();
            if (save.ShowDialog() == DialogResult.OK)
            {
                wc.DownloadFile(ghe + _view.GetUsername() + "/" + rep.Name + "/archive/master.zip", save.FileName);
            }

            _view.GetSaveButton().Enabled = false;
        }

        private async void GetCommitedInfo()
        {
            ListBox commitsInfo = _view.GetCommitedInfoListBox();
            _view.GetSaveButton().Enabled = true;

            commitsInfo.Items.Clear();
            var rep = repositories[_view.GetRepositoriesListBox().SelectedIndex];
            string url = _view.GetCommitsListBox().SelectedItem.ToString();
            string[] getref = url.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            url = getref[7];

            try
            {
                var commit = await client.Repository.Commit.Get(rep.Owner.Login, rep.Name, url);

                foreach (var c in commit.Files)
                {
                    commitsInfo.Items.Add("Имя файла: " + c.Filename);
                    commitsInfo.Items.Add("Статус файла: " + c.Status);
                    commitsInfo.Items.Add("");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetRepositoryCommits()
        {
            ListBox commitsListBox = _view.GetCommitsListBox();
            _view.GetSaveButton().Enabled = true;

            commitsListBox.Items.Clear();
            var rep = repositories[_view.GetRepositoriesListBox().SelectedIndex];

            try
            {
                var commits = await client.Repository.Commits.GetAll(rep.Owner.Login, rep.Name);
                foreach (var c in commits)
                {
                    commitsListBox.Items.Add("Коммит: " + c.Commit.Message);
                    commitsListBox.Items.Add("Выложил: " + c.Committer.Login);
                    commitsListBox.Items.Add("Дата: " + c.Commit.Author.Date.ToString());
                    commitsListBox.Items.Add(c.Commit.Url);
                    commitsListBox.Items.Add("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool InternetIsConnected()
        {
            try
            {
                System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.github.com");
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void DeleteBase()
        {
            File.Delete("login_base.txt");
            File.Create("login_base.txt");
            _view.GetLoginComboBox().Items.Clear();
        }
    }
}

