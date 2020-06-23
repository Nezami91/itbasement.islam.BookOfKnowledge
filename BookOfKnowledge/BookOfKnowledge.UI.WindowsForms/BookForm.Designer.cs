namespace BookOfKnowledge.UI.WindowsForms
{
    partial class BookForm
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
            this.btn_GetListBooks = new System.Windows.Forms.Button();
            this.btn_CreateOrUpdate = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Books = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GetListBooks
            // 
            this.btn_GetListBooks.Location = new System.Drawing.Point(589, 70);
            this.btn_GetListBooks.Name = "btn_GetListBooks";
            this.btn_GetListBooks.Size = new System.Drawing.Size(152, 37);
            this.btn_GetListBooks.TabIndex = 0;
            this.btn_GetListBooks.Text = "Get list of Books";
            this.btn_GetListBooks.UseVisualStyleBackColor = true;
            this.btn_GetListBooks.Click += new System.EventHandler(this.btn_GetListBooks_Click);
            // 
            // btn_CreateOrUpdate
            // 
            this.btn_CreateOrUpdate.Location = new System.Drawing.Point(589, 168);
            this.btn_CreateOrUpdate.Name = "btn_CreateOrUpdate";
            this.btn_CreateOrUpdate.Size = new System.Drawing.Size(152, 36);
            this.btn_CreateOrUpdate.TabIndex = 1;
            this.btn_CreateOrUpdate.Text = "Create/Update";
            this.btn_CreateOrUpdate.UseVisualStyleBackColor = true;
            this.btn_CreateOrUpdate.Click += new System.EventHandler(this.btn_CreateOrUpdate_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(589, 257);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(152, 38);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of Books";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView_Books
            // 
            this.dataGridView_Books.AllowUserToAddRows = false;
            this.dataGridView_Books.AllowUserToDeleteRows = false;
            this.dataGridView_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Books.Location = new System.Drawing.Point(12, 45);
            this.dataGridView_Books.Name = "dataGridView_Books";
            this.dataGridView_Books.ReadOnly = true;
            this.dataGridView_Books.Size = new System.Drawing.Size(545, 314);
            this.dataGridView_Books.TabIndex = 5;
            this.dataGridView_Books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Books);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_CreateOrUpdate);
            this.Controls.Add(this.btn_GetListBooks);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GetListBooks;
        private System.Windows.Forms.Button btn_CreateOrUpdate;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Books;
    }
}