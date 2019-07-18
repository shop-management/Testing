namespace ManagerView
{
    partial class CustomerView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerView));
            this.dgvBrand = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnLoad = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBrand
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBrand.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBrand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrand.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBrand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBrand.ColumnHeadersHeight = 40;
            this.dgvBrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvBrand.DoubleBuffered = true;
            this.dgvBrand.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvBrand.EnableHeadersVisualStyles = false;
            this.dgvBrand.GridColor = System.Drawing.SystemColors.Info;
            this.dgvBrand.HeaderBgColor = System.Drawing.Color.MidnightBlue;
            this.dgvBrand.HeaderForeColor = System.Drawing.Color.White;
            this.dgvBrand.Location = new System.Drawing.Point(126, 12);
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrand.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBrand.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBrand.Size = new System.Drawing.Size(566, 273);
            this.dgvBrand.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.ActiveBorderThickness = 1;
            this.btnLoad.ActiveCornerRadius = 20;
            this.btnLoad.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLoad.ActiveForecolor = System.Drawing.Color.White;
            this.btnLoad.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLoad.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.BackgroundImage")));
            this.btnLoad.ButtonText = "Load";
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLoad.IdleBorderThickness = 1;
            this.btnLoad.IdleCornerRadius = 20;
            this.btnLoad.IdleFillColor = System.Drawing.Color.White;
            this.btnLoad.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLoad.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLoad.Location = new System.Drawing.Point(370, 293);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(121, 66);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Product_Type";
            this.Column1.HeaderText = "Product Type";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Brand";
            this.Column2.HeaderText = "Brand";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ProductId";
            this.Column3.HeaderText = "Product ID";
            this.Column3.Name = "Column3";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 405);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvBrand);
            this.Name = "CustomerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerView";
            this.Load += new System.EventHandler(this.CustomerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvBrand;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;

    }
}