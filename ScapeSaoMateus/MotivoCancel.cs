using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScapeSaoMateus
{
    public partial class MotivoCancel : Form
    {
        public String motivo = " ";
        public MotivoCancel()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.motivo = tbox_motivo.Text.ToUpper();
            this.Close();
        }
    }
}
