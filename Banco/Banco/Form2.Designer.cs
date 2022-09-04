namespace Banco
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.Sald = new System.Windows.Forms.Label();
            this.Dep = new System.Windows.Forms.Button();
            this.valorBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.clean = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.btSac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo!! Pedro Rufino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo da Conta";
            // 
            // Sald
            // 
            this.Sald.AutoSize = true;
            this.Sald.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sald.Location = new System.Drawing.Point(192, 137);
            this.Sald.Name = "Sald";
            this.Sald.Size = new System.Drawing.Size(60, 17);
            this.Sald.TabIndex = 2;
            this.Sald.Text = "1550,00";
            // 
            // Dep
            // 
            this.Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dep.Location = new System.Drawing.Point(71, 258);
            this.Dep.Name = "Dep";
            this.Dep.Size = new System.Drawing.Size(75, 27);
            this.Dep.TabIndex = 3;
            this.Dep.Text = "Sacar";
            this.Dep.UseVisualStyleBackColor = true;
            this.Dep.Click += new System.EventHandler(this.btSac_Click);
            // 
            // valorBox
            // 
            this.valorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorBox.Location = new System.Drawing.Point(161, 223);
            this.valorBox.Name = "valorBox";
            this.valorBox.Size = new System.Drawing.Size(116, 24);
            this.valorBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quanto Irá Sacar?";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(205, 311);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 6;
            // 
            // clean
            // 
            this.clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clean.Location = new System.Drawing.Point(287, 259);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(75, 27);
            this.clean.TabIndex = 7;
            this.clean.Text = "Corrigir";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(177, 318);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 27);
            this.Close.TabIndex = 8;
            this.Close.Text = "Sair";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // btSac
            // 
            this.btSac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSac.Location = new System.Drawing.Point(178, 258);
            this.btSac.Name = "btSac";
            this.btSac.Size = new System.Drawing.Size(75, 27);
            this.btSac.TabIndex = 9;
            this.btSac.Text = "Deposito";
            this.btSac.UseVisualStyleBackColor = true;
            this.btSac.Click += new System.EventHandler(this.btSac_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 395);
            this.Controls.Add(this.btSac);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valorBox);
            this.Controls.Add(this.Dep);
            this.Controls.Add(this.Sald);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Bradesco";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Sald;
        private System.Windows.Forms.Button Dep;
        private System.Windows.Forms.TextBox valorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button btSac;
    }
}