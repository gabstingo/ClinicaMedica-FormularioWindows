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
using ClinicaMedica.Controller;
using ClinicaMedica.Model;

namespace Atividade_3
{
    public partial class Anotacoesmedico : FormBase
    {
        private AgendaEconsulta anotacoes = null;
        public Anotacoesmedico(AgendaEconsulta item)
        {
            anotacoes = item;
            InitializeComponent();
            if (anotacoes != null)
            {
                textBox1.Text = item.Paciente.Nome;
                dateTimePicker1.Value = item.HorarioInicioAtendimento.Value;
                dateTimePicker2.Value = item.HorarioFimAtendimento.Value;
                if (item.Anotacoes == null)
                {
                    richTextBox1.Text = "";
                }
                else
                {
                    richTextBox1.Text = item.Anotacoes;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Você quer realmente fechar a pagina de cadastro ?", "",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
                return;
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            anotacoes.Anotacoes = richTextBox1.Text;
            anotacoes.HorarioFimAtendimento = DateTime.Now;
            try
            {
                AgendaEconsultaController.Atualizar(anotacoes);
                MessageBox.Show("Dados salvos com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch
            {
                MessageBox.Show("Falha ao inserir os dados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
