namespace ProyectoCurso.Views
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            panel1 = new Panel();
            panel4 = new Panel();
            btnRespaldar = new Button();
            btnRestaurar = new Button();
            btnUsuarios = new Button();
            brnRegistro = new Button();
            btnPersonal = new Button();
            btnConsultas = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            lblAdminName = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnPersonal);
            panel1.Controls.Add(btnConsultas);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 543);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Controls.Add(btnRespaldar);
            panel4.Controls.Add(btnRestaurar);
            panel4.Controls.Add(btnUsuarios);
            panel4.Controls.Add(brnRegistro);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 305);
            panel4.Margin = new Padding(3, 20, 3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(237, 238);
            panel4.TabIndex = 3;
            // 
            // btnRespaldar
            // 
            btnRespaldar.BackColor = Color.DarkKhaki;
            btnRespaldar.Dock = DockStyle.Top;
            btnRespaldar.FlatAppearance.BorderSize = 0;
            btnRespaldar.FlatStyle = FlatStyle.Flat;
            btnRespaldar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRespaldar.ForeColor = Color.MediumVioletRed;
            btnRespaldar.Image = (Image)resources.GetObject("btnRespaldar.Image");
            btnRespaldar.ImageAlign = ContentAlignment.BottomLeft;
            btnRespaldar.Location = new Point(0, 138);
            btnRespaldar.Margin = new Padding(10);
            btnRespaldar.Name = "btnRespaldar";
            btnRespaldar.Size = new Size(237, 46);
            btnRespaldar.TabIndex = 6;
            btnRespaldar.Text = "Respaldo";
            btnRespaldar.TextAlign = ContentAlignment.MiddleRight;
            btnRespaldar.UseVisualStyleBackColor = false;
            // 
            // btnRestaurar
            // 
            btnRestaurar.BackColor = Color.DarkKhaki;
            btnRestaurar.Dock = DockStyle.Top;
            btnRestaurar.FlatAppearance.BorderSize = 0;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRestaurar.ForeColor = Color.MediumVioletRed;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.ImageAlign = ContentAlignment.BottomLeft;
            btnRestaurar.Location = new Point(0, 92);
            btnRestaurar.Margin = new Padding(10);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(237, 46);
            btnRestaurar.TabIndex = 5;
            btnRestaurar.Text = "Restaurar BD";
            btnRestaurar.TextAlign = ContentAlignment.MiddleRight;
            btnRestaurar.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.DarkKhaki;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnUsuarios.ForeColor = Color.MediumVioletRed;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.BottomLeft;
            btnUsuarios.Location = new Point(0, 46);
            btnUsuarios.Margin = new Padding(10);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(237, 46);
            btnUsuarios.TabIndex = 4;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // brnRegistro
            // 
            brnRegistro.BackColor = Color.DarkKhaki;
            brnRegistro.Dock = DockStyle.Top;
            brnRegistro.FlatAppearance.BorderSize = 0;
            brnRegistro.FlatStyle = FlatStyle.Flat;
            brnRegistro.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            brnRegistro.ForeColor = Color.MediumVioletRed;
            brnRegistro.Image = Properties.Resources.fecha_limite;
            brnRegistro.ImageAlign = ContentAlignment.BottomLeft;
            brnRegistro.Location = new Point(0, 0);
            brnRegistro.Margin = new Padding(10);
            brnRegistro.Name = "brnRegistro";
            brnRegistro.Size = new Size(237, 46);
            brnRegistro.TabIndex = 3;
            brnRegistro.Text = "Registro";
            brnRegistro.TextAlign = ContentAlignment.MiddleRight;
            brnRegistro.UseVisualStyleBackColor = false;
            // 
            // btnPersonal
            // 
            btnPersonal.BackColor = Color.PaleGoldenrod;
            btnPersonal.Dock = DockStyle.Top;
            btnPersonal.FlatAppearance.BorderSize = 0;
            btnPersonal.FlatStyle = FlatStyle.Flat;
            btnPersonal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnPersonal.ForeColor = Color.Magenta;
            btnPersonal.Location = new Point(0, 151);
            btnPersonal.Name = "btnPersonal";
            btnPersonal.Size = new Size(237, 51);
            btnPersonal.TabIndex = 2;
            btnPersonal.Text = "Personal";
            btnPersonal.UseVisualStyleBackColor = false;
            // 
            // btnConsultas
            // 
            btnConsultas.BackColor = Color.PaleGoldenrod;
            btnConsultas.Dock = DockStyle.Top;
            btnConsultas.FlatAppearance.BorderSize = 0;
            btnConsultas.FlatStyle = FlatStyle.Flat;
            btnConsultas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnConsultas.ForeColor = Color.Magenta;
            btnConsultas.Location = new Point(0, 100);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Size = new Size(237, 51);
            btnConsultas.TabIndex = 1;
            btnConsultas.Text = "Pre Planilla";
            btnConsultas.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblAdminName);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 100);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(237, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(563, 543);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(99, 100);
            panel5.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(99, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 55);
            label2.TabIndex = 1;
            label2.Text = "Administrador";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAdminName
            // 
            lblAdminName.Dock = DockStyle.Top;
            lblAdminName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAdminName.ForeColor = SystemColors.ButtonHighlight;
            lblAdminName.Location = new Point(99, 55);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(138, 37);
            lblAdminName.TabIndex = 2;
            lblAdminName.Text = "Nombre";
            lblAdminName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 202);
            label1.Name = "label1";
            label1.Size = new Size(237, 36);
            label1.TabIndex = 7;
            label1.Text = "crated by: Miguel";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 543);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnConsultas;
        private Panel panel3;
        private Button btnPersonal;
        private Panel panel4;
        private Button brnRegistro;
        private Button btnRespaldar;
        private Button btnRestaurar;
        private Button btnUsuarios;
        private Panel panel5;
        private Label lblAdminName;
        private Label label2;
        private Label label1;
    }
}