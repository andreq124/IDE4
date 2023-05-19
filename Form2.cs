using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Diagnostics;
using System.CodeDom.Compiler;
using Microsoft.CSharp;

namespace IDEEEEEEEEEEEEEEEEEEE
{
    public partial class Form2 : Form
    {
        public Form1 frm1 { get; set; }
        string q, q1 = "", q2;
        char sl = '\\';
        int t, ch = 0;
        
        //////////////////
        //Синтаксис темы//
        //////////////////

        public FastColoredTextBoxNS.Style BlueStyle = new FastColoredTextBoxNS.TextStyle(Brushes.BlueViolet, null, FontStyle.Italic);
        public FastColoredTextBoxNS.Style LightBlueStyle = new FastColoredTextBoxNS.TextStyle(Brushes.SteelBlue, null, FontStyle.Italic);
        public FastColoredTextBoxNS.Style YellowStyle = new FastColoredTextBoxNS.TextStyle(Brushes.Yellow, null, FontStyle.Italic);
        public FastColoredTextBoxNS.Style VioletStyle = new FastColoredTextBoxNS.TextStyle(Brushes.Violet, null, FontStyle.Italic);
        public FastColoredTextBoxNS.Style GreenStyle = new FastColoredTextBoxNS.TextStyle(Brushes.Green, null, FontStyle.Italic);
        public FastColoredTextBoxNS.Style oreStyle = new FastColoredTextBoxNS.TextStyle(Brushes.Orange, null, FontStyle.Italic);

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader streamReader1 = new StreamReader("tem.txt");
            t = Int32.Parse(streamReader1.ReadLine());
            streamReader1.Close();
            fastColoredTextBox1.BorderStyle = BorderStyle.None;
            if (t == -1)
            {
                //общая тема
                BackColor = Color.Black;
                ForeColor = Color.White;
                //тема менюстрип
                menuStrip1.BackColor = Color.Black;
                menuStrip1.ForeColor = Color.White;
                сохранитьToolStripMenuItem.BackColor = Color.Black;
                сохранитьКакToolStripMenuItem.BackColor = Color.Black;
                закрытьToolStripMenuItem.BackColor = Color.Black;
                сохранитьToolStripMenuItem.ForeColor = Color.White;
                сохранитьКакToolStripMenuItem.ForeColor = Color.White;
                закрытьToolStripMenuItem.ForeColor = Color.White;
                открытьФайлToolStripMenuItem.BackColor = Color.Black;
                открытьФайлToolStripMenuItem.ForeColor = Color.White;
                fastColoredTextBox1.BackColor = Color.Black;
                fastColoredTextBox1.ForeColor = Color.White;
                fastColoredTextBox1.LineNumberColor = Color.White;
                fastColoredTextBox1.IndentBackColor = Color.Black;
            }
            else if (t == 1)
            {
                //общая тема
                BackColor = Color.White;
                ForeColor = Color.Black;
                //тема менюстрип
                menuStrip1.BackColor = Color.White;
                menuStrip1.ForeColor = Color.Black;
                сохранитьToolStripMenuItem.BackColor = Color.White;
                сохранитьКакToolStripMenuItem.BackColor = Color.White;
                закрытьToolStripMenuItem.BackColor = Color.White;
                сохранитьToolStripMenuItem.ForeColor = Color.Black;
                сохранитьКакToolStripMenuItem.ForeColor = Color.Black;
                закрытьToolStripMenuItem.ForeColor = Color.Black;
                открытьФайлToolStripMenuItem.BackColor = Color.White;
                открытьФайлToolStripMenuItem.ForeColor = Color.Black;
                fastColoredTextBox1.BackColor = Color.White;
                fastColoredTextBox1.ForeColor = Color.Black;
                fastColoredTextBox1.LineNumberColor = Color.Black;
                fastColoredTextBox1.IndentBackColor = Color.White;
            }
            StreamReader docOp = new StreamReader(frm1.s);
            fastColoredTextBox1.Text = docOp.ReadToEnd();
            docOp.Close();
            lab();
            //openFileDialog1.Filter = "Файлы кода (*.cs)|*.cs|All files (*.*)|*.*";
            saveFileDialog1.Filter = "Файлы кода (*.cs)|*.cs|All files (*.*)|*.*";
        }

