using ST03_2_1071_Miron_Alin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST03_2_1071_Miron_Alin
{
    public partial class AddEditForm : Form
    {
        public Tractor Tractor { get; set; }
        public AddEditForm()
        {
            InitializeComponent();
            nudHP.Controls[0].Visible = false;
            nudPrice.Controls[0].Visible = false;
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            if (Tractor != null)
            {
                tbBrand.Text = Tractor.Brand;
                nudHP.Value = Tractor.Horsepower;
                nudPrice.Value = new decimal(Tractor.Price);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Tractor != null)
            {
                Tractor.Brand = tbBrand.Text;
                Tractor.Horsepower = (int)nudHP.Value;
                Tractor.Price = (double)nudPrice.Value;
            }
        }
    }
}
