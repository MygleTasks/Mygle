﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mygle.Grafico
{
    public partial class TelaGerenteDetalhe : Form
    {
        public TelaGerenteDetalhe()
        {
            InitializeComponent();
        }

        private void TelaGerenteDetalhe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
