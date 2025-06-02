using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebApp
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.FullName = teFullName.Text;
            student.Age = teAge.Text;
            student.Gender = teGender.Text;
            student.Address = teAddress.Text;
            student.ContactNumber = teContactNumber.Text;

            students.Add(student);
            gcStudents.DataSource = students;
            gcStudents.RefreshDataSource();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.FullName = teFullName.Text;
            student.Age = teAge.Text;
            student.Gender = teGender.Text;
            student.Address = teAddress.Text;
            student.ContactNumber = teContactNumber.Text;

            gcStudents.DataSource = students;
            students[gvStudents.FocusedRowHandle] = student;
            gcStudents.RefreshDataSource();
        }
    }
}
