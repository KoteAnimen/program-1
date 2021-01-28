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
            mass = new int[(int)sizeMass.Value];
            currentNumber = (int)minNumber.Value;
            table.RowCount = 2;

            for(int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next((int)minNumber.Value, (int)maxNumber.Value);
                listNumbers.Items.Add(mass[i]);
            }
            for (int i = 0; i < mass.Length; i++)
            {
                for(int j = 0; j < mass.Length; j++)
                {
                    if(mass[j] == currentNumber)
                    {
                        countNumbers++;
                    }
                }
                if(countNumbers != 0)
                {
                    table.ColumnCount += 1;
                    table[table.ColumnCount - 1, 0].Value = currentNumber;
                    table[table.ColumnCount - 1, 1].Value = countNumbers;
                }
                countNumbers = 0;
                currentNumber++;
            }
        }
    }
}
