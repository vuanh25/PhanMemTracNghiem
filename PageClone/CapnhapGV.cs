using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemThiTracNghiem.PageClone
{
    public partial class CapnhapGV : Form
    {
        fAdmin fadmin = new fAdmin();
        Modify modify = new Modify();
        public CapnhapGV()
        {
            InitializeComponent();
         //   this.fadmin = fadmin;

        }

        private void CapnhapGV_Load(object sender, EventArgs e)
        {

        }

        private void btnHuyCN_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnConfirmCN_Click(object sender, EventArgs e)
        {
            /* string magv = this.txtMaSoGVCN.Text;
             string tengv = this.txtHoTenGVCN.Text;
             string ngaysinh = this.txtDiaChiCN.Text;
             string matkhau = this.txtMatKhauCN.Text;
             Admin admin = new Admin(magv, tengv, ngaysinh, matkhau);
             if (modify.Update(admin))
             {
                 fadmin.dtgrvGV.DataSource = modify.getAllGiangVien();
               //  this.Close();
             }
             else
             {
                 MessageBox.Show("Lỗi: " + "Không cập nhập  được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

             }*/
      
        }
    }
}
