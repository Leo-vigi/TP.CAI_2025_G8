using Datos;
using Datos.Ventas;
using Negocio;
using Persistencia;
using Persistencia.WebService.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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
                        ActualizarTotal(); // Llama a la función después de modificar el subtotal
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
                    subTotal -= precioTotal; // Resta el precio eliminado
                    lablSubTotal.Text = $"${subTotal:N2}"; // Actualiza el subtotal en la UI
                    ActualizarTotal(); // Llama a la función para recalcular el total
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

        private void ActualizarTotal()
        {
            decimal total = subTotal; // Inicialmente, el total es igual al subtotal

            if (subTotal > 1000000) // Si el subtotal supera $1.000.000, aplica 15% de descuento
            {
                total = subTotal * 0.85M; // Aplica descuento del 15%
            }

            lblTotal.Text = $"${total:N2}"; // Actualiza la UI con el monto correcto
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedItem == null || listBox1.Items.Count == 0)

            {
                MessageBox.Show("Seleccione un cliente y al menos un producto antes de procesar la venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente clienteSeleccionado = (Cliente)cmbClientes.SelectedItem;
            Guid idCliente = clienteSeleccionado.Id;
            //  Harcodeamos el GUID del usuario (ID fijo de la API)
            //Guid idUsuario =  Guid.Parse("0cdbc5a5-69d9-4ab8-8cb3-9932ce33f54a");

            List<dynamic> ventas = new List<dynamic>();


            foreach (string item in listBox1.Items)
            {
                string[] partes = item.Split('-');
                string nombreProducto = partes[0].Trim();
                int cantidad = int.Parse(partes[2].Replace("Cantidad: ", "").Trim());

                ProductoPersistencia productoPersistencia = new ProductoPersistencia();
                List<Producto> productos = productoPersistencia.obtenerProductosPorCategoria(((CategoriaProductos)cboCategoriaProductos.SelectedItem).Id);

                Producto producto = productos.FirstOrDefault(p => p.Nombre == nombreProducto);
                if (producto == null)
                {
                    MessageBox.Show($"Error: No se encontró el producto [{nombreProducto}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //  Harcodeamos el idUsuario aquí - ELEGIMOS QUE SEA UN VENDEDOR DE LOS USUARIOS ACTIVOS
                //PORQUE EL GUID 0cdbc5a5-69d9-4ab8-8cb3-9932ce33f54a NOS DABA ERROR DE PERMISOS
                //creo que ese user es admin y no puede hacer ventas
                //pero un vendedor del swagger si
                //y 828ac018-68be-47fd-be70-18ca1fa5aebe es vendedor
                //por lo cual hace la venta
                Guid idUsuario = new Guid("828ac018-68be-47fd-be70-18ca1fa5aebe");

                ventas.Add(new
                {
                    idCliente = idCliente.ToString(),
                    idUsuario = idUsuario.ToString(),  // Aquí se usa el GUID fijo
                    idProducto = producto.Id.ToString(),
                    cantidad = cantidad
                });
            }


            //  La API espera un solo objeto, así que enviamos una única venta en lugar de una lista

            if (ventas.Count == 0)

            {
                MessageBox.Show("Error: No hay productos para procesar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string jsonRequest = JsonConvert.SerializeObject(ventas[0]); // Se envía un solo objeto
            Console.WriteLine($"JSON enviado: {jsonRequest}");

            HttpResponseMessage response = WebHelper.Post("/api/Venta/AgregarVenta", jsonRequest);
            Console.WriteLine($"Código de respuesta: {response.StatusCode}");
            Console.WriteLine($"Mensaje del servidor: {response.Content.ReadAsStringAsync().Result}");



        }
    }
}
