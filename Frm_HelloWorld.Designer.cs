namespace CursoWindowsForms
{
    partial class Frm_HelloWorld
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
            this.Lbl_Visual = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_mudarLabel = new System.Windows.Forms.Button();
            this.Txt_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Visual
            // 
            this.Lbl_Visual.AutoSize = true;
            this.Lbl_Visual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Visual.Location = new System.Drawing.Point(30, 30);
            this.Lbl_Visual.Name = "Lbl_Visual";
            this.Lbl_Visual.Size = new System.Drawing.Size(163, 19);
            this.Lbl_Visual.TabIndex = 0;
            this.Lbl_Visual.Text = "Visual Studio Forms";
            this.Lbl_Visual.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(347, 291);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(145, 28);
            this.Btn_Sair.TabIndex = 1;
            this.Btn_Sair.Text = "Sair da aplicação";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_mudarLabel
            // 
            this.Btn_mudarLabel.Location = new System.Drawing.Point(34, 105);
            this.Btn_mudarLabel.Name = "Btn_mudarLabel";
            this.Btn_mudarLabel.Size = new System.Drawing.Size(147, 23);
            this.Btn_mudarLabel.TabIndex = 2;
            this.Btn_mudarLabel.Text = "Mudar label";
            this.Btn_mudarLabel.UseVisualStyleBackColor = true;
            this.Btn_mudarLabel.Click += new System.EventHandler(this.Btn_mudarLabel_Click);
            // 
            // Txt_box
            // 
            this.Txt_box.Location = new System.Drawing.Point(34, 64);
            this.Txt_box.Name = "Txt_box";
            this.Txt_box.Size = new System.Drawing.Size(244, 20);
            this.Txt_box.TabIndex = 3;
            // 
            // Frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 346);
            this.Controls.Add(this.Txt_box);
            this.Controls.Add(this.Btn_mudarLabel);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Lbl_Visual);
            this.Name = "Frm_HelloWorld";
            this.Text = "Hello world";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Visual;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_mudarLabel;
        private System.Windows.Forms.TextBox Txt_box;
    }
}

