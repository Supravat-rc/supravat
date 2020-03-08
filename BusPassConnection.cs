using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace BusPassApplication
{
    public class BusPassConnection
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-4FAB0LO;Initial Catalog=EMPLOYEE;Integrated Security=True");
    }
}