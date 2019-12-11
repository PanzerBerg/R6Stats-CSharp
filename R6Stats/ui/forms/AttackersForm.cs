using R6Stats.webCrawler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R6Stats.ui.forms
{
    public partial class AttackersForm : Form
    {
        public AttackersForm()
        {
            InitializeComponent();
        }

        private void AttackersForm_Load(object sender, EventArgs e)
        {
            WebCrawler.AttackersAsync();
        }
    }
}
