using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReadWriteApp
{
    public partial class FileReadWriteUI : Form
    {
        public FileReadWriteUI()
        {
            InitializeComponent();
        }

        private string path = @"C:\Users\BITM-Trainee\Documents\Visual Studio 2013\Projects\FileReadWriteApp\FileReadWriteApp\bin\Debug\studentFile.txt";
        
        //string path = Environment.CurrentDirectory + "/" + "studentFile.txt";

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            FileStream aFileStream = new FileStream(path, FileMode.Append);

            StreamWriter sw = new StreamWriter(aFileStream);

            sw.WriteLine(nameTextBox.Text);
            nameTextBox.Text = "";
            sw.Close();
            aFileStream.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                FileStream aStream = new FileStream(path, FileMode.Open);

                StreamReader sw = new StreamReader(aStream);

                studentNameListBox.Items.Clear();

                while (!sw.EndOfStream)
                {
                    string aLine = sw.ReadLine();
                    studentNameListBox.Items.Add(aLine);

                }

                sw.Close();
                aStream.Close();
            }
        }
    }
}
