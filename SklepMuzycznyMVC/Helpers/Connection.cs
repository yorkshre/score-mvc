using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace SklepMuzyczny.Helpers
{
    public class Connection
    {
          /*
           * Connection za każdym razem
           * 
           * */
        public static MySqlConnection getConnection()
        {
            string cs = @"Data Source=localhost; Database='szkola'; user ID=root; Password='MutherFucker'";
            MySqlConnection cn = new MySqlConnection(cs);
            return cn;
        }
        
        private Connection()
        {
        }

        /* to jest dosc wazna funkcja - przetwarza ona string : 
         * jesli jest null to robi z niego string o tresci  "null"
         * jesli jest tekstem np "tekst" to robi z niego string o tresci "'tekst'"
         * Mozna by jeszcze dodac uciekanie ze znakow specjalnych ale mi sie nie chcialo bawic :)
         * Chociaz jest to dosc wazna sprawa bo znajac strukture kwerend ktos obcy moglby dostac sie
         * do  danych do ktorych nie powinien sie dostac :)
         * */
        internal static string queryValue(string p)
        {
            if (p == null) return "null";
            return "'" + p + "'";
        }

        /**
         *  Ta funkcja wykonuje kwerende - ale nie zwraca rezultatow - uzywaj tylko jesli ich nie potrzebujesz
         */
        internal static void execute(string query)
        {
            MySqlConnection cn = getConnection();
            cn.Open();
            MySqlCommand c = cn.CreateCommand();
            c.CommandText = query;
            try
            {
                c.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                /* Todo check exceptions later */
            }
            cn.Close();
        }
    }
}