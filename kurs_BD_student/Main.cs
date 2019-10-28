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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection ConForm = new Connection();
            ConForm.ShowDialog();
            MainForm_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tables TabForm = new Tables();
            TabForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Otchety OForm = new Otchety();
            OForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddStudent AddForm = new AddStudent();
            AddForm.ShowDialog();
        }


        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location =
                    Point.Add(lastForm, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void BtVuz_Click(object sender, EventArgs e)
        {
            AddVUZ AV = new AddVUZ();
            AV.ShowDialog();
        }

        private void BtResidence_Click(object sender, EventArgs e)
        {
            AddAddresses AD = new AddAddresses();
            AD.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string ConnectingString = Properties.Settings.Default.BD;
                SqlConnection conn = new SqlConnection(ConnectingString);
                conn.Open();
                button1.Visible = false;
                button2.Enabled = true;
                button3.Enabled = true;
                BtResidence.Enabled = true;
                BtVuz.Enabled = true;
                button4.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Підключіть базу даних до програми щоб продовжити роботу з програмою.", "Помилка");
            }
        }
    }
}
