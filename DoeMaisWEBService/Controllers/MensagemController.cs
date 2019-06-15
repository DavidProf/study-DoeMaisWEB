﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DoeMaisWEBService.Models;

namespace DoeMaisWEBService.Controllers
{
    [RoutePrefix("doador/mensagem")]
    public class MensagemController : ApiController
    {
        [Route("lista")]
        [HttpGet]
        public List<MensagemModel> GetMensagems(String email, String senha)
        {
            return new BD.MensagemBD().GetMensagems(email, senha);
        }

        [Route]
        [HttpPost]
        public void EnviarMensagem(String cnpj, String email, String senha, String texto)
        {
            new BD.MensagemBD().EnviarMensagem(cnpj, email, senha, texto);
        }

        [Route]
        [HttpGet]
        public void GetMensagens(String cnpj, String email, String senha, String texto)
        {

        }
    }
}
