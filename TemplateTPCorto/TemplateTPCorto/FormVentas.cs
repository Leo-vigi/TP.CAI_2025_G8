using Datos;
using Datos.Ventas;
using Negocio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPCorto
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

            CargarClientes();
            CargarCategoriasProductos();
            IniciarTotales();
        }

        private void IniciarTotales()
        {
            lablSubTotal.Text = "0.00";
            lblTotal.Text = "0.00";
        }

        private void CargarCategoriasProductos()
        {

            VentasNegocio ventasNegocio = new VentasNegocio();

            List<CategoriaProductos> categoriaProductos = ventasNegocio.obtenerCategoriaProductos();

            foreach (CategoriaProductos categoriaProducto in categoriaProductos)
            {
                cboCategoriaProductos.Items.Add(categoriaProducto);
            }
        }

        private void CargarClientes()
        {
            VentasNegocio ventasNegocio = new VentasNegocio();

            List<Cliente> listadoClientes = ventasNegocio.obtenerClientes();

            foreach (Cliente cliente in listadoClientes)
            {
                cmbClientes.Items.Add(cliente);
            }
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            VentasNegocio ventasNegocio = new VentasNegocio();
          

        }




        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducto.SelectedItem != null)
            {
                txtCantidad.Text = "1";  // Por defecto, una unidad del producto seleccionado
            }

        }

        private void cboCategoriaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategoriaProductos.SelectedItem != null)
            {
                int idCategoria = ((CategoriaProductos)cboCategoriaProductos.SelectedItem).Id;
                ListarProductosPorCategoria(idCategoria);
            }

        }

        private void ListarProductosPorCategoria(int idCategoria)
        {
            lstProducto.Items.Clear(); // Limpiar lista antes de cargar nuevos elementos.

            ProductoPersistencia productoPersistencia = new ProductoPersistencia(); // Instancia la clase
            List<Producto> productos = productoPersistencia.obtenerProductosPorCategoria(idCategoria); // Llamada correcta

            foreach (Producto prod in productos)
            {
                lstProducto.Items.Add($"{prod.Nombre} - ${prod.Precio:N2}"); // Agrega nombre y precio con formato
            }
        }

        private void btnListarProductos_Click_1(object sender, EventArgs e)
        {
            if (cboCategoriaProductos.SelectedItem != null)
            {
                int idCategoria = ((CategoriaProductos)cboCategoriaProductos.SelectedItem).Id;
                ListarProductosPorCategoria(idCategoria);
            }
            else
            {
                MessageBox.Show("Seleccione una categoría de productos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private decimal subTotal = 0; // Variable para acumular el subtotal

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lstProducto.SelectedItem != null && !string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                if (int.TryParse(txtCantidad.Text, out int cantidad) && cantidad > 0)
                {
                    // Obtener nombre y precio desde lstProducto
                    string productoSeleccionado = lstProducto.SelectedItem.ToString();
                    string[] partes = productoSeleccionado.Split('-'); // Separar nombre y precio
                    string precioStr = partes.Length > 1 ? partes[1].Trim().Replace("$", "") : "0";

                    if (decimal.TryParse(precioStr, out decimal precioUnitario))
                    {
                        decimal precioTotal = precioUnitario * cantidad; // Calcular precio total del producto
                        subTotal += precioTotal; // Sumar al subtotal

                        listBox1.Items.Add($"{productoSeleccionado} - Cantidad: {cantidad} - Total: ${precioTotal:N2}");

                        // Actualizar el subtotal en la UI
                        lablSubTotal.Text = $"${subTotal:N2}";
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener el precio del producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto y especifique la cantidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string productoEnLista = listBox1.SelectedItem.ToString();
                string[] partes = productoEnLista.Split('-'); // Separar nombre, cantidad y total
                string precioStr = partes.Length > 3 ? partes[3].Trim().Replace("Total: $", "").Trim() : "0";

                if (decimal.TryParse(precioStr, out decimal precioTotal))
                {
                    subTotal -= precioTotal; // Restar el precio eliminado
                    lablSubTotal.Text = $"${subTotal:N2}"; // Actualizar el subtotal en la UI
                }
                else
                {
                    MessageBox.Show("Error al obtener el precio del producto eliminado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                listBox1.Items.Remove(listBox1.SelectedItem); // Eliminar el producto de la lista
            }
            else
            {
                MessageBox.Show("Seleccione un producto antes de quitarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lablSubTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
