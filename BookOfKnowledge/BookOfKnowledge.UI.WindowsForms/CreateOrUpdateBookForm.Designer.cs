namespace BookOfKnowledge.UI.WindowsForms
{
    partial class CreateOrUpdateBookForm
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
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txtB_Id = new System.Windows.Forms.TextBox();
            this.txtB_Title = new System.Windows.Forms.TextBox();
            this.txtB_Description = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(29, 266);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(153, 266);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txtB_Id
            // 
            this.txtB_Id.Location = new System.Drawing.Point(112, 49);
            this.txtB_Id.Name = "txtB_Id";
            this.txtB_Id.Size = new System.Drawing.Size(132, 20);
            this.txtB_Id.TabIndex = 2;
            this.txtB_Id.TextChanged += new System.EventHandler(this.txtB_Id_TextChanged);
            // 
            // txtB_Title
            // 
            this.txtB_Title.Location = new System.Drawing.Point(112, 117);
            this.txtB_Title.Name = "txtB_Title";
            this.txtB_Title.Size = new System.Drawing.Size(132, 20);
            this.txtB_Title.TabIndex = 3;
            // 
            // txtB_Description
            // 
            this.txtB_Description.Location = new System.Drawing.Point(112, 193);
            this.txtB_Description.Name = "txtB_Description";
            this.txtB_Description.Size = new System.Drawing.Size(132, 20);
            this.txtB_Description.TabIndex = 4;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(26, 49);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(16, 13);
            this.lbl_Id.TabIndex = 5;
            this.lbl_Id.Text = "Id";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(26, 120);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(27, 13);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "Title";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(26, 193);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(60, 13);
            this.lbl_Description.TabIndex = 7;
            this.lbl_Description.Text = "Description";
            // 
            // CreateOrUpdateBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 355);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.txtB_Description);
            this.Controls.Add(this.txtB_Title);
            this.Controls.Add(this.txtB_Id);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Create);
            this.Name = "CreateOrUpdateBookForm";
            this.Text = "CreateOrUpdateBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txtB_Id;
        private System.Windows.Forms.TextBox txtB_Title;
        private System.Windows.Forms.TextBox txtB_Description;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Description;
    }
}