
namespace Atividade_3
{
    partial class AgendarConsulta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HoraConsulta = new System.Windows.Forms.DateTimePicker();
            this.dataConsulta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.comboBoxMedico = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Pesq = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Médico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anotacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxPesquisa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Médico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paciente";
            // 
            // HoraConsulta
            // 
            this.HoraConsulta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HoraConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraConsulta.Location = new System.Drawing.Point(428, 110);
            this.HoraConsulta.Name = "HoraConsulta";
            this.HoraConsulta.Size = new System.Drawing.Size(94, 25);
            this.HoraConsulta.TabIndex = 4;
            // 
            // dataConsulta
            // 
            this.dataConsulta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataConsulta.Location = new System.Drawing.Point(428, 60);
            this.dataConsulta.Name = "dataConsulta";
            this.dataConsulta.Size = new System.Drawing.Size(94, 25);
            this.dataConsulta.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cadastro e Agendamento de consultas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(428, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hora de Início";
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.DisplayMember = "Nome";
            this.comboBoxPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaciente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Items.AddRange(new object[] {
            ""});
            this.comboBoxPaciente.Location = new System.Drawing.Point(12, 110);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(401, 25);
            this.comboBoxPaciente.TabIndex = 3;
            this.comboBoxPaciente.ValueMember = "ID";
            this.comboBoxPaciente.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaciente_SelectedIndexChanged);
            // 
            // comboBoxMedico
            // 
            this.comboBoxMedico.DisplayMember = "Nome";
            this.comboBoxMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMedico.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMedico.FormattingEnabled = true;
            this.comboBoxMedico.Items.AddRange(new object[] {
            ""});
            this.comboBoxMedico.Location = new System.Drawing.Point(12, 60);
            this.comboBoxMedico.Name = "comboBoxMedico";
            this.comboBoxMedico.Size = new System.Drawing.Size(401, 25);
            this.comboBoxMedico.TabIndex = 1;
            this.comboBoxMedico.ValueMember = "ID";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(433, 189);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 26);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(322, 189);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 26);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Novo Paciente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Pesq
            // 
            this.Pesq.AutoSize = true;
            this.Pesq.Location = new System.Drawing.Point(13, 137);
            this.Pesq.Name = "Pesq";
            this.Pesq.Size = new System.Drawing.Size(197, 19);
            this.Pesq.TabIndex = 13;
            this.Pesq.Text = "Pesquisar Consulta Cadastrada";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(428, 156);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 26);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Médico,
            this.NomePaciente,
            this.Medico,
            this.Paciente,
            this.Data,
            this.Inicio,
            this.Fim,
            this.ID,
            this.PacienteID,
            this.MedicoID,
            this.Anotacoes});
            this.dataGridView1.Location = new System.Drawing.Point(12, 221);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(501, 286);
            this.dataGridView1.TabIndex = 16;
            // 
            // Médico
            // 
            this.Médico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Médico.DataPropertyName = "NomeMedico";
            this.Médico.FillWeight = 130F;
            this.Médico.HeaderText = "Médico";
            this.Médico.Name = "Médico";
            this.Médico.ReadOnly = true;
            // 
            // NomePaciente
            // 
            this.NomePaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomePaciente.DataPropertyName = "NomePaciente";
            this.NomePaciente.FillWeight = 130F;
            this.NomePaciente.HeaderText = "Paciente";
            this.NomePaciente.Name = "NomePaciente";
            this.NomePaciente.ReadOnly = true;
            // 
            // Medico
            // 
            this.Medico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medico.DataPropertyName = "Medico";
            this.Medico.FillWeight = 130F;
            this.Medico.HeaderText = "Médico";
            this.Medico.Name = "Medico";
            this.Medico.ReadOnly = true;
            this.Medico.Visible = false;
            // 
            // Paciente
            // 
            this.Paciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Paciente.DataPropertyName = "Paciente";
            this.Paciente.FillWeight = 130F;
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            this.Paciente.Visible = false;
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data.DataPropertyName = "DiaAtendimento";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle1;
            this.Data.FillWeight = 110F;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Inicio
            // 
            this.Inicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Inicio.DataPropertyName = "HorarioInicioAtendimento";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.Inicio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Inicio.FillWeight = 65F;
            this.Inicio.HeaderText = "Início";
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
            this.Fim.FillWeight = 65F;
            this.Fim.HeaderText = "Fim";
            this.Fim.Name = "Fim";
            this.Fim.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // PacienteID
            // 
            this.PacienteID.DataPropertyName = "PacienteID";
            this.PacienteID.HeaderText = "PacienteID";
            this.PacienteID.Name = "PacienteID";
            this.PacienteID.ReadOnly = true;
            this.PacienteID.Visible = false;
            // 
            // MedicoID
            // 
            this.MedicoID.DataPropertyName = "MedicoID";
            this.MedicoID.HeaderText = "MedicoID";
            this.MedicoID.Name = "MedicoID";
            this.MedicoID.ReadOnly = true;
            this.MedicoID.Visible = false;
            // 
            // Anotacoes
            // 
            this.Anotacoes.DataPropertyName = "Anotacoes";
            this.Anotacoes.HeaderText = "Anotacoes";
            this.Anotacoes.Name = "Anotacoes";
            this.Anotacoes.ReadOnly = true;
            this.Anotacoes.Visible = false;
            // 
            // comboBoxPesquisa
            // 
            this.comboBoxPesquisa.DisplayMember = "Nome";
            this.comboBoxPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPesquisa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPesquisa.FormattingEnabled = true;
            this.comboBoxPesquisa.Location = new System.Drawing.Point(12, 158);
            this.comboBoxPesquisa.Name = "comboBoxPesquisa";
            this.comboBoxPesquisa.Size = new System.Drawing.Size(401, 25);
            this.comboBoxPesquisa.TabIndex = 17;
            this.comboBoxPesquisa.ValueMember = "ID";
            // 
            // AgendarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 519);
            this.Controls.Add(this.comboBoxPesquisa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.Pesq);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.comboBoxMedico);
            this.Controls.Add(this.comboBoxPaciente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataConsulta);
            this.Controls.Add(this.HoraConsulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AgendarConsulta";
            this.Text = "Agendamento de Consultas";
            this.Load += new System.EventHandler(this.AgendarConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker HoraConsulta;
        private System.Windows.Forms.DateTimePicker dataConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.ComboBox comboBoxMedico;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label Pesq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Médico;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anotacoes;
        private System.Windows.Forms.ComboBox comboBoxPesquisa;
    }
}