namespace CMSwinformApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            menuStrip1 = new MenuStrip();
            workerToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            jobDetiToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 179);
            label1.Name = "label1";
            label1.Size = new Size(599, 48);
            label1.TabIndex = 0;
            label1.Text = " Customer Maintenance project";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(600, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(41, 28);
            comboBox1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { workerToolStripMenuItem, customerToolStripMenuItem, jobDetiToolStripMenuItem, reportsToolStripMenuItem, eToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // workerToolStripMenuItem
            // 
            workerToolStripMenuItem.Name = "workerToolStripMenuItem";
            workerToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.W;
            workerToolStripMenuItem.Size = new Size(77, 24);
            workerToolStripMenuItem.Text = "&Worker";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            customerToolStripMenuItem.Size = new Size(94, 24);
            customerToolStripMenuItem.Text = "&Customer";
            // 
            // jobDetiToolStripMenuItem
            // 
            jobDetiToolStripMenuItem.Name = "jobDetiToolStripMenuItem";
            jobDetiToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.J;
            jobDetiToolStripMenuItem.Size = new Size(102, 24);
            jobDetiToolStripMenuItem.Text = "&Job Details";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.R;
            reportsToolStripMenuItem.Size = new Size(81, 24);
            reportsToolStripMenuItem.Text = "&Reports";
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            eToolStripMenuItem.Size = new Size(49, 24);
            eToolStripMenuItem.Text = "E&xit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem workerToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem jobDetiToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
    }
}