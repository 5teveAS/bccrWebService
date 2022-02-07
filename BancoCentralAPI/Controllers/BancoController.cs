using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Xml;

namespace BancoCentralAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BancoController : ControllerBase
    {


        [HttpGet]
        [Route("ConsultarDatosCompraJSON")]
        public async Task<ActionResult<string>> ConsultarDatosCompra()
        {
            string parametros = String.Format("Indicador={0}&FechaInicio={1}&FechaFinal={2}&Nombre={3}&SubNiveles=N&CorreoElectronico={4}&Token={5}",
              317,
              "01/08/2021",
              "01/09/2021",
              "steve",
              "stevarcsa@gmail.com",
              "AASS020020"
              );
            var URL = $"https://gee.bccr.fi.cr/Indicadores/Suscripciones/WS/wsindicadoreseconomicos.asmx/ObtenerIndicadoresEconomicosXML?{parametros}";
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(URL);
                string mensaje = await response.Content.ReadAsStringAsync();
                string mensajeRemplazo = mensaje.Replace("&lt;", "<");
                string mensajeRemplazo2 = mensajeRemplazo.Replace("&gt;", ">");
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(mensajeRemplazo2);
                string compraJson = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);
                return Ok(compraJson);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet]
        [Route("ConsultarDatosVentaJSON")]
        public async Task<ActionResult<string>> ConsultarDatosVentaJSON()
        {
            string parametros = String.Format("Indicador={0}&FechaInicio={1}&FechaFinal={2}&Nombre={3}&SubNiveles=N&CorreoElectronico={4}&Token={5}",
              318,
              "01/08/2021",
              "01/09/2021",
              "steve",
              "stevarcsa@gmail.com",
              "AASS020020"
              );
            var URL = $"https://gee.bccr.fi.cr/Indicadores/Suscripciones/WS/wsindicadoreseconomicos.asmx/ObtenerIndicadoresEconomicosXML?{parametros}";
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(URL);
                string mensaje = await response.Content.ReadAsStringAsync();
                string mensajeRemplazo = mensaje.Replace("&lt;", "<");
                string mensajeRemplazo2 = mensajeRemplazo.Replace("&gt;", ">");
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(mensajeRemplazo2);
                string compraJson = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);
                return Ok(compraJson);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("ConsultarDatosCompraXML")]
        public async Task<ActionResult<string>> ConsultarDatosCompraXML()
        {

            string parametros = String.Format("Indicador={0}&FechaInicio={1}&FechaFinal={2}&Nombre={3}&SubNiveles=N&CorreoElectronico={4}&Token={5}",
              317,
              "01/08/2021",
              "01/09/2021",
              "steve",
              "stevarcsa@gmail.com",
              "AASS020020"
              );

            var URL = $"https://gee.bccr.fi.cr/Indicadores/Suscripciones/WS/wsindicadoreseconomicos.asmx/ObtenerIndicadoresEconomicosXML?{parametros}";

            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(URL);
                string respuesta = await response.Content.ReadAsStringAsync();
                string respuestaRemplazo = respuesta.Replace("&lt;", "<");
                string respuestaXML = respuestaRemplazo.Replace("&gt;", ">");
                return Ok(respuestaXML);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpGet]
        [Route("ConsultarDatosVentaXML")]
        public async Task<ActionResult<string>> ConsultarDatosVentaXML()
        {
            string parametros = String.Format("Indicador={0}&FechaInicio={1}&FechaFinal={2}&Nombre={3}&SubNiveles=N&CorreoElectronico={4}&Token={5}",
              318,
              "01/08/2021",
              "01/09/2021",
              "steve",
              "stevarcsa@gmail.com",
              "AASS020020"
              );
            var URL = $"https://gee.bccr.fi.cr/Indicadores/Suscripciones/WS/wsindicadoreseconomicos.asmx/ObtenerIndicadoresEconomicosXML?{parametros}";
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(URL);
                string respuesta = await response.Content.ReadAsStringAsync();
                string respuestaRemplazo = respuesta.Replace("&lt;", "<");
                string respuestaXML = respuestaRemplazo.Replace("&gt;", ">");
                return Ok(respuestaXML);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

    }
}
