using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res_textBox.Text = "";
            string str="";
            try
            {
                str = start_textBox.Text;
                //Проверка на пустоту
                if (String.IsNullOrWhiteSpace(str))
                {
                    MessageBox.Show("Строка пустая");
                    return;
                }
            }
            catch { }
            
            //Замена на одиночный пробел
            str = str.Replace("  ", " ");
            //Создание массивов из подстрок
            string[] slova = str.Split(' ');
            for (int i = 0; i < slova.Length; i++)
            {
                //Поиск однобуквенного слова
                if (slova[i].Length != 1)
                    res_textBox.Text+=slova[i] + " ";
            }
            
        }
    }
}
