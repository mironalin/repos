using _2_1071_Miron_Alin.Entities;
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
using System.Xml.Serialization;

namespace _2_1071_Miron_Alin
{
    public partial class MainForm : Form
    {
        private Restaurant Restaurant {  get; set; }
        public MainForm()
        {
            Restaurant = new Restaurant();
            InitializeComponent();
        }

        private void DisplayWaiters()
        {
            lvWaiters.Items.Clear();
            Restaurant.Waiters.Sort();
            foreach (var waiter in Restaurant.Waiters)
            {
                ListViewItem lvi = new ListViewItem(waiter.Name);
                lvi.SubItems.Add(waiter.TablesServed.ToString());
                lvi.SubItems.Add(waiter.StartTime.ToString());
                lvi.Tag = waiter;
                lvWaiters.Items.Add(lvi);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm();
            Waiter waiter = new Waiter();
            form.Waiter = waiter;

            if (form.ShowDialog() == DialogResult.OK)
            {
                Restaurant.Waiters.Add(waiter);
                DisplayWaiters();
            }
        }

        private void lvWaiters_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddEditForm form = new AddEditForm();
            if (lvWaiters.SelectedItems.Count == 1)
            {
                Waiter waiter = lvWaiters.SelectedItems[0].Tag as Waiter;
                form.Waiter = waiter;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    DisplayWaiters();
                }
            }
        }

        private void serializeXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Restaurant));
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(sfd.FileName))
                {
                    serializer.Serialize(fs, Restaurant);
                }
            }
        }

        private void deserializeXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Restaurant));
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.OpenRead(ofd.FileName))
                {
                    Restaurant = (Restaurant)serializer.Deserialize(fs);
                    DisplayWaiters();
                }
            }
        }
    }
}
