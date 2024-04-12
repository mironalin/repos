using _2_1071_Miron_Alin.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1071_Miron_Alin
{
    public partial class AddEditForm : Form
    {
        public Waiter Waiter { get; set; }
        public AddEditForm()
        {
            InitializeComponent();
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            if (Waiter != null)
            {
                tbName.Text = Waiter.Name;
                nudTablesServed.Value = Waiter.TablesServed;
                dtpStartTime.Value = Waiter.StartTime;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Waiter != null)
            {
                Waiter.Name = tbName.Text;
                Waiter.TablesServed = (int)nudTablesServed.Value;
                Waiter.StartTime = dtpStartTime.Value;
            }

            if (!ValidateChildren())
            {
                MessageBox.Show("The form contains errors!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
        }

        private bool isNameValid()
        {
            return string.IsNullOrWhiteSpace(tbName.Text.Trim());
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (isNameValid())
            {
                e.Cancel = true;
                epName.SetError((Control)sender, "Last name is empty!");
            }
        }

        private void tbName_Validated(object sender, EventArgs e)
        {
            epName.SetError((Control)sender, string.Empty);
        }
        private void nudTablesServed_Validating(object sender, CancelEventArgs e)
        {
            if (nudTablesServed.Value >= 100)
            {
                e.Cancel = true;
                epTablesServed.SetError((Control)sender, "Impossible! A waiter can't serve more than 100 tables!");
            }
        }
        private void nudTablesServed_Validated(object sender, EventArgs e)
        {
            epTablesServed.SetError((Control)sender, string.Empty);
        }


    }
}
