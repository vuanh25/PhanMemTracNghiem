using PhanMemThiTracNghiem.PHANMEMTHITNDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace PhanMemThiTracNghiem.PageClone
{
    public partial class ThemmotGV : Form
    {
        fAdmin fadmin = new fAdmin();
        Modify modify = new Modify();
        
        public ThemmotGV(fAdmin fadmin)
        {
            InitializeComponent();
            
            this.fadmin = fadmin;
         
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnConfirm_Click(object sender, EventArgs e)
        {
            string magv = this.txtMaSoGV.Text;
            string tengv = this.txtHoTenGV.Text;
            string ngaysinh = this.txtDiaChi.Text;
            string matkhau = this.txtMatKhau.Text;
             Admin admin = new Admin(magv,tengv,ngaysinh,matkhau);
            if (modify.insert(admin))
            {
                    fadmin.dtgrvGV.DataSource = modify.getAllGiangVien();
                     this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không thêm vào được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }


    }
}
