using System.Windows.Forms;

namespace gimme_oil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таб2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таб3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.там4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетыToolStripMenuItem,
            this.таб2ToolStripMenuItem,
            this.таб3ToolStripMenuItem,
            this.там4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            this.отчетыToolStripMenuItem.Click += new System.EventHandler(this.отчетыToolStripMenuItem_Click);
            // 
            // таб2ToolStripMenuItem
            // 
            this.таб2ToolStripMenuItem.Name = "таб2ToolStripMenuItem";
            this.таб2ToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.таб2ToolStripMenuItem.Text = "Таб 2";
            // 
            // таб3ToolStripMenuItem
            // 
            this.таб3ToolStripMenuItem.Name = "таб3ToolStripMenuItem";
            this.таб3ToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.таб3ToolStripMenuItem.Text = "Таб3";
            // 
            // там4ToolStripMenuItem
            // 
            this.там4ToolStripMenuItem.Name = "там4ToolStripMenuItem";
            this.там4ToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.там4ToolStripMenuItem.Text = "Таб4";
            this.там4ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = "321";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem отчетыToolStripMenuItem;
        private ToolStripMenuItem таб2ToolStripMenuItem;
        private ToolStripMenuItem таб3ToolStripMenuItem;
        private ToolStripMenuItem там4ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}

