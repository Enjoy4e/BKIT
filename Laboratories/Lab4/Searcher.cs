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
            if (Words == null)
                return;
            String a = Pattern.Text;
            WordList.Items.Clear();
            WordList.BeginUpdate();
            foreach (String x in Words)
            {
                if (x.ToLower().Contains(a.ToLower()))
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



    }
}