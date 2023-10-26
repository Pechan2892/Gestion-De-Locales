
namespace Gestion_De_Locales
{
    partial class ReservasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservasForm));
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(12, 12);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(584, 172);
            this.dgvReservas.TabIndex = 1;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add.Location = new System.Drawing.Point(12, 207);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 43);
            this.add.TabIndex = 12;
            this.add.Text = "Agregar";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.UseVisualStyleBackColor = true;
            // 
            // btnEditarReserva
            // 
            this.btnEditarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEditarReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarReserva.Image")));
            this.btnEditarReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarReserva.Location = new System.Drawing.Point(231, 209);
            this.btnEditarReserva.Name = "btnEditarReserva";
            this.btnEditarReserva.Size = new System.Drawing.Size(100, 42);
            this.btnEditarReserva.TabIndex = 14;
            this.btnEditarReserva.Text = "Editar";
            this.btnEditarReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarReserva.UseVisualStyleBackColor = true;
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEliminarReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarReserva.Image")));
            this.btnEliminarReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarReserva.Location = new System.Drawing.Point(496, 207);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(100, 43);
            this.btnEliminarReserva.TabIndex = 15;
            this.btnEliminarReserva.Text = "Eliminar";
            this.btnEliminarReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarReserva.UseVisualStyleBackColor = true;
            // 
            // ReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 279);
            this.Controls.Add(this.btnEliminarReserva);
            this.Controls.Add(this.btnEditarReserva);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dgvReservas);
            this.Name = "ReservasForm";
            this.Text = "ReservasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button btnEditarReserva;
        private System.Windows.Forms.Button btnEliminarReserva;
    }
}