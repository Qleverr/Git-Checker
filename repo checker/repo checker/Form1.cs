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
using System.IO;

namespace repo_checker
{
    public partial class Form1 : Form
    {
        public delegate void UserEventHandler();

        public event UserEventHandler PrintRepositoriesByUser;
        public event UserEventHandler PrintRepositoryCommits;
        public event UserEventHandler PrintCommitedChanges;
        public event UserEventHandler SaveZip;
        public event UserEventHandler DeleteLogins;
        public Form1()
        {
            InitializeComponent();
            saveCurrentRepositoryButton.Enabled = false;

            loginСomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            loginСomboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            StreamReader sr = new StreamReader("login_base.txt");
            String line = sr.ReadLine();

            while (line != null)
            {
                loginСomboBox.Items.Add(line);
                line = sr.ReadLine();
            }

            sr.Close();
        }

        public string GetUsername()
        {
            string s = this.loginСomboBox.Text.ToString();

            loginСomboBox.Items.Clear();

            HashSet<string> hs = new HashSet<string>(File.ReadAllLines("login_base.txt", Encoding.GetEncoding(1251)));
            hs.Add(this.loginСomboBox.Text.ToString());

            File.WriteAllLines("login_base.txt", hs.ToArray(), Encoding.GetEncoding(1251));

            StreamReader sr = new StreamReader("login_base.txt");
            String line = sr.ReadLine();

            while (line != null)
            {
                loginСomboBox.Items.Add(line);
                line = sr.ReadLine();
            }

            sr.Close();

            return s;
        }

        public ComboBox GetLoginComboBox()
        {
            return this.loginСomboBox;
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

        public Button GetSaveButton()
        {
            return this.saveCurrentRepositoryButton;
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


        private void logincomboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PrintRepositoriesByUser();
            }
        }

        private void loginСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void удалитьБазуЛогиновToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить все логины?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteLogins();
            }
        }
    }
}
