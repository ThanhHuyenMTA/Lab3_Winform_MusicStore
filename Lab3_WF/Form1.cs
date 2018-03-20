using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab3_WF
{
    public partial class Form1 : Form
    {
        //sử dụng để chuyển sang form chính và thực hiện click vào button Report
        private bool chuyenform;
        public bool Chuyenform
        {
            get { return chuyenform; }
            set { chuyenform = value; }
        }
        //end
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void shoppingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelA.Controls.Clear();
            ShopingUC a = new ShopingUC();
            panelA.Controls.Add(a);
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelA.Controls.Clear();
            ReportUC a = new ReportUC();
            panelA.Controls.Add(a);
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelA.Controls.Clear();
            AlbumUC a = new AlbumUC();
            panelA.Controls.Add(a);
        }

        private void btnShopping_Click(object sender, EventArgs e)
        {
            panelA.Controls.Clear();
            ShopingUC a = new ShopingUC();
            panelA.Controls.Add(a);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
            panelA.Controls.Clear();
            ReportUC a = new ReportUC();
            panelA.Controls.Add(a);
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            panelA.Controls.Clear();
            AlbumUC a = new AlbumUC();
            panelA.Controls.Add(a);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool chuyenForm = chuyenform;
            if (chuyenForm == true)
            {
                panelA.Controls.Clear();
                ReportUC a = new ReportUC();
                panelA.Controls.Add(a);
                chuyenform = false;
            }
        }
       
    }
}
