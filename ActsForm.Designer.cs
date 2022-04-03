namespace gimme_oil
{
    partial class ActsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CreateRecord = new System.Windows.Forms.ToolStripButton();
            this.UpdateRecord = new System.Windows.Forms.ToolStripButton();
            this.DeleteRecord = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showPipelineTable = new System.Windows.Forms.Button();
            this.showTankerTable = new System.Windows.Forms.Button();
            this.showRailwayTable = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(575, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.CreateRecord.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // UpdateRecord
            // 
            this.UpdateRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UpdateRecord.Image = ((System.Drawing.Image)(resources.GetObject("UpdateRecord.Image")));
            this.UpdateRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateRecord.Name = "UpdateRecord";
            this.UpdateRecord.Size = new System.Drawing.Size(29, 24);
            this.UpdateRecord.Text = "Редактирование записи";
            this.UpdateRecord.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteRecord.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRecord.Image")));
            this.DeleteRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(29, 24);
            this.DeleteRecord.Text = "Удалить запись";
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
            // showPipelineTable
            // 
            this.showPipelineTable.Location = new System.Drawing.Point(12, 255);
            this.showPipelineTable.Name = "showPipelineTable";
            this.showPipelineTable.Size = new System.Drawing.Size(192, 44);
            this.showPipelineTable.TabIndex = 3;
            this.showPipelineTable.Text = "Трубопровод";
            this.showPipelineTable.UseVisualStyleBackColor = true;
            // 
            // showTankerTable
            // 
            this.showTankerTable.Location = new System.Drawing.Point(12, 305);
            this.showTankerTable.Name = "showTankerTable";
            this.showTankerTable.Size = new System.Drawing.Size(192, 44);
            this.showTankerTable.TabIndex = 4;
            this.showTankerTable.Text = "Танкер";
            this.showTankerTable.UseVisualStyleBackColor = true;
            // 
            // showRailwayTable
            // 
            this.showRailwayTable.Location = new System.Drawing.Point(12, 355);
            this.showRailwayTable.Name = "showRailwayTable";
            this.showRailwayTable.Size = new System.Drawing.Size(192, 44);
            this.showRailwayTable.TabIndex = 5;
            this.showRailwayTable.Text = "Ж/Д";
            this.showRailwayTable.UseVisualStyleBackColor = true;
            this.showRailwayTable.Click += new System.EventHandler(this.button3_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 36);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // ActsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 443);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.showRailwayTable);
            this.Controls.Add(this.showTankerTable);
            this.Controls.Add(this.showPipelineTable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ActsForm";
            this.Text = "Акты приема-сдачи";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CreateRecord;
        private System.Windows.Forms.ToolStripButton UpdateRecord;
        private System.Windows.Forms.ToolStripButton DeleteRecord;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showPipelineTable;
        private System.Windows.Forms.Button showTankerTable;
        private System.Windows.Forms.Button showRailwayTable;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}