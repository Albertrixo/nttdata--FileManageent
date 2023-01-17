using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NttData.FileManagement.Business.Logic.Contracts;
using NttData.FileManagement.Business.Logic.Implementations;
using NttData.FileManagement.Common.Model;

namespace NttData.FileMaagement.presentation.WinSIte
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsve_Click(object sender, EventArgs e)
        {
            ISTudentService studentService = new StudentService();

            Student student = new Student();
            student.Name = txtNombre.Text;

            studentService.Add(student);

            MessageBox.Show("The Studen is saved");
        }
    }
}
