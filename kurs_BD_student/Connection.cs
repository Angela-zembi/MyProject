using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace kurs_BD_student
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        string filename = Properties.Settings.Default.SaveFileBD;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "E:\\";
            openFileDialog1.Filter = "Файлы mdf (*.mdf)|*.mdf";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                textBox1.Text = filename;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы не указали путь к базе данных!");
            }
            else
            {
                string connectionsStr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename="""
                    + filename + @""";Integrated Security=True;Connect Timeout=30";
                Properties.Settings.Default["BD"] = connectionsStr;
                if (checkBox1.Checked == true)
                {
                    Properties.Settings.Default.SaveFileBD = textBox1.Text;
                    Properties.Settings.Default.Save();
                }
                else if (checkBox1.Checked == false)
                {
                    Properties.Settings.Default.SaveFileBD = null;
                    Properties.Settings.Default.Save();
                }
                this.Close();
            }
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.SaveFileBD;
        }

        private void Connection_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;

            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void Connection_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location =
                    Point.Add(lastForm, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }

        private void Connection_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
