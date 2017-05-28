namespace AlgoritmoGulosoInterativo
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
            this.labelEscolhaGulosa = new System.Windows.Forms.Label();
            this.txtRespotaEscolhaGulosa = new System.Windows.Forms.TextBox();
            this.labelMelhoresItens = new System.Windows.Forms.Label();
            this.txtListaOrdenada = new System.Windows.Forms.TextBox();
            this.txtMelhoresItens = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEscolhaGulosa
            // 
            this.labelEscolhaGulosa.AutoSize = true;
            this.labelEscolhaGulosa.Location = new System.Drawing.Point(14, 9);
            this.labelEscolhaGulosa.Name = "labelEscolhaGulosa";
            this.labelEscolhaGulosa.Size = new System.Drawing.Size(154, 23);
            this.labelEscolhaGulosa.TabIndex = 0;
            this.labelEscolhaGulosa.Text = "Escolha Gulosa";
            // 
            // txtRespotaEscolhaGulosa
            // 
            this.txtRespotaEscolhaGulosa.Enabled = false;
            this.txtRespotaEscolhaGulosa.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespotaEscolhaGulosa.Location = new System.Drawing.Point(16, 36);
            this.txtRespotaEscolhaGulosa.Multiline = true;
            this.txtRespotaEscolhaGulosa.Name = "txtRespotaEscolhaGulosa";
            this.txtRespotaEscolhaGulosa.Size = new System.Drawing.Size(540, 20);
            this.txtRespotaEscolhaGulosa.TabIndex = 1;
            // 
            // labelMelhoresItens
            // 
            this.labelMelhoresItens.AutoSize = true;
            this.labelMelhoresItens.Location = new System.Drawing.Point(16, 62);
            this.labelMelhoresItens.Name = "labelMelhoresItens";
            this.labelMelhoresItens.Size = new System.Drawing.Size(150, 23);
            this.labelMelhoresItens.TabIndex = 3;
            this.labelMelhoresItens.Text = "Lista ordenada";
            // 
            // txtListaOrdenada
            // 
            this.txtListaOrdenada.Location = new System.Drawing.Point(12, 89);
            this.txtListaOrdenada.Multiline = true;
            this.txtListaOrdenada.Name = "txtListaOrdenada";
            this.txtListaOrdenada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaOrdenada.Size = new System.Drawing.Size(544, 154);
            this.txtListaOrdenada.TabIndex = 4;
            // 
            // txtMelhoresItens
            // 
            this.txtMelhoresItens.Location = new System.Drawing.Point(12, 277);
            this.txtMelhoresItens.Multiline = true;
            this.txtMelhoresItens.Name = "txtMelhoresItens";
            this.txtMelhoresItens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMelhoresItens.Size = new System.Drawing.Size(544, 154);
            this.txtMelhoresItens.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Melhor programação de atividades";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(568, 462);
            this.Controls.Add(this.txtMelhoresItens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtListaOrdenada);
            this.Controls.Add(this.labelMelhoresItens);
            this.Controls.Add(this.txtRespotaEscolhaGulosa);
            this.Controls.Add(this.labelEscolhaGulosa);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Tempo Inicio e Fim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEscolhaGulosa;
        private System.Windows.Forms.TextBox txtRespotaEscolhaGulosa;
        private System.Windows.Forms.Label labelMelhoresItens;
        private System.Windows.Forms.TextBox txtListaOrdenada;
        private System.Windows.Forms.TextBox txtMelhoresItens;
        private System.Windows.Forms.Label label1;
    }
}

