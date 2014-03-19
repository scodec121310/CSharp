namespace prjCustomer
{
    partial class GridBox
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(366, 203);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(306, 203);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(84, 203);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(24, 203);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(74, 161);
            this.txtAddress.Size = new System.Drawing.Size(348, 29);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 161);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 129);
            this.txtEmail.Size = new System.Drawing.Size(348, 29);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 129);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 64);
            this.txtName.Size = new System.Drawing.Size(348, 29);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(74, 97);
            this.txtPhone.Size = new System.Drawing.Size(348, 29);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 64);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 97);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(74, 32);
            this.txtId.Size = new System.Drawing.Size(348, 29);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 32);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(398, 244);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // GridBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(446, 554);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GridBox";
            this.Load += new System.EventHandler(this.GridBox_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtPhone, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtAddress, 0);
            this.Controls.SetChildIndex(this.btnFirst, 0);
            this.Controls.SetChildIndex(this.btnPrevious, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.btnLast, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
