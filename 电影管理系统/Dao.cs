using System.Data.SqlClient;

namespace movieDB
{
    internal class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str = @"Server=192.168.161.1;Catalog=moviedb;Uid=mysql.session;Pwd=cq761105;";
            SqlConnection sc = new SqlConnection(str);
            sc.Open();
            return sc;
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql,connect());
            return cmd;
        }
        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();//关闭数据库连接
        }
    }
}
