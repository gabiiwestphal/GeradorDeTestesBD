using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorDeTestes.WinApp.Compartilhado;

namespace GeradorDeTestes.WinApp.ModuloMateria
{
    public class ConfiguracaoToolboxMateria : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Matérias";

        public override string TooltipInserir { get { return "Inserir uma matéria"; } }

        public override string TooltipEditar { get { return "Editar uma matéria"; } }

        public override string TooltipExcluir { get { return "Excluir uma matéria"; } }
    }
}
