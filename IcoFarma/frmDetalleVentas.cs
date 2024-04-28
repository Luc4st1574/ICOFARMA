using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Web;
using System.Net;
using Newtonsoft.Json;
using RestSharp;
using System.IO;


namespace IcoFarma
{
    public partial class frmDetalleVentas : Form
    {
        
        public frmDetalleVentas()
        {
            InitializeComponent();
        }

        private void frmDetalleVentas_Load(object sender, EventArgs e)
        {
            txtbusqueda.Select();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txtbusqueda.Text);

            if (oVenta.IdVenta != 0)
            {

                txtnumerodocumento.Text = oVenta.NumeroDocumento;

                txtfecha.Text = oVenta.FechaRegistro;
                txttipodocumento.Text = oVenta.TipoDocumento;
                txtusuario.Text = oVenta.oUsuario.NombreCompleto;


                txtdoccliente.Text = oVenta.DocumentoCliente;
                txtnombrecliente.Text = oVenta.NombreCliente;

                dgvdata.Rows.Clear();
                foreach (Detalle_Venta dv in oVenta.oDetalle_Venta)
                {
                    dgvdata.Rows.Add(new object[] { dv.oProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal });
                }

                txtmontototal.Text = oVenta.MontoTotal.ToString("0.00");
                txtmontopago.Text = oVenta.MontoPago.ToString("0.00");
                txtmontocambio.Text = oVenta.MontoCambio.ToString("0.00");


            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdoccliente.Text = "";
            txtnombrecliente.Text = "";

            dgvdata.Rows.Clear();
            txtmontototal.Text = "0.00";
            txtmontopago.Text = "0.00";
            txtmontocambio.Text = "0.00";
        }

        DateTime dateTime = DateTime.Now;

        private void btnboleta_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://facturacion.apisperu.com/api/v1/invoice/pdf");
            var request = new RestRequest();
            
            List<Producto> productos = new CN_Producto().Listar();
            
            
            request.Method = Method.POST;
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJpYXQiOjE2OTgxNjcxNTYsImV4cCI6NDg1MTc2NzE1NiwidXNlcm5hbWUiOiJMdWNhc3QiLCJjb21wYW55IjoiMTA3MTEyMTk0MDAifQ.BPcRETd0uWxIQbCY5xjl_MlOIJD73ClHKRqyyb-v6SqgpqNecLAPAKO9dyelD0mM431oNYkBrRFtIvdi6NXU9I_11M-YMruixJTtx5W7h63YcxEATEZ3ZTWmBwc5nd0J_S8nwJ-nUB4dCkf9I32G1t0cysBxlGGbLroSNBq4E1ZkjPBKaWyU5l4SvVTsODoijZjAyPUOaz43UFV-BRwyiLKFOhir8J-seX_zB7ThsM6nbc-edc5Ds6rqBBtu-ITENFTwbEeSjJgJIU8-egnSFPi7YaCKE4ynMg_MH4uGlYKyhuWrRjurxbQUTo50oa0A6dqA6EmlYWOK-oqgTl7dc64Vy0qaRht8hi-ERuC9y54fhNgCR-Djf8Co48eYtihUp1Ad4VIz-_NXM3zd34RMgEfG-z6RvP1PEkTczmodJ9Nd7eESY-sUr8u8_RhkUJAtVtxKgZeligPb4-3Bw1kdnGBmmFnn-BZqWQy_G6B5UGPFYWsJwfIGMlVFPsbrLxfUMVWCOCvvZtAhzvhNAWroEkze9JfPMGuCCrf7yp4r5S_mi4VzWXF1NMz2n9Sj26_TOgbk0FuBPW1frP37jVmybSMZNAfTS50uJvzkuZJrqTt6Z9PXT01bpFrhNigvGvhwgdFN4obYe4VuPZIrnJmWIyjjn6kGASwS-nQactDutLM");

            var detailsList = new List<object>();

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                var producto = row.Cells["Producto"].Value?.ToString();
                var precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                var cantidad = Convert.ToUInt64(row.Cells["Cantidad"].Value);
                var subtotal = Convert.ToDecimal(row.Cells["SubTotal"].Value);
                var codProducto = (detailsList.Count + 1).ToString();

                var mtoValorVenta = precio * cantidad;
                var mtoBaseIgv = mtoValorVenta;
                var mtoIGV = mtoBaseIgv * Convert.ToDecimal(0.1);

