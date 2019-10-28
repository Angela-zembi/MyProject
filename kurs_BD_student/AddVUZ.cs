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
    public partial class AddVUZ : Form
    {
        public AddVUZ()
        {
            InitializeComponent();
        }
        string constr;
        private void AddVUZ_Load(object sender, EventArgs e)
        {
            constr = Properties.Settings.Default.BD;
        }
        //
        // Додаєм вуз в базу
        //
        private void BtAddVuz_Click(object sender, EventArgs e)
        {
            if (TxBNameVuz.Text == "")
            {
                MessageBox.Show("Заповніть всі поля");
            }
            else
            {
                string pNameVuz = TxBNameVuz.Text;
                int x = 0;
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                string sql;
                sql = "SELECT * FROM VUZ " +
                    "WHERE name_vuz = @name_vuz and fdp = @fdp ";
                using (SqlCommand myCommand = new SqlCommand(sql, conn))
                {
                    myCommand.Parameters.AddWithValue("@name_vuz", pNameVuz);
                    if (RBTrue.Checked == true)
                    {
                        myCommand.Parameters.AddWithValue("@fdp", true);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@fdp", false);
                    }
                    SqlDataReader reader = myCommand.ExecuteReader();
                    while (reader.Read()) x++; reader.Close();
                }
                if (x == 0)
                {
                    sql = "INSERT INTO VUZ(name_vuz, fdp)" +
                        "values (@name_vuz, @fdp)";
                    using (SqlCommand myCommand = new SqlCommand(sql, conn))
                    {
                        myCommand.Parameters.AddWithValue("@name_vuz", pNameVuz);
                        if (RBTrue.Checked == true)
                        {
                            myCommand.Parameters.AddWithValue("@fdp", true);
                        }
                        else
                        {
                            myCommand.Parameters.AddWithValue("@fdp", false);
                        }
                        myCommand.ExecuteNonQuery();
                    }
                }
                conn.Close();
                MessageBox.Show("Дані занесені в базу даних.");
                TxBNameVuz.Clear();
                RBTrue.Checked = true;
            }
        }
        //
        // Очищаємо поля
        //
        private void BtClear_Click(object sender, EventArgs e)
        {
            TxBNameVuz.Clear();
            RBTrue.Checked = true;
        }
        //
        // Закриваємо вікно
        //
        private void BtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //Ограничение
        //
        private void TxBNameVuz_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != 'і' && l != 'ї' && l != '-' && l != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
