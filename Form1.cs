using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace DAM2_DI_TiendaAnimales_DeLuca_Tatiana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productosAnimalesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            GuardarEnBD();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.productosAnimalesTableAdapter1.Fill(this.productosAnimalesTableAdapter.ProductosAnimales);
            //las cargamos aqui tambien 
            CargarImagen();
            //que arranque en modo consulta 
            PonerModo(false);
            //COntrolamos las excepciones cuando se intentan guardar datos que no cumplen con lo pedido
            // Valores por defecto para nuevo producto
            productosAnimalesTableAdapter.ProductosAnimales.PrecioColumn.DefaultValue = 0m;
            productosAnimalesTableAdapter.ProductosAnimales.StockColumn.DefaultValue = 0;
            productosAnimalesTableAdapter.ProductosAnimales.FechaAltaColumn.DefaultValue = DateTime.Today;

            // Que stock y precio no dejen escribir letras
            stockTextBox.KeyPress += SoloNumeros;
            precioTextBox.KeyPress += SoloPrecio;

            // para buscar con la lupa o con enter, llamamos al mismo método Buscar
            tscCampo.SelectedIndex = 0;
            tsbBuscar.Click += (s, ev) => Buscar();
            tstBuscar.KeyDown += (s, ev) =>
            {
                if (ev.KeyCode == Keys.Enter) { Buscar(); ev.SuppressKeyPress = true; }
            };
            // Añadimos tooltips a los botones de la barra y a los controles del formulario
            PonerTooltips();

            // Asigna el menú contextual a todo el formulario en general
            this.ContextMenuStrip = menuContextual;

            // Validacion de algunos campos visualmente
            nombreTextBox.TextChanged += ValidarCampoVisualmente;
            precioTextBox.TextChanged += ValidarCampoVisualmente;
            stockTextBox.TextChanged += ValidarCampoVisualmente;

        }

        // Codigo para cargar las imágenes en el picturebox
        private void CargarImagen()
        {
            // Quitamos la foto anterior y liberamos para caundo se quiera editar
            if (pbImagen.Image != null) { pbImagen.Image.Dispose(); pbImagen.Image = null; }

            // Fila = producto actual
            // si no hay ninguna, salimos
            DataRowView fila = productosAnimalesBindingSource.Current as DataRowView;
            if (fila == null)
            {
                //Actualizar el título de la ventana con el producto actual
                this.Text = $"Pet Sunrise - [{fila["Codigo"]}] {fila["Nombre"]} (Total registros: {productosAnimalesBindingSource.Count})";
            }
            else
            {
                this.Text = "Pet Sunrise Tienda Animal - Sin registros";
            }


            //la ruta donde se encuentra la imágen
            string ruta = Path.Combine(Application.StartupPath, "Imagenes", fila["Imagen"].ToString());
            if (File.Exists(ruta))
            {
                using (Image original = Image.FromFile(ruta))
                    pbImagen.Image = new Bitmap(original);   // copia para que el archivo no queda bloqueado y se pueda sobreescribir
            }



        }

        private void productosAnimalesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            CargarImagen(); //como el current changed de la binding source no tiene parametros, llamamos al metodo que hemos creado para cargar la imagen
        }

        //Activar modos de visualización
        private void PonerModo(bool accion)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox) ((TextBox)c).ReadOnly = !accion;
                else if (c is ComboBox || c is DateTimePicker) c.Enabled = accion;
            }

            productosAnimalesBindingNavigator.Enabled = !accion;
            btnAceptar.Enabled = accion;
            btnCancelar.Enabled = accion;
            tslEstado.Text = accion ? "Modo acción: termina con Aceptar o Cancelar" : "Listo para añadir nuevo producto.";
            pbImagen.Cursor = accion ? Cursors.Hand : Cursors.Default; //para que el cursor sea una mano para clickar en escoger la foto
        }

        //controlamos las excepciones y que los datos ingreasdos sean correctos
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void SoloPrecio(object sender, KeyPressEventArgs e)
        {
            char coma = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != coma)
                e.Handled = true;
        }

        private bool MostrarError(string mensaje, Control campo)
        {
            MessageBox.Show(mensaje, "Datos incorrectos, intente de nuevo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            campo.Focus();
            return false;
        }

        private bool DatosValidos()
        {
            if (nombreTextBox.Text.Trim() == "")
                return MostrarError("Campo obligatorio.", nombreTextBox);

            if (codigoTextBox.Text.Trim() == "")
                return MostrarError("Campo obligatorio.", codigoTextBox);

            decimal precio;
            if (!decimal.TryParse(precioTextBox.Text, out precio) || precio < 0)
                return MostrarError("Valor inválido.", precioTextBox);

            int stock;
            if (!int.TryParse(stockTextBox.Text, out stock) || stock < 0)
                return MostrarError("Valor inválido.", stockTextBox);

            if (fechaAltaDateTimePicker.Value.Date > DateTime.Today)
                return MostrarError("Fecha incorrecta, debe ser actual o anterior.", fechaAltaDateTimePicker);

            if (categoriaComboBox.Text.Trim() == "")
                return MostrarError("Debe asignar categoría.", categoriaComboBox);

            if (marcaTextBox.Text.Trim() == "")
                return MostrarError("Debe asignar marca.", marcaTextBox);

            return true;
        }

        //Botones que se activen siempre que este fuera de modo consulta
        //editar
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            PonerModo(true);
            nombreTextBox.Focus();
            //si una busqueda no encuentra nada, le decimos al binding source que no hay nada que editar
            if (productosAnimalesBindingSource.Count == 0) return;
        }
        //añadir
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            PonerModo(true);
            nombreTextBox.Focus();
        }
        //aceptar cambios
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //validamos los datos antes de guardar
            if (!DatosValidos()) return;
            Validate();
            productosAnimalesBindingSource.EndEdit();
            PonerModo(false);
            //avisar que el producto está aeptado pero aun no guardado con feedback visual 
            status1.BackColor = Color.FromArgb(220, 248, 198); // Verde suavecito
            tslEstado.Text = "Producto aceptado correctamente.";

            MessageBox.Show("Pulse en el botón de guardar los cambios.",
            "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        //cancelar cambios, pero antes preguntar si se quiere descartar los cambios
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea descartar los cambios?", "Cancelar",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                productosAnimalesBindingSource.CancelEdit();
                PonerModo(false);
            }
        }
        //eliminar un item de la lista, pero antes preguntar si se quiere eliminar
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (productosAnimalesBindingSource.Current == null) return;

            if (MessageBox.Show("¿Seguro que quieres borrar este producto?", "Borrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                productosAnimalesBindingSource.RemoveCurrent();
            }
        }

        //guardar cambios en la base de datos
        private bool GuardarEnBD()
        {
            try
            {
                Validate();
                productosAnimalesBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(productosAnimalesTableAdapter);
                MessageBox.Show("Los cambios se han guardado en la base de datos.", "Guardado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            /*
             * 2627: violación de una restricción UNIQUE o PRIMARY KEY
             * 2601: que no se inserte un valor duplicado en una columna con restricción UNIQUE
             */
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Ya existe un producto con ese código.", "Código repetido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("No se pudo guardar: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //cerrar la aplicación sin perder datos nuevos o cambiados, siempre confirmando antes de realizar la operación
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (btnAceptar.Enabled)   // estás en modo acción
            {
                if (MessageBox.Show("¿Desea salir y perder los cambios?", "Salir",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    e.Cancel = true;
                return;
            }

            if (productosAnimalesTableAdapter.HasChanges())
            {
                DialogResult r = MessageBox.Show("Hay cambios sin guardar. ¿Desea guardarlos antes de salir?",
                    "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (r == DialogResult.Cancel) e.Cancel = true;
                else if (r == DialogResult.Yes && !GuardarEnBD()) e.Cancel = true;
            }

        }

        //añadimos metodos para utilizar en el toolsrtip buscar
        private readonly string[] columnas = { "Nombre", "Codigo", "Marca", "Categoria" };

        private void Buscar()
        {
            string texto = tstBuscar.Text.Trim().Replace("'", "''");

            if (texto == "")
            {
                productosAnimalesBindingSource.RemoveFilter();
                tslEstado.Text = "Listo";
                return;
            }
            //aqui filtramos por la columna seleccionada en el combobox del toolstrip, si existe alguna referencia en la bd con lo introducido
            string columna = columnas[tscCampo.SelectedIndex];
            productosAnimalesBindingSource.Filter = columna + " LIKE '%" + texto + "%'";
            if (productosAnimalesBindingSource.Count == 0)
            {
                MessageBox.Show("No se ha encontrado ningún producto con \"" + tstBuscar.Text.Trim() + "\".",
                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                productosAnimalesBindingSource.RemoveFilter();   // vuelve a mostrar todos, no te quedas con la ficha vacía
            }
            else
            {
                tslEstado.Text = productosAnimalesBindingSource.Count + " resultado(s)";
            }
        }

        // Añadir los tooltips a los botones del BindingNavigator
        private void PonerTooltips()
        {
            // Botones de la barra
            bindingNavigatorMoveFirstItem.ToolTipText = "Primer producto";
            bindingNavigatorMovePreviousItem.ToolTipText = "Producto previo";
            bindingNavigatorMoveNextItem.ToolTipText = "Siguiente producto";
            bindingNavigatorMoveLastItem.ToolTipText = "Último producto";
            bindingNavigatorAddNewItem.ToolTipText = "Añadir un producto nuevo";
            bindingNavigatorDeleteItem.ToolTipText = "Borrar el producto en curso";
            tsbEditar.ToolTipText = "Editar el producto en curso";
            productosAnimalesBindingNavigatorSaveItem.ToolTipText = "Guardar los cambios";
            tsbBuscar.ToolTipText = "Buscar";

            // El combo y la caja de la barra llevan el tooltip en su control interno
            toolTip1.SetToolTip(tscCampo.Control, "Introduzca el campo por el que buscar");
            toolTip1.SetToolTip(tstBuscar.Control, "Producto a buscar, según filtro");

            // Ayudas para saber que poner en el formulario
            toolTip1.SetToolTip(nombreTextBox, "Nombre del producto");
            toolTip1.SetToolTip(codigoTextBox, "Código del producto, ej; PER-001");
            toolTip1.SetToolTip(precioTextBox, "Precio en €");
            toolTip1.SetToolTip(stockTextBox, "Unidades disponibles");
            toolTip1.SetToolTip(fechaAltaDateTimePicker, "Fecha de alta del producto");
            toolTip1.SetToolTip(categoriaComboBox, "Categoría del producto");
            toolTip1.SetToolTip(marcaTextBox, "Marca del producto");
            toolTip1.SetToolTip(pbImagen, "Imagen del producto, haga clic para cambiarla");
            toolTip1.SetToolTip(btnAceptar, "Confirmar los cambios");
            toolTip1.SetToolTip(btnCancelar, "Descartar los cambios");

            // el texto de ayuda también sale en la barra de estado
            foreach (ToolStripItem item in productosAnimalesBindingNavigator.Items)
            {
                item.MouseEnter += (s, ev) =>
                {
                    string t = ((ToolStripItem)s).ToolTipText;
                    if (t != "") tslEstado.Text = t;
                };
                item.MouseLeave += (s, ev) => tslEstado.Text =
                    btnAceptar.Enabled ? "Modo acción: termina con Aceptar o Cancelar" : "Listo";
            }

            /*
             * A través de ver orden de tabulación, podemos recorrer los controles del formulario con la tecla Tab.
             */
        }

        // Cargar la imagen del producto desde un archivo, con el nombre del código del producto
        private void pbImagen_Click(object sender, EventArgs e)
        {
            if (!btnAceptar.Enabled) return;   // solo que se pueda en modo acción

            // Fila = producto actual
            // si no hay ninguna, salimos
            DataRowView fila = productosAnimalesBindingSource.Current as DataRowView;
            if (fila == null) return;

            // La foto se guarda con el código del producto como nombre,
            // avisamos si no tiene codigo y ponemos el cursor ahí para que pueda indicarlo
            if (codigoTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Escriba el código del producto, la foto se guarda con ese nombre.",
                    "Introduzca el código", MessageBoxButtons.OK, MessageBoxIcon.Information);
                codigoTextBox.Focus();
                return;
            }

            // aqui se abre la ventana de Windows para elegir un archivo
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Elija la foto del producto";
                dlg.Filter = "Imágenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (dlg.ShowDialog() != DialogResult.OK) return;

                //comprobamos que no falle nada con el archivo, por ejemplo nombre, permisos o que no exista la carpeta donde guardarlo
                try
                {
                    string carpeta = Path.Combine(Application.StartupPath, "Imagenes");
                    Directory.CreateDirectory(carpeta);

                    string nombre = codigoTextBox.Text.Trim() + Path.GetExtension(dlg.FileName).ToLower();
                    File.Copy(dlg.FileName, Path.Combine(carpeta, nombre), true);

                    // Guardamos el nombre de la foto en la fila actual del BindingSource, para que se guarde en la BD
                    fila["Imagen"] = nombre;

                    // Volvemos a dibujar la foto en el PictureBox.
                    CargarImagen();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo copiar la foto: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmImprimir_Click(object sender, EventArgs e)
        {
            // Si no hay ningún producto en pantalla, o una búsqueda vacía, no hay nada que imprimir
            if (productosAnimalesBindingSource.Current == null)
            {
                MessageBox.Show("Sin resultado a imprimir.", "Imprimir",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // PrintDocument es el documento que se manda a la impresora
            PrintDocument doc = new PrintDocument();

            // Cuando haga falta "dibujar" una página, se llama a ImprimirPagina
            doc.PrintPage += ImprimirPagina;

            // Vista previa de cómo quedará la hoja a imprimir
            // "using" cierra la ventana
            using (PrintPreviewDialog vista = new PrintPreviewDialog())
            {
                vista.Document = doc;
                vista.ShowDialog();
            }
        }

        // Dibuja la hoja con lo que hay al momento de querer imprimir la pantalla
        private void ImprimirPagina(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;

            using (Font tituloFont = new Font("Segoe UI", 18, FontStyle.Bold),
                        etiquetaFont = new Font("Segoe UI", 11, FontStyle.Bold),
                        valorFont = new Font("Segoe UI", 11, FontStyle.Regular))
            {
                // Titulo 
                g.DrawString("Pet Sunrise: Ficha de Producto", tituloFont, Brushes.Maroon, x, y);
                y += 50;

                // AARray simplificado con lo que se quiere mostrar en la ficha
                string[] campos = {
            "Nombre: " + nombreTextBox.Text,
            "Código: " + codigoTextBox.Text,
            "Categoría: " + categoriaComboBox.Text,
            "Marca: " + marcaTextBox.Text,
            "Precio: " + precioTextBox.Text + " €",
            "Stock: " + stockTextBox.Text,
            "Fecha de alta: " + fechaAltaDateTimePicker.Value.ToShortDateString()
        };

                // Mostrar los campos en una lista 
                foreach (string campo in campos)
                {
                    g.DrawString(campo, valorFont, Brushes.Black, x, y);
                    y += 30; // Espacio entre lineas
                }

                // Si hay imagen, se añade abajo
                if (pbImagen.Image != null)
                {
                    // esti simplemente es para que la imagen no este encima del texto y queda abajo del todo
                    y += 20;
                    Image img = pbImagen.Image;
                    float escala = Math.Min(200f / img.Width, 200f / img.Height);
                    g.DrawImage(img, x, y, img.Width * escala, img.Height * escala);
                }
            }

            e.HasMorePages = false;
        }

        //Para que los campos obligatorios cambien de color de fondo si estan vacios o incorrectos
        private void ValidarCampoVisualmente(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            // Si estás en modo edición y el campo está vacío, que se cambie el fondo
            if (btnAceptar.Enabled && string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.MistyRose;
            }
            else
            {
                txt.BackColor = Color.White;
            }
        }
    }
}