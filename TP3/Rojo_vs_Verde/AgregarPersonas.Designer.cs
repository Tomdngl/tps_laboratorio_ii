
namespace Evento_deportivo
{
    partial class AgregarPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPersonas));
            this.btn_Listo = new System.Windows.Forms.Button();
            this.btn_AgregarProfesor = new System.Windows.Forms.Button();
            this.btn_RemoverAlumno = new System.Windows.Forms.Button();
            this.btn_RemoverProfesor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Listo
            // 
            this.btn_Listo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Listo.BackColor = System.Drawing.Color.Lavender;
            this.btn_Listo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Listo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Listo.FlatAppearance.BorderSize = 2;
            this.btn_Listo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Listo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Listo.Location = new System.Drawing.Point(27, 113);
            this.btn_Listo.Name = "btn_Listo";
            this.btn_Listo.Size = new System.Drawing.Size(315, 42);
            this.btn_Listo.TabIndex = 5;
            this.btn_Listo.Text = "Agregar alumno";
            this.btn_Listo.UseVisualStyleBackColor = false;
            this.btn_Listo.Click += new System.EventHandler(this.btn_AgregarAlumno_Click);
            // 
            // btn_AgregarProfesor
            // 
            this.btn_AgregarProfesor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AgregarProfesor.BackColor = System.Drawing.Color.Lavender;
            this.btn_AgregarProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AgregarProfesor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AgregarProfesor.FlatAppearance.BorderSize = 2;
            this.btn_AgregarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarProfesor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarProfesor.Location = new System.Drawing.Point(415, 113);
            this.btn_AgregarProfesor.Name = "btn_AgregarProfesor";
            this.btn_AgregarProfesor.Size = new System.Drawing.Size(315, 42);
            this.btn_AgregarProfesor.TabIndex = 6;
            this.btn_AgregarProfesor.Text = "Agregar profesor";
            this.btn_AgregarProfesor.UseVisualStyleBackColor = false;
            this.btn_AgregarProfesor.Click += new System.EventHandler(this.btn_AgregarProfesor_Click);
            // 
            // btn_RemoverAlumno
            // 
            this.btn_RemoverAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_RemoverAlumno.BackColor = System.Drawing.Color.Lavender;
            this.btn_RemoverAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_RemoverAlumno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_RemoverAlumno.FlatAppearance.BorderSize = 2;
            this.btn_RemoverAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoverAlumno.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_RemoverAlumno.Location = new System.Drawing.Point(27, 285);
            this.btn_RemoverAlumno.Name = "btn_RemoverAlumno";
            this.btn_RemoverAlumno.Size = new System.Drawing.Size(315, 42);
            this.btn_RemoverAlumno.TabIndex = 7;
            this.btn_RemoverAlumno.Text = "Remover alumno";
            this.btn_RemoverAlumno.UseVisualStyleBackColor = false;
            this.btn_RemoverAlumno.Click += new System.EventHandler(this.btn_RemoverAlumno_Click);
            // 
            // btn_RemoverProfesor
            // 
            this.btn_RemoverProfesor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_RemoverProfesor.BackColor = System.Drawing.Color.Lavender;
            this.btn_RemoverProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_RemoverProfesor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_RemoverProfesor.FlatAppearance.BorderSize = 2;
            this.btn_RemoverProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoverProfesor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_RemoverProfesor.Location = new System.Drawing.Point(415, 285);
            this.btn_RemoverProfesor.Name = "btn_RemoverProfesor";
            this.btn_RemoverProfesor.Size = new System.Drawing.Size(315, 42);
            this.btn_RemoverProfesor.TabIndex = 8;
            this.btn_RemoverProfesor.Text = "Remover profesor";
            this.btn_RemoverProfesor.UseVisualStyleBackColor = false;
            this.btn_RemoverProfesor.Click += new System.EventHandler(this.btn_RemoverProfesor_Click);
            // 
            // AgregarPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_RemoverProfesor);
            this.Controls.Add(this.btn_RemoverAlumno);
            this.Controls.Add(this.btn_AgregarProfesor);
            this.Controls.Add(this.btn_Listo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar personas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Listo;
        private System.Windows.Forms.Button btn_AgregarProfesor;
        private System.Windows.Forms.Button btn_RemoverAlumno;
        private System.Windows.Forms.Button btn_RemoverProfesor;
    }
}