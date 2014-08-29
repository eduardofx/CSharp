namespace Formulario
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
            this.btOk = new System.Windows.Forms.Button();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.Sobrenome = new System.Windows.Forms.Label();
            this.BoxSobrenome = new System.Windows.Forms.TextBox();
            this.Idade = new System.Windows.Forms.Label();
            this.BoxIdade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(222, 151);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(113, 45);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Enviar";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // BoxName
            // 
            this.BoxName.Location = new System.Drawing.Point(145, 72);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(190, 20);
            this.BoxName.TabIndex = 1;
            this.BoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(75, 75);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 2;
            this.Nome.Text = "Nome";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sobrenome
            // 
            this.Sobrenome.AutoSize = true;
            this.Sobrenome.Location = new System.Drawing.Point(75, 112);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(61, 13);
            this.Sobrenome.TabIndex = 3;
            this.Sobrenome.Text = "Sobrenome";
            this.Sobrenome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BoxSobrenome
            // 
            this.BoxSobrenome.Location = new System.Drawing.Point(145, 112);
            this.BoxSobrenome.Name = "BoxSobrenome";
            this.BoxSobrenome.Size = new System.Drawing.Size(190, 20);
            this.BoxSobrenome.TabIndex = 4;
            this.BoxSobrenome.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Idade
            // 
            this.Idade.AutoSize = true;
            this.Idade.Location = new System.Drawing.Point(75, 151);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(34, 13);
            this.Idade.TabIndex = 5;
            this.Idade.Text = "Idade";
            this.Idade.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // BoxIdade
            // 
            this.BoxIdade.Location = new System.Drawing.Point(146, 151);
            this.BoxIdade.Name = "BoxIdade";
            this.BoxIdade.Size = new System.Drawing.Size(59, 20);
            this.BoxIdade.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 332);
            this.Controls.Add(this.BoxIdade);
            this.Controls.Add(this.Idade);
            this.Controls.Add(this.BoxSobrenome);
            this.Controls.Add(this.Sobrenome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.BoxName);
            this.Controls.Add(this.btOk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Sobrenome;
        private System.Windows.Forms.TextBox BoxSobrenome;
        private System.Windows.Forms.Label Idade;
        private System.Windows.Forms.TextBox BoxIdade;
    }
}

