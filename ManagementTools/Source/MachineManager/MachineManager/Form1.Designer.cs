namespace MachineManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DisplayListView = new System.Windows.Forms.ListView();
            this.MachineNameBox = new System.Windows.Forms.TextBox();
            this.MachineIDBox = new System.Windows.Forms.TextBox();
            this.PlantBox = new System.Windows.Forms.TextBox();
            this.LineBox = new System.Windows.Forms.TextBox();
            this.MachineNameLabel = new System.Windows.Forms.Label();
            this.LineLabel = new System.Windows.Forms.Label();
            this.PlantLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TheoreticalLabel = new System.Windows.Forms.Label();
            this.TheoreticalBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EngineerBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayListView
            // 
            this.DisplayListView.Location = new System.Drawing.Point(13, 33);
            this.DisplayListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DisplayListView.Name = "DisplayListView";
            this.DisplayListView.Size = new System.Drawing.Size(1199, 510);
            this.DisplayListView.TabIndex = 0;
            this.DisplayListView.UseCompatibleStateImageBehavior = false;
            // 
            // MachineNameBox
            // 
            this.MachineNameBox.Location = new System.Drawing.Point(1351, 65);
            this.MachineNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MachineNameBox.Name = "MachineNameBox";
            this.MachineNameBox.Size = new System.Drawing.Size(111, 22);
            this.MachineNameBox.TabIndex = 1;
            // 
            // MachineIDBox
            // 
            this.MachineIDBox.Location = new System.Drawing.Point(1351, 33);
            this.MachineIDBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MachineIDBox.Name = "MachineIDBox";
            this.MachineIDBox.ReadOnly = true;
            this.MachineIDBox.Size = new System.Drawing.Size(111, 22);
            this.MachineIDBox.TabIndex = 2;
            // 
            // PlantBox
            // 
            this.PlantBox.Location = new System.Drawing.Point(1351, 129);
            this.PlantBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlantBox.Name = "PlantBox";
            this.PlantBox.Size = new System.Drawing.Size(111, 22);
            this.PlantBox.TabIndex = 3;
            // 
            // LineBox
            // 
            this.LineBox.Location = new System.Drawing.Point(1351, 97);
            this.LineBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LineBox.Name = "LineBox";
            this.LineBox.Size = new System.Drawing.Size(111, 22);
            this.LineBox.TabIndex = 5;
            // 
            // MachineNameLabel
            // 
            this.MachineNameLabel.AutoSize = true;
            this.MachineNameLabel.Location = new System.Drawing.Point(1237, 69);
            this.MachineNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MachineNameLabel.Name = "MachineNameLabel";
            this.MachineNameLabel.Size = new System.Drawing.Size(98, 17);
            this.MachineNameLabel.TabIndex = 6;
            this.MachineNameLabel.Text = "MachineName";
            // 
            // LineLabel
            // 
            this.LineLabel.AutoSize = true;
            this.LineLabel.Location = new System.Drawing.Point(1237, 101);
            this.LineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LineLabel.Name = "LineLabel";
            this.LineLabel.Size = new System.Drawing.Size(35, 17);
            this.LineLabel.TabIndex = 7;
            this.LineLabel.Text = "Line";
            // 
            // PlantLabel
            // 
            this.PlantLabel.AutoSize = true;
            this.PlantLabel.Location = new System.Drawing.Point(1237, 138);
            this.PlantLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlantLabel.Name = "PlantLabel";
            this.PlantLabel.Size = new System.Drawing.Size(40, 17);
            this.PlantLabel.TabIndex = 9;
            this.PlantLabel.Text = "Plant";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1484, 27);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(103, 24);
            this.toolStripButton1.Text = "New Machine";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(99, 24);
            this.toolStripButton2.Text = "Edit Machine";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(117, 24);
            this.toolStripButton3.Text = "Delete Machine";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(62, 24);
            this.toolStripButton4.Text = "Refresh";
            this.toolStripButton4.Click += new System.EventHandler(this.ToolStripButton4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // TheoreticalLabel
            // 
            this.TheoreticalLabel.AutoSize = true;
            this.TheoreticalLabel.Location = new System.Drawing.Point(1237, 169);
            this.TheoreticalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TheoreticalLabel.Name = "TheoreticalLabel";
            this.TheoreticalLabel.Size = new System.Drawing.Size(79, 17);
            this.TheoreticalLabel.TabIndex = 15;
            this.TheoreticalLabel.Text = "Theoretical";
            // 
            // TheoreticalBox
            // 
            this.TheoreticalBox.Location = new System.Drawing.Point(1351, 166);
            this.TheoreticalBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TheoreticalBox.Name = "TheoreticalBox";
            this.TheoreticalBox.Size = new System.Drawing.Size(111, 22);
            this.TheoreticalBox.TabIndex = 14;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(1237, 257);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(47, 17);
            this.ErrorLabel.TabIndex = 17;
            this.ErrorLabel.Text = "Errors";
            // 
            // ErrorBox
            // 
            this.ErrorBox.Location = new System.Drawing.Point(1307, 254);
            this.ErrorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ErrorBox.Multiline = true;
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(156, 288);
            this.ErrorBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1237, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Engineer";
            // 
            // EngineerBox
            // 
            this.EngineerBox.Location = new System.Drawing.Point(1351, 197);
            this.EngineerBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EngineerBox.Name = "EngineerBox";
            this.EngineerBox.Size = new System.Drawing.Size(111, 22);
            this.EngineerBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1237, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "SNPID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EngineerBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.TheoreticalLabel);
            this.Controls.Add(this.TheoreticalBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PlantLabel);
            this.Controls.Add(this.LineLabel);
            this.Controls.Add(this.MachineNameLabel);
            this.Controls.Add(this.LineBox);
            this.Controls.Add(this.PlantBox);
            this.Controls.Add(this.MachineIDBox);
            this.Controls.Add(this.MachineNameBox);
            this.Controls.Add(this.DisplayListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DisplayListView;
        private System.Windows.Forms.TextBox MachineNameBox;
        private System.Windows.Forms.TextBox MachineIDBox;
        private System.Windows.Forms.TextBox PlantBox;
        private System.Windows.Forms.TextBox LineBox;
        private System.Windows.Forms.Label MachineNameLabel;
        private System.Windows.Forms.Label LineLabel;
        private System.Windows.Forms.Label PlantLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label TheoreticalLabel;
        private System.Windows.Forms.TextBox TheoreticalBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox ErrorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EngineerBox;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Label label2;
    }
}

