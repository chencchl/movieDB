using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace movieDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&&textBox2.Text!="")
            {

            }
            else
            {
                MessageBox.Show("输入有空项，请重新输入");
            }
        }
        //登陆方法：验证是否允许登录，允许返回真
        public Boolean login()
        {
            //用户
            if(radioButtonUser.Checked==true)
            {
                Dao dao = new Dao();
                string sql = "select * FROM t_user WHERE id = '"+textBox1.Text+"' and psw = '"+textBox2.Text+"'";
                MessageBox.Show(sql);
            }
            //管理员
            if (radioButtonAdmin.Checked == true)
            {

            }
            return true;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
