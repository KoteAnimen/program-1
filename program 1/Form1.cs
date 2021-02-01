using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program_1
{
    public partial class Form1 : Form
    {
        public int[] mass;
        public int countNumbers;
        public int currentNumber;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void GetAnswer_Click(object sender, EventArgs e)
        {
            //Задаем размер массива = N, и задаем 1-ое проверяемое число
            mass = new int[(int)sizeMass.Value];//1
            currentNumber = (int)minNumber.Value;//1
            table.RowCount = 2;//1

            //Создаем массив
            for(int i = 0; i < mass.Length; i++)//2
            {
                mass[i] = rnd.Next((int)minNumber.Value, (int)maxNumber.Value);//2
                listNumbers.Items.Add(mass[i]);//2
            }
            //Перебираем массив чисел
            for (int i = 0; i < mass.Length; i++)//3
            {
                //Ищем совпадения с текущим проверяемым числом
                for(int j = 0; j < mass.Length; j++)//4
                {
                    //Если проверяемый элемент массива = текущему проверяемому числу, то счетчик этого числа + 1
                    if(mass[j] == currentNumbe5)//5
                    {
                        countNumbers++;//6
                    }
                }
                //Если счетчик текущего проверяемого числа не = 0, то выводим это число и значение счетчика найденых совпадений
                if(countNumbers != 0)//7
                {
                    table.ColumnCount += 1;//8
                    table[table.ColumnCount - 1, 0].Value = currentNumber;//8
                    table[table.ColumnCount - 1, 1].Value = countNumbers;//8
                }
                //Обнуляем счетчик и переходим к следующему числу
                countNumbers = 0;//9
                currentNumber++;//9
            }
        }
    }
}
