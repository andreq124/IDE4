using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
//using FastTreeNS;

namespace IDEEEEEEEEEEEEEEEEEEE
{
    public partial class Form1 : Form
    {
        PrivateFontCollection font;
        private void fontsProjects()
        {
            //Добавляем шрифт из указанного файла в em.Drawing.Text.PrivateFontCollection
            this.font = new PrivateFontCollection();
            this.font.AddFontFile("font/UtromPressKachat.ttf"); ;
        }

        private void fonts()
        {
            //Задаем шрифт текста, отображаемого элементом управления.
            label1.Font = new Font(font.Families[0], 70);
            button1.Font = new Font(font.Families[0], 11);
            button2.Font = new Font(font.Families[0], 11);
            button3.Font = new Font(font.Families[0], 11);
            button4.Font = new Font(font.Families[0], 11);
        }

        int t;
        public int gg;
        public string s { get; set; }
        public Form1()
        {
            InitializeComponent();
            fontsProjects();
            fonts();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("tem.txt"); //Открываем файл для чтения
            t = Int32.Parse(streamReader.ReadLine());
            streamReader.Close();
            label1.Text = "RykoYoki C±#";
            if (t == -1)
            {
                BackColor = Color.Black;
                button1.BackColor = Color.Black;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                ForeColor = Color.White;
            }
            button1.Text = "Создать новый файл";
            button2.Text = "Открыть файл";
            button3.Text = "Прекратить сеанс сатанизма";
            button4.Text = "Сменить тему";
            openFileDialog1.Filter = "Файлы кода (*.cs)|*.cs|All files (*.*)|*.*";
            saveFileDialog1.Filter = "Файлы кода (*.cs)|*.cs|All files (*.*)|*.*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader streamReader1 = new StreamReader("tem.txt");
            t = Int32.Parse(streamReader1.ReadLine());
            streamReader1.Close();
            t *= -1;
            System.IO.File.Delete("tem.txt");
            StreamWriter zn;  //Класс для записи в файл
            FileInfo file = new FileInfo("tem.txt");
            zn = file.AppendText(); //Дописываем инфу в файл, если файла не существует он создастся
            zn.WriteLine(t); //Записываем в файл текст из текстового поля
            zn.Close(); // Закрываем файл
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog(this);
                s = saveFileDialog1.FileName;
                gg = 1;
                FileStream fstream = null;
                fstream = new FileStream(s, FileMode.OpenOrCreate);
                fstream?.Close();

                Form2 frm2 = new Form2();
                frm2.frm1 = this;
                frm2.Show();
                this.Hide();
            } 
            catch
            {
                MessageBox.Show("Укажите файл", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                s = openFileDialog1.FileName;
                gg = 0;
                Form2 frm2 = new Form2();
                frm2.frm1 = this;
                frm2.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Укажите файл", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}