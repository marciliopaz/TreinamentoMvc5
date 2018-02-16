using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    // 3 - RoutePrefix
    //[RoutePrefix("novasrotas")]

    //4 - Renomear o nome do routeprefix
    [RoutePrefix("geral")]

    public class NovasRotasController : Controller
    {
        // GET: NovasRotas

        [Route("novasrotas/index/{nascimento}")]
        public string Index(DateTime nascimento)
        {
            return string.Format("Data de nascimento {0:dd/MM/yyyy}", nascimento);
        }

        //[Route("novasrotas/getdados/{nome}/{idade}")]
        [Route("info/{nome}/{idade}")]
        public  string GetDados (string nome, int idade=20)
        {
            return HttpUtility.HtmlEncode(
                string.Format("Bem vindo {0} com idade de {1}", nome, idade));
        }

        //[Route("novasrotas/getpreco/{preco}")]
        [Route("cotacao/{preco:int:min(20)}")]
        public string GetPreco (int preco)
        {
            return "preco do produto é " + preco;
        }

        //[Route("novasrotas/getcliente/{id}")]
        [Route("cliente/{id:int:min(5):max(99)}")]
        public string GetCliente (int id)
        {
            return "Codigo do cliente: " + id;
        }


    }
}