﻿using Neptuno2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neptuno2023.Windows
{
    public partial class FrmSeleccionarPais : Form
    {
        public FrmSeleccionarPais()
        {
            InitializeComponent();
        }

        private Pais paiseSeleccionado;

        public Pais GetPais()
        {
            return paiseSeleccionado;
        }
    }
}
