namespace GestionClientes
{
    partial class Menu
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
            btnGestionCLientes = new Button();
            SuspendLayout();
            // 
            // btnGestionCLientes
            // 
            btnGestionCLientes.Location = new Point(125, 28);
            btnGestionCLientes.Name = "btnGestionCLientes";
            btnGestionCLientes.Size = new Size(75, 51);
            btnGestionCLientes.TabIndex = 0;
            btnGestionCLientes.Text = "Gestionar Clientes";
            btnGestionCLientes.UseVisualStyleBackColor = true;
            btnGestionCLientes.Click += btnGestionCLientes_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 153);
            Controls.Add(btnGestionCLientes);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionCLientes;
    }
}
