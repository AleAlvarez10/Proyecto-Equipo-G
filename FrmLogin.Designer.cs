namespace Proyecto_Equipo_G
{
    partial class FrmLogin
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
            btnIngresar = new Button();
            txt_user = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            txt_password = new MaskedTextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Gold;
            btnIngresar.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(435, 481);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(304, 77);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txt_user
            // 
            txt_user.BackColor = Color.Gold;
            txt_user.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_user.Location = new Point(435, 172);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(526, 67);
            txt_user.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(153, 179);
            label1.Name = "label1";
            label1.Size = new Size(240, 60);
            label1.TabIndex = 2;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(60, 297);
            label2.Name = "label2";
            label2.Size = new Size(333, 60);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA";
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.Gold;
            txt_password.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(435, 290);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(526, 67);
            txt_password.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(376, 57);
            label3.Name = "label3";
            label3.Size = new Size(363, 60);
            label3.TabIndex = 5;
            label3.Text = "BIENVENIDO!!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(184, 373);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 233);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Gold;
            linkLabel1.Location = new Point(423, 671);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(303, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿No tiene cuenta?, Registrese AQUI";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FrmLogin
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.video_games_retro_games_pattern_technology_maze_Pacman_216381_wallhere_com;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1102, 710);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_user);
            Controls.Add(btnIngresar);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private MaskedTextBox txt_user;
        private Label label1;
        private Label label2;
        private MaskedTextBox txt_password;
        private Label label3;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}