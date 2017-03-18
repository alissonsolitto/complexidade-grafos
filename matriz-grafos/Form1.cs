using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public int[,] matriz;

        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarComboBox(int n)
        {
            cbxVerticeInicial.Items.Clear();
            cbxVerticeFinal.Items.Clear();
            cbxVerticeGrau.Items.Clear();

            for (int i = 0; i < n; i++)
            {
                cbxVerticeInicial.Items.AddRange(new string[] { String.Format("V{0}", i) });
                cbxVerticeFinal.Items.AddRange(new string[] { String.Format("V{0}", i) });
                cbxVerticeGrau.Items.AddRange(new string[] { String.Format("V{0}", i) });
            }
        }

        private void SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cbx = (ComboBox)sender;
            
            int linha  = Convert.ToInt32(cbx.Name.Substring(3, 1));
            int coluna = Convert.ToInt32(cbx.Name.Substring(4, 1));
            matriz[linha, coluna] = Convert.ToInt32(cbx.SelectedItem.ToString());
        }

        private void btnGerarMatriz_Click(object sender, EventArgs e)
        {
            int Vertice = Convert.ToInt32(txtNumVertice.Text);

            if (Vertice > 10)
            {
                MessageBox.Show("O número máximo de vértices aceito é 10");
            }
            else
            {
                pnlMatriz.Controls.Clear();
                matriz = new int[Vertice, Vertice];

                CarregarComboBox(Vertice);

                int Left = 30;
                int Top = 30;
                int Width = 100;

                for (int i = 0; i < Vertice; i++)
                {
                    for (int j = 0; j < Vertice; j++)
                    {

                        ComboBox cbx = new ComboBox();
                        cbx.Name = String.Format("cbx{0}{1}", i, j);
                        cbx.Items.AddRange(new string[] { "0", "1" });

                        //Posição na tela
                        cbx.Parent = pnlMatriz;
                        cbx.Left = Left + 5;
                        cbx.Top = Top;
                        cbx.Width = Width;

                        if (j == 0)//caso seja a primeira coluna
                        {
                            Label lbl = new Label();
                            lbl.Parent = pnlMatriz;
                            lbl.Left = 5;
                            lbl.Top = Top;
                            lbl.Text = String.Format("V{0}", i);
                        }

                        if (i == 0) //caso seja a primeira linha inseri o cabeçalho
                        {
                            Label lbl = new Label();
                            lbl.Parent = pnlMatriz;
                            lbl.Left = Left + (Width / 2);
                            lbl.Top = 5;
                            lbl.Text = String.Format("V{0}", j);
                        }

                        Left += Width + 20;

                        //Evento
                        cbx.SelectedValueChanged += this.SelectedValueChanged;
                    }

                    Top += 50;
                    Left = 30;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2(matriz, Convert.ToInt32(txtNumVertice.Text)).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Vertice1 = Convert.ToInt32(cbxVerticeInicial.SelectedItem.ToString().Substring(1, 1));
            int Vertice2 = Convert.ToInt32(cbxVerticeFinal.SelectedItem.ToString().Substring(1, 1));

            if((matriz[Vertice1, Vertice2] == 1) || (matriz[Vertice2, Vertice1] == 1))
            {
                MessageBox.Show("Existe aresta entre os vértices");
            }
            else
            {
                MessageBox.Show("Não existe aresta entre os vértices");
            }
        }

        private void btnGrauVertice_Click(object sender, EventArgs e)
        {
            int Vertice = Convert.ToInt32(txtNumVertice.Text);
            int VerticeGrau = Convert.ToInt32(cbxVerticeGrau.SelectedItem.ToString().Substring(1, 1));
            int grau = 0;

            for (int i = 0; i < Vertice; i++)
            {
                if (i == VerticeGrau)
                {
                    for (int j = 0; j < Vertice; j++)
                    {
                        grau += matriz[i, j] == 1 ? 1 : 0;
                    }
                }
                else
                {
                    grau += matriz[i, VerticeGrau] == 1 ? 1 : 0;
                }
            }

            MessageBox.Show(String.Format("O grau do vértice é {0}", grau));

        }
    }
}
