using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wcf = new WebRefWcf.Servico01Client();
            //string msg = wcf.Mensagem() ;
            //MessageBox.Show(msg);

            int total = wcf.Somar(10, 20);
            MessageBox.Show(total.ToString());

        }
    }
}
