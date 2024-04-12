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
    public partial class MainForm : Form
    {
        private Farm Farm { get; set; }
        public MainForm()
        {
            Farm = new Farm();
            InitializeComponent();

            treeView1.NodeMouseDoubleClick += treeView1_NodeMouseDoubleClick;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTractor_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm();
            Tractor tractor = new Tractor();
            form.Tractor = tractor;

            if (form.ShowDialog() == DialogResult.OK)
            {
                Farm.Tractors.Add(tractor);
                PopulateTreeView();
            }
        }

        private void PopulateTreeView()
        {
            treeView1.Nodes.Clear();
            Farm.Tractors.Sort();

            foreach(var tractor in Farm.Tractors)
            {
                TreeNode node = new TreeNode(tractor.ToString());
                treeView1.Nodes.Add(node);
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != null)
            {
                TreeNode selectedNode = e.Node;
                int selectedIndex = treeView1.Nodes.IndexOf(selectedNode);
                Tractor tractor = Farm.Tractors[selectedIndex];

                using(var form2 = new AddEditForm())
                {
                    form2.Tractor = tractor;
                    if (DialogResult.OK == form2.ShowDialog())
                    {
                        Farm.Tractors[selectedIndex] = form2.Tractor;
                        PopulateTreeView();
                        
                    }
                }
            }
        }
    }
}
