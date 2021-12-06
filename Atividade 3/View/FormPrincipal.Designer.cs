
namespace Atividade_3
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnCadastroMedico = new System.Windows.Forms.Button();
            this.btnCadastroPaciente = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHistorico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastroMedico
            // 
            this.btnCadastroMedico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroMedico.Location = new System.Drawing.Point(11, 202);
            this.btnCadastroMedico.Name = "btnCadastroMedico";
            this.btnCadastroMedico.Size = new System.Drawing.Size(122, 26);
            this.btnCadastroMedico.TabIndex = 4;
            this.btnCadastroMedico.Text = "Cadastrar Médico";
            this.btnCadastroMedico.UseVisualStyleBackColor = true;
            this.btnCadastroMedico.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastroPaciente
            // 
            this.btnCadastroPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroPaciente.Location = new System.Drawing.Point(11, 247);
            this.btnCadastroPaciente.Name = "btnCadastroPaciente";
            this.btnCadastroPaciente.Size = new System.Drawing.Size(122, 26);
            this.btnCadastroPaciente.TabIndex = 5;
            this.btnCadastroPaciente.Text = "Cadastrar Paciente";
            this.btnCadastroPaciente.UseVisualStyleBackColor = true;
            this.btnCadastroPaciente.Click += new System.EventHandler(this.btnCadastroPaciente_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgendar.Location = new System.Drawing.Point(13, 66);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(122, 26);
            this.btnAgendar.TabIndex = 1;
            this.btnAgendar.Text = "Agendar Consulta";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultas.Location = new System.Drawing.Point(12, 111);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(122, 26);
            this.btnConsultas.TabIndex = 2;
            this.btnConsultas.Text = "Tabela de Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consulta Médica";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnHistorico
            // 
            this.btnHistorico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistorico.Location = new System.Drawing.Point(12, 156);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(121, 26);
            this.btnHistorico.TabIndex = 3;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // FormPrincipal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 287);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.btnCadastroPaciente);
            this.Controls.Add(this.btnCadastroMedico);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPrincipal";
            this.Text = "Agenda Médica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroMedico;
        private System.Windows.Forms.Button btnCadastroPaciente;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHistorico;
    }
}

