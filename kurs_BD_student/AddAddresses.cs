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
    public partial class AddAddresses : Form
    {
        public AddAddresses()
        {
            InitializeComponent();
        }
        string constr;
        private void AddAddresses_Load(object sender, EventArgs e)
        {
            constr = Properties.Settings.Default.BD;
        }
        //
        // Додаєм студентів до бази даних
        //
        private void BtAddStudent_Click(object sender, EventArgs e)
        {
            if (TxBContry.Text == "" || TxBRegion.Text == "" || TxBCityName.Text == ""
                || TxBStreetNum.Text == "" || TxBIndex.Text == "" || TxBPhone.Text == "")
            {
                MessageBox.Show("Заповніть всі поля");
            }
            else
            {
                string typeSet = "Місто";
                string pContry = TxBContry.Text;
                string pRegion = TxBRegion.Text;
                string pResidence = TxBCityName.Text;
                string pStreetNum = TxBStreetNum.Text;
                int pIndex = Convert.ToInt32(TxBIndex.Text);
                decimal pPhone = Convert.ToDecimal(TxBPhone.Text);
                if (RBСity.Checked == true)
                {
                    typeSet = "Місто";
                }
                else
                {
                    typeSet = "Село";
                }
                int x = 0;
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                string sql;
                sql = "SELECT * FROM ADDRESSES " +
                    "WHERE Contry = @Contry and Region = @Region and Type_Settlement = @Type_Settlement " +
                    "and NameCity = @NameCity and Street_num = @Street_num and IndexNumber = @IndexNumber and Phone = @Phone";
                using (SqlCommand myCommand = new SqlCommand(sql, conn))
                {
                    myCommand.Parameters.AddWithValue("@Contry", pContry);
                    myCommand.Parameters.AddWithValue("@Region", pRegion);
                    myCommand.Parameters.AddWithValue("@Type_Settlement", typeSet);
                    myCommand.Parameters.AddWithValue("@NameCity", pResidence);
                    myCommand.Parameters.AddWithValue("@Street_num", pStreetNum);
                    myCommand.Parameters.AddWithValue("@IndexNumber", pIndex);
                    myCommand.Parameters.AddWithValue("@Phone", pPhone);
                    SqlDataReader reader = myCommand.ExecuteReader();
                    while (reader.Read()) x++; reader.Close();
                }
                if (x == 0)
                {
                    sql = "INSERT INTO ADDRESSES(Contry, Region, Type_Settlement, NameCity, Street_num, IndexNumber, Phone)" +
                        "values (@Contry, @Region, @Type_Settlement, @NameCity, @Street_num, @IndexNumber, @Phone)";
                    using (SqlCommand myCommand = new SqlCommand(sql, conn))
                    {
                        myCommand.Parameters.AddWithValue("@Contry", pContry);
                        myCommand.Parameters.AddWithValue("@Region", pRegion);
                        myCommand.Parameters.AddWithValue("@Type_Settlement", typeSet);
                        myCommand.Parameters.AddWithValue("@NameCity", pResidence);
                        myCommand.Parameters.AddWithValue("@Street_num", pStreetNum);
                        myCommand.Parameters.AddWithValue("@IndexNumber", pIndex);
                        myCommand.Parameters.AddWithValue("@Phone", pPhone);
                        myCommand.ExecuteNonQuery();
                    }
                }
                conn.Close();
                MessageBox.Show("Дані занесені в базу даних.");
                BtClear_Click(sender, e);
            }
        }
        //
        // Очищаєм поля
        //
        private void BtClear_Click(object sender, EventArgs e)
        {
            TxBContry.Clear();
            TxBRegion.Clear(); 
            TxBCityName.Clear();
            TxBStreetNum.Clear();
            TxBIndex.Clear();
            TxBPhone.Clear();
        }
        //
        // Закрити вікно
        //
        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        // Ограничение при вводе
        //
        private void TxBContry_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != 'ї' && l != 'і' && l != '-' && l != 'ё' && l != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void TxBRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != 'ї' && l != 'і' && l != '-' && l != 'ё' && l != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void TxBCityName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != 'ї' && l != 'і' && l != '-' && l != 'ё' && l != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void TxBStreetNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && (l < 'А' || l > 'я') && l != '.' && l != '-'
               && l != 'ї' && l != 'і' && l != 'ё' && l != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void TxBIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void TxBPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
