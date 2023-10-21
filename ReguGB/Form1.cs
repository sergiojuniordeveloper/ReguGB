using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SJReguaGB.AppWindows;

namespace ReguGB
{
    public partial class Form1 : Form
    {
        Size mFormTamanhoPadrao = new Size(0, 0);
        
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Iniciar()
        {
            this.BackColor = Color.Magenta; // ou qualquer outra cor muito incomum (de preferência uma que não exista na imagem)
            this.TransparencyKey = Color.Magenta; // igual à cor de fundo do Form
            //this.FormBorderStyle = FormBorderStyle.None; // se quiser remover as bordas do Form
            this.KeyPreview = true;
            mFormTamanhoPadrao = new Size(2059, 1040);
            AlterarTituloForm();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        #region Mover Form com o clique e mover do mouse sobre a imagem
        //bool mouseClicked;
        //Point clickedAt;
        //private void picImagem_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (mouseClicked)
        //    {
        //        this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
        //    }
        //}

        //private void picImagem_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button != MouseButtons.Left)
        //        return;

        //    mouseClicked = true;
        //    clickedAt = e.Location;
        //}

        //private void picImagem_MouseUp(object sender, MouseEventArgs e)
        //{
        //    mouseClicked = false;
        //}

        #endregion

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control || e.Shift)
            {
                string key = e.KeyCode.ToString();
                Point posicao = new Point();
                Size tamanho = new Size();
                posicao = this.Location;
                tamanho = this.Size;
                int i = 1;

                if (e.Shift)
                    i = 15;



                if (e.KeyCode == Keys.Up)
                    posicao.Y -= i;

                if (e.KeyCode == Keys.Right)
                    posicao.X += i;

                if (e.KeyCode == Keys.Down)
                    posicao.Y += i;

                if (e.KeyCode == Keys.Left)
                    posicao.X -= i;

                if (posicao != this.Location)
                    this.Location = posicao;
                


                if (e.KeyCode == Keys.Add)
                    tamanho.Width += i;

                if (e.KeyCode == Keys.Subtract )
                    tamanho.Width -= i;

                if (tamanho != this.Size)
                    this.Size = tamanho;

                AlterarTituloForm();
            }

        }

        private void btnRedimensionarPadrao_Click(object sender, EventArgs e)
        {
            this.Size = mFormTamanhoPadrao;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AlterarTituloForm();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlterarTituloForm()
        {
            this.Text = classes.InfoApp.GerarTituloForm("", true,  String.Format("Posicao Y = {0}, X = {1} - Tamanho Width = {2}, Height = {3}", this.Location.Y, this.Location.X, this.Size.Width, this.Size.Height)) ;
        }

        private void btnTransparencia_Click(object sender, EventArgs e)
        {
           // pnlImagem.BackColor = Color.FromArgb(100, 88, 44, 55);

        }
    }
}

