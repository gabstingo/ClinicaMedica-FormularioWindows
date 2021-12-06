
namespace Atividade_3
{
    partial class HistoricoPaciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMedico = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomeMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anotacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pacienteid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(133, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Histórico de Paciente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxMedico
            // 
            this.comboBoxMedico.DisplayMember = "Nome";
            this.comboBoxMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMedico.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMedico.FormattingEnabled = true;
            this.comboBoxMedico.Location = new System.Drawing.Point(78, 56);
            this.comboBoxMedico.Name = "comboBoxMedico";
            this.comboBoxMedico.Size = new System.Drawing.Size(369, 25);
            this.comboBoxMedico.TabIndex = 19;
            this.comboBoxMedico.ValueMember = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeMedico,
            this.NomePaciente,
            this.Anotacoes,
            this.ID,
            this.DataAtendimento,
            this.Inicio,
            this.Fim,
            this.Paciente,
            this.Pacienteid,
            this.dataGridViewTextBoxColumn1,
            this.MedicoID});
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(510, 418);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NomeMedico
            // 
            this.NomeMedico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeMedico.DataPropertyName = "NomeMedico";
            this.NomeMedico.FillWeight = 190F;
            this.NomeMedico.HeaderText = "Médico";
            this.NomeMedico.Name = "NomeMedico";
            this.NomeMedico.ReadOnly = true;
            // 
            // NomePaciente
            // 
            this.NomePaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomePaciente.DataPropertyName = "NomePaciente";
            this.NomePaciente.FillWeight = 190F;
            this.NomePaciente.HeaderText = "Paciente";
            this.NomePaciente.Name = "NomePaciente";
            this.NomePaciente.ReadOnly = true;
            this.NomePaciente.Visible = false;
            // 
            // Anotacoes
            // 
            this.Anotacoes.DataPropertyName = "Anotacoes";
            this.Anotacoes.HeaderText = "Anotacoes";
            this.Anotacoes.Name = "Anotacoes";
            this.Anotacoes.ReadOnly = true;
            this.Anotacoes.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // DataAtendimento
            // 
            this.DataAtendimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataAtendimento.DataPropertyName = "DiaAtendimento";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.DataAtendimento.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataAtendimento.HeaderText = "Data";
            this.DataAtendimento.Name = "DataAtendimento";
            this.DataAtendimento.ReadOnly = true;
            // 
            // Inicio
            // 
            this.Inicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Inicio.DataPropertyName = "HorarioInicioAtendimento";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.Inicio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Inicio.FillWeight = 60F;
            this.Inicio.HeaderText = " Início";
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            // 
            // Fim
            // 
            this.Fim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fim.DataPropertyName = "HorarioFimAtendimento";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.Fim.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fim.FillWeight = 50F;
            this.Fim.HeaderText = "Fim";
            this.Fim.Name = "Fim";
            this.Fim.ReadOnly = true;
            // 
            // Paciente
            // 
            this.Paciente.DataPropertyName = "Paciente";
            this.Paciente.HeaderText = "PAciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            this.Paciente.Visible = false;
            // 
            // Pacienteid
            // 
            this.Pacienteid.DataPropertyName = "PacienteId";
            this.Pacienteid.HeaderText = "Pacienteid";
            this.Pacienteid.Name = "Pacienteid";
            this.Pacienteid.ReadOnly = true;
            this.Pacienteid.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Medico";
            this.dataGridViewTextBoxColumn1.HeaderText = "Medico";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // MedicoID
            // 
            this.MedicoID.DataPropertyName = "MedicoId";
            this.MedicoID.HeaderText = "MedicoId";
            this.MedicoID.Name = "MedicoID";
            this.MedicoID.ReadOnly = true;
            this.MedicoID.Visible = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(453, 56);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 25);
            this.btnAtualizar.TabIndex = 21;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // HistoricoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HistoricoPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico Do Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMedico;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anotacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAtendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pacienteid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicoID;
    }
}