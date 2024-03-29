﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoeMaisWEBService.Models
{
    public class DoacaoModel
    {
        private String cod;
        private String instituicao;
        private String dataDoada;
        private String dataParaDoar;
        private String dataParaRetirada;

        public string Cod { get => cod; set => cod = value; }
        public string Instituicao { get => instituicao; set => instituicao = value; }
        public string DataDoada { get => dataDoada ?? String.Empty; set => dataDoada = value ?? String.Empty; }
        public string DataParaDoar { get => dataParaDoar; set => dataParaDoar = value; }
        public string DataParaRetirada { get => dataParaRetirada ?? String.Empty; set => dataParaRetirada = value ?? String.Empty; }
    }
}