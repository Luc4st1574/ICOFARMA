using CapaEntidad;
using CapaNegocio;
using IcoFarma.Utilidades;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using System.Windows.Forms.DataVisualization.Charting;

namespace IcoFarma
{
    public partial class frmReporteVentas : Form
    {
        public frmReporteVentas()
        {
            InitializeComponent();

            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;


            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            chart2.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;


            chart2.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
        }


        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {

                if (columna.Visible == true && columna.Name != "FechaRegistro" && columna.Name != "TipoDocumento"
                    && columna.Name != "NumeroDocumento" && columna.Name != "UsuarioRegistro" && columna.Name != "DocumentoProveedor"
                    && columna.Name != "RazonSocial" && columna.Name != "CodigoProducto" && columna.Name != "NombreProducto"
                    && columna.Name != "Categoria")
                {
                    cboc1.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cboc1.DisplayMember = "Texto";
            cboc1.ValueMember = "Valor";
            cboc1.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {

                if (columna.Visible == true && columna.Name != "FechaRegistro" && columna.Name != "TipoDocumento"
                    && columna.Name != "NumeroDocumento" && columna.Name != "UsuarioRegistro" && columna.Name != "DocumentoProveedor"
                    && columna.Name != "RazonSocial" && columna.Name != "CodigoProducto" && columna.Name != "NombreProducto"
                    && columna.Name != "Categoria")
                {
                    cboc2.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cboc2.DisplayMember = "Texto";
            cboc2.ValueMember = "Valor";
            cboc2.SelectedIndex = 0;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            lista = new CN_Reporte().Venta(txtfechainicio.Text.ToString(), txtfechafin.Text.ToString());

            dgvdata.Rows.Clear();

            foreach (ReporteVenta rv in lista)
            {
                dgvdata.Rows.Add(new object[] {
                    rv.FechaRegistro,
                    rv.TipoDocumento,
                    rv.NumeroDocumento,
                    rv.MontoTotal,
                    rv.UsuarioRegistro,
                    rv.DocumentoCliente,
                    rv.NombreCliente,
                    rv.CodigoProducto,
                    rv.NombreProducto,
                    rv.Categoria,
                    rv.PrecioVenta,
                    rv.Cantidad,
                    rv.SubTotal
                });
            }
            chart3.Series.Clear();
            LlenarGraficoPie();
            chart3.Titles.Clear();

            chart4.Series.Clear();
            LlenarGraficoPie2();
            chart4.Titles.Clear();
        }

        private void btnExcel_Click_1(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {

                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dgvdata.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[] {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString()
                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimparBusqueda_Click_1(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
        private void LlenarGrafico()
        {
            // Obtener el campo seleccionado en cbobusqueda
            string columnaFiltro = ((OpcionCombo)cboc1.SelectedItem).Valor.ToString();

            // Crear una serie de datos para el gráfico
            Series series = chart1.Series.Add(columnaFiltro);
            series.ChartType = SeriesChartType.StackedColumn;
            series.Palette = ChartColorPalette.BrightPastel;

            // Crear un diccionario para realizar un seguimiento de las fechas y sus valores
            Dictionary<string, double> fechaValores = new Dictionary<string, double>();

            // Llenar el diccionario
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                string fechaRegistro = row.Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(fechaRegistro))
                {
                    if (fechaValores.ContainsKey(fechaRegistro))
                    {
                        double valor;
                        if (double.TryParse(row.Cells[columnaFiltro].Value.ToString(), out valor))
                        {
                            fechaValores[fechaRegistro] += valor;
                        }
                    }
                    else
                    {
                        double valor;
                        if (double.TryParse(row.Cells[columnaFiltro].Value.ToString(), out valor))
                        {
                            fechaValores[fechaRegistro] = valor;
                        }
                    }
                }
            }

            // Agregar las fechas y sus valores al gráfico
            foreach (var fechaValor in fechaValores)
            {
                series.Points.AddXY(fechaValor.Key, fechaValor.Value);
            }
        }

        private void LlenarGrafico2()
        {
            // Obtener el campo seleccionado en cbobusqueda
            string columnaFiltro = ((OpcionCombo)cboc2.SelectedItem).Valor.ToString();

            // Crear una serie de datos para el gráfico
            Series series = chart2.Series.Add(columnaFiltro);
            series.ChartType = SeriesChartType.StackedColumn;
            series.Palette = ChartColorPalette.BrightPastel;

            // Crear un diccionario para realizar un seguimiento de las fechas y sus valores
            Dictionary<string, double> fechaValores = new Dictionary<string, double>();

            // Llenar el diccionario
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                string fechaRegistro = row.Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(fechaRegistro))
                {
                    if (fechaValores.ContainsKey(fechaRegistro))
                    {
                        double valor;
                        if (double.TryParse(row.Cells[columnaFiltro].Value.ToString(), out valor))
                        {
                            fechaValores[fechaRegistro] += valor;
                        }
                    }
                    else
                    {
                        double valor;
                        if (double.TryParse(row.Cells[columnaFiltro].Value.ToString(), out valor))
                        {
                            fechaValores[fechaRegistro] = valor;
                        }
                    }
                }
            }

            // Agregar las fechas y sus valores al gráfico
            foreach (var fechaValor in fechaValores)
            {
                series.Points.AddXY(fechaValor.Key, fechaValor.Value);
            }
        }

        public class ProductoPorcentaje
        {
            public string Nombre { get; set; }
            public double Porcentaje { get; set; }
        }

        private void LlenarGraficoPie()
        {
            List<ProductoPorcentaje> productosPorcentajeList = new List<ProductoPorcentaje>();

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                string producto = row.Cells["NombreProducto"].Value.ToString();
                if (!string.IsNullOrEmpty(producto))
                {
                    bool encontrado = false;
                    foreach (var productoPorcentaje in productosPorcentajeList)
                    {
                        if (productoPorcentaje.Nombre == producto)
                        {
                            productoPorcentaje.Porcentaje++;
                            encontrado = true;
                            break;
                        }
                    }
                    if (!encontrado)
                    {
                        productosPorcentajeList.Add(new ProductoPorcentaje
                        {
                            Nombre = producto,
                            Porcentaje = 1
                        });
                    }
                }
            }

            int totalElementos = dgvdata.Rows.Count;

            Series seriesPie = chart3.Series.Add("Productos");
            seriesPie.ChartType = SeriesChartType.Pie;
            seriesPie.Palette = ChartColorPalette.BrightPastel;
            seriesPie.IsValueShownAsLabel = true;

            foreach (var productoPorcentaje in productosPorcentajeList)
            {
                double porcentaje = (productoPorcentaje.Porcentaje / totalElementos);

                // Agregar un punto al gráfico con el porcentaje
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueY(porcentaje * 100); // Establecer el porcentaje como valor Y
                dataPoint.AxisLabel = productoPorcentaje.Nombre; // Establecer el nombre del producto como etiqueta
                dataPoint.LegendText = $"{productoPorcentaje.Nombre} ({porcentaje:P1})"; // Etiqueta en la leyenda con un decimal
                // Formatear el porcentaje para que aparezca con dos decimales en el gráfico
                dataPoint.Label = $"{porcentaje:P1}";

                seriesPie.Points.Add(dataPoint);
            }

            chart3.Titles.Add("Distribución de Productos por Porcentaje");
            chart3.Titles[0].ForeColor = Color.White;

        }

        private void LlenarGraficoPie2()
        {
            List<ProductoPorcentaje> productosPorcentajeList = new List<ProductoPorcentaje>();

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                string producto = row.Cells["UsuarioRegistro"].Value.ToString();
                if (!string.IsNullOrEmpty(producto))
                {
                    bool encontrado = false;
                    foreach (var productoPorcentaje in productosPorcentajeList)
                    {
                        if (productoPorcentaje.Nombre == producto)
                        {
                            productoPorcentaje.Porcentaje++;
                            encontrado = true;
                            break;
                        }
                    }
                    if (!encontrado)
                    {
                        productosPorcentajeList.Add(new ProductoPorcentaje
                        {
                            Nombre = producto,
                            Porcentaje = 1
                        });
                    }
                }
            }

            int totalElementos = dgvdata.Rows.Count;

            Series seriesPie = chart4.Series.Add("Usuarios");
            seriesPie.ChartType = SeriesChartType.Pie;
            seriesPie.Palette = ChartColorPalette.BrightPastel;
            seriesPie.IsValueShownAsLabel = true;

            foreach (var productoPorcentaje in productosPorcentajeList)
            {
                double porcentaje = (productoPorcentaje.Porcentaje / totalElementos);

                // Agregar un punto al gráfico con el porcentaje
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueY(porcentaje * 100); // Establecer el porcentaje como valor Y
                dataPoint.AxisLabel = productoPorcentaje.Nombre; // Establecer el nombre del producto como etiqueta
                dataPoint.LegendText = $"{productoPorcentaje.Nombre} ({porcentaje:P1})"; // Etiqueta en la leyenda con un decimal
                // Formatear el porcentaje para que aparezca con dos decimales en el gráfico
                dataPoint.Label = $"{porcentaje:P1}";

                seriesPie.Points.Add(dataPoint);
            }

            chart4.Titles.Add("Porcentaje de Ventas por Usuario");
            chart4.Titles[0].ForeColor = Color.White;

        }

        private void cboc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            LlenarGrafico();
        }

        private void cboc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            LlenarGrafico2();
        }
    }
}
