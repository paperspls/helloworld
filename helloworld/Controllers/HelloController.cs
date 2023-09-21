using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("~/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello World!";
        }

            [HttpGet("/meunome")]
            public string MeuNome()
            {
                return "Rhyan!";
            }

                [HttpGet("/bsms")]
                public string bsms()
                {
                return "1- PROATIVIDADE\n2- RESILIENCIA\n3- ORIENTAÇÃO AO DETALHE";
                }

                    [HttpGet("/objetivos")]
                    public string objetivos()
                    {
                        return "1- Aprofundar meu conhecimento em Databases\n2- Treinar minha comunicação\n3- Fazer networking";
                    }
    }
}
