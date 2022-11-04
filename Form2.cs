using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampaldemoFile
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBinarWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.id = Convert.ToInt32(textid.Text);
                emp.name = txtname.Text;
                emp.salary = Convert.ToInt32(txtsalary.Text);
                FileStream fs = new FileStream(@"F:\WindoFrom\emp.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Binary data save");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                
                FileStream fs = new FileStream(@"F:\WindoFrom\emp.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                emp=(Employee)bf.Deserialize(fs);
                textid.Text=emp.id.ToString();
                txtname.Text=emp.name.ToString();
                txtsalary.Text=emp.salary.ToString();
                fs.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.id = Convert.ToInt32(textid.Text);
                emp.name = txtname.Text;
                emp.salary = Convert.ToInt32(txtsalary.Text);
                FileStream fs = new FileStream(@"F:\WindoFrom\emp.sope", FileMode.Create, FileAccess.Write);
                SoapFormatter bf = new SoapFormatter();
                bf.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("soap data save");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();

                FileStream fs = new FileStream(@"F:\WindoFrom\emp.sope", FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                emp = (Employee)soapFormatter.Deserialize(fs);
                textid.Text = emp.id.ToString();
                txtname.Text = emp.name.ToString();
                txtsalary.Text = emp.salary.ToString();
                fs.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
