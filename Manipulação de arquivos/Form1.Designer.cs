namespace Manipulação_de_arquivos
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
            this.buttonEscrever = new System.Windows.Forms.Button();
            this.buttonLer = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAdicRem = new System.Windows.Forms.Button();
            this.labArq = new System.Windows.Forms.Label();
            this.textBoxEscr = new System.Windows.Forms.TextBox();
            this.buttonEdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEscrever
            // 
            this.buttonEscrever.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEscrever.Location = new System.Drawing.Point(87, 264);
            this.buttonEscrever.Name = "buttonEscrever";
            this.buttonEscrever.Size = new System.Drawing.Size(162, 45);
            this.buttonEscrever.TabIndex = 0;
            this.buttonEscrever.Text = "Atualizar Txt";
            this.buttonEscrever.UseVisualStyleBackColor = true;
            this.buttonEscrever.Click += new System.EventHandler(this.buttonEscrever_Click);
            // 
            // buttonLer
            // 
            this.buttonLer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLer.Location = new System.Drawing.Point(87, 94);
            this.buttonLer.Name = "buttonLer";
            this.buttonLer.Size = new System.Drawing.Size(162, 45);
            this.buttonLer.TabIndex = 1;
            this.buttonLer.Text = "Ler Txt";
            this.buttonLer.UseVisualStyleBackColor = true;
            this.buttonLer.Click += new System.EventHandler(this.buttonLer_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arquivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnAdicRem
            // 
            this.BtnAdicRem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnAdicRem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAdicRem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnAdicRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicRem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicRem.ForeColor = System.Drawing.Color.White;
            this.BtnAdicRem.Location = new System.Drawing.Point(40, 12);
            this.BtnAdicRem.Name = "BtnAdicRem";
            this.BtnAdicRem.Size = new System.Drawing.Size(36, 28);
            this.BtnAdicRem.TabIndex = 6;
            this.BtnAdicRem.Text = "+";
            this.BtnAdicRem.UseVisualStyleBackColor = false;
            this.BtnAdicRem.Click += new System.EventHandler(this.BtnAdicArqRem_Click_1);
            // 
            // labArq
            // 
            this.labArq.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labArq.Location = new System.Drawing.Point(155, 12);
            this.labArq.Name = "labArq";
            this.labArq.Size = new System.Drawing.Size(277, 30);
            this.labArq.TabIndex = 4;
            this.labArq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxEscr
            // 
            this.textBoxEscr.Location = new System.Drawing.Point(270, 80);
            this.textBoxEscr.Multiline = true;
            this.textBoxEscr.Name = "textBoxEscr";
            this.textBoxEscr.Size = new System.Drawing.Size(458, 238);
            this.textBoxEscr.TabIndex = 7;
            // 
            // buttonEdi
            // 
            this.buttonEdi.Location = new System.Drawing.Point(202, 175);
            this.buttonEdi.Name = "buttonEdi";
            this.buttonEdi.Size = new System.Drawing.Size(47, 47);
            this.buttonEdi.TabIndex = 8;
            this.buttonEdi.Text = "Editar";
            this.buttonEdi.UseVisualStyleBackColor = true;
            this.buttonEdi.Click += new System.EventHandler(this.buttonEdi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 379);
            this.Controls.Add(this.buttonEdi);
            this.Controls.Add(this.textBoxEscr);
            this.Controls.Add(this.BtnAdicRem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labArq);
            this.Controls.Add(this.buttonLer);
            this.Controls.Add(this.buttonEscrever);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEscrever;
        private System.Windows.Forms.Button buttonLer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAdicRem;
        private System.Windows.Forms.Label labArq;
        private System.Windows.Forms.TextBox textBoxEscr;
        private System.Windows.Forms.Button buttonEdi;
    }
}

