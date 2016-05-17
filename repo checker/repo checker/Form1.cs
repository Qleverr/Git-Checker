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
        public event UserEventHandler PrintCommitedChanges;
        public event UserEventHandler SaveZip;

        public Form1()
        {
            InitializeComponent();
        }

        public string GetUsername()
        {
            return this.usernameTextBox.Text.ToString();
        }

        public ListBox GetRepositoriesListBox()
        {
            return this.repositoriesListBox;
        }

        public ListBox GetCommitedInfoListBox()
        {
            return this.commitedInfoListBox;
        }

        public ListBox GetCommitsListBox()
        {
            return this.commitsListBox;
        }

        public void ClearAllListBoxes()
        {
            this.repositoriesListBox.Items.Clear();
            this.commitsListBox.Items.Clear();
            this.commitedInfoListBox.Items.Clear();
        }

        private void showRepositoriesButton_Click(object sender, EventArgs e)
        {
            PrintRepositoriesByUser();
        }

        private void repositoriesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PrintRepositoryCommits();
        }

        private void commitsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PrintCommitedChanges();
        }

        private void saveCurrentRepository_Click(object sender, EventArgs e)
        {
            SaveZip();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
