using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ceklink;
namespace Formx
{
    public partial class Form1 : Form
    {
    	public cek Link;
        public Form1()
        {
            InitializeComponent();
        }
        public void ubahStatus(bool status)
        {
            btnStatus.BackColor = status ? Color.Green : Color.Red;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();

            if (iData.GetDataPresent(DataFormats.Text))
            {
                Link = new cek{ 
                    link = (String)iData.GetData(DataFormats.Text) 
                };
                textBox1.Text = Link.link;
                // cek valid atau tidak
                if (Link.IsLink) ubahStatus(true);
                else ubahStatus(false);
            }
            else
            {
                // No it is not.
                textBox1.Text = "https://";
                btnStatus.BackColor = Color.Red;
            }

            this.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
