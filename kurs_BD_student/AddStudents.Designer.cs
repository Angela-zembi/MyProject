namespace kurs_BD_student
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxBSurname = new System.Windows.Forms.TextBox();
            this.TxBName = new System.Windows.Forms.TextBox();
            this.TxBPatronymic = new System.Windows.Forms.TextBox();
            this.TxBNationality = new System.Windows.Forms.TextBox();
            this.BtAddStudent = new System.Windows.Forms.Button();
            this.BtClear = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            this.CBVuz = new System.Windows.Forms.ComboBox();
            this.CBAddresses = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Додаваня студента у таблицю";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(73, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Прізвище:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(112, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ім\'я:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(46, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "По-батькові:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(20, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Національність:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(103, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "ВУЗу:";
            // 
            // TxBSurname
            // 
            this.TxBSurname.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxBSurname.Location = new System.Drawing.Point(163, 38);
            this.TxBSurname.MaxLength = 15;
            this.TxBSurname.Name = "TxBSurname";
            this.TxBSurname.Size = new System.Drawing.Size(216, 29);
            this.TxBSurname.TabIndex = 13;
            this.TxBSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxBSurname_KeyPress);
            // 
            // TxBName
            // 
            this.TxBName.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxBName.Location = new System.Drawing.Point(163, 67);
            this.TxBName.MaxLength = 15;
            this.TxBName.Name = "TxBName";
            this.TxBName.Size = new System.Drawing.Size(216, 29);
            this.TxBName.TabIndex = 14;
            this.TxBName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxBName_KeyPress);
            // 
            // TxBPatronymic
            // 
            this.TxBPatronymic.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxBPatronymic.Location = new System.Drawing.Point(163, 96);
            this.TxBPatronymic.MaxLength = 15;
            this.TxBPatronymic.Name = "TxBPatronymic";
            this.TxBPatronymic.Size = new System.Drawing.Size(216, 29);
            this.TxBPatronymic.TabIndex = 15;
            this.TxBPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxBPatronymic_KeyPress);
            // 
            // TxBNationality
            // 
            this.TxBNationality.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxBNationality.Location = new System.Drawing.Point(163, 142);
            this.TxBNationality.MaxLength = 15;
            this.TxBNationality.Name = "TxBNationality";
            this.TxBNationality.Size = new System.Drawing.Size(148, 29);
            this.TxBNationality.TabIndex = 16;
            this.TxBNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxBNationality_KeyPress);
            // 
            // BtAddStudent
            // 
            this.BtAddStudent.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtAddStudent.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtAddStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtAddStudent.Location = new System.Drawing.Point(50, 259);
            this.BtAddStudent.Name = "BtAddStudent";
            this.BtAddStudent.Size = new System.Drawing.Size(124, 40);
            this.BtAddStudent.TabIndex = 24;
            this.BtAddStudent.Text = "Додати";
            this.BtAddStudent.UseVisualStyleBackColor = false;
            this.BtAddStudent.Click += new System.EventHandler(this.BtAddStudent_Click);
            // 
            // BtClear
            // 
            this.BtClear.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtClear.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtClear.Location = new System.Drawing.Point(202, 259);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(124, 40);
            this.BtClear.TabIndex = 25;
            this.BtClear.Text = "Скасувати";
            this.BtClear.UseVisualStyleBackColor = false;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // BtClose
            // 
            this.BtClose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtClose.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtClose.Image = ((System.Drawing.Image)(resources.GetObject("BtClose.Image")));
            this.BtClose.Location = new System.Drawing.Point(332, 259);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(47, 40);
            this.BtClose.TabIndex = 26;
            this.BtClose.UseVisualStyleBackColor = false;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // CBVuz
            // 
            this.CBVuz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBVuz.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBVuz.FormattingEnabled = true;
            this.CBVuz.Location = new System.Drawing.Point(163, 179);
            this.CBVuz.Name = "CBVuz";
            this.CBVuz.Size = new System.Drawing.Size(148, 28);
            this.CBVuz.TabIndex = 27;
            // 
            // CBAddresses
            // 
            this.CBAddresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAddresses.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBAddresses.FormattingEnabled = true;
            this.CBAddresses.Location = new System.Drawing.Point(77, 213);
            this.CBAddresses.Name = "CBAddresses";
            this.CBAddresses.Size = new System.Drawing.Size(364, 28);
            this.CBAddresses.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(5, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Адреса:";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(449, 307);
            this.ControlBox = false;
            this.Controls.Add(this.CBAddresses);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBVuz);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.BtClear);
            this.Controls.Add(this.BtAddStudent);
            this.Controls.Add(this.TxBNationality);
            this.Controls.Add(this.TxBPatronymic);
            this.Controls.Add(this.TxBName);
            this.Controls.Add(this.TxBSurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddStudents_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddStudents_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddStudents_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddStudents_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxBSurname;
        private System.Windows.Forms.TextBox TxBName;
        private System.Windows.Forms.TextBox TxBPatronymic;
        private System.Windows.Forms.TextBox TxBNationality;
        private System.Windows.Forms.Button BtAddStudent;
        private System.Windows.Forms.Button BtClear;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.ComboBox CBVuz;
        private System.Windows.Forms.ComboBox CBAddresses;
        private System.Windows.Forms.Label label7;
    }
}