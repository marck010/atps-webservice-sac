﻿using ATPS.SistemasDistribuidos.Chat.Dominio.Entidades;
using ATPS.SistemasDistribuidos.Chat.Dominio.Entidades;
using ATPS.SistemasDistribuidos.Chat.Dominio.Interfaces.Repositorios;
using ATPS.SistemasDistribuidos.Dominio.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATPS.SistemasDistribuidos.Dominio.Servicos
{
    public interface IServicoAtendimento
    {
        Atendimento SalvarAtualizarAtendimento(string chaveAcessoRemetente, Usuario usuarioDestinatario, string mensagem, Atendimento atendimentoEmAndamento);
    }
}
