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
using System.Xml.Linq;

namespace ReadingAFile
{
    public partial class FrmRegistration : Form
    {
        public string FileName { get; private set; }

        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentno = txtStudentNo.Text;
            string lastname = txtLastName.Text;
            string age = txtAge.Text;
            string birthday = dateTimePickerBday.Text;
            string program = cbProgram.Text;
            string firstname = txtFirstName.Text;
            string mi = txtMiddleInitial.Text;
            string gender = cbProgram.Text;
            string contactno = txtContactNo.Text;

            string docPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath2, FileName));

            string[] reg = { "StudentNo.:" + studentno, "FullName:" + firstname + " " + mi + " " + lastname,
                "Program:" + program + "\nAge:" + age, "Birthday:" + birthday, "ContactNo.:" + contactno, "Gender: " + gender };
            Console.WriteLine(studentno);
            
            foreach (string i in reg)
            {
                outputFile.WriteLine(i);
            }
            outputFile.Close();
            MessageBox.Show("Saved");
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord frm = new FrmStudentRecord();
            frm.ShowDialog();
        }
    }
}
