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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        string constr;
        DataSet ds = new DataSet();

        SqlDataAdapter AddressesDataAdapter;
        SqlCommandBuilder AddressesCommandBuilder;
        BindingSource AddressesBindingSource = new BindingSource();

        SqlDataAdapter VuzDataAdapter;
        SqlCommandBuilder VuzCommandBuilder;
        BindingSource VuzBindingSource = new BindingSource();

        private void AddStudents_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;

            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }
        private void AddStudents_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location =
                    Point.Add(lastForm, new Size(Point.Subtract(Cursor.Position, new Size(lastCursor))));
            }
        }
        private void AddStudents_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        //
        // При завантажені форми считуємо дані з БД в ComboBox
        //
        private void AddStudents_Load(object sender, EventArgs e)
        {
            constr = Properties.Settings.Default.BD;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            //
            // ВУЗ
            //
            VuzDataAdapter = new SqlDataAdapter("SELECT * FROM VUZ", conn); // Создаем адаптер
            VuzCommandBuilder = new SqlCommandBuilder(VuzDataAdapter);
            VuzDataAdapter.Fill(ds, "VUZ"); // Получаем данные из БД в таблицу
            VuzBindingSource.DataSource = ds; // Создаем привязку к таблице
            VuzBindingSource.DataMember = "VUZ";

            CBVuz.ValueMember = "Id_vuz";
            CBVuz.DisplayMember = "name_vuz";
            CBVuz.DataSource = VuzBindingSource;
            CBVuz.SelectedIndex = -1;
            //
            // Адресс
            //
            string sql = "SELECT Id_addresses, (Region+',  '+Type_Settlement+','+NameCity+','+Street_num)  as Adres FROM ADDRESSES";
            AddressesDataAdapter = new SqlDataAdapter(sql, conn); // Создаем адаптер
            AddressesCommandBuilder = new SqlCommandBuilder(AddressesDataAdapter);
            AddressesDataAdapter.Fill(ds, "ADDRESSES"); // Получаем данные из БД в таблицу
            AddressesBindingSource.DataSource = ds; // Создаем привязку к таблице
            AddressesBindingSource.DataMember = "ADDRESSES";

            CBAddresses.ValueMember = "Id_addresses";
            CBAddresses.DisplayMember = "Adres";
            CBAddresses.DataSource = AddressesBindingSource;
            CBAddresses.SelectedIndex = -1;
            conn.Close();
        }
        //
        // Додати студента
        //
        private void BtAddStudent_Click(object sender, EventArgs e)
        {
            if (TxBSurname.Text == "" || TxBName.Text == "" || TxBPatronymic.Text == ""
                || TxBNationality.Text == "" || CBVuz.Text == "" || CBAddresses.Text == "")
            {
                MessageBox.Show("Заповніть всі поля");
            }
            else
            {
                string pSurname = TxBSurname.Text;
                string pName = TxBName.Text;
                string pPatronymic = TxBPatronymic.Text;
                string pNationality = TxBNationality.Text;
                int pVuz = Convert.ToInt32(CBVuz.SelectedValue);
                int pAddresses = Convert.ToInt32(CBAddresses.SelectedValue);
                int x = 0;
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                string sql;
                sql = "SELECT * FROM STUDENT " +
                    "WHERE First_name = @First_name and Last_name = @Last_name " +
                    "and Patronymic = @Patronymic and Nationality = @Nationality " +
                    "and Id_vuz = @Id_vuz and Id_addresses = @Id_addresses ";
                using (SqlCommand myCommand = new SqlCommand(sql, conn))
                {
                    myCommand.Parameters.AddWithValue("@First_name", pSurname);
                    myCommand.Parameters.AddWithValue("@Last_name", pName);
                    myCommand.Parameters.AddWithValue("@Patronymic", pPatronymic);
                    myCommand.Parameters.AddWithValue("@Nationality", pNationality);
                    myCommand.Parameters.AddWithValue("@Id_vuz", pVuz);
                    myCommand.Parameters.AddWithValue("@Id_addresses", pAddresses);
                    SqlDataReader reader = myCommand.ExecuteReader();
                    while (reader.Read()) x++; reader.Close();
                }
                if (x == 0)
                {
                    sql = "INSERT INTO STUDENT(First_name, Last_name, Patronymic, Nationality, Id_vuz, Id_addresses)" +
                        "values (@First_name, @Last_name, @Patronymic, @Nationality, @Id_vuz, @Id_addresses)";
                    using (SqlCommand myCommand = new SqlCommand(sql, conn))
                    {
                        myCommand.Parameters.AddWithValue("@First_name", pSurname);
                        myCommand.Parameters.AddWithValue("@Last_name", pName);
                        myCommand.Parameters.AddWithValue("@Patronymic", pPatronymic);
                        myCommand.Parameters.AddWithValue("@Nationality", pNationality);
                        myCommand.Parameters.AddWithValue("@Id_vuz", pVuz);
                        myCommand.Parameters.AddWithValue("@Id_addresses", pAddresses);
                        myCommand.ExecuteNonQuery();
                    }
                }
                conn.Close();
                BtClear_Click(sender, e);
                MessageBox.Show("Дані занесені в базу даних.");
            }
        }
        //
        // Очистити поля
        //
        private void BtClear_Click(object sender, EventArgs e)
        {
            TxBSurname.Clear();
            TxBName.Clear();
            TxBPatronymic.Clear();
            TxBNationality.Clear();
            CBVuz.SelectedIndex = -1;
            CBAddresses.SelectedIndex = -1;
        }
        //
        // Закрити вікно
        //
        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        // Ограничение
        //
        private void TxBSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != 'і' && l != 'ї' && l != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void TxBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != 'і' && l != 'ї' && l != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void TxBPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != 'і' && l != 'ї' && l != '-' && l != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void TxBNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != 'і' && l != 'ї' && l != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
