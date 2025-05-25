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
                lstProducto.Items.Add(prod.Nombre); // Muestra solo el nombre del producto.
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
    }
}
