﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioAvaliacao
{
    public partial class Telefones : Form
    {
        public Telefones()
        {
            InitializeComponent();
            btnDeletar.Visible = false;
            btnAlterar.Visible = false;
        }
        string continua = "yes";

        private void Telefones_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }
    }
}
