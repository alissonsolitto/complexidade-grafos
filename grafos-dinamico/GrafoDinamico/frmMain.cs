using clsListaAdjacencias;
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
    public partial class frmMain : Form
    {
        private clsGrafo _clsGrafo;
        public clsGrafo clsGrafo
        {
            get
            {
                return _clsGrafo = _clsGrafo ?? new clsGrafo();
            }
        }

        private List<clsVertice> _lstInicial;
        public List<clsVertice> lstInicial
        {
            get
            {
                _lstInicial = _lstInicial == null ? new List<clsVertice>() : _lstInicial;
                _lstInicial.Clear();

                foreach (clsVertice item in clsGrafo.getVertices())
                {
                    _lstInicial.Add(item);
                }

                return _lstInicial;
            }
        }

        private List<clsVertice> _lstFinal;
        public List<clsVertice> lstFinal
        {
            get
            {
                _lstFinal = _lstFinal == null ? new List<clsVertice>() : _lstFinal;
                _lstFinal.Clear();

                foreach (clsVertice item in clsGrafo.getVertices())
                {
                    _lstFinal.Add(item);
                }

                return _lstFinal;
            }
        }

        public void AtualizaTreeView()
        {
            tvGrafo.Nodes.Clear();

            foreach(clsVertice Item in clsGrafo.getVertices())
            {
                TreeNode tn = new TreeNode(Item.Nome);
                foreach (clsVertice SubItem in Item.getArestas())
                {
                    tn.Nodes.Add(SubItem.Nome);
                }

                tvGrafo.Nodes.Add(tn);
            }

            tvGrafo.ExpandAll();
        }


        public frmMain()
        {
            InitializeComponent();            
        }

        private void btnAddVertice_Click(object sender, EventArgs e)
        {
            String v = txtVertice.Text.ToString();
            clsGrafo.setAddVertice(new clsVertice(v));           
            AtualizaComboAresta();
            AtualizaTreeView();
        }

        private void AtualizaComboAresta()
        {
            cbxArestaInicial.DataSource = null;
            cbxArestaInicial.DataSource = lstInicial;
            cbxArestaInicial.Refresh();

            cbxArestaFinal.DataSource = null;
            cbxArestaFinal.DataSource = lstFinal;
            cbxArestaFinal.Refresh();

            cbxVerticeInicial.DataSource = null;
            cbxVerticeInicial.DataSource = lstInicial;
            cbxVerticeInicial.Refresh();

            cbxVerticeFinal.DataSource = null;
            cbxVerticeFinal.DataSource = lstFinal;
            cbxVerticeFinal.Refresh();

            cbxVertice.DataSource = null;
            cbxVertice.DataSource = lstInicial;
            cbxVertice.Refresh();            
        }

        private void btnAddAresta_Click(object sender, EventArgs e)
        {
            String ArestaInicial = cbxArestaInicial.SelectedItem.ToString();
            String ArestaFinal   = cbxArestaFinal.SelectedItem.ToString();

            //Buscando os objetos correspondentes ao nome da vértice
            int inicial = clsGrafo.getVertices().IndexOf(new clsVertice(ArestaInicial));
            int final   = clsGrafo.getVertices().IndexOf(new clsVertice(ArestaFinal));

            //Vinculando a vértice final à inicial
            clsGrafo.getVertices()[inicial].setAddAresta(clsGrafo.getVertices()[final]);

            AtualizaTreeView();
        }

        private void btnGerarGrafo_Click(object sender, EventArgs e)
        {
            (new frmGrafo(clsGrafo)).Show();
        }

        private void btnVerificaAresta_Click(object sender, EventArgs e)
        {
            String msg = String.Empty;

            String VerticeInicial = cbxVerticeInicial.SelectedItem.ToString();
            String VerticeFinal   = cbxVerticeFinal.SelectedItem.ToString();

            //Buscando os objetos correspondentes ao nome da vértice
            int inicial = clsGrafo.getVertices().IndexOf(new clsVertice(VerticeInicial));
            int final = clsGrafo.getVertices().IndexOf(new clsVertice(VerticeFinal));

            clsVertice VInicial = clsGrafo.getVertices()[inicial];
            clsVertice VFinal   = clsGrafo.getVertices()[final];

            msg = ((VInicial.getArestas().Contains(VFinal)) || (VFinal.getArestas().Contains(VInicial))) ? "Existe uma aresta ligando os dois vértices" : "Não existe uma aresta ligando os dois vértices";

            MessageBox.Show(msg);            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int grau = 0;
            String Vertice = cbxVertice.SelectedItem.ToString();

            int vertice = clsGrafo.getVertices().IndexOf(new clsVertice(Vertice));
            clsVertice clsVertice = clsGrafo.getVertices()[vertice];
            grau = clsVertice.getArestas().Count();


            foreach (clsVertice Item in clsGrafo.getVertices())
            {
                grau += Item.getArestas().Contains(clsVertice) ? 1 : 0;
            }

            MessageBox.Show(String.Format("O grau do vértice é {0}", grau.ToString()));
        }
    }
}

