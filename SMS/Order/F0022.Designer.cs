namespace SMS.Order
{
    partial class F0022
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dSF0006BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_F0006 = new SMS.Report.DS_F0006();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dSF0006BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_F0006)).BeginInit();
            this.SuspendLayout();
            // 
            // dSF0006BindingSource
            // 
            this.dSF0006BindingSource.DataSource = this.dS_F0006;
            this.dSF0006BindingSource.Position = 0;
            // 
            // dS_F0006
            // 
            this.dS_F0006.DataSetName = "DS_F0006";
            this.dS_F0006.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "SaleInfo";
            reportDataSource1.Value = this.dSF0006BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SMS.Report.RF0022.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(850, 1000);
            this.reportViewer1.TabIndex = 0;
            // 
            // F0022
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 1005);
            this.Controls.Add(this.reportViewer1);
            this.Name = "F0022";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F0022";
            this.Load += new System.EventHandler(this.F0022_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSF0006BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_F0006)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dSF0006BindingSource;
        private Report.DS_F0006 dS_F0006;
    }
}