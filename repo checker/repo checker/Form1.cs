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
    public partial class Form1 : Form
    {
        public delegate void UserEventHandler();

        public event UserEventHandler PrintRepositoriesByUser;
        public event UserEventHandler PrintRepositoryCommits;
        public event UserEventHandler SaveZip;

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
            PrintRepositoriesByUser();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void usersRepositoriesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PrintRepositoryCommits();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveZip();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
