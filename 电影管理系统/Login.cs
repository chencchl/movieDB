using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 电影管理系统;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace movieDB
{
    public partial class Login : Form
    {
        public Login()
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
                login();
            }
            else
            {
                MessageBox.Show("输入有空项，请重新输入");
            }
        }
        //登陆方法：验证是否允许登录，允许返回真
        public void login()
        {
            //用户
            if(radioButtonUser.Checked==true)
            {
                Dao dao = new Dao();            
                string sql = $"select * FROM t_user WHERE id = 'textBox1.Text' and psw='{textBox2.Text}'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    Data.UID = dc["id"].ToString();
                    Data.UName = dc["name"].ToString();
                    MessageBox.Show("登陆成功");
                    user1 user = new user1();
                    this.Hide();
                    user.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登陆失败");
              
                }
                dao.DaoClose();        
            }
            //管理员
            if (radioButtonAdmin.Checked == true)
            {
                Dao dao = new Dao();
                string sql = $"select * from t_admin where id='{textBox1.Text}' and psw='{textBox2.Text}'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MessageBox.Show("登陆成功");
                    admin1 a = new admin1();
                    this.Hide();
                    a.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登陆失败");
                }
                dao.DaoClose();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
