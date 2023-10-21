
namespace ReguGB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnRedimensionarPadrao = new System.Windows.Forms.Button();
            this.btnFoco = new System.Windows.Forms.Button();
            this.picImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(1890, 701);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(141, 30);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnRedimensionarPadrao
            // 
            this.btnRedimensionarPadrao.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRedimensionarPadrao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRedimensionarPadrao.ForeColor = System.Drawing.Color.White;
            this.btnRedimensionarPadrao.Location = new System.Drawing.Point(12, 701);
            this.btnRedimensionarPadrao.Name = "btnRedimensionarPadrao";
            this.btnRedimensionarPadrao.Size = new System.Drawing.Size(270, 30);
            this.btnRedimensionarPadrao.TabIndex = 1;
            this.btnRedimensionarPadrao.Text = "Redimensionar Padrao";
            this.btnRedimensionarPadrao.UseVisualStyleBackColor = false;
            this.btnRedimensionarPadrao.Click += new System.EventHandler(this.btnRedimensionarPadrao_Click);
            // 
            // btnFoco
            // 
            this.btnFoco.BackColor = System.Drawing.Color.Gray;
            this.btnFoco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFoco.ForeColor = System.Drawing.Color.White;
            this.btnFoco.Location = new System.Drawing.Point(1743, 701);
            this.btnFoco.Name = "btnFoco";
            this.btnFoco.Size = new System.Drawing.Size(141, 30);
            this.btnFoco.TabIndex = 2;
            this.btnFoco.Text = "Foco";
            this.btnFoco.UseVisualStyleBackColor = false;
            // 
            // picImagem
            // 
            this.picImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picImagem.Image = ((System.Drawing.Image)(resources.GetObject("picImagem.Image")));
            this.picImagem.Location = new System.Drawing.Point(3, 358);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(2039, 376);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 3;
            this.picImagem.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2043, 733);
            this.Controls.Add(this.btnRedimensionarPadrao);
            this.Controls.Add(this.btnFoco);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.picImagem);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReguaGB - By SJ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnRedimensionarPadrao;
        private System.Windows.Forms.Button btnFoco;
        private System.Windows.Forms.PictureBox picImagem;
    }
}