                var detail = new
                {
                    codProducto = codProducto,
                    unidad = "NIU",
                    descripcion = producto,
                    cantidad = cantidad,
                    mtoValorUnitario = 0,
                    mtoValorVenta = mtoValorVenta,
                    mtoBaseIgv = mtoBaseIgv,
                    porcentajeIgv = 0,
                    igv = 0,
                    tipAfeIgv = 0,
                    totalImpuestos = mtoIGV,
                    mtoPrecioUnitario = precio
                };

                detailsList.Add(detail);
            }

            // Corregir la obtención de mtoValorVenta y totalImpuestos
            var mtoOperGravadas = detailsList.Sum(detail => (decimal)detail.GetType().GetProperty("mtoValorVenta").GetValue(detail));
            var totalImpuestos = detailsList.Sum(detail => (decimal)detail.GetType().GetProperty("totalImpuestos").GetValue(detail));

            var jsonData = new
            {
                ublVersion = "2.1",
                fecVencimiento = dateTime.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                tipoOperacion = "0101",
                tipoDoc = "01",
                serie = "F002",
                correlativo = txtbusqueda.Text,
                fechaEmision = dateTime.ToString("yyyy-MM-ddTHH:mm:sszzz"),

                formaPago = new
                {
                    moneda = "PEN",
                    tipo = "Contado"
                },
                tipoMoneda = "PEN",

                client = new
                {
                    tipoDoc = "6",
                    numDoc = Convert.ToUInt64(txtdoccliente.Text),
                    rznSocial = txtnombrecliente.Text,
                    address = new
                    {
                        direccion = "Direccion Predeterminada",
                        provincia = "",
                        departamento = "",
                        distrito = "",
                        ubigueo = ""
                    }
                },

                company = new
                {
                    ruc = 10711219400,
                    razonSocial = "Botica ICOFARMA",
                    nombreComercial = "ICOFARMA",
                    address = new
                    {
                        direccion = "704 Av. Bolivia Víctor Larco Herrera",
                        provincia = "Trujillo",
                        departamento = "La Libertad",
                        distrito = "Victor Larco Herrera",
                        ubigueo = "130201"
                    }
                },
                mtoOperGravadas = mtoOperGravadas,
                mtoOperExoneradas = 0, // Puedes ajustar esto según tus necesidades

                mtoIGV = totalImpuestos,
                totalImpuestos = totalImpuestos, // Puedes ajustar esto según tus necesidades
                valorVenta = mtoOperGravadas + totalImpuestos, // Puedes ajustar esto según tus necesidades
                subTotal = mtoOperGravadas,
                mtoImpVenta = mtoOperGravadas + totalImpuestos,
                details = detailsList.ToArray(),
                legends = new[]
                {
                    new
                    {
                        code = "1000",
                        value = $"SON {totalImpuestos.ToString()} {mtoOperGravadas.ToString()}/100 SOLES"
                    }
                }
            };

            string jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(jsonData);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

            RestResponse response = (RestResponse)client.Execute(request);

            string nombreArchivo = txtbusqueda.Text + ".pdf";

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Archivos PDF|*.pdf";
            saveFileDialog1.FileName = nombreArchivo;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaDescarga = saveFileDialog1.FileName;
                System.IO.File.WriteAllBytes(rutaDescarga, response.RawBytes);
                label11.Text = "Archivo PDF descargado con éxito como: " + rutaDescarga;
            }
        }

       

        private void dgvdata_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow fila = dgvdata.Rows[indice];
                txt_precioxu.Text = fila.Cells["Precio"].Value.ToString();
                txt_cantidad.Text = fila.Cells["Cantidad"].Value.ToString();
                txt_producto.Text = fila.Cells["Producto"].Value.ToString();
                txt_subtotal.Text = fila.Cells["SubTotal"].Value.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtmontopago_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtmontocambio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombrecliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            if (txttipodocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txttipodocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtnumerodocumento.Text);


            Texto_Html = Texto_Html.Replace("@doccliente", txtdoccliente.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtnombrecliente.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtusuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtmontototal.Text);
            Texto_Html = Texto_Html.Replace("@pagocon", txtmontopago.Text);
            Texto_Html = Texto_Html.Replace("@cambio", txtmontocambio.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", txtnumerodocumento.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {

                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

