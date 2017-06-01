namespace Lab2
{
    partial class RunForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_std = new System.Windows.Forms.Button();
            this.btn_bk = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Managment Center";
            // 
            // btn_std
            // 
            this.btn_std.Location = new System.Drawing.Point(47, 234);
            this.btn_std.Name = "btn_std";
            this.btn_std.Size = new System.Drawing.Size(182, 32);
            this.btn_std.TabIndex = 1;
            this.btn_std.Text = "Students";
            this.btn_std.UseVisualStyleBackColor = true;
            this.btn_std.Click += new System.EventHandler(this.btn_std_Click);
            // 
            // btn_bk
            // 
            this.btn_bk.Location = new System.Drawing.Point(291, 234);
            this.btn_bk.Name = "btn_bk";
            this.btn_bk.Size = new System.Drawing.Size(182, 32);
            this.btn_bk.TabIndex = 1;
            this.btn_bk.Text = "Books";
            this.btn_bk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_bk.UseVisualStyleBackColor = true;
            this.btn_bk.Click += new System.EventHandler(this.btn_bk_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(537, 234);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(182, 32);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // RunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 381);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_bk);
            this.Controls.Add(this.btn_std);
            this.Controls.Add(this.label1);
            this.Name = "RunForm";
            this.Text = "RunForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_std;
        private System.Windows.Forms.Button btn_bk;
        private System.Windows.Forms.Button btn_exit;
    }
}