namespace DAM2_DI_TiendaAnimales_DeLuca_Tatiana
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idProductoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label fechaAltaLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label marcaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label imagenLabel;
            this.productosAnimalesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productosAnimalesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idProductoLabel1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.fechaAltaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.productosAnimalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosAnimalesTableAdapter = new DAM2_DI_TiendaAnimales_DeLuca_Tatiana.ProductosAnimalesTableAdapter();
            this.productosAnimalesTableAdapter1 = new DAM2_DI_TiendaAnimales_DeLuca_Tatiana.ProductosAnimalesTableAdapterTableAdapters.ProductosAnimalesTableAdapter1();
            this.tableAdapterManager = new DAM2_DI_TiendaAnimales_DeLuca_Tatiana.ProductosAnimalesTableAdapterTableAdapters.TableAdapterManager();
            this.imagenPictureBox = new System.Windows.Forms.PictureBox();
            idProductoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            fechaAltaLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            imagenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productosAnimalesBindingNavigator)).BeginInit();
            this.productosAnimalesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosAnimalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosAnimalesTableAdapter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idProductoLabel
            // 
            idProductoLabel.AutoSize = true;
            idProductoLabel.ForeColor = System.Drawing.Color.Maroon;
            idProductoLabel.Location = new System.Drawing.Point(60, 60);
            idProductoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            idProductoLabel.Name = "idProductoLabel";
            idProductoLabel.Size = new System.Drawing.Size(83, 17);
            idProductoLabel.TabIndex = 1;
            idProductoLabel.Text = "Id Producto:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(613, 62);
            nombreLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(61, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(60, 114);
            codigoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(54, 17);
            codigoLabel.TabIndex = 5;
            codigoLabel.Text = "Codigo:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(613, 241);
            precioLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(48, 17);
            precioLabel.TabIndex = 7;
            precioLabel.Text = "Precio:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(60, 181);
            stockLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(45, 17);
            stockLabel.TabIndex = 9;
            stockLabel.Text = "Stock:";
            // 
            // fechaAltaLabel
            // 
            fechaAltaLabel.AutoSize = true;
            fechaAltaLabel.Location = new System.Drawing.Point(60, 242);
            fechaAltaLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            fechaAltaLabel.Name = "fechaAltaLabel";
            fechaAltaLabel.Size = new System.Drawing.Size(74, 17);
            fechaAltaLabel.TabIndex = 11;
            fechaAltaLabel.Text = "Fecha Alta:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(613, 118);
            categoriaLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(69, 17);
            categoriaLabel.TabIndex = 13;
            categoriaLabel.Text = "Categoria:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(613, 179);
            marcaLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(48, 17);
            marcaLabel.TabIndex = 15;
            marcaLabel.Text = "Marca:";
            // 
            // productosAnimalesBindingNavigator
            // 
            this.productosAnimalesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productosAnimalesBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(178)))));
            this.productosAnimalesBindingNavigator.BindingSource = this.productosAnimalesBindingSource;
            this.productosAnimalesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productosAnimalesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productosAnimalesBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.productosAnimalesBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.productosAnimalesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.productosAnimalesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productosAnimalesBindingNavigatorSaveItem});
            this.productosAnimalesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productosAnimalesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productosAnimalesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productosAnimalesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productosAnimalesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productosAnimalesBindingNavigator.Name = "productosAnimalesBindingNavigator";
            this.productosAnimalesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productosAnimalesBindingNavigator.Size = new System.Drawing.Size(1066, 31);
            this.productosAnimalesBindingNavigator.TabIndex = 0;
            this.productosAnimalesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(41, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.ForeColor = System.Drawing.Color.Maroon;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(66, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // productosAnimalesBindingNavigatorSaveItem
            // 
            this.productosAnimalesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productosAnimalesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productosAnimalesBindingNavigatorSaveItem.Image")));
            this.productosAnimalesBindingNavigatorSaveItem.Name = "productosAnimalesBindingNavigatorSaveItem";
            this.productosAnimalesBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.productosAnimalesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.productosAnimalesBindingNavigatorSaveItem.Click += new System.EventHandler(this.productosAnimalesBindingNavigatorSaveItem_Click);
            // 
            // idProductoLabel1
            // 
            this.idProductoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosAnimalesBindingSource, "IdProducto", true));
            this.idProductoLabel1.Location = new System.Drawing.Point(153, 60);
            this.idProductoLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.idProductoLabel1.Name = "idProductoLabel1";
            this.idProductoLabel1.Size = new System.Drawing.Size(266, 30);
            this.idProductoLabel1.TabIndex = 2;
            this.idProductoLabel1.Text = "label1";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosAnimalesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(706, 58);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(266, 25);
            this.nombreTextBox.TabIndex = 4;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosAnimalesBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(153, 110);
            this.codigoTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(266, 25);
            this.codigoTextBox.TabIndex = 6;
            // 
            // precioTextBox
            // 
            this.precioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosAnimalesBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(706, 237);
            this.precioTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(266, 25);
            this.precioTextBox.TabIndex = 8;
            // 
            // stockTextBox
            // 
            this.stockTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosAnimalesBindingSource, "Stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(153, 177);
            this.stockTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(266, 25);
            this.stockTextBox.TabIndex = 10;
            // 
            // fechaAltaDateTimePicker
            // 
            this.fechaAltaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productosAnimalesBindingSource, "FechaAlta", true));
            this.fechaAltaDateTimePicker.Location = new System.Drawing.Point(153, 237);
            this.fechaAltaDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fechaAltaDateTimePicker.Name = "fechaAltaDateTimePicker";
            this.fechaAltaDateTimePicker.Size = new System.Drawing.Size(266, 25);
            this.fechaAltaDateTimePicker.TabIndex = 12;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosAnimalesBindingSource, "Categoria", true));
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            "Perros",
            "Gatos",
            "Peces",
            "Aves",
            "Roedores",
            "Reptiles"});
            this.categoriaComboBox.Location = new System.Drawing.Point(706, 114);
            this.categoriaComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(266, 25);
            this.categoriaComboBox.TabIndex = 14;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosAnimalesBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(706, 175);
            this.marcaTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(266, 25);
            this.marcaTextBox.TabIndex = 16;
            // 
            // productosAnimalesBindingSource
            // 
            this.productosAnimalesBindingSource.DataMember = "ProductosAnimales";
            this.productosAnimalesBindingSource.DataSource = this.productosAnimalesTableAdapter;
            // 
            // productosAnimalesTableAdapter
            // 
            this.productosAnimalesTableAdapter.DataSetName = "ProductosAnimalesTableAdapter";
            this.productosAnimalesTableAdapter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosAnimalesTableAdapter1
            // 
            this.productosAnimalesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductosAnimalesTableAdapter1 = this.productosAnimalesTableAdapter1;
            this.tableAdapterManager.UpdateOrder = DAM2_DI_TiendaAnimales_DeLuca_Tatiana.ProductosAnimalesTableAdapterTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.Location = new System.Drawing.Point(60, 308);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(89, 34);
            imagenLabel.TabIndex = 17;
            imagenLabel.Text = "Imagen\r\ndel Producto:";
            // 
            // imagenPictureBox
            // 
            this.imagenPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productosAnimalesBindingSource, "Imagen", true));
            this.imagenPictureBox.Location = new System.Drawing.Point(156, 308);
            this.imagenPictureBox.Name = "imagenPictureBox";
            this.imagenPictureBox.Size = new System.Drawing.Size(266, 205);
            this.imagenPictureBox.TabIndex = 18;
            this.imagenPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1066, 588);
            this.Controls.Add(imagenLabel);
            this.Controls.Add(this.imagenPictureBox);
            this.Controls.Add(idProductoLabel);
            this.Controls.Add(this.idProductoLabel1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(fechaAltaLabel);
            this.Controls.Add(this.fechaAltaDateTimePicker);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(this.productosAnimalesBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosAnimalesBindingNavigator)).EndInit();
            this.productosAnimalesBindingNavigator.ResumeLayout(false);
            this.productosAnimalesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosAnimalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosAnimalesTableAdapter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProductosAnimalesTableAdapter productosAnimalesTableAdapter;
        private System.Windows.Forms.BindingSource productosAnimalesBindingSource;
        private ProductosAnimalesTableAdapterTableAdapters.ProductosAnimalesTableAdapter1 productosAnimalesTableAdapter1;
        private ProductosAnimalesTableAdapterTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productosAnimalesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productosAnimalesBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idProductoLabel1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.DateTimePicker fechaAltaDateTimePicker;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.PictureBox imagenPictureBox;
    }
}

