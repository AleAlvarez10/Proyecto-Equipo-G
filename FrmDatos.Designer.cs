namespace Proyecto_Equipo_G
{
    partial class FrmDatos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnTendencias = new Button();
            dgvDatos = new DataGridView();
            btnMejoresClientes = new Button();
            button1 = new Button();
            button2 = new Button();
            btnEliminarVideojuego = new Button();
            btnVentasRecientes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // btnTendencias
            // 
            btnTendencias.BackColor = Color.Gold;
            btnTendencias.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTendencias.Image = Properties.Resources.local_fire_department_16dp_EA3323_FILL0_wght400_GRAD0_opsz20;
            btnTendencias.Location = new Point(12, 89);
            btnTendencias.Name = "btnTendencias";
            btnTendencias.Size = new Size(357, 93);
            btnTendencias.TabIndex = 0;
            btnTendencias.Text = "Tendencias";
            btnTendencias.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnTendencias.UseVisualStyleBackColor = false;
            btnTendencias.Click += btnTendencias_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.BackgroundColor = Color.SteelBlue;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.GridColor = Color.Black;
            dgvDatos.Location = new Point(375, 38);
            dgvDatos.Name = "dgvDatos";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.Size = new Size(996, 679);
            dgvDatos.TabIndex = 1;
            // 
            // btnMejoresClientes
            // 
            btnMejoresClientes.BackColor = Color.Gold;
            btnMejoresClientes.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMejoresClientes.Image = Properties.Resources.star_16dp_000000_FILL0_wght400_GRAD0_opsz20;
            btnMejoresClientes.ImageAlign = ContentAlignment.MiddleRight;
            btnMejoresClientes.Location = new Point(12, 209);
            btnMejoresClientes.Name = "btnMejoresClientes";
            btnMejoresClientes.Size = new Size(357, 95);
            btnMejoresClientes.TabIndex = 2;
            btnMejoresClientes.Text = "Mejores Clientes";
            btnMejoresClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnMejoresClientes.UseVisualStyleBackColor = false;
            btnMejoresClientes.Click += btnMejoresClientes_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.videogame_asset_16dp_000000_FILL0_wght400_GRAD0_opsz20;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(12, 329);
            button1.Name = "button1";
            button1.Size = new Size(357, 95);
            button1.TabIndex = 3;
            button1.Text = "Ventas por Genero";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.emoji_objects_16dp_000000_FILL0_wght400_GRAD0_opsz20;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(12, 453);
            button2.Name = "button2";
            button2.Size = new Size(357, 95);
            button2.TabIndex = 4;
            button2.Text = "Desarrolladores TOP";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnEliminarVideojuego
            // 
            btnEliminarVideojuego.BackColor = Color.Gold;
            btnEliminarVideojuego.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarVideojuego.Image = Properties.Resources.add_16dp_000000_FILL0_wght400_GRAD0_opsz20;
            btnEliminarVideojuego.Location = new Point(1377, 89);
            btnEliminarVideojuego.Name = "btnEliminarVideojuego";
            btnEliminarVideojuego.Size = new Size(237, 93);
            btnEliminarVideojuego.TabIndex = 5;
            btnEliminarVideojuego.Text = "Añadir Videojuego";
            btnEliminarVideojuego.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEliminarVideojuego.UseVisualStyleBackColor = false;
            btnEliminarVideojuego.Click += btnEliminarVideojuego_Click;
            // 
            // btnVentasRecientes
            // 
            btnVentasRecientes.BackColor = Color.Gold;
            btnVentasRecientes.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentasRecientes.Image = Properties.Resources.schedule_16dp_000000_FILL0_wght400_GRAD0_opsz20;
            btnVentasRecientes.ImageAlign = ContentAlignment.MiddleRight;
            btnVentasRecientes.Location = new Point(12, 572);
            btnVentasRecientes.Name = "btnVentasRecientes";
            btnVentasRecientes.Size = new Size(357, 95);
            btnVentasRecientes.TabIndex = 6;
            btnVentasRecientes.Text = "Ventas Recientes";
            btnVentasRecientes.TextAlign = ContentAlignment.MiddleLeft;
            btnVentasRecientes.UseVisualStyleBackColor = false;
            btnVentasRecientes.Click += btnVentasRecientes_Click;
            // 
            // FrmDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.video_games_retro_games_pattern_technology_maze_Pacman_216381_wallhere_com;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1625, 748);
            Controls.Add(btnVentasRecientes);
            Controls.Add(btnEliminarVideojuego);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnMejoresClientes);
            Controls.Add(dgvDatos);
            Controls.Add(btnTendencias);
            Name = "FrmDatos";
            Text = "FrmDatos";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTendencias;
        private DataGridView dgvDatos;
        private Button btnMejoresClientes;
        private Button button1;
        private Button button2;
        private Button btnEliminarVideojuego;
        private Button btnVentasRecientes;
    }
}