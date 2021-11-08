
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(49, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(315, 71);
            this.button2.TabIndex = 16;
            this.button2.Text = "Filtrar victorias del equipo rojo";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Lavender;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(425, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(315, 71);
            this.button3.TabIndex = 17;
            this.button3.Text = "Filtrar victorias del equipo verde";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}