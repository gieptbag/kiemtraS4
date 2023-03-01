using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiemtra1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           if(txtUserName.Text =="hoahiep" && txtpassword.Text == "12345")
            {

                MessageBox.Show("Đăng nhập thành công", "Thông Báo");
            }
           else
            {

                MessageBox.Show("Sai tên đăng nhập  hoặc mật khẩu", "Thông Báo");
            }
        }
    }
}
