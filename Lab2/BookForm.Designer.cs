namespace Lab2
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
            this.title_label = new System.Windows.Forms.Label();
            this.lang_label = new System.Windows.Forms.Label();
            this.isbn_label = new System.Windows.Forms.Label();
            this.cat_label = new System.Windows.Forms.Label();
            this.qty_label = new System.Windows.Forms.Label();
            this.title_field = new System.Windows.Forms.TextBox();
            this.lang_field = new System.Windows.Forms.TextBox();
            this.isbn_field = new System.Windows.Forms.TextBox();
            this.cat_field = new System.Windows.Forms.TextBox();
            this.qty_field = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(83, 38);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(27, 13);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Title";
            // 
            // lang_label
            // 
            this.lang_label.AutoSize = true;
            this.lang_label.Location = new System.Drawing.Point(83, 86);
            this.lang_label.Name = "lang_label";
            this.lang_label.Size = new System.Drawing.Size(55, 13);
            this.lang_label.TabIndex = 0;
            this.lang_label.Text = "Language";
            // 
            // isbn_label
            // 
            this.isbn_label.AutoSize = true;
            this.isbn_label.Location = new System.Drawing.Point(83, 140);
            this.isbn_label.Name = "isbn_label";
            this.isbn_label.Size = new System.Drawing.Size(32, 13);
            this.isbn_label.TabIndex = 0;
            this.isbn_label.Text = "ISBN";
            // 
            // cat_label
            // 
            this.cat_label.AutoSize = true;
            this.cat_label.Location = new System.Drawing.Point(83, 195);
            this.cat_label.Name = "cat_label";
            this.cat_label.Size = new System.Drawing.Size(49, 13);
            this.cat_label.TabIndex = 0;
            this.cat_label.Text = "Category";
            // 
            // qty_label
            // 
            this.qty_label.AutoSize = true;
            this.qty_label.Location = new System.Drawing.Point(83, 242);
            this.qty_label.Name = "qty_label";
            this.qty_label.Size = new System.Drawing.Size(46, 13);
            this.qty_label.TabIndex = 0;
            this.qty_label.Text = "Quantity";
            // 
            // title_field
            // 
            this.title_field.Location = new System.Drawing.Point(263, 35);
            this.title_field.Name = "title_field";
            this.title_field.Size = new System.Drawing.Size(456, 20);
            this.title_field.TabIndex = 1;
            // 
            // lang_field
            // 
            this.lang_field.Location = new System.Drawing.Point(263, 86);
            this.lang_field.Name = "lang_field";
            this.lang_field.Size = new System.Drawing.Size(456, 20);
            this.lang_field.TabIndex = 1;
            // 
            // isbn_field
            // 
            this.isbn_field.Location = new System.Drawing.Point(263, 140);
            this.isbn_field.Name = "isbn_field";
            this.isbn_field.Size = new System.Drawing.Size(456, 20);
            this.isbn_field.TabIndex = 1;
            // 
            // cat_field
            // 
            this.cat_field.Location = new System.Drawing.Point(263, 195);
            this.cat_field.Name = "cat_field";
            this.cat_field.Size = new System.Drawing.Size(456, 20);
            this.cat_field.TabIndex = 1;
            // 
            // qty_field
            // 
            this.qty_field.Location = new System.Drawing.Point(263, 242);
            this.qty_field.Name = "qty_field";
            this.qty_field.Size = new System.Drawing.Size(456, 20);
            this.qty_field.TabIndex = 1;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_create.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_create.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_create.Location = new System.Drawing.Point(592, 366);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(126, 23);
            this.btn_create.TabIndex = 2;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_cancel.Location = new System.Drawing.Point(441, 366);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(126, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.ForeColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(228, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 292);
            this.panel1.TabIndex = 3;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 409);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.qty_field);
            this.Controls.Add(this.cat_field);
            this.Controls.Add(this.isbn_field);
            this.Controls.Add(this.lang_field);
            this.Controls.Add(this.title_field);
            this.Controls.Add(this.qty_label);
            this.Controls.Add(this.cat_label);
            this.Controls.Add(this.isbn_label);
            this.Controls.Add(this.lang_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.panel1);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label lang_label;
        private System.Windows.Forms.Label isbn_label;
        private System.Windows.Forms.Label cat_label;
        private System.Windows.Forms.Label qty_label;
        private System.Windows.Forms.TextBox title_field;
        private System.Windows.Forms.TextBox lang_field;
        private System.Windows.Forms.TextBox isbn_field;
        private System.Windows.Forms.TextBox cat_field;
        private System.Windows.Forms.TextBox qty_field;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel panel1;
    }
}