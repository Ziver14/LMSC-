using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DBWork dBWork = new DBWork();

            LoadData();

           
        }


        //Метод загрузки информации в DataGrid
        private void LoadData()
        {
            var reader = DBWork.LoadTraningExercision();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridViewCycle.DataSource = dt;

            reader.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbSqad.Text, out double onePM))
            {
                // Если корректное число, обновляем веса в базе
                DBWork.UpdateWight(onePM);
                LoadData(); // Обновляем данные в DataGrid
            }
            else
            {
                // Если ввод некорректен, показываем сообщение об ошибке
                MessageBox.Show("Введите корректное числовое значение для максимального веса.");
            }
        }
    }
}
