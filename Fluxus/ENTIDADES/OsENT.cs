﻿using System;

namespace Fluxus.ENTIDADES
{

    public class OsENT
    {
        public string Titulo { get; set; }
        public string Referencia { get; set; }
        public string Agencia { get; set; }
        public string Profissional_cod { get; set; }
        public string Atividade_cod { get; set; }
        public string Nome_cliente { get; set; }
        public string Cidade { get; set; }
        public string Nome_contato { get; set; }
        public string Telefone_contato { get; set; }
        public string Coordenada { get; set; }
        public string Status { get; set; }
        public string Obs { get; set; }
        public string Fatura_cod { get; set; }
        public DateTime Data_ordem { get; set; }
        public DateTime Prazo_execucao { get; set; }
        public DateTime Data_pendente { get; set; }
        public DateTime Data_vistoria { get; set; }
        public DateTime Data_concluida { get; set; }
        public bool Siopi { get; set; }
    }


}