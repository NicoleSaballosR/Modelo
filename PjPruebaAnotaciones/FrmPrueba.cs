using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjPruebaAnotaciones
{
    public partial class FrmPrueba : Form
    {
        Employee obJe = new();
        public FrmPrueba()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                obJe.IdNumber = int.Parse(txtIDNumber.Text);    
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                obJe.FirstName = txtFirstName.Text;
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                obJe.LastName = txtLastName.Text;
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIDNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
