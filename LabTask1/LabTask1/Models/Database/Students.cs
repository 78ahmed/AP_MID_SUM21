using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LabTask1.Models.Database
{
    public class Students
    {
        SqlConnection conn;
        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Insert(Student s)
        {
            string query = "insert into Students values(@name,@dob,@credit,@cgpa,@dept)";
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@name", s.Name);
            cmd.Parameters.AddWithValue("@dob",s.Dob);
            cmd.Parameters.AddWithValue("@credit",s.Credit);
            cmd.Parameters.AddWithValue("@cgpa",s.CGPA);
            cmd.Parameters.AddWithValue("@dept",s.Dept);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            string query = "select * from Students";
            SqlCommand cmd = new SqlCommand(query,conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student s = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Dob = reader.GetDateTime(reader.GetOrdinal("Dob")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                    Dept = reader.GetInt32(reader.GetOrdinal("Dept_Id"))
                };

                students.Add(s);
            
            }
            conn.Close();
            return students;
        }
        public Student Get(int id)
        {
            Student s = null;
            string query = $"select * from Students where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                s=new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Dob = reader.GetDateTime(reader.GetOrdinal("Dob")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                    Dept = reader.GetInt32(reader.GetOrdinal("Dept_Id"))
                };

            }
            conn.Close();
            return s;
        }
        public void Update(Student s)
        {
            string query = "update Students Set Name=@name,Dob=@dob,Credit=@credit,CGPA=@cgpa,Dept_Id=@dept where Id=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", s.Name);
            cmd.Parameters.AddWithValue("@dob", s.Dob);
            cmd.Parameters.AddWithValue("@credit", s.Credit);
            cmd.Parameters.AddWithValue("@cgpa", s.CGPA);
            cmd.Parameters.AddWithValue("@dept", s.Dept);
            cmd.Parameters.AddWithValue("@id", s.Id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(int id)
        {
            string query = $"delete from Students where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}