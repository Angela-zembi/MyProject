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
using System.Xml;

namespace kurs_BD_student
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();       
        }
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        string constr;
        DataSet ds = new DataSet();

        SqlDataAdapter StudentDataAdapter;
        SqlCommandBuilder StudentCommandBuilder;
        BindingSource StudentBindingSource = new BindingSource();

        SqlDataAdapter AddressesDataAdapter;
        SqlCommandBuilder AddressesCommandBuilder;
        BindingSource AddressesBindingSource = new BindingSource();

        SqlDataAdapter VuzDataAdapter;
        SqlCommandBuilder VuzCommandBuilder;
        BindingSource VuzBindingSource = new BindingSource();

        private void Student_Load()
        {
            StudentDataAdapter = new SqlDataAdapter("select * from  STUDENT", constr);
            StudentCommandBuilder = new SqlCommandBuilder(StudentDataAdapter);
            StudentDataAdapter.Fill(ds, "STUDENT");
            StudentBindingSource.DataSource = ds;
            StudentBindingSource.DataMember = "STUDENT";
            dGVStudent.DataSource = StudentBindingSource;
            //
            // Заголовки столбцов
            //
            dGVStudent.Columns[0].HeaderText = "Код студента";
            dGVStudent.Columns[1].HeaderText = "Прізвище";
            dGVStudent.Columns[2].HeaderText = "Ім'я";
            dGVStudent.Columns[3].HeaderText = "По батькові";
            dGVStudent.Columns[4].HeaderText = "Національність";
            dGVStudent.Columns[5].HeaderText = "Код ВУЗа";
            dGVStudent.Columns[6].HeaderText = "Код адреси";
            //
            // Размеры столбцов
            //
            dGVStudent.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVStudent.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVStudent.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVStudent.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVStudent.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void Addresses_Load()
        {
            AddressesDataAdapter = new SqlDataAdapter("select * from  ADDRESSES", constr);
            AddressesCommandBuilder = new SqlCommandBuilder(AddressesDataAdapter);
            AddressesDataAdapter.Fill(ds, "ADDRESSES");
            AddressesBindingSource.DataSource = ds;
            AddressesBindingSource.DataMember = "ADDRESSES";
            dGVAddresses.DataSource = AddressesBindingSource;
            //
            // Заголовки столбцов
            //
            dGVAddresses.Columns[0].HeaderText = "Код адреси";
            dGVAddresses.Columns[1].HeaderText = "Країна";
            dGVAddresses.Columns[2].HeaderText = "Регіон";
            dGVAddresses.Columns[3].HeaderText = "Тип поселення";
            dGVAddresses.Columns[4].HeaderText = "Назва міста";
            dGVAddresses.Columns[5].HeaderText = "Назва улиці № будинку";
            dGVAddresses.Columns[6].HeaderText = "Індекс";
            dGVAddresses.Columns[7].HeaderText = "Телефон";
            //
            // Размеры столбцов
            //
            dGVAddresses.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVAddresses.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVAddresses.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVAddresses.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVAddresses.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void Vuz_Load()
        {
            VuzDataAdapter = new SqlDataAdapter("select * from  VUZ", constr);
            VuzCommandBuilder = new SqlCommandBuilder(VuzDataAdapter);
            VuzDataAdapter.Fill(ds, "VUZ");
            VuzBindingSource.DataSource = ds;
            VuzBindingSource.DataMember = "VUZ";
            dGVVuz.DataSource = VuzBindingSource;
            //
            // Заголовки столбцов
            //
            dGVVuz.Columns[0].HeaderText = "Код ВУЗа";
            dGVVuz.Columns[1].HeaderText = "Назва ВУЗа";
            dGVVuz.Columns[2].HeaderText = "Підготовчі курси";
            //
            // Размеры столбцов
            //
            dGVVuz.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVVuz.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVVuz.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void Tables_Load(object sender, EventArgs e)
        {
            constr = Properties.Settings.Default.BD;
            Student_Load();
            Addresses_Load();
            Vuz_Load();
        }
        //
        // Переміщення форми
        //
        private void Tables_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;

            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }
        private void Tables_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location =
                    Point.Add(lastForm, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }
        private void Tables_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        //
        // Додавання нової інформації до бази
        //
        private void додатиАдресуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAddresses AA = new AddAddresses();
            AA.ShowDialog();
        }
        private void додатиВУЗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVUZ AV = new AddVUZ();
            AV.ShowDialog();
        }
        private void додатиСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent AS = new AddStudent();
            AS.ShowDialog();
        }
        //
        // Розмір вікна
        //
        private void наВесьЕкранToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (наВесьЕкранToolStripMenuItem.Checked == false)
            {
                наВесьЕкранToolStripMenuItem.Checked = true;
                звичайнийToolStripMenuItem.Checked = false;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.WindowState = FormWindowState.Maximized;                
            }
        }
        private void звичайнийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (звичайнийToolStripMenuItem.Checked == false)
            {
                наВесьЕкранToolStripMenuItem.Checked = false;
                звичайнийToolStripMenuItem.Checked = true;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.WindowState = FormWindowState.Normal;
            }
        }
        //
        // Перегляд звіту
        //
        private void звітиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otchety OForm = new Otchety();
            OForm.ShowDialog();
        }
        //
        // Закрити форму
        //
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        // Збереження
        //
        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressesDataAdapter.Update(ds.Tables["ADDRESSES"]);
            VuzDataAdapter.Update(ds.Tables["VUZ"]);
            StudentDataAdapter.Update(ds.Tables["STUDENT"]);
            ds.AcceptChanges();
        }
        private void пошукToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (пошукToolStripMenuItem.Checked == false)
            {
                пошукToolStripMenuItem.Checked = true;
                GBSearchStudent.Visible = true;
                GBSearchAddress.Visible = true;
            }
            else if (пошукToolStripMenuItem.Checked == true)
            {
                пошукToolStripMenuItem.Checked = false;
                GBSearchStudent.Visible = false;
                GBSearchAddress.Visible = false;
            }
        }
        private void сортуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (пошукToolStripMenuItem.Checked == false)
            {
                пошукToolStripMenuItem.Checked = true;
                GBSortStudent.Visible = true;
                GBSortAddress.Visible = true;
            }
            else if (пошукToolStripMenuItem.Checked == true)
            {
                пошукToolStripMenuItem.Checked = false;
                GBSortStudent.Visible = false;
                GBSortAddress.Visible = false;
            }
        }
        //
        // Пошук
        //
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql;
            SqlConnection connectionString = new SqlConnection(constr);
            sql = "SELECT * FROM STUDENT";
            SqlDataAdapter StudentTableAdapter = new SqlDataAdapter(sql, connectionString);
            DataTable StudentTable = new DataTable();
            StudentTableAdapter.Fill(StudentTable);
            StudentBindingSource.DataSource = StudentTable;
            if (RBSurname.Checked == true)
            {
                StudentBindingSource.Filter = "[First_name] LIKE '%" + textBox1.Text + "%'";
            }
            else if (RBName.Checked == true)
            {
                StudentBindingSource.Filter = "[Last_name] LIKE '%" + textBox1.Text + "%'";
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string sql;
            SqlConnection connectionString = new SqlConnection(constr);
            sql = "SELECT * FROM ADDRESSES";
            SqlDataAdapter AddressesTableAdapter = new SqlDataAdapter(sql, connectionString);
            DataTable AddressesTable = new DataTable();
            AddressesDataAdapter.Fill(AddressesTable);
            AddressesBindingSource.DataSource = AddressesTable;
            if (RBContry.Checked == true)
            {
                AddressesBindingSource.Filter = "[Contry] LIKE '%" + textBox2.Text + "%'";
            }
            else if (RBRegion.Checked == true)
            {
                AddressesBindingSource.Filter = "[Region] LIKE '%" + textBox2.Text + "%'";
            }
        }
        //
        // Сортування
        //
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DataView myDataview = new DataView(ds.Tables["STUDENT"]);
            myDataview.Sort = "First_name asc";
            dGVStudent.DataSource = myDataview;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DataView myDataview = new DataView(ds.Tables["STUDENT"]);
            myDataview.Sort = "Nationality asc";
            dGVStudent.DataSource = myDataview;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DataView myDataview = new DataView(ds.Tables["STUDENT"]);
            myDataview.Sort = "Id_vuz asc";
            dGVStudent.DataSource = myDataview;
        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            DataView myDataview = new DataView(ds.Tables["ADDRESSES"]);
            myDataview.Sort = "Contry asc";
            dGVStudent.DataSource = myDataview;
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            DataView myDataview = new DataView(ds.Tables["ADDRESSES"]);
            myDataview.Sort = "Region asc";
            dGVStudent.DataSource = myDataview;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        
        
    }
}
