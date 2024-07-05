using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Projesi
{
    internal class SqlBaglantısı
    {
        public SqlConnection baglantı()
        {

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-Q5UEOO5;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }


    }
}
