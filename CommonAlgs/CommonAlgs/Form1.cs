using System.Windows.Forms;

namespace CommonAlgs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Numbers;
        public string[] AfterNumbers;
        public float OutNumber;
        static bool Case;

        private void Max_MouseClick(object sender, MouseEventArgs e)
        {
            float temp; 
            AfterNumbers = textBox1.Text.Split(' ');
            for (int i = 0; i < AfterNumbers.Length; i++)
            {
                float.TryParse(AfterNumbers[i], out temp);
                if (OutNumber < temp)
                {
                    OutNumber = temp;
                }
            }
            textOut.Text = OutNumber.ToString();
        }

        private void Min_MouseClick(object sender, MouseEventArgs e)
        {
            AfterNumbers = textBox1.Text.Split(' ');
            for (int i = 0; i < AfterNumbers.Length; i++)
            {
                if (OutNumber > float.Parse(AfterNumbers[i]))
                {
                    OutNumber = float.Parse(AfterNumbers[i]);
                }
            }
            textOut.Text = OutNumber.ToString();
        }

        private void Sort_MouseClick(object sender, MouseEventArgs e)
        {
            Case = checkBox1.Checked;
            textOut.Text = BubbleSort(textBox1.Text);
        }
        static string BubbleSort(string NumsString)
        {
            string OutString = "";
            float temp;
            string[] NumsString2 = NumsString.Split(' ');//Строчный массив из цифр
            float[] NumsFloat = new float[NumsString2.Length];//пустой массив чесел
            for (int i = 0;i < NumsFloat.Length;i++) //Цикл певодящий массиив из строк в массив чисел
            {
                float.TryParse(NumsString2[i],out NumsFloat[i]);
            }

            for (int iy = 1; iy < NumsFloat.Length; iy++)
            {
                for (int i = 0; i < NumsFloat.Length - iy; i++)//цикл сортировки массива
                {
                    if (Case == false)
                    {
                        if (NumsFloat[i] < NumsFloat[i + 1]) //если следующий элемент больше предыдущего то поменять их местами
                        {
                            temp = NumsFloat[i];
                            NumsFloat[i] = NumsFloat[i + 1];
                            NumsFloat[i + 1] = temp;
                        }
                    }
                   else
                    {
                        if (NumsFloat[i] > NumsFloat[i + 1]) //если следующий элемент меньше предыдущего то поменять их местами
                        {
                            temp = NumsFloat[i];
                            NumsFloat[i] = NumsFloat[i + 1];
                            NumsFloat[i + 1] = temp;
                        }
                    }
                }
            }
            for (int i = 0;i<NumsFloat.Length;i++) //цикл создающий строку из элементов масcива
            {
                OutString += " " + NumsFloat[i].ToString();
            }
            return OutString;
        }
    }
}
