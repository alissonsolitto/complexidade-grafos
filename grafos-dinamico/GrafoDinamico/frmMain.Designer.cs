namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.tvGrafo = new System.Windows.Forms.TreeView();
            this.gbxVertice = new System.Windows.Forms.GroupBox();
            this.btnAddVertice = new System.Windows.Forms.Button();
            this.txtVertice = new System.Windows.Forms.TextBox();
            this.gbxAresta = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAresta = new System.Windows.Forms.Button();
            this.cbxArestaFinal = new System.Windows.Forms.ComboBox();
            this.cbxArestaInicial = new System.Windows.Forms.ComboBox();
            this.btnGerarGrafo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerificaAresta = new System.Windows.Forms.Button();
            this.cbxVerticeFinal = new System.Windows.Forms.ComboBox();
            this.cbxVerticeInicial = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cbxVertice = new System.Windows.Forms.ComboBox();
            this.gbxVertice.SuspendLayout();
            this.gbxAresta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvGrafo
            // 
            this.tvGrafo.Location = new System.Drawing.Point(16, 172);
            this.tvGrafo.Margin = new System.Windows.Forms.Padding(4);
            this.tvGrafo.Name = "tvGrafo";
            this.tvGrafo.Size = new System.Drawing.Size(561, 235);
            this.tvGrafo.TabIndex = 0;
            // 
            // gbxVertice
            // 
            this.gbxVertice.Controls.Add(this.btnAddVertice);
            this.gbxVertice.Controls.Add(this.txtVertice);
            this.gbxVertice.Location = new System.Drawing.Point(16, 15);
            this.gbxVertice.Margin = new System.Windows.Forms.Padding(4);
            this.gbxVertice.Name = "gbxVertice";
            this.gbxVertice.Padding = new System.Windows.Forms.Padding(4);
            this.gbxVertice.Size = new System.Drawing.Size(563, 60);
            this.gbxVertice.TabIndex = 1;
            this.gbxVertice.TabStop = false;
            this.gbxVertice.Text = "Adicionar Vértice:";
            // 
            // btnAddVertice
            // 
            this.btnAddVertice.Location = new System.Drawing.Point(492, 23);
            this.btnAddVertice.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVertice.Name = "btnAddVertice";
            this.btnAddVertice.Size = new System.Drawing.Size(48, 25);
            this.btnAddVertice.TabIndex = 1;
            this.btnAddVertice.Text = "+";
            this.btnAddVertice.UseVisualStyleBackColor = true;
            this.btnAddVertice.Click += new System.EventHandler(this.btnAddVertice_Click);
            // 
            // txtVertice
            // 
            this.txtVertice.Location = new System.Drawing.Point(8, 23);
            this.txtVertice.Margin = new System.Windows.Forms.Padding(4);
            this.txtVertice.Name = "txtVertice";
            this.txtVertice.Size = new System.Drawing.Size(475, 22);
            this.txtVertice.TabIndex = 0;
            // 
            // gbxAresta
            // 
            this.gbxAresta.Controls.Add(this.label1);
            this.gbxAresta.Controls.Add(this.btnAddAresta);
            this.gbxAresta.Controls.Add(this.cbxArestaFinal);
            this.gbxAresta.Controls.Add(this.cbxArestaInicial);
            this.gbxAresta.Location = new System.Drawing.Point(16, 82);
            this.gbxAresta.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAresta.Name = "gbxAresta";
            this.gbxAresta.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAresta.Size = new System.Drawing.Size(563, 66);
            this.gbxAresta.TabIndex = 2;
            this.gbxAresta.TabStop = false;
            this.gbxAresta.Text = "Adicionar Aresta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "====>";
            // 
            // btnAddAresta
            // 
            this.btnAddAresta.Location = new System.Drawing.Point(492, 23);
            this.btnAddAresta.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAresta.Name = "btnAddAresta";
            this.btnAddAresta.Size = new System.Drawing.Size(48, 26);
            this.btnAddAresta.TabIndex = 6;
            this.btnAddAresta.Text = "+";
            this.btnAddAresta.UseVisualStyleBackColor = true;
            this.btnAddAresta.Click += new System.EventHandler(this.btnAddAresta_Click);
            // 
            // cbxArestaFinal
            // 
            this.cbxArestaFinal.FormattingEnabled = true;
            this.cbxArestaFinal.Location = new System.Drawing.Point(277, 23);
            this.cbxArestaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.cbxArestaFinal.Name = "cbxArestaFinal";
            this.cbxArestaFinal.Size = new System.Drawing.Size(205, 24);
            this.cbxArestaFinal.TabIndex = 5;
            // 
            // cbxArestaInicial
            // 
            this.cbxArestaInicial.FormattingEnabled = true;
            this.cbxArestaInicial.Location = new System.Drawing.Point(8, 23);
            this.cbxArestaInicial.Margin = new System.Windows.Forms.Padding(4);
            this.cbxArestaInicial.Name = "cbxArestaInicial";
            this.cbxArestaInicial.Size = new System.Drawing.Size(205, 24);
            this.cbxArestaInicial.TabIndex = 4;
            // 
            // btnGerarGrafo
            // 
            this.btnGerarGrafo.Location = new System.Drawing.Point(16, 563);
            this.btnGerarGrafo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerarGrafo.Name = "btnGerarGrafo";
            this.btnGerarGrafo.Size = new System.Drawing.Size(563, 28);
            this.btnGerarGrafo.TabIndex = 3;
            this.btnGerarGrafo.Text = "Gerar Grafo";
            this.btnGerarGrafo.UseVisualStyleBackColor = true;
            this.btnGerarGrafo.Click += new System.EventHandler(this.btnGerarGrafo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnVerificaAresta);
            this.groupBox1.Controls.Add(this.cbxVerticeFinal);
            this.groupBox1.Controls.Add(this.cbxVerticeInicial);
            this.groupBox1.Location = new System.Drawing.Point(16, 415);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(563, 66);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existe aresta entre os dois vértices?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "<===>";
            // 
            // btnVerificaAresta
            // 
            this.btnVerificaAresta.Location = new System.Drawing.Point(492, 23);
            this.btnVerificaAresta.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerificaAresta.Name = "btnVerificaAresta";
            this.btnVerificaAresta.Size = new System.Drawing.Size(48, 26);
            this.btnVerificaAresta.TabIndex = 6;
            this.btnVerificaAresta.Text = "?";
            this.btnVerificaAresta.UseVisualStyleBackColor = true;
            this.btnVerificaAresta.Click += new System.EventHandler(this.btnVerificaAresta_Click);
            // 
            // cbxVerticeFinal
            // 
            this.cbxVerticeFinal.FormattingEnabled = true;
            this.cbxVerticeFinal.Location = new System.Drawing.Point(277, 23);
            this.cbxVerticeFinal.Margin = new System.Windows.Forms.Padding(4);
            this.cbxVerticeFinal.Name = "cbxVerticeFinal";
            this.cbxVerticeFinal.Size = new System.Drawing.Size(205, 24);
            this.cbxVerticeFinal.TabIndex = 5;
            // 
            // cbxVerticeInicial
            // 
            this.cbxVerticeInicial.FormattingEnabled = true;
            this.cbxVerticeInicial.Location = new System.Drawing.Point(8, 23);
            this.cbxVerticeInicial.Margin = new System.Windows.Forms.Padding(4);
            this.cbxVerticeInicial.Name = "cbxVerticeInicial";
            this.cbxVerticeInicial.Size = new System.Drawing.Size(205, 24);
            this.cbxVerticeInicial.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Controls.Add(this.cbxVertice);
            this.groupBox2.Location = new System.Drawing.Point(16, 489);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(563, 66);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calcular grau do vértice:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(221, 21);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(93, 26);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cbxVertice
            // 
            this.cbxVertice.FormattingEnabled = true;
            this.cbxVertice.Location = new System.Drawing.Point(8, 23);
            this.cbxVertice.Margin = new System.Windows.Forms.Padding(4);
            this.cbxVertice.Name = "cbxVertice";
            this.cbxVertice.Size = new System.Drawing.Size(205, 24);
            this.cbxVertice.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 605);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGerarGrafo);
            this.Controls.Add(this.gbxAresta);
            this.Controls.Add(this.gbxVertice);
            this.Controls.Add(this.tvGrafo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafos";
            this.gbxVertice.ResumeLayout(false);
            this.gbxVertice.PerformLayout();
            this.gbxAresta.ResumeLayout(false);
            this.gbxAresta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvGrafo;
        private System.Windows.Forms.GroupBox gbxVertice;
        private System.Windows.Forms.GroupBox gbxAresta;
        private System.Windows.Forms.ComboBox cbxArestaFinal;
        private System.Windows.Forms.ComboBox cbxArestaInicial;
        private System.Windows.Forms.Button btnAddVertice;
        private System.Windows.Forms.TextBox txtVertice;
        private System.Windows.Forms.Button btnAddAresta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerarGrafo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerificaAresta;
        private System.Windows.Forms.ComboBox cbxVerticeFinal;
        private System.Windows.Forms.ComboBox cbxVerticeInicial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cbxVertice;
    }
}

