using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepMuzyczny.Controllers
{

    public class HomeController : Controller

    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            MySqlConnection conn = Helpers.Connection.getConnection();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "Select idTowaru, Nazwa from towar where idTowaru in (Select idTowaru from (SELECT idTowaru, SUM(Ilosc) as suma from towar_zamowienie group by idTowaru order by suma desc limit 5) as listaId)";
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
