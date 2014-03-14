using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlayIndoor
{
    public partial class rep : Form
    {
        public rep()
        {
            InitializeComponent();
        }

        private void rep_Load(object sender, EventArgs e)
        {
            this.axplayer.URL = @"ListaPrincipal.wpl";
            this.axplayer.settings.setMode("loop", true);
        }

        private void rep_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
