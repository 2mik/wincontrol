namespace GroupPanelSample
{
    partial class FrmFirst
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
            flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            groupPanel1 = new WinControl.GroupPanel();
            btnApply = new System.Windows.Forms.Button();
            textBox6 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            textBox5 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            groupPanel2 = new WinControl.GroupPanel();
            comboBox3 = new System.Windows.Forms.ComboBox();
            label9 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            flowLayoutPanel.SuspendLayout();
            groupPanel1.ContentPanel.SuspendLayout();
            groupPanel2.ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(groupPanel1);
            flowLayoutPanel.Controls.Add(groupPanel2);
            flowLayoutPanel.Location = new System.Drawing.Point(9, 9);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new System.Drawing.Size(590, 400);
            flowLayoutPanel.TabIndex = 0;
            // 
            // groupPanel1
            // 
            // 
            // 
            // 
            groupPanel1.ContentPanel.BackColor = System.Drawing.Color.FromArgb(232, 230, 215);
            groupPanel1.ContentPanel.Controls.Add(btnApply);
            groupPanel1.ContentPanel.Controls.Add(textBox6);
            groupPanel1.ContentPanel.Controls.Add(label6);
            groupPanel1.ContentPanel.Controls.Add(textBox5);
            groupPanel1.ContentPanel.Controls.Add(label5);
            groupPanel1.ContentPanel.Controls.Add(textBox4);
            groupPanel1.ContentPanel.Controls.Add(label4);
            groupPanel1.ContentPanel.Controls.Add(textBox3);
            groupPanel1.ContentPanel.Controls.Add(label3);
            groupPanel1.ContentPanel.Controls.Add(textBox2);
            groupPanel1.ContentPanel.Controls.Add(label2);
            groupPanel1.ContentPanel.Controls.Add(textBox1);
            groupPanel1.ContentPanel.Controls.Add(label1);
            groupPanel1.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            groupPanel1.ContentPanel.Location = new System.Drawing.Point(0, 20);
            groupPanel1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupPanel1.ContentPanel.Name = "pnlContent";
            groupPanel1.ContentPanel.Size = new System.Drawing.Size(580, 130);
            groupPanel1.ContentPanel.TabIndex = 1;
            groupPanel1.Location = new System.Drawing.Point(4, 3);
            groupPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupPanel1.Name = "groupPanel1";
            groupPanel1.Size = new System.Drawing.Size(580, 150);
            groupPanel1.TabIndex = 0;
            groupPanel1.TitleText = "Group Panel 1";
            groupPanel1.TitleClick += groupPanel_TitleClick;
            // 
            // btnApply
            // 
            btnApply.BackColor = System.Drawing.Color.FromArgb(221, 220, 203);
            btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnApply.Location = new System.Drawing.Point(348, 64);
            btnApply.Name = "btnApply";
            btnApply.Size = new System.Drawing.Size(70, 23);
            btnApply.TabIndex = 12;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(242, 64);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(100, 23);
            textBox6.TabIndex = 11;
            textBox6.Text = "Text C";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Location = new System.Drawing.Point(179, 68);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(60, 15);
            label6.TabIndex = 10;
            label6.Text = "Some text";
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(242, 38);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(100, 23);
            textBox5.TabIndex = 7;
            textBox5.Text = "Text B";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Location = new System.Drawing.Point(179, 42);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 15);
            label5.TabIndex = 6;
            label5.Text = "Some text";
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(242, 12);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(100, 23);
            textBox4.TabIndex = 3;
            textBox4.Text = "Text A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Location = new System.Drawing.Point(179, 16);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 15);
            label4.TabIndex = 2;
            label4.Text = "Some text";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(73, 64);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(100, 23);
            textBox3.TabIndex = 9;
            textBox3.Text = "Text 3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Location = new System.Drawing.Point(10, 68);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Some text";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(73, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "Text 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Location = new System.Drawing.Point(10, 42);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Some text";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(73, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Text 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(10, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Some text";
            // 
            // groupPanel2
            // 
            // 
            // 
            // 
            groupPanel2.ContentPanel.BackColor = System.Drawing.Color.FromArgb(232, 230, 215);
            groupPanel2.ContentPanel.Controls.Add(comboBox3);
            groupPanel2.ContentPanel.Controls.Add(label9);
            groupPanel2.ContentPanel.Controls.Add(comboBox2);
            groupPanel2.ContentPanel.Controls.Add(label8);
            groupPanel2.ContentPanel.Controls.Add(comboBox1);
            groupPanel2.ContentPanel.Controls.Add(label7);
            groupPanel2.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            groupPanel2.ContentPanel.Location = new System.Drawing.Point(0, 20);
            groupPanel2.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupPanel2.ContentPanel.Name = "pnlContent";
            groupPanel2.ContentPanel.Size = new System.Drawing.Size(300, 130);
            groupPanel2.ContentPanel.TabIndex = 1;
            groupPanel2.ContentPanel.Visible = false;
            groupPanel2.Expanded = false;
            groupPanel2.Location = new System.Drawing.Point(4, 159);
            groupPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupPanel2.Name = "groupPanel2";
            groupPanel2.Size = new System.Drawing.Size(580, 20);
            groupPanel2.TabIndex = 1;
            groupPanel2.TitleText = "Group Panel 2";
            groupPanel2.TitleClick += groupPanel_TitleClick;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            comboBox3.Location = new System.Drawing.Point(78, 66);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(121, 23);
            comboBox3.TabIndex = 5;
            comboBox3.Text = "Item 3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Location = new System.Drawing.Point(10, 70);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(65, 15);
            label9.TabIndex = 4;
            label9.Text = "Select item";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            comboBox2.Location = new System.Drawing.Point(78, 39);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(121, 23);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "Item 2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Location = new System.Drawing.Point(10, 43);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(65, 15);
            label8.TabIndex = 2;
            label8.Text = "Select item";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            comboBox1.Location = new System.Drawing.Point(78, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Item 1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Location = new System.Drawing.Point(10, 16);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(65, 15);
            label7.TabIndex = 0;
            label7.Text = "Select item";
            // 
            // FrmFirst
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(612, 426);
            Controls.Add(flowLayoutPanel);
            Name = "FrmFirst";
            Text = "First Page";
            flowLayoutPanel.ResumeLayout(false);
            groupPanel1.ContentPanel.ResumeLayout(false);
            groupPanel1.ContentPanel.PerformLayout();
            groupPanel2.ContentPanel.ResumeLayout(false);
            groupPanel2.ContentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private WinControl.GroupPanel groupPanel1;
        private WinControl.GroupPanel groupPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
    }
}