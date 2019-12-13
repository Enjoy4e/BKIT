using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Lab5;
namespace Lab4
{
    public partial class Searcher : Form
    {
        private List<String> Words;
        public Searcher()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            int m;
            if (Words == null || !Int32.TryParse(max.Text, out m))
                return;
            String a = Pattern.Text;
            WordList.Items.Clear();
            WordList.BeginUpdate();
            foreach (String x in Words)
            {
                if (checkBox1.Checked == true)
                    if ((Levenstein.levdist(x, Pattern.Text)) < m)
                    {
                        WordList.Items.Add(x);
                    }
                if (checkBox1.Checked == false)
                    if ((Levenstein.Distance(x, Pattern.Text)) < m)
                    {
                        WordList.Items.Add(x);
                    }
            }
            WordList.EndUpdate();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            OpenFileDialog readfiledialog;
            readfiledialog = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };
            readfiledialog.ShowDialog();

            stopwatch.Restart();
            String[] tmp = File.ReadAllText(readfiledialog.FileName, Encoding.GetEncoding(1251)).Split(new char[] { '\n', '\r', ' ' , '.',',','!','_','?','=','-','+',':','*',';','{','}','"','[',']' });

            Words = new List<String>();
            foreach (string x in tmp)
            {

                if ((x.Trim() != "") && (!Words.Contains(x)))
                {
                    Words.Add(x);
                }
            }

            stopwatch.Stop();
            Timer.Text = "Timer  " + stopwatch.Elapsed.TotalMilliseconds + "ms";

        }


        private void Searcher_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Searcher_Load_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



    }
}