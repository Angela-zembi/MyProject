namespace kurs_BD_student
{
    partial class Tables
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tables));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dGVStudent = new System.Windows.Forms.DataGridView();
            this.GBSearchStudent = new System.Windows.Forms.GroupBox();
            this.RBName = new System.Windows.Forms.RadioButton();
            this.RBSurname = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GBSortStudent = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dGVAddresses = new System.Windows.Forms.DataGridView();
            this.GBSearchAddress = new System.Windows.Forms.GroupBox();
            this.RBRegion = new System.Windows.Forms.RadioButton();
            this.RBContry = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GBSortAddress = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dGVVuz = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дадатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиАдресуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиВУЗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звітиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розмірВікнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наВесьЕкранToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звичайнийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudent)).BeginInit();
            this.GBSearchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GBSortStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAddresses)).BeginInit();
            this.GBSearchAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.GBSortAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVuz)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage1.Controls.Add(this.dGVStudent);
            this.tabPage1.Controls.Add(this.GBSearchStudent);
            this.tabPage1.Controls.Add(this.GBSortStudent);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(869, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Студенти";
            // 
            // dGVStudent
            // 
            this.dGVStudent.BackgroundColor = System.Drawing.Color.White;
            this.dGVStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVStudent.Location = new System.Drawing.Point(3, 3);
            this.dGVStudent.Name = "dGVStudent";
            this.dGVStudent.Size = new System.Drawing.Size(863, 337);
            this.dGVStudent.TabIndex = 0;
            // 
            // GBSearchStudent
            // 
            this.GBSearchStudent.Controls.Add(this.RBName);
            this.GBSearchStudent.Controls.Add(this.RBSurname);
            this.GBSearchStudent.Controls.Add(this.label1);
            this.GBSearchStudent.Controls.Add(this.textBox1);
            this.GBSearchStudent.Controls.Add(this.pictureBox2);
            this.GBSearchStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GBSearchStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.GBSearchStudent.Location = new System.Drawing.Point(3, 340);
            this.GBSearchStudent.Name = "GBSearchStudent";
            this.GBSearchStudent.Size = new System.Drawing.Size(863, 49);
            this.GBSearchStudent.TabIndex = 9;
            this.GBSearchStudent.TabStop = false;
            this.GBSearchStudent.Text = "Поиск";
            // 
            // RBName
            // 
            this.RBName.AutoSize = true;
            this.RBName.Dock = System.Windows.Forms.DockStyle.Left;
            this.RBName.Location = new System.Drawing.Point(630, 21);
            this.RBName.Name = "RBName";
            this.RBName.Size = new System.Drawing.Size(65, 25);
            this.RBName.TabIndex = 7;
            this.RBName.Text = "ім\'ям";
            this.RBName.UseVisualStyleBackColor = true;
            // 
            // RBSurname
            // 
            this.RBSurname.AutoSize = true;
            this.RBSurname.Checked = true;
            this.RBSurname.Dock = System.Windows.Forms.DockStyle.Left;
            this.RBSurname.Location = new System.Drawing.Point(531, 21);
            this.RBSurname.Name = "RBSurname";
            this.RBSurname.Size = new System.Drawing.Size(99, 25);
            this.RBSurname.TabIndex = 6;
            this.RBSurname.TabStop = true;
            this.RBSurname.Text = "прізвищем";
            this.RBSurname.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(443, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "пошук за:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(193, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(3, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 25);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // GBSortStudent
            // 
            this.GBSortStudent.Controls.Add(this.radioButton1);
            this.GBSortStudent.Controls.Add(this.radioButton2);
            this.GBSortStudent.Controls.Add(this.radioButton3);
            this.GBSortStudent.Controls.Add(this.pictureBox1);
            this.GBSortStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GBSortStudent.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GBSortStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.GBSortStudent.Location = new System.Drawing.Point(3, 389);
            this.GBSortStudent.Name = "GBSortStudent";
            this.GBSortStudent.Size = new System.Drawing.Size(863, 47);
            this.GBSortStudent.TabIndex = 3;
            this.GBSortStudent.TabStop = false;
            this.GBSortStudent.Text = "Сортування:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton1.Location = new System.Drawing.Point(355, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(140, 23);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "по номеру ВУЗу";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton2.Location = new System.Drawing.Point(206, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(149, 23);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "по національності";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton3.Location = new System.Drawing.Point(97, 21);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(109, 23);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "по прізвищу";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(3, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 23);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.Controls.Add(this.dGVAddresses);
            this.tabPage2.Controls.Add(this.GBSearchAddress);
            this.tabPage2.Controls.Add(this.GBSortAddress);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(869, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Адреси";
            // 
            // dGVAddresses
            // 
            this.dGVAddresses.BackgroundColor = System.Drawing.Color.White;
            this.dGVAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVAddresses.Location = new System.Drawing.Point(3, 3);
            this.dGVAddresses.Name = "dGVAddresses";
            this.dGVAddresses.Size = new System.Drawing.Size(863, 337);
            this.dGVAddresses.TabIndex = 0;
            // 
            // GBSearchAddress
            // 
            this.GBSearchAddress.Controls.Add(this.RBRegion);
            this.GBSearchAddress.Controls.Add(this.RBContry);
            this.GBSearchAddress.Controls.Add(this.label2);
            this.GBSearchAddress.Controls.Add(this.textBox2);
            this.GBSearchAddress.Controls.Add(this.pictureBox3);
            this.GBSearchAddress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GBSearchAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.GBSearchAddress.Location = new System.Drawing.Point(3, 340);
            this.GBSearchAddress.Name = "GBSearchAddress";
            this.GBSearchAddress.Size = new System.Drawing.Size(863, 49);
            this.GBSearchAddress.TabIndex = 11;
            this.GBSearchAddress.TabStop = false;
            this.GBSearchAddress.Text = "Поиск";
            // 
            // RBRegion
            // 
            this.RBRegion.AutoSize = true;
            this.RBRegion.Dock = System.Windows.Forms.DockStyle.Left;
            this.RBRegion.Location = new System.Drawing.Point(615, 21);
            this.RBRegion.Name = "RBRegion";
            this.RBRegion.Size = new System.Drawing.Size(86, 25);
            this.RBRegion.TabIndex = 7;
            this.RBRegion.Text = "Регіоном";
            this.RBRegion.UseVisualStyleBackColor = true;
            // 
            // RBContry
            // 
            this.RBContry.AutoSize = true;
            this.RBContry.Checked = true;
            this.RBContry.Dock = System.Windows.Forms.DockStyle.Left;
            this.RBContry.Location = new System.Drawing.Point(531, 21);
            this.RBContry.Name = "RBContry";
            this.RBContry.Size = new System.Drawing.Size(84, 25);
            this.RBContry.TabIndex = 6;
            this.RBContry.TabStop = true;
            this.RBContry.Text = "Країною";
            this.RBContry.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(443, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "пошук за:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(193, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 25);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Location = new System.Drawing.Point(3, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(190, 25);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // GBSortAddress
            // 
            this.GBSortAddress.Controls.Add(this.radioButton9);
            this.GBSortAddress.Controls.Add(this.radioButton10);
            this.GBSortAddress.Controls.Add(this.pictureBox4);
            this.GBSortAddress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GBSortAddress.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GBSortAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.GBSortAddress.Location = new System.Drawing.Point(3, 389);
            this.GBSortAddress.Name = "GBSortAddress";
            this.GBSortAddress.Size = new System.Drawing.Size(863, 47);
            this.GBSortAddress.TabIndex = 10;
            this.GBSortAddress.TabStop = false;
            this.GBSortAddress.Text = "Сортування:";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton9.Location = new System.Drawing.Point(184, 21);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(95, 23);
            this.radioButton9.TabIndex = 4;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "по регіону";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton10.Location = new System.Drawing.Point(97, 21);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(87, 23);
            this.radioButton10.TabIndex = 5;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "по країні";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Location = new System.Drawing.Point(3, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(94, 23);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage3.Controls.Add(this.dGVVuz);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(869, 439);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ВУЗи";
            // 
            // dGVVuz
            // 
            this.dGVVuz.BackgroundColor = System.Drawing.Color.White;
            this.dGVVuz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVVuz.Location = new System.Drawing.Point(3, 3);
            this.dGVVuz.Name = "dGVVuz";
            this.dGVVuz.Size = new System.Drawing.Size(385, 433);
            this.dGVVuz.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.дадатиToolStripMenuItem,
            this.звітиToolStripMenuItem,
            this.розмірВікнаToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиToolStripMenuItem,
            this.пошукToolStripMenuItem,
            this.сортуванняToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(54, 27);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // пошукToolStripMenuItem
            // 
            this.пошукToolStripMenuItem.Checked = true;
            this.пошукToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.пошукToolStripMenuItem.Name = "пошукToolStripMenuItem";
            this.пошукToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.пошукToolStripMenuItem.Text = "Пошук";
            this.пошукToolStripMenuItem.Click += new System.EventHandler(this.пошукToolStripMenuItem_Click);
            // 
            // сортуванняToolStripMenuItem
            // 
            this.сортуванняToolStripMenuItem.Checked = true;
            this.сортуванняToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.сортуванняToolStripMenuItem.Name = "сортуванняToolStripMenuItem";
            this.сортуванняToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.сортуванняToolStripMenuItem.Text = "Сортування";
            this.сортуванняToolStripMenuItem.Click += new System.EventHandler(this.сортуванняToolStripMenuItem_Click);
            // 
            // дадатиToolStripMenuItem
            // 
            this.дадатиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиАдресуToolStripMenuItem,
            this.додатиВУЗToolStripMenuItem,
            this.додатиСтудентаToolStripMenuItem});
            this.дадатиToolStripMenuItem.Name = "дадатиToolStripMenuItem";
            this.дадатиToolStripMenuItem.Size = new System.Drawing.Size(121, 27);
            this.дадатиToolStripMenuItem.Text = "Дадати нові дані";
            // 
            // додатиАдресуToolStripMenuItem
            // 
            this.додатиАдресуToolStripMenuItem.Name = "додатиАдресуToolStripMenuItem";
            this.додатиАдресуToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.додатиАдресуToolStripMenuItem.Text = "Додати адресу";
            this.додатиАдресуToolStripMenuItem.Click += new System.EventHandler(this.додатиАдресуToolStripMenuItem_Click);
            // 
            // додатиВУЗToolStripMenuItem
            // 
            this.додатиВУЗToolStripMenuItem.Name = "додатиВУЗToolStripMenuItem";
            this.додатиВУЗToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.додатиВУЗToolStripMenuItem.Text = "Додати ВУЗ";
            this.додатиВУЗToolStripMenuItem.Click += new System.EventHandler(this.додатиВУЗToolStripMenuItem_Click);
            // 
            // додатиСтудентаToolStripMenuItem
            // 
            this.додатиСтудентаToolStripMenuItem.Name = "додатиСтудентаToolStripMenuItem";
            this.додатиСтудентаToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.додатиСтудентаToolStripMenuItem.Text = "Додати Студента";
            this.додатиСтудентаToolStripMenuItem.Click += new System.EventHandler(this.додатиСтудентаToolStripMenuItem_Click);
            // 
            // звітиToolStripMenuItem
            // 
            this.звітиToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.звітиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("звітиToolStripMenuItem.Image")));
            this.звітиToolStripMenuItem.Name = "звітиToolStripMenuItem";
            this.звітиToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.звітиToolStripMenuItem.Text = "Звіти";
            this.звітиToolStripMenuItem.Click += new System.EventHandler(this.звітиToolStripMenuItem_Click);
            // 
            // розмірВікнаToolStripMenuItem
            // 
            this.розмірВікнаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наВесьЕкранToolStripMenuItem,
            this.звичайнийToolStripMenuItem});
            this.розмірВікнаToolStripMenuItem.Name = "розмірВікнаToolStripMenuItem";
            this.розмірВікнаToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.розмірВікнаToolStripMenuItem.Text = "Розмір вікна";
            // 
            // наВесьЕкранToolStripMenuItem
            // 
            this.наВесьЕкранToolStripMenuItem.Name = "наВесьЕкранToolStripMenuItem";
            this.наВесьЕкранToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.наВесьЕкранToolStripMenuItem.Text = "На весь екран";
            this.наВесьЕкранToolStripMenuItem.Click += new System.EventHandler(this.наВесьЕкранToolStripMenuItem_Click);
            // 
            // звичайнийToolStripMenuItem
            // 
            this.звичайнийToolStripMenuItem.Checked = true;
            this.звичайнийToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.звичайнийToolStripMenuItem.Name = "звичайнийToolStripMenuItem";
            this.звичайнийToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.звичайнийToolStripMenuItem.Text = "Звичайний";
            this.звичайнийToolStripMenuItem.Click += new System.EventHandler(this.звичайнийToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(60, 27);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(877, 501);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Tables_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tables_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tables_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tables_MouseUp);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudent)).EndInit();
            this.GBSearchStudent.ResumeLayout(false);
            this.GBSearchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GBSortStudent.ResumeLayout(false);
            this.GBSortStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAddresses)).EndInit();
            this.GBSearchAddress.ResumeLayout(false);
            this.GBSearchAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.GBSortAddress.ResumeLayout(false);
            this.GBSortAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVVuz)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox GBSortStudent;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dGVStudent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dGVAddresses;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dGVVuz;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem звітиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розмірВікнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наВесьЕкранToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem звичайнийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дадатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиАдресуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиВУЗToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиСтудентаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GBSearchStudent;
        private System.Windows.Forms.RadioButton RBName;
        private System.Windows.Forms.RadioButton RBSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox GBSearchAddress;
        private System.Windows.Forms.RadioButton RBRegion;
        private System.Windows.Forms.RadioButton RBContry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox GBSortAddress;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}