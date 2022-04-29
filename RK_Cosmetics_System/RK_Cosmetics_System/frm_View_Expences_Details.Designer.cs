namespace RK_Cosmetics_System
{
    partial class frm_View_Expences_Details
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
            this.gb_Expences_Details = new System.Windows.Forms.GroupBox();
            this.dgv_View_Expences_Details = new System.Windows.Forms.DataGridView();
            this.expencesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_RK_Cosmetics_SystemDataSet6 = new RK_Cosmetics_System.DB_RK_Cosmetics_SystemDataSet6();
            this.pnl_Customer_Details = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_To_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_To_Date = new System.Windows.Forms.Label();
            this.dtp_From_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_From_Date = new System.Windows.Forms.Label();
            this.expences_DetailsTableAdapter = new RK_Cosmetics_System.DB_RK_Cosmetics_SystemDataSet6TableAdapters.Expences_DetailsTableAdapter();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.expencesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expencesDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Expences_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Expences_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expencesDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RK_Cosmetics_SystemDataSet6)).BeginInit();
            this.pnl_Customer_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Expences_Details
            // 
            this.gb_Expences_Details.Controls.Add(this.dgv_View_Expences_Details);
            this.gb_Expences_Details.Controls.Add(this.pnl_Customer_Details);
            this.gb_Expences_Details.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.gb_Expences_Details.Location = new System.Drawing.Point(118, 214);
            this.gb_Expences_Details.Name = "gb_Expences_Details";
            this.gb_Expences_Details.Size = new System.Drawing.Size(1826, 688);
            this.gb_Expences_Details.TabIndex = 1;
            this.gb_Expences_Details.TabStop = false;
            this.gb_Expences_Details.Text = "Expences Details";
            // 
            // dgv_View_Expences_Details
            // 
            this.dgv_View_Expences_Details.AllowUserToAddRows = false;
            this.dgv_View_Expences_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Expences_Details.AutoGenerateColumns = false;
            this.dgv_View_Expences_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Expences_Details.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgv_View_Expences_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Expences_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expencesIdDataGridViewTextBoxColumn,
            this.expencesDetailsDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.paidByDataGridViewTextBoxColumn});
            this.dgv_View_Expences_Details.DataSource = this.expencesDetailsBindingSource;
            this.dgv_View_Expences_Details.Location = new System.Drawing.Point(48, 207);
            this.dgv_View_Expences_Details.Name = "dgv_View_Expences_Details";
            this.dgv_View_Expences_Details.ReadOnly = true;
            this.dgv_View_Expences_Details.RowTemplate.Height = 24;
            this.dgv_View_Expences_Details.Size = new System.Drawing.Size(1721, 441);
            this.dgv_View_Expences_Details.TabIndex = 18;
            // 
            // expencesDetailsBindingSource
            // 
            this.expencesDetailsBindingSource.DataMember = "Expences_Details";
            this.expencesDetailsBindingSource.DataSource = this.dB_RK_Cosmetics_SystemDataSet6;
            // 
            // dB_RK_Cosmetics_SystemDataSet6
            // 
            this.dB_RK_Cosmetics_SystemDataSet6.DataSetName = "DB_RK_Cosmetics_SystemDataSet6";
            this.dB_RK_Cosmetics_SystemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl_Customer_Details
            // 
            this.pnl_Customer_Details.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_Customer_Details.Controls.Add(this.btn_Search);
            this.pnl_Customer_Details.Controls.Add(this.dtp_To_Date);
            this.pnl_Customer_Details.Controls.Add(this.lbl_To_Date);
            this.pnl_Customer_Details.Controls.Add(this.dtp_From_Date);
            this.pnl_Customer_Details.Controls.Add(this.lbl_From_Date);
            this.pnl_Customer_Details.Location = new System.Drawing.Point(244, 54);
            this.pnl_Customer_Details.Name = "pnl_Customer_Details";
            this.pnl_Customer_Details.Size = new System.Drawing.Size(1406, 91);
            this.pnl_Customer_Details.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Yellow;
            this.btn_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(1248, 19);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(142, 52);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtp_To_Date
            // 
            this.dtp_To_Date.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_To_Date.Location = new System.Drawing.Point(878, 25);
            this.dtp_To_Date.Name = "dtp_To_Date";
            this.dtp_To_Date.Size = new System.Drawing.Size(320, 43);
            this.dtp_To_Date.TabIndex = 2;
            // 
            // lbl_To_Date
            // 
            this.lbl_To_Date.AutoSize = true;
            this.lbl_To_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_To_Date.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_To_Date.Location = new System.Drawing.Point(722, 28);
            this.lbl_To_Date.Name = "lbl_To_Date";
            this.lbl_To_Date.Size = new System.Drawing.Size(130, 39);
            this.lbl_To_Date.TabIndex = 10;
            this.lbl_To_Date.Text = "To Date";
            // 
            // dtp_From_Date
            // 
            this.dtp_From_Date.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_From_Date.Location = new System.Drawing.Point(219, 28);
            this.dtp_From_Date.Name = "dtp_From_Date";
            this.dtp_From_Date.Size = new System.Drawing.Size(320, 43);
            this.dtp_From_Date.TabIndex = 1;
            // 
            // lbl_From_Date
            // 
            this.lbl_From_Date.AutoSize = true;
            this.lbl_From_Date.BackColor = System.Drawing.Color.Pink;
            this.lbl_From_Date.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From_Date.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_From_Date.Location = new System.Drawing.Point(32, 28);
            this.lbl_From_Date.Name = "lbl_From_Date";
            this.lbl_From_Date.Size = new System.Drawing.Size(168, 39);
            this.lbl_From_Date.TabIndex = 8;
            this.lbl_From_Date.Text = "From Date";
            // 
            // expences_DetailsTableAdapter
            // 
            this.expences_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.btn_Refresh.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(977, 923);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(142, 52);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // expencesIdDataGridViewTextBoxColumn
            // 
            this.expencesIdDataGridViewTextBoxColumn.DataPropertyName = "Expences_Id";
            this.expencesIdDataGridViewTextBoxColumn.HeaderText = "Expences_Id";
            this.expencesIdDataGridViewTextBoxColumn.Name = "expencesIdDataGridViewTextBoxColumn";
            this.expencesIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expencesDetailsDataGridViewTextBoxColumn
            // 
            this.expencesDetailsDataGridViewTextBoxColumn.DataPropertyName = "Expences_Details";
            this.expencesDetailsDataGridViewTextBoxColumn.HeaderText = "Expences_Details";
            this.expencesDetailsDataGridViewTextBoxColumn.Name = "expencesDetailsDataGridViewTextBoxColumn";
            this.expencesDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountPaidDataGridViewTextBoxColumn
            // 
            this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "Amount_Paid";
            this.amountPaidDataGridViewTextBoxColumn.HeaderText = "Amount_Paid";
            this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
            this.amountPaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidByDataGridViewTextBoxColumn
            // 
            this.paidByDataGridViewTextBoxColumn.DataPropertyName = "Paid_By";
            this.paidByDataGridViewTextBoxColumn.HeaderText = "Paid_By";
            this.paidByDataGridViewTextBoxColumn.Name = "paidByDataGridViewTextBoxColumn";
            this.paidByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_View_Expences_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Expences_Details);
            this.Name = "frm_View_Expences_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_Expences_Details";
            this.Load += new System.EventHandler(this.frm_View_Expences_Details_Load);
            this.gb_Expences_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Expences_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expencesDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_RK_Cosmetics_SystemDataSet6)).EndInit();
            this.pnl_Customer_Details.ResumeLayout(false);
            this.pnl_Customer_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Expences_Details;
        private System.Windows.Forms.DataGridView dgv_View_Expences_Details;
        private System.Windows.Forms.Panel pnl_Customer_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_To_Date;
        private System.Windows.Forms.Label lbl_To_Date;
        private System.Windows.Forms.DateTimePicker dtp_From_Date;
        private System.Windows.Forms.Label lbl_From_Date;
        private DB_RK_Cosmetics_SystemDataSet6 dB_RK_Cosmetics_SystemDataSet6;
        private System.Windows.Forms.BindingSource expencesDetailsBindingSource;
        private DB_RK_Cosmetics_SystemDataSet6TableAdapters.Expences_DetailsTableAdapter expences_DetailsTableAdapter;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn expencesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expencesDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidByDataGridViewTextBoxColumn;
    }
}