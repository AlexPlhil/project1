using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private TextBox historyTextBox;
        public Form1()
        {
            InitializeComponent();
            InitializeHistoryTextBox();

        }
        private void InitializeHistoryTextBox()
        {
            historyTextBox = new TextBox();
            historyTextBox.Multiline = true;
            historyTextBox.ScrollBars = ScrollBars.Vertical;
            historyTextBox.Dock = DockStyle.Bottom;
            historyTextBox.Height = 100; // You can adjust the height as needed
            Controls.Add(historyTextBox);
        }
        List<string> result = new List<string>();
        List<string> stor = new List<string>();
        List<double> work = new List<double>();
        private int counter1 = 0;
        public int quantity = 0;

        public void t()
        {
          
            counter1 = 0;
            result.Add(textBox1.Text);
            string input = textBox1.Text;
            string[] elements = input.Split(' ');
            foreach (string element in elements)
            {
                if (double.TryParse(element, out double number))
                {

                    work.Add(number);
                    counter1++;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                    return;
                }
            }
            input = textBox1.Text;
        }
        public double s()
        {
            double p = 0;
            double sp = counter1;
            for (int qw = 0; qw < counter1; qw++)
            {
                p +=work[qw];

            }
            double k = p/sp;
            return k;
        }
        private void UpdateHistory(string entry)
        {
            stor.Add(entry);
            UpdateHistoryTextBox();
        }
        private void UpdateHistory1()
        {
            quantity--;
            textBox1.Text="";
            textBox1.Text=result[quantity];
            stor.RemoveAt(quantity);
            UpdateHistoryTextBox();
        }
        private void UpdateHistoryTextBox()
        {
            historyTextBox.Text = string.Join("\r\n", stor);
        }
        public double a;
        public double b;
        public char c;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            button1.Height = panel2.Height/8;
            button2.Height = panel2.Height/8;
            button3.Height = panel2.Height/8;
            button4.Height = panel2.Height/8;
            button5.Height = panel2.Height/8;
            button6.Height = panel2.Height/8;
            button7.Height = panel2.Height/8;
            button8.Height = panel2.Height/8;
            button9.Height = panel2.Height/8;
            button10.Height = panel2.Height/8;
            button11.Height = panel2.Height/8;
            button12.Height = panel2.Height/8;
            button13.Height = panel2.Height/8;
            button14.Height = panel2.Height/8;
            button15.Height = panel2.Height/8;
            button16.Height = panel2.Height/8;
            button17.Height = panel2.Height/8;
            button18.Height = panel2.Height/8;
            button19.Height = panel2.Height/8;
            button20.Height = panel2.Height/8;
            button21.Height = panel2.Height/8;
            button22.Height = panel2.Height/8;
            button23.Height = panel2.Height/8;
            button24.Height = panel2.Height/8;
            button25.Height = panel2.Height/8;
            button26.Height = panel2.Height/8;
            button27.Height = panel2.Height/8;
            button28.Height = panel2.Height/8;
            button29.Height = panel2.Height/8;
            button30.Height = panel2.Height/8;
            button31.Height = panel2.Height/8;
            button32.Height = panel2.Height/8;

            button1.Width = panel2.Width/4;
            button2.Width = panel2.Width/4;
            button3.Width = panel2.Width/4;
            button4.Width = panel2.Width/4;
            button5.Width = panel2.Width/4;
            button6.Width = panel2.Width/4;
            button7.Width = panel2.Width/4;
            button8.Width = panel2.Width/4;
            button9.Width = panel2.Width/4;
            button10.Width = panel2.Width/4;
            button11.Width = panel2.Width/4;
            button12.Width = panel2.Width/4;
            button13.Width = panel2.Width/4;
            button14.Width = panel2.Width/4;
            button15.Width = panel2.Width/4;
            button16.Width = panel2.Width/4;
            button17.Width = panel2.Width/4;
            button18.Width = panel2.Width/4;
            button19.Width = panel2.Width/4;
            button20.Width = panel2.Width/4;
            button21.Width = panel2.Width/4;
            button22.Width = panel2.Width/4;
            button23.Width = panel2.Width/4;
            button24.Width = panel2.Width/4;
            button25.Width = panel2.Width/4;
            button26.Width = panel2.Width/4;
            button27.Width = panel2.Width/4;
            button28.Width = panel2.Width/4;
            button29.Width = panel2.Width/4;
            button30.Width = panel2.Width/4;
            button31.Width = panel2.Width/4;
            button32.Width = panel2.Width/4;

            button1.Top = 0;
            button2.Top = 0;
            button3.Top = 0;
            button4.Top = 0;

            button5.Top = panel2.Height/8;
            button6.Top = panel2.Height/8;
            button7.Top = panel2.Height/8;
            button8.Top = panel2.Height/8;

            button9.Top = panel2.Height*2/8;
            button10.Top = panel2.Height*2/8;
            button11.Top = panel2.Height*2/8;
            button12.Top = panel2.Height*2/8;

            button13.Top = panel2.Height*3/8;
            button14.Top = panel2.Height*3/8;
            button15.Top = panel2.Height*3/8;
            button16.Top = panel2.Height*3/8;

            button17.Top = panel2.Height*4/8;
            button18.Top = panel2.Height*4/8;
            button19.Top = panel2.Height*4/8;
            button20.Top = panel2.Height*4/8;

            button21.Top = panel2.Height*5/8;
            button22.Top = panel2.Height*5/8;
            button23.Top = panel2.Height*5/8;
            button24.Top = panel2.Height*5/8;

            button25.Top = panel2.Height*6/8;
            button26.Top = panel2.Height*6/8;
            button27.Top = panel2.Height*6/8;
            button28.Top = panel2.Height*6/8;

            button29.Top = panel2.Height*7/8;
            button30.Top = panel2.Height*7/8;
            button31.Top = panel2.Height*7/8;
            button32.Top = panel2.Height*7/8;

            button1.Left = 0;
            button5.Left = 0;
            button9.Left = 0;
            button13.Left = 0;
            button17.Left = 0;
            button21.Left = 0;
            button25.Left = 0;
            button29.Left = 0;

            button2.Left = panel2.Width/4;
            button6.Left = panel2.Width/4;
            button10.Left = panel2.Width/4;
            button14.Left = panel2.Width/4;
            button18.Left = panel2.Width/4;
            button22.Left = panel2.Width/4;
            button26.Left = panel2.Width/4;
            button30.Left = panel2.Width/4;

            button3.Left = panel2.Width*2/4;
            button7.Left = panel2.Width*2/4;
            button11.Left = panel2.Width*2/4;
            button15.Left = panel2.Width*2/4;
            button19.Left = panel2.Width*2/4;
            button23.Left = panel2.Width*2/4;
            button27.Left = panel2.Width*2/4;
            button31.Left = panel2.Width*2/4;

            button4.Left = panel2.Width*3/4;
            button8.Left = panel2.Width*3/4;
            button12.Left = panel2.Width*3/4;
            button16.Left = panel2.Width*3/4;
            button20.Left = panel2.Width*3/4;
            button24.Left = panel2.Width*3/4;
            button28.Left = panel2.Width*3/4;
            button32.Left = panel2.Width*3/4;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text+="1";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text+="2";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text+="3";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text+="4";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text+="5";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text+="6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text+="7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text+="8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text+="9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            t();
            c = '/';
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            t();
            c = '*';
            textBox1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            t();
            c = '-';
            textBox1.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            t();
            c = '+';
            textBox1.Text = "";
        }
        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text+=" ";
        }
        private void button28_Click(object sender, EventArgs e)
        {
            int counter = counter1;
            a =Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            switch (c)
            {
                case '+':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {

                        double modifiedNumber = work[qw];
                        modifiedNumber += a; // Умножить каждый элемент на число
                        work[qw] = modifiedNumber;
                        counter++;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"Addition: {a} operation nubmber: {quantity}");
                    break;
                case '-':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {
                        double modifiedNumber = work[qw];
                        modifiedNumber -= a; // Умножить каждый элемент на число
                        work[qw] = modifiedNumber;
                        counter++;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"minus: {a} operation nubmber: {quantity}");
                    break;
                case '*':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {

                        double modifiedNumber = work[qw];
                        modifiedNumber *= a; // Умножить каждый элемент на число
                        work[qw] = modifiedNumber;
                        counter++;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"multiply: {a} operation nubmber: {quantity}");
                    break;

                case '/':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {

                        double modifiedNumber = work[qw];
                        modifiedNumber /= a; // Умножить каждый элемент на число
                        work[qw] = modifiedNumber;
                        counter++;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"devide: {a} operation nubmber: {quantity}");
                    break;
                case 'y':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {
                        double modifiedNumber = work[qw];
                        modifiedNumber = Math.Pow(modifiedNumber, a); // Возвести каждый элемент в pow
                        work[qw] = modifiedNumber;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"pow by x: {a} operation nubmber: {quantity}");
                    break;
                case 's':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {
                        double modifiedNumber = work[qw];
                        modifiedNumber = Math.Pow(modifiedNumber, 1/a); // Вычислить квадратный корень заданной степени для каждого элемента
                        work[qw] = modifiedNumber;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"koren is x: {a} operation nubmber: {quantity}");
                    break;
                case 'l':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {
                        double modifiedNumber = work[qw];
                        modifiedNumber = Math.Log(modifiedNumber, a); // Вычислить логарифм по заданному основанию для каждого элемента
                        work[qw] = modifiedNumber;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"log: {a} operation nubmber: {quantity}");
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            quantity++;
            t();
            textBox1.Text="";
            c='p';
            for (int qw = 0; qw < counter1; qw++)
            {
                double modifiedNumber = work[qw];
                modifiedNumber = Math.Pow(modifiedNumber, 2); // Возвести каждый элемент в pow
                work[qw] = modifiedNumber;
                textBox1.Text += Convert.ToString(work[qw]) + " ";
            }
            result.Add(textBox1.Text);
            UpdateHistory($"pow: {a} operation nubmber: {quantity}");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            t();
            c = 'y';
            textBox1.Text="";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            quantity++;
            t();
            textBox1.Text="";
            c='k';
            for (int qw = 0; qw < counter1; qw++)
            {
                double modifiedNumber = work[qw];
                modifiedNumber = Math.Sqrt(modifiedNumber); // Вычислить квадратный корень заданной степени для каждого элемента
                work[qw] = modifiedNumber;
                textBox1.Text += Convert.ToString(work[qw]) + " ";

            }
            result.Add(textBox1.Text);
            UpdateHistory($"koran: {2} operation nubmber: {quantity}");

        }

        private void button8_Click(object sender, EventArgs e)
        {

            t();
            c = 's';
            textBox1.Text="";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            t();
            c = 'l';
            textBox1.Text="";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            quantity++;
            t();
            textBox1.Text="";
            double modifiedNumber = 0, y = 0, q = 0;
            for (int qw = 0; qw < counter1; qw++)
            {

                y+= Math.Pow(s() - work[qw], 2);

            }
            q=y/(counter1-1);
            modifiedNumber = Math.Sqrt(q);
            textBox1.Text = Convert.ToString(modifiedNumber)+' ';
            result.Add(textBox1.Text);
            UpdateHistory($"pow: {modifiedNumber} operation nubmber: {quantity}");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            quantity++;
            t();
            textBox1.Text="";
            textBox1.Text = Convert.ToString(s());
            result.Add(textBox1.Text);
            UpdateHistory($"mediana: {s()} operation nubmber: {quantity}");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            quantity++;
            t();
            textBox1.Text="";
            c='f';
            for (int qw = 0; qw < counter1; qw++)
            {
                double modifiedNumber = work[qw];
                modifiedNumber = Factorial(modifiedNumber); // Вычислить факториал для каждого элемента
                work[qw] = modifiedNumber;
                textBox1.Text += Convert.ToString(work[qw]) + " ";

            }
            result.Add(textBox1.Text);
            UpdateHistory($"fact: {a}"+$"operation nubmber: {quantity}");
        }
        static double Factorial(double n)
        {
            if (n == 0)
                return 1;
            else if (n < 0)
                return double.NaN; // Обработка отрицательных чисел
            else
                return n * Factorial(n - 1);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            work.RemoveRange(0, counter1);
            UpdateHistory1();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            switch (c)
            {
                case '+':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {

                        double modifiedNumber = work[qw];
                        modifiedNumber += a; // Умножить каждый элемент на число
                        work[qw] = modifiedNumber;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"Addition: {a} operation nubmber: {quantity}");
                    break;
                case '-':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {
                        double modifiedNumber = work[qw];
                        modifiedNumber -= a; // Умножить каждый элемент на число
                        work[qw] = modifiedNumber;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"minus: {a} operation nubmber: {quantity}");
                    break;
                case '*':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {

                        double modifiedNumber = work[qw];
                        modifiedNumber *= a; // Умножить каждый элемент на число
                        work[qw] = modifiedNumber;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"multiply: {a} operation nubmber: {quantity}");
                    break;

                case '/':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {

                        double modifiedNumber = work[qw];
                        modifiedNumber /= a; // Умножить каждый элемент на число
                        work[qw] = modifiedNumber;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"devide: {a} operation nubmber: {quantity}");
                    break;
                case 'y':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {
                        double modifiedNumber = work[qw];
                        modifiedNumber = Math.Pow(modifiedNumber, a); // Возвести каждый элемент в pow
                        work[qw] = modifiedNumber;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"pow by x: {a} operation nubmber: {quantity}");
                    break;
                case 's':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {
                        double modifiedNumber = work[qw];
                        modifiedNumber = Math.Pow(modifiedNumber, 1/a); // Вычислить квадратный корень заданной степени для каждого элемента
                        work[qw] = modifiedNumber;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"koren is x: {a} operation nubmber: {quantity}");
                    break;
                case 'l':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {
                        double modifiedNumber = work[qw];
                        modifiedNumber = Math.Log(modifiedNumber, a); // Вычислить логарифм по заданному основанию для каждого элемента
                        work[qw] = modifiedNumber;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"log: {a} operation nubmber: {quantity}");
                    break;
                case 'p':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {
                        double modifiedNumber = work[qw];
                        modifiedNumber = Math.Pow(modifiedNumber, 2); // Возвести каждый элемент в pow
                        work[qw] = modifiedNumber;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";
                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"pow: {a} operation nubmber: {quantity}");
                    break;
                case 'k':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {
                        double modifiedNumber = work[qw];
                        modifiedNumber = Math.Sqrt(modifiedNumber); // Вычислить квадратный корень заданной степени для каждого элемента
                        work[qw] = modifiedNumber;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"koran: {2} operation nubmber: {quantity}");
                    break;
                case 'f':
                    quantity++;
                    for (int qw = 0; qw < counter1; qw++)
                    {
                        double modifiedNumber = work[qw];
                        modifiedNumber = Factorial(modifiedNumber); // Вычислить факториал для каждого элемента
                        work[qw] = modifiedNumber;
                        textBox1.Text += Convert.ToString(work[qw]) + " ";

                    }
                    result.Add(textBox1.Text);
                    UpdateHistory($"fact: {a}"+$"operation nubmber: {quantity}");
                    break;
            }
            }

        private void button29_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Sample.txt");
            textBox1.Text = sr.ReadLine();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Sample.txt");

            t();
            sw.WriteLine(textBox1.Text);

            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            work.RemoveRange(0, counter1);
            result.RemoveRange(0, quantity);
            stor.RemoveRange(0, quantity);
            quantity=0;
            UpdateHistoryTextBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            textBox1.Text="";
            work.RemoveRange(0, counter1);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            s =s.Substring(0, s.Length-1);
            textBox1.Text=s;
        }

        private void button26_Click(object sender, EventArgs e)
        {
           
                textBox1.Text+="0";
            
        }
    }
}
   