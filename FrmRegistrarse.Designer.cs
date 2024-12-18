namespace Proyecto_Equipo_G
{
    partial class FrmRegistrarse
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
            label1 = new Label();
            txt_nombre = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            txt_telefono = new MaskedTextBox();
            txt_correo = new MaskedTextBox();
            btnRegistrarse = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(181, 120);
            label1.Name = "label1";
            label1.Size = new Size(131, 35);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.Gold;
            txt_nombre.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            txt_nombre.Location = new Point(348, 120);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(478, 43);
            txt_nombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(181, 265);
            label2.Name = "label2";
            label2.Size = new Size(142, 35);
            label2.TabIndex = 2;
            label2.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(181, 192);
            label3.Name = "label3";
            label3.Size = new Size(113, 35);
            label3.TabIndex = 3;
            label3.Text = "Correo";
            // 
            // txt_telefono
            // 
            txt_telefono.BackColor = Color.Gold;
            txt_telefono.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            txt_telefono.Location = new Point(348, 262);
            txt_telefono.Mask = "0000000000";
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(478, 43);
            txt_telefono.TabIndex = 3;
            // 
            // txt_correo
            // 
            txt_correo.BackColor = Color.Gold;
            txt_correo.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            txt_correo.Location = new Point(348, 189);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(478, 43);
            txt_correo.TabIndex = 2;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.Gold;
            btnRegistrarse.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarse.Location = new Point(416, 394);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(187, 68);
            btnRegistrarse.TabIndex = 4;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Gold;
            linkLabel1.Location = new Point(367, 551);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(323, 19);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Si deseas eliminar tu cuenta, clic AQUI";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FrmRegistrarse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.video_games_retro_games_pattern_technology_maze_Pacman_216381_wallhere_com;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1038, 579);
            Controls.Add(linkLabel1);
            Controls.Add(btnRegistrarse);
            Controls.Add(txt_correo);
            Controls.Add(txt_telefono);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Name = "FrmRegistrarse";
            Text = "FrmRegistrarse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox txt_nombre;
        private Label label2;
        private Label label3;
        private MaskedTextBox txt_telefono;
        private MaskedTextBox txt_correo;
        private Button btnRegistrarse;
        private LinkLabel linkLabel1;
    }
}