
namespace Evento_deportivo
{
    partial class Jugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jugar));
            this.lst_Juegos = new System.Windows.Forms.ListBox();
            this.btn_verResultado = new System.Windows.Forms.Button();
            this.btn_cargarResultado = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_AddRmv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Juegos
            // 
            this.lst_Juegos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lst_Juegos.FormattingEnabled = true;
            this.lst_Juegos.ItemHeight = 28;
            this.lst_Juegos.Location = new System.Drawing.Point(449, 29);
            this.lst_Juegos.Name = "lst_Juegos";
            this.lst_Juegos.Size = new System.Drawing.Size(323, 396);
            this.lst_Juegos.TabIndex = 0;
            this.lst_Juegos.SelectedIndexChanged += new System.EventHandler(this.lst_Juegos_SelectedIndexChanged);
            // 
            // btn_verResultado
            // 
            this.btn_verResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_verResultado.BackColor = System.Drawing.Color.Lavender;
            this.btn_verResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_verResultado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_verResultado.FlatAppearance.BorderSize = 2;
            this.btn_verResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verResultado.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_verResultado.Location = new System.Drawing.Point(88, 185);
            this.btn_verResultado.Name = "btn_verResultado";
            this.btn_verResultado.Size = new System.Drawing.Size(315, 42);
            this.btn_verResultado.TabIndex = 6;
            this.btn_verResultado.Text = "Ver resultado";
            this.btn_verResultado.UseVisualStyleBackColor = false;
            this.btn_verResultado.Click += new System.EventHandler(this.btn_verResultado_Click);
            // 
            // btn_cargarResultado
            // 
            this.btn_cargarResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cargarResultado.BackColor = System.Drawing.Color.Lavender;
            this.btn_cargarResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cargarResultado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cargarResultado.FlatAppearance.BorderSize = 2;
            this.btn_cargarResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargarResultado.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cargarResultado.Location = new System.Drawing.Point(88, 123);
            this.btn_cargarResultado.Name = "btn_cargarResultado";
            this.btn_cargarResultado.Size = new System.Drawing.Size(315, 42);
            this.btn_cargarResultado.TabIndex = 8;
            this.btn_cargarResultado.Text = "Cargar resultados";
            this.btn_cargarResultado.UseVisualStyleBackColor = false;
            this.btn_cargarResultado.Click += new System.EventHandler(this.btn_cargarResultado_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Eliminar.BackColor = System.Drawing.Color.Lavender;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Eliminar.FlatAppearance.BorderSize = 2;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Eliminar.Location = new System.Drawing.Point(88, 248);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(315, 42);
            this.btn_Eliminar.TabIndex = 9;
            this.btn_Eliminar.Text = "Eliminar juego";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_volver.BackColor = System.Drawing.Color.Lavender;
            this.btn_volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_volver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_volver.FlatAppearance.BorderSize = 2;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.Location = new System.Drawing.Point(88, 307);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(315, 42);
            this.btn_volver.TabIndex = 12;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_AddRmv
            // 
            this.btn_AddRmv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddRmv.BackColor = System.Drawing.Color.Lavender;
            this.btn_AddRmv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AddRmv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AddRmv.FlatAppearance.BorderSize = 2;
            this.btn_AddRmv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddRmv.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AddRmv.Location = new System.Drawing.Point(88, 29);
            this.btn_AddRmv.Name = "btn_AddRmv";
            this.btn_AddRmv.Size = new System.Drawing.Size(315, 71);
            this.btn_AddRmv.TabIndex = 13;
            this.btn_AddRmv.Text = "Agregar / Remover alumnos";
            this.btn_AddRmv.UseVisualStyleBackColor = false;
            this.btn_AddRmv.Click += new System.EventHandler(this.btn_AddRmv_Click);
            // 
            // Jugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_AddRmv);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_cargarResultado);
            this.Controls.Add(this.btn_verResultado);
            this.Controls.Add(this.lst_Juegos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Jugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jugar";
            this.Load += new System.EventHandler(this.Jugar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lst_Juegos;
        private System.Windows.Forms.Button btn_verResultado;
        private System.Windows.Forms.Button btn_cargarResultado;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_AddRmv;
    }
}