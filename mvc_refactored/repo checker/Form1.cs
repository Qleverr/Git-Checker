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
    public partial class Form1 : Form, IView, IModelObserver
    {
        IController controller;
        public event ViewHandler<IView> changed;

        public void setController(IController cont)
        {
            controller = cont;
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void repository_nameFunctioned(IModel m, ModelEventArgs e)
        {
            usersRepositoriesListBox.Items.Add("Название репозитория " + e.newrepository_name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string GetUsername()
        {
            return this.usernameTextBox.Text.ToString();
        }

        public ListBox GetUserRepositoriesListBox()
        {
            return this.usersRepositoriesListBox;
        }

        public ListBox GetRepositoryInfoListBox()
        {
            return this.repositoryInfoListBox;
        }

        public ListBox GetCommitsListBox()
        {
            return this.commitsListBox;
        }

        private void showRepositoriesButton_Click(object sender, EventArgs e)
        {
            controller.model_work();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void usersRepositoriesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //PrintRepositoryCommits();
        }

        private void usersRepositoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void commitsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
