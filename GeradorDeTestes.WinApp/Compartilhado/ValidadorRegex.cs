namespace GeradorDeTestes.WinApp.Compartilhado
{
    public class ValidadorRegex
    {
        public bool ApenasLetra(string letra)
        {
            bool estaValido = System.Text.RegularExpressions.Regex.IsMatch(letra, @"^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]*$");

            return estaValido;
        }
    }
}
