using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosApp_Juan_Camilo_Ardila
{
    public partial class HistorialPedidos : Form
    {
        public HistorialPedidos()
        {
            InitializeComponent();
            this.Load += HistorialPedidos_Load;
            cmbFiltroHistorial.SelectedIndexChanged += cmbFiltroHistorial_SelectedIndexChanged;
        }
        private void cmbFiltroHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSeleccionado = cmbFiltroHistorial.SelectedItem.ToString();
            mostrarPedidosRealizados(tipoSeleccionado);
        }

        private void mostrarPedidosRealizados(string tipoEntrega)
        {
            var pedidosRealizados = RegistroPedidos.Instancia.Pedidos.Where(p => tipoEntrega == "Todos" || p.MetodoEntrega.TipoEntrega() == tipoEntrega)
                .Select(p => new
                {
                    Cliente = p.Cliente,
                    Producto = p.Producto,
                    PesoKg = p.Peso,
                    DistanciaKm = p.Distancia,
                    Urgente = p.Urgente ? "Sí" : "No",
                    TipoEntrega = p.MetodoEntrega.TipoEntrega(),
                    Costo = p.ObtenerCosto().ToString("0.00")

                }).ToList();

            dgvHistorialPedidos.DataSource = pedidosRealizados;
        }

        private void dgvHistorialPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HistorialPedidos_Load(object sender, EventArgs e)
        {
            var tipo = RegistroPedidos.Instancia.Pedidos
                .Select(p => p.MetodoEntrega.TipoEntrega())
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            tipo.Insert(0, "Todos");
            cmbFiltroHistorial.DataSource = tipo;

            mostrarPedidosRealizados("Todos");
        }

        
    }
}
