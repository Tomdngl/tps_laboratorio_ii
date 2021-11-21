
namespace Competencia
{
    partial class FrmCompetencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompetencia));
            this.btn_Estadisticas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Tablas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Estadisticas
            // 
            this.btn_Estadisticas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Estadisticas.BackColor = System.Drawing.Color.Lavender;
            this.btn_Estadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Estadisticas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Estadisticas.FlatAppearance.BorderSize = 2;
            this.btn_Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Estadisticas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Estadisticas.Location = new System.Drawing.Point(439, 181);
            this.btn_Estadisticas.Name = "btn_Estadisticas";
            this.btn_Estadisticas.Size = new System.Drawing.Size(289, 76);
            this.btn_Estadisticas.TabIndex = 3;
            this.btn_Estadisticas.Text = "Estadisticas";
            this.btn_Estadisticas.UseVisualStyleBackColor = false;
            this.btn_Estadisticas.Click += new System.EventHandler(this.btn_Estadisticas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 143);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Tablas
            // 
            this.btn_Tablas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Tablas.BackColor = System.Drawing.Color.Lavender;
            this.btn_Tablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Tablas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Tablas.FlatAppearance.BorderSize = 2;
            this.btn_Tablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tablas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Tablas.Location = new System.Drawing.Point(57, 181);
            this.btn_Tablas.Name = "btn_Tablas";
            this.btn_Tablas.Size = new System.Drawing.Size(289, 76);
            this.btn_Tablas.TabIndex = 5;
            this.btn_Tablas.Text = "Tablas";
            this.btn_Tablas.UseVisualStyleBackColor = false;
            this.btn_Tablas.Click += new System.EventHandler(this.btn_Tablas_Click);
            // 
            // Competencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_Tablas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Estadisticas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Competencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evento deportivo";
            this.Load += new System.EventHandler(this.EventoDeportivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Estadisticas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Tablas;
    }
}