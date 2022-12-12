using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string remove(string str)
        {
            //Проверка на четность символов
            if (str.Length % 2 == 0)
            {
                //Удаление
                return str.Remove(str.Length / 2 - 1, 2);
            }
            //Если количество символов нечетное, удаление одного символа
            return str.Remove(str.Length / 2, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res_textBox.Text = "";
            string str="";
            //Проверка на пустоту

            try
            {
                str = start_textBox.Text;
                if (String.IsNullOrWhiteSpace(str))
                {
                    MessageBox.Show("Строка пустая");
                    return;
                }
            }
            catch { }
            
           res_textBox.Text+="Количество символов: " + str.Length;
            res_textBox.Text +="\n"+remove(str);
        }
    }
}
