namespace Lab2
{
    partial class StudentForm
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
            this.stdId = new System.Windows.Forms.Label();
            this.stdName = new System.Windows.Forms.Label();
            this.stdContact = new System.Windows.Forms.Label();
            this.stdIntake = new System.Windows.Forms.Label();
            this.stdId_field = new System.Windows.Forms.TextBox();
            this.stdName_field = new System.Windows.Forms.TextBox();
            this.stdContact_field = new System.Windows.Forms.TextBox();
            this.stdIntake_field = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stdId
            // 
            this.stdId.AutoSize = true;
            this.stdId.Location = new System.Drawing.Point(75, 32);
            this.stdId.Name = "stdId";
            this.stdId.Size = new System.Drawing.Size(58, 13);
            this.stdId.TabIndex = 0;
            this.stdId.Text = "Student ID";
            // 
            // stdName
            // 
            this.stdName.AutoSize = true;
            this.stdName.Location = new System.Drawing.Point(75, 85);
            this.stdName.Name = "stdName";
            this.stdName.Size = new System.Drawing.Size(75, 13);
            this.stdName.TabIndex = 0;
            this.stdName.Text = "Student Name";
            // 
            // stdContact
            // 
            this.stdContact.AutoSize = true;
            this.stdContact.Location = new System.Drawing.Point(75, 148);
            this.stdContact.Name = "stdContact";
            this.stdContact.Size = new System.Drawing.Size(65, 13);
            this.stdContact.TabIndex = 0;
            this.stdContact.Text = "Contact Info";
            // 
            // stdIntake
            // 
            this.stdIntake.AutoSize = true;
            this.stdIntake.Location = new System.Drawing.Point(75, 204);
            this.stdIntake.Name = "stdIntake";
            this.stdIntake.Size = new System.Drawing.Size(37, 13);
            this.stdIntake.TabIndex = 0;
            this.stdIntake.Text = "Intake";
            // 
            // stdId_field
            // 
            this.stdId_field.Location = new System.Drawing.Point(221, 29);
            this.stdId_field.Name = "stdId_field";
            this.stdId_field.Size = new System.Drawing.Size(295, 20);
            this.stdId_field.TabIndex = 1;
            // 
            // stdName_field
            // 
            this.stdName_field.Location = new System.Drawing.Point(221, 82);
            this.stdName_field.Name = "stdName_field";
            this.stdName_field.Size = new System.Drawing.Size(295, 20);
            this.stdName_field.TabIndex = 2;
            // 
            // stdContact_field
            // 
            this.stdContact_field.Location = new System.Drawing.Point(221, 145);
            this.stdContact_field.Name = "stdContact_field";
            this.stdContact_field.Size = new System.Drawing.Size(295, 20);
            this.stdContact_field.TabIndex = 3;
            // 
            // stdIntake_field
            // 
            this.stdIntake_field.Location = new System.Drawing.Point(221, 201);
            this.stdIntake_field.Name = "stdIntake_field";
            this.stdIntake_field.Size = new System.Drawing.Size(295, 20);
            this.stdIntake_field.TabIndex = 4;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(478, 272);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(374, 272);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 307);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.stdIntake_field);
            this.Controls.Add(this.stdContact_field);
            this.Controls.Add(this.stdName_field);
            this.Controls.Add(this.stdId_field);
            this.Controls.Add(this.stdIntake);
            this.Controls.Add(this.stdContact);
            this.Controls.Add(this.stdName);
            this.Controls.Add(this.stdId);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stdId;
        private System.Windows.Forms.Label stdName;
        private System.Windows.Forms.Label stdContact;
        private System.Windows.Forms.Label stdIntake;
        private System.Windows.Forms.TextBox stdId_field;
        private System.Windows.Forms.TextBox stdName_field;
        private System.Windows.Forms.TextBox stdContact_field;
        private System.Windows.Forms.TextBox stdIntake_field;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}