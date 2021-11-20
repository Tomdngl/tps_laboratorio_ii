
namespace Evento_deportivo
{
    partial class Remover_Alumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remover_Alumno));
            this.lst_alumnos = new System.Windows.Forms.ListBox();
            this.btn_Rmv = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_alumnos
            // 
            this.lst_alumnos.FormattingEnabled = true;
            this.lst_alumnos.ItemHeight = 15;
            this.lst_alumnos.Location = new System.Drawing.Point(289, 12);
            this.lst_alumnos.Name = "lst_alumnos";
            this.lst_alumnos.Size = new System.Drawing.Size(473, 439);
            this.lst_alumnos.TabIndex = 1;
            this.lst_alumnos.SelectedIndexChanged += new System.EventHandler(this.lst_alumnos_SelectedIndexChanged);
            // 
            // btn_Rmv
            // 
            this.btn_Rmv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Rmv.BackColor = System.Drawing.Color.Lavender;
            this.btn_Rmv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Rmv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Rmv.FlatAppearance.BorderSize = 2;
            this.btn_Rmv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rmv.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Rmv.Location = new System.Drawing.Point(2, 75);
            this.btn_Rmv.Name = "btn_Rmv";
            this.btn_Rmv.Size = new System.Drawing.Size(281, 88);
            this.btn_Rmv.TabIndex = 16;
            this.btn_Rmv.Text = "Remover";
            this.btn_Rmv.UseVisualStyleBackColor = false;
            this.btn_Rmv.Click += new System.EventHandler(this.btn_Rmv_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Volver.BackColor = System.Drawing.Color.Lavender;
            this.btn_Volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Volver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Volver.FlatAppearance.BorderSize = 2;
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Volver.Location = new System.Drawing.Point(2, 290);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(281, 88);
            this.btn_Volver.TabIndex = 17;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // Remover_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Rmv);
            this.Controls.Add(this.lst_alumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Remover_Alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remover_Alumno";
            this.Load += new System.EventHandler(this.Remover_Alumno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_alumnos;
        private System.Windows.Forms.Button btn_Rmv;
        private System.Windows.Forms.Button btn_Volver;
    }
}