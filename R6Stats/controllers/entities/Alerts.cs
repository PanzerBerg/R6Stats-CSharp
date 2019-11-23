using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R6Stats.controllers.entities
{
    class Alerts
    {
        public void Alert(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, buttons);
        }

        public bool AlertReturn(float valor, float saldo)
        {
            string message = "Sua compra de $ " + valor.ToString("0.00") + " foi concluida com sucesso.\n Seu saldo atual é de R$ " + saldo.ToString("0.00");
            string caption = "Transação concluida";

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

    }
}
