using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoIOFile
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee= new Employee();
                employee.EmpId =Convert.ToInt32(txtEmpID.Text);
                employee.Name = txtEmpName.Text;
                employee.Salary = Convert.ToInt32(txtEmpSalary.Text);
                FileStream fs = new FileStream(@"D:\DemoIOFile\emp.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("Binary data is saved");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                FileStream fs = new FileStream(@"D:\DemoIOFile\emp.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                employee = (Employee)binary.Deserialize(fs);
                txtEmpID.Text = employee.EmpId.ToString();
                txtEmpName.Text = employee.Name;
                txtEmpSalary.Text = employee.Salary.ToString();
                fs.Close();
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.EmpId = Convert.ToInt32(txtEmpID.Text);
                employee.Name = txtEmpName.Text;
                employee.Salary = Convert.ToInt32(txtEmpSalary.Text);
                FileStream fs = new FileStream(@"D:\DemoIOFile\emp.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                xml.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("XML data is saved");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                FileStream fs = new FileStream(@"D:\DemoIOFile\emp.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                employee = (Employee)xml.Deserialize(fs);
                txtEmpID.Text = employee.EmpId.ToString();
                txtEmpName.Text = employee.Name;
                txtEmpSalary.Text = employee.Salary.ToString();
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
                Employee employee = new Employee();
                employee.EmpId = Convert.ToInt32(txtEmpID.Text);
                employee.Name = txtEmpName.Text;
                employee.Salary = Convert.ToInt32(txtEmpSalary.Text);
                FileStream fs = new FileStream(@"D:\DemoIOFile\emp.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("SOAP data is saved");

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
                Employee employee = new Employee();
                FileStream fs = new FileStream(@"D:\DemoIOFile\emp.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                employee = (Employee)sf.Deserialize(fs);
                txtEmpID.Text = employee.EmpId.ToString();
                txtEmpName.Text = employee.Name;
                txtEmpSalary.Text = employee.Salary.ToString();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.EmpId = Convert.ToInt32(txtEmpID.Text);
                employee.Name = txtEmpName.Text;
                employee.Salary = Convert.ToInt32(txtEmpSalary.Text);
                FileStream fs = new FileStream(@"D:\DemoIOFile\emp.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Employee>(fs, employee);
                fs.Close();
                MessageBox.Show("JSON data is saved");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                FileStream fs = new FileStream(@"D:\DemoIOFile\emp.json", FileMode.Open, FileAccess.Read);
                employee=JsonSerializer.Deserialize<Employee>(fs);
                txtEmpID.Text=employee.EmpId.ToString();
                txtEmpName.Text = employee.Name;
                txtEmpSalary.Text=employee.Salary.ToString();   
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
