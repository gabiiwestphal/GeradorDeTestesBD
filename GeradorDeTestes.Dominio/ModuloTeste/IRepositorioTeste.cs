using System;
using System.Collections.Generic;
using FluentValidation.Results;
using GeradorDeTestes.Dominio.Compartilhado;
using GeradorDeTestes.Dominio.ModuloQuestao;

namespace GeradorDeTestes.Dominio.ModuloTeste
{
    public interface IRepositorioTeste : IRepositorioBase<Teste>
    {
        //ValidationResult InserirQuestoesNoTeste(Teste teste,
        //    List<Questao> questoesTeste);
    }
}
