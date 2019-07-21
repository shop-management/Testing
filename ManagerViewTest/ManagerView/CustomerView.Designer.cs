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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerView));
            this.dgvBrand = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnGenerateId = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBrand
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBrand.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBrand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrand.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBrand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgvBrand.Location = new System.Drawing.Point(474, 37);
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrand.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBrand.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBrand.Size = new System.Drawing.Size(566, 273);
            this.dgvBrand.TabIndex = 0;
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
            this.btnLoad.Location = new System.Drawing.Point(704, 353);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(164, 57);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(160, 55);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(219, 29);
            this.txtType.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Brand";
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(160, 97);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(219, 29);
            this.txtBrand.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gen. ID";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(160, 139);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(219, 29);
            this.txtId.TabIndex = 10;
            // 
            // btnGenerateId
            // 
            this.btnGenerateId.ActiveBorderThickness = 1;
            this.btnGenerateId.ActiveCornerRadius = 20;
            this.btnGenerateId.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGenerateId.ActiveForecolor = System.Drawing.Color.White;
            this.btnGenerateId.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGenerateId.BackColor = System.Drawing.SystemColors.Control;
            this.btnGenerateId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerateId.BackgroundImage")));
            this.btnGenerateId.ButtonText = "Generate ID";
            this.btnGenerateId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateId.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGenerateId.IdleBorderThickness = 1;
            this.btnGenerateId.IdleCornerRadius = 20;
            this.btnGenerateId.IdleFillColor = System.Drawing.Color.White;
            this.btnGenerateId.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGenerateId.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGenerateId.Location = new System.Drawing.Point(172, 192);
            this.btnGenerateId.Margin = new System.Windows.Forms.Padding(5);
            this.btnGenerateId.Name = "btnGenerateId";
            this.btnGenerateId.Size = new System.Drawing.Size(164, 57);
            this.btnGenerateId.TabIndex = 1;
            this.btnGenerateId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerateId.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 718);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerateId);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvBrand);
            this.Name = "CustomerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerView";
            this.Load += new System.EventHandler(this.CustomerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvBrand;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGenerateId;

    }
}