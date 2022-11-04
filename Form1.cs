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

namespace SampaldemoFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            try 
            {
                FileStream fs=new FileStream(@"F:\WindoFrom\test.txt",FileMode.Create, FileAccess.Write);
                BinaryWriter bw=new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(textBox1.Text));
                bw.Write(textBox2.Text);
                bw.Write(textBox3.Text);
                bw.Close();
                fs.Close();
                MessageBox.Show("data added to file");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            try 
            {
                FileStream fs =new FileStream(@"F:\WindoFrom\test.txt",FileMode.Open, FileAccess.Read);
                BinaryReader bw=new BinaryReader(fs);
                textBox1.Text=bw.ReadInt32().ToString();
                textBox2.Text=bw.ReadString();
                textBox3.Text=bw.ReadString();
                bw.Close();
                fs.Close();
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCreateDirectory_Click(object sender, EventArgs e)
        {
            string path = @"F:\WindoFrom";
            if(Directory.Exists(path))
            {
                MessageBox.Show("Directory is alrady exists");
            }
            else 
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("created");
            }
        }

        private void BtnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"F:\WindoFrom\test.txt";
            if(File.Exists(path))
            {
                MessageBox.Show("File is already exists");
            }
            else
            {
                File.Create(path);
                MessageBox.Show("File created");
            }

        }

        private void btnWriteStream_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\WindoFrom\info.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw=new StreamWriter(fs);   
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
                fs.Close();
                MessageBox.Show("data added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReadStream_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\WindoFrom\info.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr=new StreamReader(fs);   
                richTextBox1.Text=sr.ReadToEnd();
                sr.Close();
                fs.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
