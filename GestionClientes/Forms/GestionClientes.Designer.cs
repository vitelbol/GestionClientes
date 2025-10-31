namespace GestionClientes
{
    partial class GestionClientes
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
            listClientes = new ListBox();
            btnGuardar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnEliminar = new Button();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtTarjetaCredito = new TextBox();
            lblTarjeta = new Label();
            SuspendLayout();
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.Location = new Point(12, 30);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(297, 349);
            listClientes.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(557, 215);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(378, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(449, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(183, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(234, 385);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(449, 87);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(183, 23);
            txtApellido.TabIndex = 6;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(378, 87);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(449, 116);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(183, 23);
            txtTelefono.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(378, 116);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Telefono:";
            // 
            // txtTarjetaCredito
            // 
            txtTarjetaCredito.Location = new Point(378, 163);
            txtTarjetaCredito.Name = "txtTarjetaCredito";
            txtTarjetaCredito.Size = new Size(254, 23);
            txtTarjetaCredito.TabIndex = 10;
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.Location = new Point(378, 145);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(100, 15);
            lblTarjeta.TabIndex = 9;
            lblTarjeta.Text = "Tarjeta de credito:";
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 450);
            Controls.Add(txtTarjetaCredito);
            Controls.Add(lblTarjeta);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(btnEliminar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnGuardar);
            Controls.Add(listClientes);
            Name = "GestionClientes";
            Text = "Form1";
            Load += GestionClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listClientes;
        private Button btnGuardar;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnEliminar;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtTarjetaCredito;
        private Label lblTarjeta;
    }
}