using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Projesi
{
    class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-AK5Q0PBD\\SQLEXPRESS;Initial Catalog=Hastane_Projesi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
