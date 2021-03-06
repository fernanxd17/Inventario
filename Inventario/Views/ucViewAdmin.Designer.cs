﻿using System.Windows.Forms;

namespace Inventario.Views
{
    partial class ucViewAdmin
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucViewAdmin));
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Numero_Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadExistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgrearProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(384, 71);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(91, 22);
            this.txtBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(484, 71);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_Serie,
            this.Nombre,
            this.Proveedor,
            this.Categoria,
            this.Precio,
            this.CantidadExistencia});
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvProductos.Location = new System.Drawing.Point(19, 103);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(857, 213);
            this.dgvProductos.TabIndex = 3;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductos_CellContentClick);
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductos_CellContentClick_1);
            // 
            // Numero_Serie
            // 
            this.Numero_Serie.HeaderText = "Numero Serie";
            this.Numero_Serie.Name = "Numero_Serie";
            this.Numero_Serie.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // CantidadExistencia
            // 
            this.CantidadExistencia.HeaderText = "Cantidad Existencia";
            this.CantidadExistencia.Name = "CantidadExistencia";
            this.CantidadExistencia.ReadOnly = true;
            // 
            // btnAgrearProducto
            // 
            this.btnAgrearProducto.Location = new System.Drawing.Point(19, 401);
            this.btnAgrearProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgrearProducto.Name = "btnAgrearProducto";
            this.btnAgrearProducto.Size = new System.Drawing.Size(132, 28);
            this.btnAgrearProducto.TabIndex = 4;
            this.btnAgrearProducto.Text = "Agregar Producto";
            this.btnAgrearProducto.UseVisualStyleBackColor = true;
            this.btnAgrearProducto.Click += new System.EventHandler(this.BtnAgrearProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "INVENTARIO";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(323, 401);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 28);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar Producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click_1);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Location = new System.Drawing.Point(171, 401);
            this.btnEditarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(132, 28);
            this.btnEditarProducto.TabIndex = 7;
            this.btnEditarProducto.Text = "Editar Producto";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            this.btnEditarProducto.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Busca rapidamente el producto por su Numero de Serie:";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(744, 63);
            this.btnVender.Margin = new System.Windows.Forms.Padding(4);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(132, 28);
            this.btnVender.TabIndex = 9;
            this.btnVender.Text = "Vender Producto";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(19, 4);
            this.Salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(144, 23);
            this.Salir.TabIndex = 10;
            this.Salir.Text = "Salir del Sistema";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(579, 297);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 230);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ucViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgrearProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucViewAdmin";
            this.Size = new System.Drawing.Size(893, 527);
            this.Load += new System.EventHandler(this.UcViewAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgrearProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadExistencia;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditarProducto;
        private Label label2;
        private Button btnVender;
        private Button Salir;
        private PictureBox pictureBox1;

        public Button BtnAgrearProducto
        {
            get
            {
                return this.btnAgrearProducto;
            }
        }

        public Button BtnEliminar
        {
            get
            {
                return this.btnEliminar;
            }
        }

        public Button BtnEditarProducto
        {
            get
            {
                return this.btnEditarProducto;
            }
        }

        public Button BtnVenderProducto{
            get{
                return this.btnVender;
            }
        }
    }
}
