using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace WindowsFormsApp15.Telas
{
    public partial class Whatsapp : Form
    {
        public Whatsapp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string telPara = txtNumero.Text;
            string Mensagem = txtMensagem.Text;
            this.EnviarWhatsapp(telPara, Mensagem);
        }
        private void EnviarWhatsapp(string telPara, string Mensagem)
        {
            telPara = telPara.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            TwilioClient.Init("AC70b9b67a32b116779d34b9097e5cd9d1", "3c9bb04fa8e721cb0788430da93c5d85");
            var message = MessageResource.Create(
             new PhoneNumber("whatsapp:" + telPara),
            from: new PhoneNumber("whatsapp:+14155238886"),
            body: Mensagem
        );        
        }
    }
}
