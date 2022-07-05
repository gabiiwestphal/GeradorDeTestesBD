using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract void Inserir();
        public virtual void Editar() { }
        public abstract void Excluir();
        public virtual void VisualizarDetalhes() { }
        public abstract UserControl ObtemListagem();
        public abstract ConfiguracaoToolboxBase ObtemConfiguracaoToolbox();
    }
}
