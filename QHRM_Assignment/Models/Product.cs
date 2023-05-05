using Microsoft.Data.SqlClient;
using System.Data;

namespace OHRM_Sanket_Patil.Models
{
    public class Product
    {
        public int id { get; set; }

        public string product { get; set; }
        public string description { get; set; }

        public DateTime created  { get; set; }

        

    }
}
