﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LabTask1.Models.Database
{
    public class Admins
    {
        SqlConnection conn;
        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }
        void Insert(Admin a)
        {

        } 
        void GetAll()
        {

        }
        void Get(int id)
        {

        }
        void Edit(Admin a)
        {

        }
        void Delete(int id)
        {

        }
    }
}