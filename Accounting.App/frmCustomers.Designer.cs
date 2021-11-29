namespace Accounting.App
{
    partial class frmCustomers
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnAddNew = new System.Windows.Forms.ToolStripButton();
            this.BtnEditCustomer = new System.Windows.Forms.ToolStripButton();
            this.BtnDeleteCustomer = new System.Windows.Forms.ToolStripButton();
            this.BtnRefreshCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtfilter = new System.Windows.Forms.ToolStripTextBox();
            this.BtnAddNewCustomer = new System.Windows.Forms.ToolStrip();
            this.DgCustomers = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAddNew,
            this.BtnEditCustomer,
            this.BtnDeleteCustomer,
            this.BtnRefreshCustomer,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.txtfilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Image = global::Accounting.App.Properties.Resources._1371475930_filenew;
            this.BtnAddNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(70, 59);
            this.BtnAddNew.Text = "شخص جدید";
            this.BtnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnEditCustomer
            // 
            this.BtnEditCustomer.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
            this.BtnEditCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnEditCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditCustomer.Name = "BtnEditCustomer";
            this.BtnEditCustomer.Size = new System.Drawing.Size(47, 59);
            this.BtnEditCustomer.Text = "ویرایش";
            this.BtnEditCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEditCustomer.Click += new System.EventHandler(this.BtnEditCustomer_Click);
            // 
            // BtnDeleteCustomer
            // 
            this.BtnDeleteCustomer.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.BtnDeleteCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnDeleteCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            this.BtnDeleteCustomer.Size = new System.Drawing.Size(44, 59);
            this.BtnDeleteCustomer.Text = "حذف";
            this.BtnDeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // BtnRefreshCustomer
            // 
            this.BtnRefreshCustomer.Image = global::Accounting.App.Properties.Resources._1371476342_Refresh;
            this.BtnRefreshCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRefreshCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefreshCustomer.Name = "BtnRefreshCustomer";
            this.BtnRefreshCustomer.Size = new System.Drawing.Size(60, 59);
            this.BtnRefreshCustomer.Text = "بروزرسانی";
            this.BtnRefreshCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRefreshCustomer.Click += new System.EventHandler(this.BtnRefreshCustomer_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 59);
            this.toolStripLabel1.Text = "جستجو";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 59);
            // 
            // txtfilter
            // 
            this.txtfilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.Size = new System.Drawing.Size(100, 62);
            this.txtfilter.TextChanged += new System.EventHandler(this.txtfilter_TextChanged);
            // 
            // BtnAddNewCustomer
            // 
            this.BtnAddNewCustomer.Location = new System.Drawing.Point(0, 62);
            this.BtnAddNewCustomer.Name = "BtnAddNewCustomer";
            this.BtnAddNewCustomer.Size = new System.Drawing.Size(584, 25);
            this.BtnAddNewCustomer.TabIndex = 1;
            this.BtnAddNewCustomer.Text = "toolStrip2";
            // 
            // DgCustomers
            // 
            this.DgCustomers.AllowUserToAddRows = false;
            this.DgCustomers.AllowUserToDeleteRows = false;
            this.DgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgCustomers.Location = new System.Drawing.Point(0, 87);
            this.DgCustomers.Name = "DgCustomers";
            this.DgCustomers.ReadOnly = true;
            this.DgCustomers.Size = new System.Drawing.Size(584, 274);
            this.DgCustomers.TabIndex = 2;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Column1";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FullName";
            this.Column1.HeaderText = "نام";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Mobile";
            this.Column2.HeaderText = "موبایل";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Email";
            this.Column3.HeaderText = "ایمیل";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.DgCustomers);
            this.Controls.Add(this.BtnAddNewCustomer);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست افراد";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnAddNew;
        private System.Windows.Forms.ToolStripButton BtnEditCustomer;
        private System.Windows.Forms.ToolStripButton BtnDeleteCustomer;
        private System.Windows.Forms.ToolStrip BtnAddNewCustomer;
        private System.Windows.Forms.ToolStripButton BtnRefreshCustomer;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView DgCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtfilter;
    }
}