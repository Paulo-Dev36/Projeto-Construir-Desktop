using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Projeto_Construir_Desktop
{
    public class Componentes
    {
        public void FormatarEmReais(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox t = (TextBox)sender;
                string w = Regex.Replace(t.Text, "[^0-9]", string.Empty);
              
                if (w == string.Empty)
                    w = "00";

                if (e.KeyChar.Equals((char)Keys.Back))
                {
                    w = w.Substring(0, w.Length - 1);
                }
                else
                {
                    w += e.KeyChar;
                }

                t.Text = string.Format("{0:#,##0.00}", double.Parse(w) / 100);
                t.Select(t.Text.Length, 0);
            }
            e.Handled = true;
        }

        public void PermitirSomenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (char)Keys.Back != e.KeyChar)
                e.Handled = true;
        }
    }
}
