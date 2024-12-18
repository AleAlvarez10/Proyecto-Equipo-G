namespace Proyecto_Equipo_G
{
    partial class FrmMenuPr
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvCatalogo = new DataGridView();
            dgvCarrito = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            btnAgregarCarrito = new Button();
            btnVerificarCupon = new Button();
            btnFinalizarCompra = new Button();
            txt_cupon = new MaskedTextBox();
            labelID = new Label();
            btnDatos = new Button();
            btnDevolucion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // dgvCatalogo
            // 
            dgvCatalogo.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCatalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCatalogo.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCatalogo.Location = new Point(254, 93);
            dgvCatalogo.Name = "dgvCatalogo";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Gold;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCatalogo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCatalogo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvCatalogo.Size = new Size(819, 612);
            dgvCatalogo.TabIndex = 0;
            // 
            // dgvCarrito
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCarrito.BackgroundColor = SystemColors.ActiveCaption;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle5;
            dgvCarrito.Location = new Point(1090, 95);
            dgvCarrito.Name = "dgvCarrito";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvCarrito.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.Size = new Size(489, 610);
            dgvCarrito.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(266, 21);
            label3.Name = "label3";
            label3.Size = new Size(275, 60);
            label3.TabIndex = 6;
            label3.Text = "CATALOGO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(1090, 21);
            label1.Name = "label1";
            label1.Size = new Size(311, 60);
            label1.TabIndex = 7;
            label1.Text = "MI CARRITO";
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.BackColor = Color.Gold;
            btnAgregarCarrito.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarCarrito.Location = new Point(22, 191);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(213, 77);
            btnAgregarCarrito.TabIndex = 8;
            btnAgregarCarrito.Text = "Agregar al carrito";
            btnAgregarCarrito.UseVisualStyleBackColor = false;
            btnAgregarCarrito.Click += btnAgregarCarrito_Click;
            // 
            // btnVerificarCupon
            // 
            btnVerificarCupon.BackColor = Color.Gold;
            btnVerificarCupon.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerificarCupon.Location = new Point(22, 327);
            btnVerificarCupon.Name = "btnVerificarCupon";
            btnVerificarCupon.Size = new Size(213, 70);
            btnVerificarCupon.TabIndex = 9;
            btnVerificarCupon.Text = "Verificar mi cupon";
            btnVerificarCupon.UseVisualStyleBackColor = false;
            btnVerificarCupon.Click += button1_Click;
            // 
            // btnFinalizarCompra
            // 
            btnFinalizarCompra.BackColor = Color.Gold;
            btnFinalizarCompra.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinalizarCompra.Location = new Point(22, 531);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(213, 77);
            btnFinalizarCompra.TabIndex = 10;
            btnFinalizarCompra.Text = "FINALIZAR COMPRA";
            btnFinalizarCompra.UseVisualStyleBackColor = false;
            btnFinalizarCompra.Click += btnFinalizarCompra_Click;
            // 
            // txt_cupon
            // 
            txt_cupon.Location = new Point(22, 412);
            txt_cupon.Name = "txt_cupon";
            txt_cupon.Size = new Size(213, 23);
            txt_cupon.TabIndex = 11;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.BackColor = Color.Black;
            labelID.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelID.ForeColor = Color.Gold;
            labelID.Location = new Point(-1, 694);
            labelID.Name = "labelID";
            labelID.Size = new Size(189, 36);
            labelID.TabIndex = 12;
            labelID.Text = "ID CLIENTE:";
            // 
            // btnDatos
            // 
            btnDatos.BackColor = Color.Gold;
            btnDatos.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDatos.Location = new Point(1451, 4);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(151, 62);
            btnDatos.TabIndex = 13;
            btnDatos.Text = "DATOS";
            btnDatos.UseVisualStyleBackColor = false;
            btnDatos.Click += btnDatos_Click;
            // 
            // btnDevolucion
            // 
            btnDevolucion.BackColor = Color.Gold;
            btnDevolucion.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDevolucion.Location = new Point(22, 21);
            btnDevolucion.Name = "btnDevolucion";
            btnDevolucion.Size = new Size(213, 77);
            btnDevolucion.TabIndex = 14;
            btnDevolucion.Text = "Devolver";
            btnDevolucion.UseVisualStyleBackColor = false;
            btnDevolucion.Click += btnDevolucion_Click;
            // 
            // FrmMenuPr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.video_games_retro_games_pattern_technology_maze_Pacman_216381_wallhere_com;
            ClientSize = new Size(1604, 739);
            Controls.Add(btnDevolucion);
            Controls.Add(btnDatos);
            Controls.Add(labelID);
            Controls.Add(txt_cupon);
            Controls.Add(btnFinalizarCompra);
            Controls.Add(btnVerificarCupon);
            Controls.Add(btnAgregarCarrito);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dgvCarrito);
            Controls.Add(dgvCatalogo);
            Name = "FrmMenuPr";
            Text = "FrmMenuPr";
            Load += FrmMenuPr_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCatalogo;
        private DataGridView dgvCarrito;
        private Label label3;
        private Label label1;
        private Button btnAgregarCarrito;
        private Button btnVerificarCupon;
        private Button btnFinalizarCompra;
        private MaskedTextBox txt_cupon;
        private Label label2;
        private Label labelID;
        private Button btnDatos;
        private Button btnDevolucion;
    }
}