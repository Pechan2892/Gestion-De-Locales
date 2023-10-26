
namespace Gestion_De_Locales
{
    partial class ClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEliminarReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarReserva.Image")));
            this.btnEliminarReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarReserva.Location = new System.Drawing.Point(505, 207);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(100, 43);
            this.btnEliminarReserva.TabIndex = 19;
            this.btnEliminarReserva.Text = "Eliminar";
            this.btnEliminarReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarReserva.UseVisualStyleBackColor = true;
            // 
            // btnEditarReserva
            // 
            this.btnEditarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEditarReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarReserva.Image")));
            this.btnEditarReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarReserva.Location = new System.Drawing.Point(240, 209);
            this.btnEditarReserva.Name = "btnEditarReserva";
            this.btnEditarReserva.Size = new System.Drawing.Size(100, 42);
            this.btnEditarReserva.TabIndex = 18;
            this.btnEditarReserva.Text = "Editar";
            this.btnEditarReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarReserva.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add.Location = new System.Drawing.Point(21, 207);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 43);
            this.add.TabIndex = 17;
            this.add.Text = "Agregar";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(21, 12);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(584, 172);
            this.dgvClientes.TabIndex = 16;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 267);
            this.Controls.Add(this.btnEliminarReserva);
            this.Controls.Add(this.btnEditarReserva);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dgvClientes);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarReserva;
        private System.Windows.Forms.Button btnEditarReserva;
        private System.Windows.Forms.Button add;
        public System.Windows.Forms.DataGridView dgvClientes;
    }
}