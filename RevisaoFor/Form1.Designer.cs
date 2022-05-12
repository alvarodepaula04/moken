namespace RevisaoFor
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_cont = new System.Windows.Forms.Button();
            this.btn_valor = new System.Windows.Forms.Button();
            this.btn_par = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_menor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(62, 76);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(185, 34);
            this.btn_soma.TabIndex = 1;
            this.btn_soma.Text = "Soma";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_cont
            // 
            this.btn_cont.Location = new System.Drawing.Point(61, 127);
            this.btn_cont.Name = "btn_cont";
            this.btn_cont.Size = new System.Drawing.Size(185, 36);
            this.btn_cont.TabIndex = 2;
            this.btn_cont.Text = "Contador ";
            this.btn_cont.UseVisualStyleBackColor = true;
            this.btn_cont.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_valor
            // 
            this.btn_valor.Location = new System.Drawing.Point(62, 181);
            this.btn_valor.Name = "btn_valor";
            this.btn_valor.Size = new System.Drawing.Size(185, 36);
            this.btn_valor.TabIndex = 3;
            this.btn_valor.Text = "Valores maiores que 5";
            this.btn_valor.UseVisualStyleBackColor = true;
            this.btn_valor.Click += new System.EventHandler(this.btn_valor_Click);
            // 
            // btn_par
            // 
            this.btn_par.Location = new System.Drawing.Point(62, 233);
            this.btn_par.Name = "btn_par";
            this.btn_par.Size = new System.Drawing.Size(185, 30);
            this.btn_par.TabIndex = 4;
            this.btn_par.Text = "Numeros Pares";
            this.btn_par.UseVisualStyleBackColor = true;
            this.btn_par.Click += new System.EventHandler(this.btn_par_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(62, 280);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(185, 30);
            this.btn_mult.TabIndex = 5;
            this.btn_mult.Text = "Mutiplicação";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_menor
            // 
            this.btn_menor.Location = new System.Drawing.Point(61, 325);
            this.btn_menor.Name = "btn_menor";
            this.btn_menor.Size = new System.Drawing.Size(185, 30);
            this.btn_menor.TabIndex = 6;
            this.btn_menor.Text = "Valores menores que 5";
            this.btn_menor.UseVisualStyleBackColor = true;
            this.btn_menor.Click += new System.EventHandler(this.btn_menor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 386);
            this.Controls.Add(this.btn_menor);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_par);
            this.Controls.Add(this.btn_valor);
            this.Controls.Add(this.btn_cont);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_cont;
        private System.Windows.Forms.Button btn_valor;
        private System.Windows.Forms.Button btn_par;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_menor;
    }
}

