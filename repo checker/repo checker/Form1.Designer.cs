namespace repo_checker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.showRepositoriesButton = new System.Windows.Forms.Button();
            this.saveCurrentRepositoryButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.repositoriesListBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.commitedInfoListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.commitsListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.справкаToolStripMenuItem1.Text = "Справка";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Controls.Add(this.showRepositoriesButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите логин пользователя";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.Location = new System.Drawing.Point(6, 18);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(296, 20);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // showRepositoriesButton
            // 
            this.showRepositoriesButton.Location = new System.Drawing.Point(6, 45);
            this.showRepositoriesButton.Name = "showRepositoriesButton";
            this.showRepositoriesButton.Size = new System.Drawing.Size(296, 33);
            this.showRepositoriesButton.TabIndex = 0;
            this.showRepositoriesButton.Text = "Показать репозитории";
            this.showRepositoriesButton.UseVisualStyleBackColor = true;
            this.showRepositoriesButton.Click += new System.EventHandler(this.showRepositoriesButton_Click);
            // 
            // saveCurrentRepositoryButton
            // 
            this.saveCurrentRepositoryButton.Location = new System.Drawing.Point(373, 363);
            this.saveCurrentRepositoryButton.Name = "saveCurrentRepositoryButton";
            this.saveCurrentRepositoryButton.Size = new System.Drawing.Size(306, 33);
            this.saveCurrentRepositoryButton.TabIndex = 0;
            this.saveCurrentRepositoryButton.Text = "Сохранить выбранный репозиторий";
            this.saveCurrentRepositoryButton.UseVisualStyleBackColor = true;
            this.saveCurrentRepositoryButton.Click += new System.EventHandler(this.saveCurrentRepository_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.repositoriesListBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 124);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список репозиториев";
            // 
            // repositoriesListBox
            // 
            this.repositoriesListBox.FormattingEnabled = true;
            this.repositoriesListBox.Location = new System.Drawing.Point(6, 14);
            this.repositoriesListBox.Name = "repositoriesListBox";
            this.repositoriesListBox.Size = new System.Drawing.Size(300, 95);
            this.repositoriesListBox.TabIndex = 0;
            this.repositoriesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.repositoriesListBox_MouseDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.commitedInfoListBox);
            this.groupBox4.Location = new System.Drawing.Point(330, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(414, 317);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Информация репозитория";
            // 
            // commitedInfoListBox
            // 
            this.commitedInfoListBox.FormattingEnabled = true;
            this.commitedInfoListBox.Location = new System.Drawing.Point(6, 19);
            this.commitedInfoListBox.Name = "commitedInfoListBox";
            this.commitedInfoListBox.Size = new System.Drawing.Size(402, 290);
            this.commitedInfoListBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.commitsListBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 141);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Список коммитов";
            // 
            // commitsListBox
            // 
            this.commitsListBox.FormattingEnabled = true;
            this.commitsListBox.Location = new System.Drawing.Point(6, 19);
            this.commitsListBox.Name = "commitsListBox";
            this.commitsListBox.Size = new System.Drawing.Size(300, 108);
            this.commitsListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 408);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.saveCurrentRepositoryButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RepoChecker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button showRepositoriesButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox repositoriesListBox;
        private System.Windows.Forms.Button saveCurrentRepositoryButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox commitedInfoListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox commitsListBox;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
    }
}

