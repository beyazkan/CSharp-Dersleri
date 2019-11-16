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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<TreeNode> list_dugum = new List<TreeNode>();
            
            list_dugum.Add(new TreeNode("Selam"));
            list_dugum.Add(new TreeNode("Merhaba"));
            list_dugum.Add(new TreeNode("Naber"));

            TreeNode dugum = new TreeNode("Deneme", list_dugum.ToArray());

            treeView1.Nodes.AddRange(new TreeNode[] { dugum });
        }
    }
}
