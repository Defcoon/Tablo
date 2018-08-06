using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Periyodik_Tablo_V._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            periyodik_tablo form =new periyodik_tablo();
            if (form.ShowDialog() == DialogResult.OK)
            {
               
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {         
            feedback form = new feedback();
            if (form.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V.1 Notları:\n Bu sürümde periyodik tablo ve kimya ile uğraşan bazı bilimadamlarına yer verilmiştir...\n İsteklerinizi ve görüşlerinizi Geri Bildirim kısmından bana iletebilirsiniz... \n-------------------------------------------------------------------------------\n V1.1 Notları : \n Bu sürümde fare işaretcisinin konumuna göre renk değiştirebilen özellik peryodik tabloya entegre edilmiştir laf aramızda en zoru bu oldu :) ", "Sürüm Bilgileri",MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bilimadamları form = new Bilimadamları();
            if (form.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
