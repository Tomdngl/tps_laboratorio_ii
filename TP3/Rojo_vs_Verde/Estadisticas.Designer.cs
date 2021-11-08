
namespace Evento_deportivo
{
    partial class Estadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadisticas));
            this.btn_GuardarTablon = new System.Windows.Forms.Button();
            this.btn_CargarTablon = new System.Windows.Forms.Button();
            this.btn_VictoriasRojo = new System.Windows.Forms.Button();
            this.btn_VictoriasVerde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GuardarTablon
            // 
            this.btn_GuardarTablon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GuardarTablon.BackColor = System.Drawing.Color.Lavender;
            this.btn_GuardarTablon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_GuardarTablon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_GuardarTablon.FlatAppearance.BorderSize = 2;
            this.btn_GuardarTablon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarTablon.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GuardarTablon.Location = new System.Drawing.Point(49, 56);
            this.btn_GuardarTablon.Name = "btn_GuardarTablon";
            this.btn_GuardarTablon.Size = new System.Drawing.Size(315, 71);
            this.btn_GuardarTablon.TabIndex = 14;
            this.btn_GuardarTablon.Text = "Guardar tablon";
            this.btn_GuardarTablon.UseVisualStyleBackColor = false;
            this.btn_GuardarTablon.Click += new System.EventHandler(this.btn_GuardarTablon_Click);
            // 
            // btn_CargarTablon
            // 
            this.btn_CargarTablon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CargarTablon.BackColor = System.Drawing.Color.Lavender;
            this.btn_CargarTablon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CargarTablon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CargarTablon.FlatAppearance.BorderSize = 2;
            this.btn_CargarTablon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CargarTablon.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CargarTablon.Location = new System.Drawing.Point(416, 56);
            this.btn_CargarTablon.Name = "btn_CargarTablon";
            this.btn_CargarTablon.Size = new System.Drawing.Size(315, 71);
            this.btn_CargarTablon.TabIndex = 15;
            this.btn_CargarTablon.Text = "Cargar tablon";
            this.btn_CargarTablon.UseVisualStyleBackColor = false;
            this.btn_CargarTablon.Click += new System.EventHandler(this.btn_CargarTablon_Click);
            // 
            // btn_VictoriasRojo
            // 
            this.btn_VictoriasRojo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_VictoriasRojo.BackColor = System.Drawing.Color.Lavender;
            this.btn_VictoriasRojo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_VictoriasRojo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_VictoriasRojo.FlatAppearance.BorderSize = 2;
            this.btn_VictoriasRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VictoriasRojo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VictoriasRojo.Location = new System.Drawing.Point(49, 229);
            this.btn_VictoriasRojo.Name = "btn_VictoriasRojo";
            this.btn_VictoriasRojo.Size = new System.Drawing.Size(315, 71);
            this.btn_VictoriasRojo.TabIndex = 16;
            this.btn_VictoriasRojo.Text = "Filtrar victorias del equipo rojo";
            this.btn_VictoriasRojo.UseVisualStyleBackColor = false;
            this.btn_VictoriasRojo.Click += new System.EventHandler(this.btn_VictoriasRojo_Click);
            // 
            // btn_VictoriasVerde
            // 
            this.btn_VictoriasVerde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_VictoriasVerde.BackColor = System.Drawing.Color.Lavender;
            this.btn_VictoriasVerde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_VictoriasVerde.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_VictoriasVerde.FlatAppearance.BorderSize = 2;
            this.btn_VictoriasVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VictoriasVerde.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VictoriasVerde.Location = new System.Drawing.Point(425, 229);
            this.btn_VictoriasVerde.Name = "btn_VictoriasVerde";
            this.btn_VictoriasVerde.Size = new System.Drawing.Size(315, 71);
            this.btn_VictoriasVerde.TabIndex = 17;
            this.btn_VictoriasVerde.Text = "Filtrar victorias del equipo verde";
            this.btn_VictoriasVerde.UseVisualStyleBackColor = false;
            this.btn_VictoriasVerde.Click += new System.EventHandler(this.btn_VictoriasVerde_Click);
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_VictoriasVerde);
            this.Controls.Add(this.btn_VictoriasRojo);
            this.Controls.Add(this.btn_CargarTablon);
            this.Controls.Add(this.btn_GuardarTablon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Estadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GuardarTablon;
        private System.Windows.Forms.Button btn_CargarTablon;
        private System.Windows.Forms.Button btn_VictoriasRojo;
        private System.Windows.Forms.Button btn_VictoriasVerde;
    }
}