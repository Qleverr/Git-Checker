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
            this.новыйРепозиторийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.существующийРепозиторийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.showRepositoriesButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.usersRepositoriesListBox = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйРепозиторийToolStripMenuItem,
            this.существующийРепозиторийToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // новыйРепозиторийToolStripMenuItem
            // 
            this.новыйРепозиторийToolStripMenuItem.Name = "новыйРепозиторийToolStripMenuItem";
            this.новыйРепозиторийToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.новыйРепозиторийToolStripMenuItem.Text = "Новый репозиторий...";
            // 
            // существующийРепозиторийToolStripMenuItem
            // 
            this.существующийРепозиторийToolStripMenuItem.Name = "существующийРепозиторийToolStripMenuItem";
            this.существующийРепозиторийToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.существующийРепозиторийToolStripMenuItem.Text = "Существующий репозиторий...";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Controls.Add(this.showRepositoriesButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите логин пользователя";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "Сохранить выбранный репозиторий";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(6, 18);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(300, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // showRepositoriesButton
            // 
            this.showRepositoriesButton.Location = new System.Drawing.Point(162, 44);
            this.showRepositoriesButton.Name = "showRepositoriesButton";
            this.showRepositoriesButton.Size = new System.Drawing.Size(144, 33);
            this.showRepositoriesButton.TabIndex = 0;
            this.showRepositoriesButton.Text = "Показать репозитории";
            this.showRepositoriesButton.UseVisualStyleBackColor = true;
            this.showRepositoriesButton.Click += new System.EventHandler(this.showRepositoriesButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.usersRepositoriesListBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 122);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список репозиториев";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(6, 19);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(300, 95);
            this.listBox3.TabIndex = 5;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // usersRepositoriesListBox
            // 
            this.usersRepositoriesListBox.FormattingEnabled = true;
            this.usersRepositoriesListBox.Location = new System.Drawing.Point(6, 20);
            this.usersRepositoriesListBox.Name = "usersRepositoriesListBox";
            this.usersRepositoriesListBox.Size = new System.Drawing.Size(300, 95);
            this.usersRepositoriesListBox.TabIndex = 0;
            this.usersRepositoriesListBox.SelectedIndexChanged += new System.EventHandler(this.usersRepositoriesListBox_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(300, 277);
            this.listBox2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Location = new System.Drawing.Point(330, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 303);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Информация о коммите";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Location = new System.Drawing.Point(12, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 122);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Список коммитов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 391);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.ToolStripMenuItem новыйРепозиторийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem существующийРепозиторийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button showRepositoriesButton;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListBox usersRepositoriesListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

