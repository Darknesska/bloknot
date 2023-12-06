using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;
using System.Media;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace bloknot
{
    
    public partial class Form1 : Form
    {
        private Font font;
        
        
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter ="Текстовые файлы (*.txt)|*.txt";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            saveAsFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            openFileDialog1.FileName = @"Text2.txt";
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText($"{openFileDialog1.FileName}", textBox1.Text);
            MessageBox.Show("Вы сохранили файл");
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playSimpleSound1();
            if (saveAsFileDialog.ShowDialog() == DialogResult.Cancel) return;
            string text = textBox1.Text;
            File.WriteAllText(saveAsFileDialog.FileName, text);
            MessageBox.Show("Вы успешно сохранили файл");
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playSimpleSound();
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == String.Empty) return;
           
            try
            {
                var stramReader = new StreamReader(
                openFileDialog1.FileName, Encoding.GetEncoding(1251));
                textBox1.Text = stramReader.ReadToEnd();
                stramReader.Close();
            }
            catch (FileNotFoundException error)
            {
                MessageBox.Show(error.Message + "\nНет такого файла или вы не выбрали ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit exit = new Exit();
            exit.ShowDialog();
            
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void aboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тext editor");
        }

        private void createrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From Darknes");
        }
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Darknes\Downloads\123444.wav");
            simpleSound.Play();
        }
        private void playSimpleSound1()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Darknes\Downloads\sun_strike.wav");
            simpleSound.Play();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void cancelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(printDialog1.ShowDialog() == DialogResult.OK) 
            {   
                printDocument1.PrinterSettings=printDialog1.PrinterSettings;
                printDocument1.Print();
                
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string text = textBox1.Text;
            e.Graphics.DrawString(text, this.font, Brushes.Black,10,10);
        }

        private void pageParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = new System.Drawing.Printing.PageSettings();
            pageSetupDialog1.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            pageSetupDialog1.ShowNetwork = false;

            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                object[] results = new object[]
                {
            pageSetupDialog1.PageSettings.Margins,
            pageSetupDialog1.PageSettings.PaperSize,
            pageSetupDialog1.PageSettings.Landscape,
            pageSetupDialog1.PrinterSettings.PrinterName,
            pageSetupDialog1.PrinterSettings.PrintRange
                };

            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.font=fontDialog1.Font;
                MessageBox.Show(this.font.Name);
            }
        }

        private void ggToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Зря ты так далеко зашел");
           Application.Exit();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();

        }
    }
}
