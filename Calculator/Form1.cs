using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        // Объявление переменных
        float a, b;
        int count;
        bool znak = true;
        private object labelResult;
        private object textBoxTemperature;

        // Объявление констант для новых операций
        private const int MODULUS = 5;
        private const int EXPONENTIATION = 6;
        private const int SQUARE_ROOT = 7;
        private const int PERCENTAGE = 8;

        public object TextBoxTemperature { get => textBoxTemperature; set => textBoxTemperature = value; }


        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }

        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    break;

                case 2:
                    b = a - float.Parse(textBox1.Text);
                    break;

                case 3:
                    b = a * float.Parse(textBox1.Text);
                    break;

                case 4:
                    b = a / float.Parse(textBox1.Text);
                    break;

                case MODULUS:
                    b = a % float.Parse(textBox1.Text);
                    break;

                case EXPONENTIATION:
                    b = (float)Math.Pow(a, float.Parse(textBox1.Text));
                    break;

                case SQUARE_ROOT:
                    b = (float)Math.Sqrt(a);
                    break;

                case PERCENTAGE:
                    string percentageText = textBox1.Text.Replace("%", "");
                    float percentageValue = (a * float.Parse(percentageText)) / 100;
                    b = a - percentageValue; // Возвращаем значение процента
                    break;

                default:
                    break;
            }
            textBox1.Text = b.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1; // Сложение
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2; // Вычитание
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3; // Умножение
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4; // Деление
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        // Обработчик для остатка от деления
        private void buttonModulus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = MODULUS; // Остаток от деления
            label1.Text = a.ToString() + "%";
            znak = true;
        }

        // Обработчик для возведения в степень
        private void buttonExponentiation_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = EXPONENTIATION; // Возведение в степень
            label1.Text = a.ToString() + "^";
            znak = true;
        }

        // Обработчик для квадратного корня
        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = SQUARE_ROOT; // Квадратный корень
            label1.Text = "√" + a.ToString();
            znak = true;
        }

        // Обработчик для процентов
        private void buttonPercentage_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = PERCENTAGE; // Процент
            label1.Text = a.ToString() + "% от ";
            znak = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            // Получаем текущее число из текстового поля
            a = float.Parse(textBox1.Text);

            // Очищаем текстовое поле
            textBox1.Clear();

            // Устанавливаем счетчик для процентов
            count = PERCENTAGE;

            // Отображаем число с символом %
            label1.Text = a.ToString() + " %";

            // Устанавливаем флаг для знака
            znak = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            b = (float)Math.Pow(a, 2); // Вычисляем квадрат числа
            textBox1.Text = b.ToString(); // Отображаем результат
            label1.Text = ""; // Очищаем метку
        }

        
    

        private void button2_Click(object sender, EventArgs e)
        {
            int length = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox1.Text += text[i];
            }
        }
    }
}
