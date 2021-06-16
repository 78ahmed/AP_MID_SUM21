using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LabTask1.Models.Database
{
    public class Database
    {
        public Admins Admins { get; set; }
        public Students Students { get; set; }
        public Depertments Depertments { get; set; }
        public Database()
        {
            string connString = @"Server=DESKTOP-DVV1NA8\SQLEXPRESS;Database=LabTask1;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            Admins = new Admins(conn);
            Students = new Students(conn);
            Depertments = new Depertments(conn);
        }
    }
}