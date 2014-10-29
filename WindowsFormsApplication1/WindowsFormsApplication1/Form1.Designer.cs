namespace WindowsFormsApplication1
{
    partial class scientificCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scientificCalculator));
            this.equation = new System.Windows.Forms.ComboBox();
            this.value = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.calculateButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textValue1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.physicsPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.chemistryPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.mathPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.textValue2 = new System.Windows.Forms.Label();
            this.textValue3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textValue4 = new System.Windows.Forms.Label();
            this.textValue7 = new System.Windows.Forms.Label();
            this.textValue6 = new System.Windows.Forms.Label();
            this.textValue5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // equation
            // 
            this.equation.FormattingEnabled = true;
            this.equation.Location = new System.Drawing.Point(12, 27);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(165, 21);
            this.equation.TabIndex = 1;
            this.equation.Text = "Select a equation";
            // 
            // value
            // 
            this.value.FormattingEnabled = true;
            this.value.Location = new System.Drawing.Point(183, 27);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(100, 21);
            this.value.TabIndex = 2;
            this.value.Text = "Select a value";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(770, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripLabel
            // 
            this.stripLabel.Name = "stripLabel";
            this.stripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(289, 25);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate!";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            this.calculateButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(43, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(370, 25);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(43, 244);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(43, 218);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(43, 192);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(43, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 22;
            // 
            // textValue1
            // 
            this.textValue1.AutoSize = true;
            this.textValue1.Location = new System.Drawing.Point(9, 91);
            this.textValue1.Name = "textValue1";
            this.textValue1.Size = new System.Drawing.Size(0, 13);
            this.textValue1.TabIndex = 28;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.physicsPanel,
            this.chemistryPanel,
            this.mathPanel,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // physicsPanel
            // 
            this.physicsPanel.Name = "physicsPanel";
            this.physicsPanel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.physicsPanel.Size = new System.Drawing.Size(170, 22);
            this.physicsPanel.Text = "Physics";
            this.physicsPanel.Click += new System.EventHandler(this.physicsPanel_Click);
            // 
            // chemistryPanel
            // 
            this.chemistryPanel.Name = "chemistryPanel";
            this.chemistryPanel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.chemistryPanel.Size = new System.Drawing.Size(170, 22);
            this.chemistryPanel.Text = "Chemistry";
            this.chemistryPanel.Click += new System.EventHandler(this.chemistryPanel_Click);
            // 
            // mathPanel
            // 
            this.mathPanel.Name = "mathPanel";
            this.mathPanel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mathPanel.Size = new System.Drawing.Size(170, 22);
            this.mathPanel.Text = "Math";
            this.mathPanel.Click += new System.EventHandler(this.mathPanel_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(52, 20);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // textValue2
            // 
            this.textValue2.AutoSize = true;
            this.textValue2.Location = new System.Drawing.Point(9, 117);
            this.textValue2.Name = "textValue2";
            this.textValue2.Size = new System.Drawing.Size(0, 13);
            this.textValue2.TabIndex = 30;
            // 
            // textValue3
            // 
            this.textValue3.AutoSize = true;
            this.textValue3.Location = new System.Drawing.Point(9, 143);
            this.textValue3.Name = "textValue3";
            this.textValue3.Size = new System.Drawing.Size(0, 13);
            this.textValue3.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 34;
            // 
            // textValue4
            // 
            this.textValue4.AutoSize = true;
            this.textValue4.Location = new System.Drawing.Point(9, 169);
            this.textValue4.Name = "textValue4";
            this.textValue4.Size = new System.Drawing.Size(0, 13);
            this.textValue4.TabIndex = 35;
            // 
            // textValue7
            // 
            this.textValue7.AutoSize = true;
            this.textValue7.Location = new System.Drawing.Point(9, 247);
            this.textValue7.Name = "textValue7";
            this.textValue7.Size = new System.Drawing.Size(0, 13);
            this.textValue7.TabIndex = 36;
            // 
            // textValue6
            // 
            this.textValue6.AutoSize = true;
            this.textValue6.Location = new System.Drawing.Point(9, 221);
            this.textValue6.Name = "textValue6";
            this.textValue6.Size = new System.Drawing.Size(0, 13);
            this.textValue6.TabIndex = 37;
            // 
            // textValue5
            // 
            this.textValue5.AutoSize = true;
            this.textValue5.Location = new System.Drawing.Point(9, 195);
            this.textValue5.Name = "textValue5";
            this.textValue5.Size = new System.Drawing.Size(0, 13);
            this.textValue5.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 43;
            // 
            // scientificCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textValue5);
            this.Controls.Add(this.textValue6);
            this.Controls.Add(this.textValue7);
            this.Controls.Add(this.textValue4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textValue3);
            this.Controls.Add(this.textValue2);
            this.Controls.Add(this.textValue1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.value);
            this.Controls.Add(this.equation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "scientificCalculator";
            this.Text = "Scientific Calculator";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox equation;
        private System.Windows.Forms.ComboBox value;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label textValue1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem physicsPanel;
        private System.Windows.Forms.ToolStripMenuItem chemistryPanel;
        private System.Windows.Forms.ToolStripMenuItem mathPanel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.Label textValue2;
        private System.Windows.Forms.Label textValue3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textValue4;
        private System.Windows.Forms.Label textValue7;
        private System.Windows.Forms.Label textValue6;
        private System.Windows.Forms.Label textValue5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

