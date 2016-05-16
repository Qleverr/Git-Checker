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
//using System.Reactive.Linq;

namespace repo_checker
{
    public partial class Form1 : Form
    {
        public delegate void UserEventHandler();
        public event UserEventHandler PrintRepositoriesByUser;
        //public event UserEventHandler OpenFile;
        //public event UserEventHandler CreateFile;
        public IReadOnlyList<Repository> repositories;
        public GitHubClient client;
        public Uri ghe = new Uri("https://github.com/");

        public Form1()
        {
            InitializeComponent();
        }

        public string GetUsername()
        {
            return this.usernameTextBox.Text.ToString();
        }

        public ListBox GetUserRepositoriesListBox()
        {
            return this.usersRepositoriesListBox;
        }

        private void showRepositoriesButton_Click(object sender, EventArgs e)
        {
            PrintRepositoriesByUser();
        }

        private async void showUserInfo_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            client = new GitHubClient(new ProductHeaderValue(usernameTextBox.Text), ghe);

            var user = await client.User.Get(usernameTextBox.Text);

            listBox2.Items.Add("Name: " + user.Name);
            listBox2.Items.Add("Email: " + user.Email);
        }

        private async void usersRepositoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            var rep = repositories[usersRepositoriesListBox.SelectedIndex];
            var commits = await client.Repository.Commits.GetAll(rep.Owner.Login, rep.Name);

            listBox3.Items.Add("Репозиторий: " + rep.Name);
            listBox3.Items.Add("");

            foreach (var c in commits)
            {
                listBox3.Items.Add("Коммитер: " + c.Committer.Login + ", время: " + c.Commit.Author.Date.ToString());
                listBox3.Items.Add("Изменения: " + c.Commit.Message);
            }
        }
    }
}
