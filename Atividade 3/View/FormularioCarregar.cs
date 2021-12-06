using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atividade_3.Controller;
using ClinicaMedica.Model;

namespace Atividade_3.View
{
    public partial class FormularioCarregar : Form
    {
        public FormularioCarregar()
        {
            InitializeComponent();
        }

        bool inicia = false;

        private void FormularioCarregar_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
            }
            else
            {
                timer1.Enabled = false;
                this.Close();
            }

            if (inicia == false)
            {
                CarregamentoIniciarController.iniciaBD();
                inicia = true;
            }
        }
    }
}
