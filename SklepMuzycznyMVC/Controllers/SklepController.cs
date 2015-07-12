using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepMuzyczny.Controllers
{
    public class SklepController : Controller
    {
        //
        // GET: /Sklep/

        public ActionResult Index()
        {

            MySqlConnection conn = Helpers.Connection.getConnection();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select `idGatunku`,`Name` from `gatunek`";
            command.CommandText = query;

            MySqlDataReader reader = command.ExecuteReader();
            List<string> names = new List<string>();
            List<int> id = new List<int>();
            while (reader.Read())
            {
                id.Add(reader.GetInt32(0));
                names.Add(reader.GetString(1));

            }
            reader.Close();
            conn.Close();
            ViewBag.id = id;
            ViewBag.names = names;


            return View();

        }


        public ActionResult ListaTowaru1()
        {
            MySqlConnection conn = Helpers.Connection.getConnection();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select idTowaru,nazwa from towar where idGatunku in( select idGatunku from gatunek group by idGatunku)";
            command.CommandText = query;

            MySqlDataReader reader = command.ExecuteReader();
            List<string> nazwa = new List<string>();
            List<int> id = new List<int>();
            while (reader.Read())
            {
                id.Add(reader.GetInt32(0));
                nazwa.Add(reader.GetString(1));

            }
            reader.Close();
            conn.Close();
            ViewBag.id = id;
            ViewBag.nazwa = nazwa;


            return View();
            
        }
    }
}