using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApValidadorGeradorCpfCnpj.Fabricas;
using WebApValidadorGeradorCpfCnpj.Validadores;

namespace WebApValidadorGeradorCpfCnpj.Controllers
{
    [RoutePrefix("api/gerador")]
    public class GeneratorController : ApiController
    {
        [Route("cpf")]
        public HttpResponseMessage GetCpf()
        {
            string cpf = CpfFactory.GerarCpf();

            return Request.CreateResponse(HttpStatusCode.OK, cpf);
        }

        [Route("cnpj")]
        public HttpResponseMessage GetCnpj()
        {
            string cnpj = CnpjFactory.gerarCnpj();

            return Request.CreateResponse(HttpStatusCode.OK, cnpj);
        }

    }
}
