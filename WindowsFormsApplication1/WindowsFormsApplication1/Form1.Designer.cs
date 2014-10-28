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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.physicsPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.chemistryPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.mathPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.equation = new System.Windows.Forms.ComboBox();
            this.value = new System.Windows.Forms.ComboBox();
            this.value1 = new System.Windows.Forms.TextBox();
            this.value2 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.calculateButton = new System.Windows.Forms.Button();
            this.valueText1 = new System.Windows.Forms.Label();
            this.valueText2 = new System.Windows.Forms.Label();
            this.valueText3 = new System.Windows.Forms.Label();
            this.value3 = new System.Windows.Forms.TextBox();
            this.valueUnit1 = new System.Windows.Forms.Label();
            this.valueUnit3 = new System.Windows.Forms.Label();
            this.valueUnit2 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 0;
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
            // 
            // mathPanel
            // 
            this.mathPanel.Name = "mathPanel";
            this.mathPanel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mathPanel.Size = new System.Drawing.Size(170, 22);
            this.mathPanel.Text = "Math";
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
            // equation
            // 
            this.equation.FormattingEnabled = true;
            this.equation.Items.AddRange(new object[] {
            "Work",
            "Power",
            "Calorimetric Equation"});
            this.equation.Location = new System.Drawing.Point(12, 27);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(165, 21);
            this.equation.TabIndex = 1;
            this.equation.Text = "Select a equation";
            this.equation.SelectedIndexChanged += new System.EventHandler(this.equalition_SelectedIndexChanged);
            // 
            // value
            // 
            this.value.FormattingEnabled = true;
            this.value.Items.AddRange(new object[] {
            "Force - F",
            "Trajectory - s",
            "Work - W"});
            this.value.Location = new System.Drawing.Point(183, 27);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(121, 21);
            this.value.TabIndex = 2;
            // 
            // value1
            // 
            this.value1.Location = new System.Drawing.Point(43, 88);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(100, 20);
            this.value1.TabIndex = 3;
            // 
            // value2
            // 
            this.value2.Location = new System.Drawing.Point(43, 114);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(100, 20);
            this.value2.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(773, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripLabel
            // 
            this.stripLabel.Name = "stripLabel";
            this.stripLabel.Size = new System.Drawing.Size(70, 17);
            this.stripLabel.Text = "Calculation:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(310, 27);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate!";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // valueText1
            // 
            this.valueText1.AutoSize = true;
            this.valueText1.Location = new System.Drawing.Point(12, 91);
            this.valueText1.Name = "valueText1";
            this.valueText1.Size = new System.Drawing.Size(25, 13);
            this.valueText1.TabIndex = 8;
            this.valueText1.Text = "F = ";
            // 
            // valueText2
            // 
            this.valueText2.AutoSize = true;
            this.valueText2.Location = new System.Drawing.Point(12, 117);
            this.valueText2.Name = "valueText2";
            this.valueText2.Size = new System.Drawing.Size(24, 13);
            this.valueText2.TabIndex = 9;
            this.valueText2.Text = "s = ";
            // 
            // valueText3
            // 
            this.valueText3.AutoSize = true;
            this.valueText3.Location = new System.Drawing.Point(12, 143);
            this.valueText3.Name = "valueText3";
            this.valueText3.Size = new System.Drawing.Size(30, 13);
            this.valueText3.TabIndex = 10;
            this.valueText3.Text = "W = ";
            // 
            // value3
            // 
            this.value3.Location = new System.Drawing.Point(43, 140);
            this.value3.Name = "value3";
            this.value3.Size = new System.Drawing.Size(100, 20);
            this.value3.TabIndex = 5;
            // 
            // valueUnit1
            // 
            this.valueUnit1.AutoSize = true;
            this.valueUnit1.Location = new System.Drawing.Point(149, 91);
            this.valueUnit1.Name = "valueUnit1";
            this.valueUnit1.Size = new System.Drawing.Size(49, 13);
            this.valueUnit1.TabIndex = 11;
            this.valueUnit1.Text = "Newtons";
            // 
            // valueUnit3
            // 
            this.valueUnit3.AutoSize = true;
            this.valueUnit3.Location = new System.Drawing.Point(149, 143);
            this.valueUnit3.Name = "valueUnit3";
            this.valueUnit3.Size = new System.Drawing.Size(37, 13);
            this.valueUnit3.TabIndex = 12;
            this.valueUnit3.Text = "Joules";
            // 
            // valueUnit2
            // 
            this.valueUnit2.AutoSize = true;
            this.valueUnit2.Location = new System.Drawing.Point(149, 117);
            this.valueUnit2.Name = "valueUnit2";
            this.valueUnit2.Size = new System.Drawing.Size(39, 13);
            this.valueUnit2.TabIndex = 13;
            this.valueUnit2.Text = "Meters";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(391, 27);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // scientificCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 506);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.valueUnit2);
            this.Controls.Add(this.valueUnit3);
            this.Controls.Add(this.valueUnit1);
            this.Controls.Add(this.valueText3);
            this.Controls.Add(this.valueText2);
            this.Controls.Add(this.valueText1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.value3);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.value);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "scientificCalculator";
            this.Text = "Scientific Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem physicsPanel;
        private System.Windows.Forms.ToolStripMenuItem chemistryPanel;
        private System.Windows.Forms.ToolStripMenuItem mathPanel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ComboBox equation;
        private System.Windows.Forms.ComboBox value;
        private System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.TextBox value2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label valueText1;
        private System.Windows.Forms.Label valueText2;
        private System.Windows.Forms.Label valueText3;
        private System.Windows.Forms.TextBox value3;
        private System.Windows.Forms.Label valueUnit1;
        private System.Windows.Forms.Label valueUnit3;
        private System.Windows.Forms.Label valueUnit2;
        private System.Windows.Forms.Button updateButton;
    }
}