        void tema()
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
            if (t == -1)
            {
                //общая тема
                BackColor = Color.Black;
                ForeColor = Color.White;
                //тема менюстрип
                menuStrip1.BackColor = Color.Black;
                menuStrip1.ForeColor = Color.White;
                сохранитьToolStripMenuItem.BackColor = Color.Black;
                сохранитьКакToolStripMenuItem.BackColor = Color.Black;
                закрытьToolStripMenuItem.BackColor = Color.Black;
                сохранитьToolStripMenuItem.ForeColor = Color.White;
                сохранитьКакToolStripMenuItem.ForeColor = Color.White;
                закрытьToolStripMenuItem.ForeColor = Color.White;
                открытьФайлToolStripMenuItem.BackColor = Color.Black;
                открытьФайлToolStripMenuItem.ForeColor = Color.White;
                fastColoredTextBox1.BackColor = Color.Black;
                fastColoredTextBox1.ForeColor = Color.White;
                fastColoredTextBox1.LineNumberColor = Color.White;
                fastColoredTextBox1.IndentBackColor = Color.Black;
            }
            else if (t == 1)
            {
                //общая тема
                BackColor = Color.White;
                ForeColor = Color.Black;
                //тема менюстрип
                menuStrip1.BackColor = Color.White;
                menuStrip1.ForeColor = Color.Black;
                сохранитьToolStripMenuItem.BackColor = Color.White;
                сохранитьКакToolStripMenuItem.BackColor = Color.White;
                закрытьToolStripMenuItem.BackColor = Color.White;
                сохранитьToolStripMenuItem.ForeColor = Color.Black;
                сохранитьКакToolStripMenuItem.ForeColor = Color.Black;
                закрытьToolStripMenuItem.ForeColor = Color.Black;
                открытьФайлToolStripMenuItem.BackColor = Color.White;
                открытьФайлToolStripMenuItem.ForeColor = Color.Black;
                fastColoredTextBox1.BackColor = Color.White;
                fastColoredTextBox1.ForeColor = Color.Black;
                fastColoredTextBox1.LineNumberColor = Color.Black;
                fastColoredTextBox1.IndentBackColor = Color.White;
            }
        }

        void lab()
        {
            q = frm1.s;
            int ql = q.Length;
            for (int i = ql - 1; ; i--)
            {
                if (String.Equals(q[i], sl))
                {
                    break;
                }
                else
                {
                    q1 += q[i];
                }
            }
            char[] arr = q1.ToCharArray();
            Array.Reverse(arr);
            string q2 = new string(arr);
            label1.Text = q2;
            q2 = String.Empty;
            q1 = String.Empty;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result, result1;
            result = MessageBox.Show("Сохранить файл?", "Сохранение файла", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                StreamWriter docWR = new StreamWriter(frm1.s);
                docWR.WriteLine(fastColoredTextBox1.Text);
                docWR.Close();
            }
            this.Close();
            frm1.Close();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter docWR = new StreamWriter(frm1.s);
            docWR.WriteLine(fastColoredTextBox1.Text);
            docWR.Close();
        }

        private void сменитьТемуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //////////////////////////
            //Press f to pay respect// 
            //////////////////////////
            StreamWriter docWR = new StreamWriter(frm1.s);
            docWR.WriteLine(fastColoredTextBox1.Text);
            docWR.Close();
            //System.Diagnostics.Process t = new System.Diagnostics.Process();
            //t.StartInfo.FileName = "cmd.exe";
            //t.Start();
            
            //string strCmdText;
            //strCmdText = "help";
            //System.Diagnostics.Process.Start("cmd.exe", strCmdText);
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            string str = @"/K cd C:\Windows\Microsoft.NET\Framework64\v4.0.30319&csc "+q;

            ////string kom = "/k csc ";
            ////kom += frm1.s;
            ////psi.WorkingDirectory = @"/k cd C:\Windows\Microsoft.NET\Framework64\v4.0.30319";
            ////psi.Arguments = @"/c cd C:\Windows\Microsoft.NET\Framework64\v4.0.30319 csc" + frm1.s;

            Console.ReadLine();
            ////psi.Arguments = "/k csc -?";
            Process.Start(@"C:\Windows\System32\cmd.exe", str);

        }

        private void поддержатьРазработчикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://donatty.com/topIDEbesplatno");
        }


        #region Подсветка
        private void fastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
            e.ChangedRange.ClearFoldingMarkers();
            
            e.ChangedRange.SetFoldingMarkers("{", "}");
            e.ChangedRange.SetFoldingMarkers(@"#region\b", @"#endregion\b");
            //Синенький
            //e.ChangedRange.SetStyle(BlueStyle, @"private"); 
            //e.ChangedRange.SetStyle(BlueStyle, @"public");
            //e.ChangedRange.SetStyle(BlueStyle, @"bool");
            //e.ChangedRange.SetStyle(BlueStyle, @"decimal");
            //e.ChangedRange.SetStyle(BlueStyle, @"long");
            //e.ChangedRange.SetStyle(BlueStyle, @"int");
            //e.ChangedRange.SetStyle(BlueStyle, @"ulong");
            //e.ChangedRange.SetStyle(BlueStyle, @"uint");
            //e.ChangedRange.SetStyle(BlueStyle, @"byte");
            //e.ChangedRange.SetStyle(BlueStyle, @"double");
            //e.ChangedRange.SetStyle(BlueStyle, @"float"); 
            //e.ChangedRange.SetStyle(BlueStyle, @"char");
            //e.ChangedRange.SetStyle(BlueStyle, @"string"); 
            //e.ChangedRange.SetStyle(BlueStyle, @"get");
            //e.ChangedRange.SetStyle(BlueStyle, @"set");
            //e.ChangedRange.SetStyle(BlueStyle, @"object");
            //e.ChangedRange.SetStyle(BlueStyle, @"var");
            //e.ChangedRange.SetStyle(BlueStyle, @"new");
            //e.ChangedRange.SetStyle(BlueStyle, @"void");
            //e.ChangedRange.SetStyle(BlueStyle, @"this");
            //e.ChangedRange.SetStyle(BlueStyle, @"using");
            //e.ChangedRange.SetStyle(BlueStyle, @"static");
            //e.ChangedRange.SetStyle(BlueStyle, @"namespase");
            //e.ChangedRange.SetStyle(BlueStyle, @"class");
            //e.ChangedRange.SetStyle(BlueStyle, @"partical");
            //e.ChangedRange.SetStyle(BlueStyle, @"internal"); 
            //e.ChangedRange.SetStyle(BlueStyle, @"args");
            //e.ChangedRange.SetStyle(BlueStyle, @"null");
            //e.ChangedRange.SetStyle(BlueStyle, @"namespace");
            ////Голубой
            //e.ChangedRange.SetStyle(LightBlueStyle, @"sender");
            //Жёлтенький
            e.ChangedRange.SetStyle(YellowStyle, @"Main");
            e.ChangedRange.SetStyle(YellowStyle, @"WriteLine");
            e.ChangedRange.SetStyle(YellowStyle, @"Write");
            e.ChangedRange.SetStyle(YellowStyle, @"ReadLine");
            e.ChangedRange.SetStyle(YellowStyle, @"Read");
            e.ChangedRange.SetStyle(YellowStyle, @"Parse");
            e.ChangedRange.SetStyle(YellowStyle, @"TryParse");
            e.ChangedRange.SetStyle(YellowStyle, @"ReadKey");
            e.ChangedRange.SetStyle(YellowStyle, @"Clear");
            e.ChangedRange.SetStyle(YellowStyle, @"Equals");
            e.ChangedRange.SetStyle(YellowStyle, @"Beep");
            e.ChangedRange.SetStyle(YellowStyle, @"GetCursorPosition");
            e.ChangedRange.SetStyle(YellowStyle, @"ToInt64");
            e.ChangedRange.SetStyle(YellowStyle, @"ToInt16");
            e.ChangedRange.SetStyle(YellowStyle, @"ToInt32");
            e.ChangedRange.SetStyle(YellowStyle, @"ToDouble");
            e.ChangedRange.SetStyle(YellowStyle, @"ToString");
            e.ChangedRange.SetStyle(YellowStyle, @"ToChar");
            e.ChangedRange.SetStyle(YellowStyle, @"ToByte");
            e.ChangedRange.SetStyle(YellowStyle, @"ToSByte");
            e.ChangedRange.SetStyle(YellowStyle, @"ToBoolean");
            e.ChangedRange.SetStyle(YellowStyle, @"ToDataTime");
            e.ChangedRange.SetStyle(YellowStyle, @"ToDecimal");
            e.ChangedRange.SetStyle(YellowStyle, @"ToHexString");
            e.ChangedRange.SetStyle(YellowStyle, @"ToSingle");
            e.ChangedRange.SetStyle(YellowStyle, @"ToUInt16");
            e.ChangedRange.SetStyle(YellowStyle, @"ToUInt32");
            e.ChangedRange.SetStyle(YellowStyle, @"ToUInt64");
            e.ChangedRange.SetStyle(YellowStyle, @"TryToBase64Chars");
            e.ChangedRange.SetStyle(YellowStyle, @"ToBase64String");
            e.ChangedRange.SetStyle(YellowStyle, @"ToBase64CharArray");
            e.ChangedRange.SetStyle(YellowStyle, @"Start");
            e.ChangedRange.SetStyle(YellowStyle, @"ResetColor");
            e.ChangedRange.SetStyle(YellowStyle, @"ForegroundColor");
            e.ChangedRange.SetStyle(YellowStyle, @"BackgroundColor");
            e.ChangedRange.SetStyle(YellowStyle, @"");
            //Фиолетовенький
            e.ChangedRange.SetStyle(VioletStyle, @"if ");
            e.ChangedRange.SetStyle(VioletStyle, @"else");
            e.ChangedRange.SetStyle(VioletStyle, @"for ");
            e.ChangedRange.SetStyle(VioletStyle, @"do");
            e.ChangedRange.SetStyle(VioletStyle, @"while");
            e.ChangedRange.SetStyle(VioletStyle, @"try");
            e.ChangedRange.SetStyle(VioletStyle, @"catch");
            //Зелёненький
            e.ChangedRange.SetStyle(GreenStyle, @"Program");
            e.ChangedRange.SetStyle(GreenStyle, @"Console");
            e.ChangedRange.SetStyle(GreenStyle, @"Convert");
            e.ChangedRange.SetStyle(GreenStyle, @"Process");
            e.ChangedRange.SetStyle(GreenStyle, @"ConsoleColor");
            ////
            //e.ChangedRange.SetStyle(oreStyle, @"""");
        }
        #endregion
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sq;
            saveFileDialog1.ShowDialog(this);
            frm1.s = saveFileDialog1.FileName;
            StreamWriter docWR = new StreamWriter(frm1.s);
            docWR.WriteLine(fastColoredTextBox1.Text);
            docWR.Close();
            StreamReader sr = new StreamReader(frm1.s);
            fastColoredTextBox1.Text = sr.ReadToEnd();
            sr.Close();
            lab();
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result, result1;
            result = MessageBox.Show("Вы уверены, что хотите отерыть ноый файл? Подаробится закрыть старый.", "Открыть файл?", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                result1 = MessageBox.Show("Нужно сохранить открытый файл?", "Сохраняем?", MessageBoxButtons.YesNo);
                if (result1 == System.Windows.Forms.DialogResult.No)
                {
                    openFileDialog1.ShowDialog();
                    StreamReader docOp = new StreamReader(openFileDialog1.FileName);
                    frm1.s = openFileDialog1.FileName;
                    fastColoredTextBox1.Text = docOp.ReadToEnd();
                    docOp.Close();
                    lab();
                }
                else
                {
                    StreamWriter docWR = new StreamWriter(frm1.s);
                    docWR.WriteLine(fastColoredTextBox1.Text);
                    docWR.Close();
                    MessageBox.Show("Успешно сохранено!", "Сохранено.", MessageBoxButtons.OK);
                    openFileDialog1.ShowDialog();
                    StreamReader docOp = new StreamReader(openFileDialog1.FileName);
                    frm1.s = openFileDialog1.FileName;
                    fastColoredTextBox1.Text = docOp.ReadToEnd();
                    docOp.Close();
                    lab();
                }
            }
        }
    }
}