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
    [RoutePrefix("api/validar")]
    public class ValidateController : ApiController
    {
        [Route("cnpj/{cnpj}")]
        [HttpPost]
        public HttpResponseMessage PostCnpj(string cnpj)
        {
            var cnpjValido = CnpjValidator.Validar(cnpj);
            string mensagem = "";
            if(cnpjValido)
            {
                mensagem = "Cnpj valido";
            } else
            {
                mensagem = "Cnpj invalido";
            }

            return Request.CreateResponse(HttpStatusCode.OK, mensagem);
        }

        [Route("cpf/{cpf}")]
        [HttpPost]
        public HttpResponseMessage PostCpf(string cpf)
        {
            var cpfValido = CpfValidator.Validar(cpf);
            string mensagem = "";

            if (cpfValido)
            {
                mensagem = "Cpf valido";
            }
            else
            {
                mensagem = "Cpf invalido";
            }

            return Request.CreateResponse(HttpStatusCode.OK, mensagem);
        }
    }
}
