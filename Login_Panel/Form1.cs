using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Panel
{
    public partial class Form1 : Form
    {

        string ka = "Ali";
        string sfr = "Sa1234";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {


            if(ka == kullaniciadi.Text && sfr==sifre.Text)
            {
                MessageBox.Show("GİRİS YAPILDI");
            }
            else
            {
                MessageBox.Show("GİRİS YAPILMADI");
            }
        }
    }
}
