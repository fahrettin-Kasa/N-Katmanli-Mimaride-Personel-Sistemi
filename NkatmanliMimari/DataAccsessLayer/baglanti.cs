using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccsessLayer
{
    public class baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-CQKIIC2\SQLEXPRESS01;Initial Catalog=DbPersonel;Integrated Security=True");

    }
}
