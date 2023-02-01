using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
using PdfToText;
using iTextSharp.text.pdf.parser;

namespace PDFReader
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine voice = new SpeechRecognitionEngine();
        SpeechSynthesizer SS;
        string filedir;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SS = new SpeechSynthesizer();
            SS.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior, 0);
        }

        private void btn_readFile_Click(object sender, EventArgs e)
        {
            //List<string> words = File.ReadAllLines(filedir).ToList();
            //foreach (var i in words)
            //{
            //    tbox.Text += i;
            //}
            //tbox.Text.ToString().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] word = tbox.Text.Split();
            string words = String.Empty;
            foreach (string i in word)
            {
                words += i + " ";
            }
            SS = new SpeechSynthesizer();
            SS.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior, 0);
            //SS.SpeakAsync(tbox.Text.ToString());
            SS.SpeakAsync(words);
            //File.Delete(filedir);
            //filedir = "";
            btnControl.Enabled = btn_openFile.Enabled = true;
            btn_readFile.Enabled = false;
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            //openFD.InitialDirectory = "C:\\";
            openFD.Title = "Select a PDF file";
            openFD.FileName = "";
            openFD.Filter = "PDF files|*.pdf";
            if (openFD.ShowDialog() == DialogResult.Cancel)
            {
                SS.Dispose();
                textBox1.Text = String.Empty;
                tbox.Text = String.Empty;
                btnControl.Enabled = false;
            }
            else
            {
                SS.Dispose();
                tbox.Text = String.Empty;
                btn_openFile.Enabled = false;
                btn_readFile.Enabled = true;
                filedir = openFD.FileName;

                iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(openFD.FileName);
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    sb.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
                tbox.Text = sb.ToString();
                //if (filedir.Substring(filedir.Length - 4) == ".txt")
                //{
                //    File.Copy(filedir, filedir + ".txt");
                //}
                //else
                //{
                //    PDFParser doc = new PDFParser();
                //    doc.ExtractText(filedir, filedir + ".txt");
                //}
                textBox1.Text = filedir;
                filedir = filedir + ".txt";
            }
            
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if (btnControl.Text == "II")
            {
                SS.Pause();
                btnControl.Text = ">";
            }
            else
            {
                SS.Resume();
                btnControl.Text = "II";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new Form2();
            form.ShowDialog();
        }
    }
}
