using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            switch (node.Text)
            {
                case "Calculator":
                    // y.Dispose();
                    jijo.Controls.Clear();
                    Form2 fifi = new Form2();
                    fifi.TopLevel = false;
                    jijo.Controls.Add(fifi);
                    // y.Dock = DockStyle.Fill;
                    fifi.Show();

                    break;
                case "Names":
                    // y.Dispose();
                    jijo.Controls.Clear();
                    Form3 f = new Form3();
                    f.TopLevel = false;
                    jijo.Controls.Add(f);
                    // y.Dock = DockStyle.Fill;
                    f.Show();

                    break;
                case "reg.no":
                    // y.Dispose();
                    jijo.Controls.Clear();
                    Form4 y = new Form4();
                    y.TopLevel = false;
                    jijo.Controls.Add(y);
                    // y.Dock = DockStyle.Fill;
                    y.Show();

                    break;
                case "Room1":
                    // y.Dispose();
                    jijo.Controls.Clear();
                    Form5 x = new Form5();
                    x.TopLevel = false;
                    jijo.Controls.Add(x);
                    // y.Dock = DockStyle.Fill;
                    x.Show();

                    break;
               
            }
        }
    }
}
