using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TeamProject
{
    class DB {

        //MysqlConnector
        private static string strconn = 
            "Server=13.58.234.156;" +
            "Database=dotnetPBL3;" +
            "Uid=root;" +
            "Pwd=dbswjd30;" +
            "SslMode=none;" +
            "charset=utf8;";

        private MySqlConnection conn = null;             
        private MySqlCommand comm = null;               
        private MySqlDataReader read = null;            

        public DB()
        {
            conn = new MySqlConnection();
            comm = new MySqlCommand();
            try
            {
                conn.ConnectionString = strconn;
                conn.Open();
               
                comm.Connection = conn;
            }
            catch (Exception e)
            {
                conn = null;
                comm = null;
                MessageBox.Show(e.ToString());
            }
        }

        //연결 삭제
        public void Close()
        {
            conn.Close();
        }

        //----------------------------------------
        //insert, delete, update같은 데이터를 읽지는 않고
        //처리만 하는 함수
        public bool NonQuery(string query)
        {
            if (conn == null || comm == null)
            {
                MessageBox.Show("DB가 연결되어 있지 않습니다.");
                return false;
            }
            try
            {
                comm.CommandText = query;
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            return true;
        }//NonQuery()
         //---------------------------------------
         //select와 같은 데이터를 읽어오는 함수
        private bool Query(string query)
        {
            if (conn == null || comm == null)
            {
                MessageBox.Show("DB가 연결되어 있지 않습니다.");
                return false;
            }

            if (read != null) read.Close();

            try
            {
                comm.CommandText = query;
                read = comm.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
            return true;
        }//Query()
         //----------------------------------------------
         //----------------------------------------------
        private bool ReadNext()
        {
            if (read != null) return read.Read();
            return false;
        }
        //--------------------------------------------
        private string GetData(string name)
        {
            if (read != null) return read[name].ToString();
            MessageBox.Show("읽은 데이터가 없습니다.");
            return "";
        }


        //Product 검색 질의 처리
        public List<Product> SelectProduct(string query)
        {
            List<Product> list = new List<Product>();
            Product pro;
            try
            {   
                Query(query);
                while (ReadNext())
                {
                    if (GetData("e_date") == "")
                    {
                        pro = new Product(
                            GetData("category"),
                            GetData("name"),
                            int.Parse(GetData("price")));
                        
                    }
                    else
                    {
                        pro = new Food(
                            GetData("category"),
                            GetData("name"),
                            int.Parse(GetData("price")),
                            GetData("e_date"));
                    }

                    pro.amount = int.Parse(GetData("amount"));
                    list.Add(pro);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("DB 연동이 안되었습니다.");
            }
            if (list.Count == 0)    return null;
            else                    return list;
        }//SelectProduct()
         //--------------------------------------------
         //Pay 검색 질의 처리
        public List<Pay> SelectPay(string query)
        {
            List<Pay> list = new List<Pay>();
            Pay pay;
            try
            {
                Query(query);
                while (ReadNext())
                {
                    pay = new Pay(
                        int.Parse(GetData("paynum")),
                        GetData("pname"), 
                        int.Parse(GetData("price")),
                        GetData("type"),
                        GetData("time"),
                        int.Parse(GetData("amount")));

                    list.Add(pay);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("DB 연동이 안되었습니다.");
            }
            if (list.Count == 0) return null;
            else return list;
        }//SelectPay()
         //--------------------------------------------
         //DB의 마지막 결제번호를 확인
        public int ReturnPrePaynum()
        {
            if (conn == null || comm == null)
            {
                MessageBox.Show("DB가 연결되어 있지 않습니다.");
                return 0;
            }

            Query("select paynum from pay order by paynum desc limit 1");

            if (ReadNext())
            {
                return int.Parse(GetData("paynum"));
            }
            else
            {
                return 0;
            }       
        }//ReturnPrePaynum()
    }//class
}//namespace
