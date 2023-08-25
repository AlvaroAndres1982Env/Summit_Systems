namespace WebAPI.Controllers
{
    using System.Web.Http;
    using Transversal;

    public class testController : ApiController
    {
        Negocio.test objtest = new Negocio.test();

        // POST api/<controller>
        public string Post(test oTexto)
        {
            var Datos = objtest.Registrar(oTexto);
            return Datos;
        }
    }
}