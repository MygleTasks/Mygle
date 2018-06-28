namespace Mygle.Grafico
{
    partial class TelaGerenteResumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaGerenteResumo));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbResumo = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Button();
            this.btUsuarios = new System.Windows.Forms.Button();
            this.btDetalhe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCategorias = new System.Windows.Forms.Button();
            this.lbValorVendido = new System.Windows.Forms.Label();
            this.graGerenteMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graGerenteDia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btMeta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graGerenteMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graGerenteDia)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(417, 500);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(216, 191);
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(351, 461);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 29);
            this.label2.TabIndex = 51;
            this.label2.Text = "Meta de Valor de Venda por Dia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(351, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 29);
            this.label1.TabIndex = 50;
            this.label1.Text = "Meta de Venda de Itens por Dia";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(417, 224);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 191);
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // lbResumo
            // 
            this.lbResumo.AutoSize = true;
            this.lbResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbResumo.Location = new System.Drawing.Point(255, 53);
            this.lbResumo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResumo.Name = "lbResumo";
            this.lbResumo.Size = new System.Drawing.Size(289, 39);
            this.lbResumo.TabIndex = 46;
            this.lbResumo.Text = "Resumo Gerente";
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(10, 444);
            this.btLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(160, 49);
            this.btLogout.TabIndex = 45;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btUsuarios
            // 
            this.btUsuarios.Location = new System.Drawing.Point(10, 273);
            this.btUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btUsuarios.Name = "btUsuarios";
            this.btUsuarios.Size = new System.Drawing.Size(160, 49);
            this.btUsuarios.TabIndex = 3;
            this.btUsuarios.Text = "Usuários";
            this.btUsuarios.UseVisualStyleBackColor = true;
            this.btUsuarios.Click += new System.EventHandler(this.btUsuarios_Click);
            // 
            // btDetalhe
            // 
            this.btDetalhe.Location = new System.Drawing.Point(10, 216);
            this.btDetalhe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDetalhe.Name = "btDetalhe";
            this.btDetalhe.Size = new System.Drawing.Size(160, 49);
            this.btDetalhe.TabIndex = 2;
            this.btDetalhe.Text = "Detalhe";
            this.btDetalhe.UseVisualStyleBackColor = true;
            this.btDetalhe.Click += new System.EventHandler(this.btDetalhe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 123);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btCategorias
            // 
            this.btCategorias.Location = new System.Drawing.Point(10, 330);
            this.btCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCategorias.Name = "btCategorias";
            this.btCategorias.Size = new System.Drawing.Size(160, 49);
            this.btCategorias.TabIndex = 4;
            this.btCategorias.Text = "Categorias";
            this.btCategorias.UseVisualStyleBackColor = true;
            this.btCategorias.Click += new System.EventHandler(this.btCategorias_Click);
            // 
            // lbValorVendido
            // 
            this.lbValorVendido.AutoSize = true;
            this.lbValorVendido.Location = new System.Drawing.Point(860, 504);
            this.lbValorVendido.Name = "lbValorVendido";
            this.lbValorVendido.Size = new System.Drawing.Size(0, 17);
            this.lbValorVendido.TabIndex = 60;
            this.lbValorVendido.Click += new System.EventHandler(this.lbValorVendido_Click);
            // 
            // graGerenteMes
            // 
            chartArea3.Name = "ChartArea1";
            this.graGerenteMes.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graGerenteMes.Legends.Add(legend3);
            this.graGerenteMes.Location = new System.Drawing.Point(356, 500);
            this.graGerenteMes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graGerenteMes.Name = "graGerenteMes";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Vendas";
            this.graGerenteMes.Series.Add(series3);
            this.graGerenteMes.Size = new System.Drawing.Size(391, 219);
            this.graGerenteMes.TabIndex = 61;
            this.graGerenteMes.Text = "chart1";
            // 
            // graGerenteDia
            // 
            chartArea4.Name = "ChartArea1";
            this.graGerenteDia.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.graGerenteDia.Legends.Add(legend4);
            this.graGerenteDia.Location = new System.Drawing.Point(356, 224);
            this.graGerenteDia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graGerenteDia.Name = "graGerenteDia";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "VendasDia";
            this.graGerenteDia.Series.Add(series4);
            this.graGerenteDia.Size = new System.Drawing.Size(391, 223);
            this.graGerenteDia.TabIndex = 62;
            this.graGerenteDia.Text = "chart1";
            // 
            // btMeta
            // 
            this.btMeta.Location = new System.Drawing.Point(10, 387);
            this.btMeta.Margin = new System.Windows.Forms.Padding(4);
            this.btMeta.Name = "btMeta";
            this.btMeta.Size = new System.Drawing.Size(160, 49);
            this.btMeta.TabIndex = 63;
            this.btMeta.Text = "Meta";
            this.btMeta.UseVisualStyleBackColor = true;
            this.btMeta.Click += new System.EventHandler(this.btMeta_Click);
            // 
            // TelaGerenteResumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(940, 823);
            this.Controls.Add(this.btMeta);
            this.Controls.Add(this.graGerenteDia);
            this.Controls.Add(this.graGerenteMes);
            this.Controls.Add(this.lbValorVendido);
            this.Controls.Add(this.btCategorias);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbResumo);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btUsuarios);
            this.Controls.Add(this.btDetalhe);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TelaGerenteResumo";
            this.Text = "TelaResumoGerente";
            this.Load += new System.EventHandler(this.TelaGerenteResumo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaGerenteResumo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graGerenteMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graGerenteDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbResumo;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btUsuarios;
        private System.Windows.Forms.Button btDetalhe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btCategorias;
        private System.Windows.Forms.Label lbValorVendido;
        private System.Windows.Forms.DataVisualization.Charting.Chart graGerenteMes;
        private System.Windows.Forms.DataVisualization.Charting.Chart graGerenteDia;
        private System.Windows.Forms.Button btMeta;
    }
}