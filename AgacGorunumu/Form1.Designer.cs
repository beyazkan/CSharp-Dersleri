namespace AgacGorunumu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("2020");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("23.04.2019");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("01.01.2019");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("2019", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("01.01.2018");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("30.08.2018");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("2018", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("2017");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "20";
            treeNode1.Text = "2020";
            treeNode1.ToolTipText = "2020 Yılı";
            treeNode2.Name = "2";
            treeNode2.Text = "23.04.2019";
            treeNode2.ToolTipText = "Çocuk Bayramı";
            treeNode3.Name = "1";
            treeNode3.Text = "01.01.2019";
            treeNode3.ToolTipText = "Yıl başı";
            treeNode4.Name = "19";
            treeNode4.Text = "2019";
            treeNode4.ToolTipText = "2019 Yılı";
            treeNode5.Name = "11";
            treeNode5.Text = "01.01.2018";
            treeNode5.ToolTipText = "Yılbaşı";
            treeNode6.Name = "5";
            treeNode6.Text = "30.08.2018";
            treeNode6.ToolTipText = "Zafer Bayramı";
            treeNode7.Name = "18";
            treeNode7.Text = "2018";
            treeNode7.ToolTipText = "2018 Yılı";
            treeNode8.Name = "17";
            treeNode8.Text = "2017";
            treeNode8.ToolTipText = "2017 Yılı";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(332, 426);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

