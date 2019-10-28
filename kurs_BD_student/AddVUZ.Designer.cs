namespace kurs_BD_student
{
    partial class AddVUZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVUZ));
            this.TxBNameVuz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtClose = new System.Windows.Forms.Button();
            this.BtClear = new System.Windows.Forms.Button();
            this.BtAddVuz = new System.Windows.Forms.Button();
            this.RBTrue = new System.Windows.Forms.RadioButton();
            this.RBFalse = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TxBNameVuz
            // 
            this.TxBNameVuz.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxBNameVuz.Location = new System.Drawing.Point(154, 39);
            this.TxBNameVuz.MaxLength = 50;
            this.TxBNameVuz.Name = "TxBNameVuz";
            this.TxBNameVuz.Size = new System.Drawing.Size(178, 29);
            this.TxBNameVuz.TabIndex = 24;
            this.TxBNameVuz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxBNameVuz_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(5, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Підготовчі курси:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Название вуза:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Додаваня вуза у таблицю";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtClose
            // 
            this.BtClose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtClose.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtClose.Image = ((System.Drawing.Image)(resources.GetObject("BtClose.Image")));
            this.BtClose.Location = new System.Drawing.Point(288, 111);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(47, 40);
            this.BtClose.TabIndex = 29;
            this.BtClose.UseVisualStyleBackColor = false;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // BtClear
            // 
            this.BtClear.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtClear.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtClear.Location = new System.Drawing.Point(157, 111);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(124, 40);
            this.BtClear.TabIndex = 28;
            this.BtClear.Text = "Скасувати";
            this.BtClear.UseVisualStyleBackColor = false;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // BtAddVuz
            // 
            this.BtAddVuz.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtAddVuz.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtAddVuz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtAddVuz.Location = new System.Drawing.Point(27, 111);
            this.BtAddVuz.Name = "BtAddVuz";
            this.BtAddVuz.Size = new System.Drawing.Size(124, 40);
            this.BtAddVuz.TabIndex = 27;
            this.BtAddVuz.Text = "Додати";
            this.BtAddVuz.UseVisualStyleBackColor = false;
            this.BtAddVuz.Click += new System.EventHandler(this.BtAddVuz_Click);
            // 
            // RBTrue
            // 
            this.RBTrue.AutoSize = true;
            this.RBTrue.Checked = true;
            this.RBTrue.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RBTrue.ForeColor = System.Drawing.SystemColors.Control;
            this.RBTrue.Location = new System.Drawing.Point(169, 74);
            this.RBTrue.Name = "RBTrue";
            this.RBTrue.Size = new System.Drawing.Size(56, 25);
            this.RBTrue.TabIndex = 30;
            this.RBTrue.TabStop = true;
            this.RBTrue.Text = "Так";
            this.RBTrue.UseVisualStyleBackColor = true;
            // 
            // RBFalse
            // 
            this.RBFalse.AutoSize = true;
            this.RBFalse.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RBFalse.ForeColor = System.Drawing.SystemColors.Control;
            this.RBFalse.Location = new System.Drawing.Point(242, 74);
            this.RBFalse.Name = "RBFalse";
            this.RBFalse.Size = new System.Drawing.Size(45, 25);
            this.RBFalse.TabIndex = 31;
            this.RBFalse.Text = "Ні";
            this.RBFalse.UseVisualStyleBackColor = true;
            // 
            // AddVUZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(347, 163);
            this.ControlBox = false;
            this.Controls.Add(this.RBFalse);
            this.Controls.Add(this.RBTrue);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.BtClear);
            this.Controls.Add(this.BtAddVuz);
            this.Controls.Add(this.TxBNameVuz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVUZ";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddVUZ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxBNameVuz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.Button BtClear;
        private System.Windows.Forms.Button BtAddVuz;
        private System.Windows.Forms.RadioButton RBTrue;
        private System.Windows.Forms.RadioButton RBFalse;
    }
}