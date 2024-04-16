namespace Recuperar_contrasena
{
    partial class Clientes
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
            dgvUsuarios = new DataGridView();
            tbxNombreUsuario = new TextBox();
            tbxNombre = new TextBox();
            tbxApellido = new TextBox();
            tbxMesNacimiento = new TextBox();
            tbxContrasena = new TextBox();
            tbxDiaNacimiento = new TextBox();
            tbxTelefono = new TextBox();
            tbxSexo = new TextBox();
            tbxPais = new TextBox();
            tbxConfirmacionContrasena = new TextBox();
            btnConfirmar = new Button();
            tbxId = new TextBox();
            tbxAnoNacimiento = new TextBox();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = SystemColors.ControlDarkDark;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(74, 168);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(633, 339);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dgvClientes_CellContentClick;
            // 
            // tbxNombreUsuario
            // 
            tbxNombreUsuario.Location = new Point(12, 92);
            tbxNombreUsuario.Name = "tbxNombreUsuario";
            tbxNombreUsuario.Size = new Size(161, 23);
            tbxNombreUsuario.TabIndex = 1;
            tbxNombreUsuario.Text = "Usuario";
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(12, 36);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(185, 23);
            tbxNombre.TabIndex = 2;
            tbxNombre.Text = "Nombre";
            // 
            // tbxApellido
            // 
            tbxApellido.Location = new Point(215, 36);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.Size = new Size(165, 23);
            tbxApellido.TabIndex = 4;
            tbxApellido.Text = "Apellido";
            // 
            // tbxMesNacimiento
            // 
            tbxMesNacimiento.Location = new Point(680, 92);
            tbxMesNacimiento.Name = "tbxMesNacimiento";
            tbxMesNacimiento.Size = new Size(100, 23);
            tbxMesNacimiento.TabIndex = 5;
            tbxMesNacimiento.Text = "Mes ";
            // 
            // tbxContrasena
            // 
            tbxContrasena.Location = new Point(402, 36);
            tbxContrasena.Name = "tbxContrasena";
            tbxContrasena.Size = new Size(182, 23);
            tbxContrasena.TabIndex = 6;
            tbxContrasena.Text = "Contrasena";
            // 
            // tbxDiaNacimiento
            // 
            tbxDiaNacimiento.Location = new Point(574, 92);
            tbxDiaNacimiento.Name = "tbxDiaNacimiento";
            tbxDiaNacimiento.Size = new Size(100, 23);
            tbxDiaNacimiento.TabIndex = 7;
            tbxDiaNacimiento.Text = "Dia ";
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(179, 92);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(185, 23);
            tbxTelefono.TabIndex = 8;
            tbxTelefono.Text = "Telefono";
            // 
            // tbxSexo
            // 
            tbxSexo.Location = new Point(786, 36);
            tbxSexo.Name = "tbxSexo";
            tbxSexo.Size = new Size(100, 23);
            tbxSexo.TabIndex = 9;
            tbxSexo.Text = "Sexo";
            // 
            // tbxPais
            // 
            tbxPais.Location = new Point(379, 92);
            tbxPais.Name = "tbxPais";
            tbxPais.Size = new Size(165, 23);
            tbxPais.TabIndex = 10;
            tbxPais.Text = "Pais";
            // 
            // tbxConfirmacionContrasena
            // 
            tbxConfirmacionContrasena.Location = new Point(590, 36);
            tbxConfirmacionContrasena.Name = "tbxConfirmacionContrasena";
            tbxConfirmacionContrasena.Size = new Size(165, 23);
            tbxConfirmacionContrasena.TabIndex = 11;
            tbxConfirmacionContrasena.Text = "Confirmar contrasena";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(346, 130);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(198, 23);
            btnConfirmar.TabIndex = 12;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(251, 130);
            tbxId.Name = "tbxId";
            tbxId.ReadOnly = true;
            tbxId.Size = new Size(89, 23);
            tbxId.TabIndex = 13;
            // 
            // tbxAnoNacimiento
            // 
            tbxAnoNacimiento.Location = new Point(795, 92);
            tbxAnoNacimiento.Name = "tbxAnoNacimiento";
            tbxAnoNacimiento.Size = new Size(100, 23);
            tbxAnoNacimiento.TabIndex = 14;
            tbxAnoNacimiento.Text = "Ano";
            tbxAnoNacimiento.TextChanged += textBox1_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(550, 130);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(198, 23);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 519);
            Controls.Add(btnEliminar);
            Controls.Add(tbxAnoNacimiento);
            Controls.Add(tbxId);
            Controls.Add(btnConfirmar);
            Controls.Add(tbxConfirmacionContrasena);
            Controls.Add(tbxPais);
            Controls.Add(tbxSexo);
            Controls.Add(tbxTelefono);
            Controls.Add(tbxDiaNacimiento);
            Controls.Add(tbxContrasena);
            Controls.Add(tbxMesNacimiento);
            Controls.Add(tbxApellido);
            Controls.Add(tbxNombre);
            Controls.Add(tbxNombreUsuario);
            Controls.Add(dgvUsuarios);
            Name = "Clientes";
            Text = "Form1";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private TextBox tbxNombreUsuario;
        private TextBox tbxNombre;
        private TextBox tbxApellido;
        private TextBox tbxMesNacimiento;
        private TextBox tbxContrasena;
        private TextBox tbxDiaNacimiento;
        private TextBox tbxTelefono;
        private TextBox tbxSexo;
        private TextBox tbxPais;
        private TextBox tbxConfirmacionContrasena;
        private Button btnConfirmar;
        private TextBox tbxId;
        private TextBox tbxAnoNacimiento;
        private Button btnEliminar;
    }
}