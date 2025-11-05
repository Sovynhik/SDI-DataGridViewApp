namespace Lab4_Variant16
{
    partial class FormSearch
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgwResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwResults
            // 
            this.dgwResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwResults.Location = new System.Drawing.Point(0, 0);
            this.dgwResults.Name = "dgwResults";
            this.dgwResults.Size = new System.Drawing.Size(400, 300);
            this.dgwResults.TabIndex = 0;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.dgwResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Результаты поиска";
            ((System.ComponentModel.ISupportInitialize)(this.dgwResults)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgwResults;
    }
}