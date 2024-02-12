using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek_1575
{
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtYazi.SelectionFont = new Font(rtxtYazi.Font, FontStyle.Bold);
        }

        private void ptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtYazi.Font = new Font("Arial Black", 12);
        }

        private void ptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtxtYazi.Font = new Font("Arial Black", 15);
        }

        private void ptToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            rtxtYazi.Font = new Font("Arial Black", 20);
        }

        private void ptToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            rtxtYazi.Font = new Font("Arial Black", 25);
        }
    }
}
