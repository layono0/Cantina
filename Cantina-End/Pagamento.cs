using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_End
{
    public partial class Pagamento : Form
    {
        private string _produtos;
        private string _cliente;
        public Pagamento(string produtos, string cliente)
        {
            InitializeComponent();

            _produtos = produtos;
            _cliente = cliente;
            listBox1.Items.Add(produtos);
        }

        private void Pagamento_Load(object sender, EventArgs e)
        {

        }
    }
}
