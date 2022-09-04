namespace Banco
{
    partial class Form1
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
            this.clear_log = new System.Windows.Forms.Button();
            this.log_cont = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pass_user = new System.Windows.Forms.TextBox();
            this.user_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clear_log
            // 
            this.clear_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_log.Location = new System.Drawing.Point(225, 241);
            this.clear_log.Name = "clear_log";
            this.clear_log.Size = new System.Drawing.Size(109, 33);
            this.clear_log.TabIndex = 11;
            this.clear_log.Text = "Limpar";
            this.clear_log.UseVisualStyleBackColor = true;
            // 
            // log_cont
            // 
            this.log_cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_cont.Location = new System.Drawing.Point(65, 241);
            this.log_cont.Name = "log_cont";
            this.log_cont.Size = new System.Drawing.Size(109, 33);
            this.log_cont.TabIndex = 10;
            this.log_cont.Text = "Login";
            this.log_cont.UseVisualStyleBackColor = true;
            this.log_cont.Click += new System.EventHandler(this.log_cont_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numero da Conta";
            // 
            // pass_user
            // 
            this.pass_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_user.Location = new System.Drawing.Point(121, 179);
            this.pass_user.Name = "pass_user";
            this.pass_user.PasswordChar = '*';
            this.pass_user.Size = new System.Drawing.Size(154, 29);
            this.pass_user.TabIndex = 7;
            // 
            // user_name
            // 
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(121, 93);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(154, 29);
            this.user_name.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 340);
            this.Controls.Add(this.clear_log);
            this.Controls.Add(this.log_cont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass_user);
            this.Controls.Add(this.user_name);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Bradesco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear_log;
        private System.Windows.Forms.Button log_cont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass_user;
        private System.Windows.Forms.TextBox user_name;
    }
}

