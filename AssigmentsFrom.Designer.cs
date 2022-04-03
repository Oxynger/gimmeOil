namespace gimme_oil
{
    partial class AssigmentsFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssigmentsFrom));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CreateRecord = new System.Windows.Forms.ToolStripButton();
            this.UpdateRecord = new System.Windows.Forms.ToolStripButton();
            this.DeleteRecord = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(344, 409);
            this.dataGridView1.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateRecord,
            this.UpdateRecord,
            this.DeleteRecord});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(579, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // CreateRecord
            // 
            this.CreateRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateRecord.Image = ((System.Drawing.Image)(resources.GetObject("CreateRecord.Image")));
            this.CreateRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateRecord.Name = "CreateRecord";
            this.CreateRecord.Size = new System.Drawing.Size(29, 24);
            this.CreateRecord.Text = "Создать запись";
            this.CreateRecord.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.CreateRecord.Click += new System.EventHandler(this.CreateRecord_Click);
            // 
            // UpdateRecord
            // 
            this.UpdateRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UpdateRecord.Image = ((System.Drawing.Image)(resources.GetObject("UpdateRecord.Image")));
            this.UpdateRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateRecord.Name = "UpdateRecord";
            this.UpdateRecord.Size = new System.Drawing.Size(29, 24);
            this.UpdateRecord.Text = "Редактирование записи";
            this.UpdateRecord.Click += new System.EventHandler(this.UpdateRecord_Click);
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteRecord.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRecord.Image")));
            this.DeleteRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(29, 24);
            this.DeleteRecord.Text = "Удалить запись";
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // AssigmentsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AssigmentsFrom";
            this.Text = "Маршрутные поручения";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CreateRecord;
        private System.Windows.Forms.ToolStripButton UpdateRecord;
        private System.Windows.Forms.ToolStripButton DeleteRecord;
    }
}

