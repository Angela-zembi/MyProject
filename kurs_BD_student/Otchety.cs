using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs_BD_student
{
    public partial class Otchety : Form
    {
        public Otchety()
        {
            InitializeComponent();
        }

        private void Otchety_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "my_bdDataSet.View". При необходимости она может быть перемещена или удалена.
            this.ViewTableAdapter.Fill(this.my_bdDataSet.View);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "my_bdDataSet.View1". При необходимости она может быть перемещена или удалена.
            this.View1TableAdapter.Fill(this.my_bdDataSet.View1);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
