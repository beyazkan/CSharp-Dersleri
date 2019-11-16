using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgacGorunumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treeView1.Nodes.Add("2018");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<TreeNode> listofDate = new List<TreeNode>();

            listofDate.Add(new TreeNode("2017"));
            listofDate.Add(new TreeNode("2016"));


            treeView1.Nodes.AddRange(listofDate.ToArray());
        }
    }
}
