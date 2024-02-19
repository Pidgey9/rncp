using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace elearning.Models
{
    public class DaoQuiz
    {
        string connectionString = @"Data Source=DESKTOP-F1NS20D;Initial Catalog=RNCP;Integrated Security=True";
        public bool Delete(int id)
        {
            string sql = "delete Quiz where id = " + id;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;
        }
        public bool Update(Quiz q)
        {
            string sql = "update Quiz set question=@question,cours=@cours,reponse=@reponse where id=@id ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.Int).Value = q.Id;
            command.Parameters.Add("question", SqlDbType.NVarChar).Value = q.Question;
            command.Parameters.Add("cours", SqlDbType.NVarChar).Value = q.Cours;
            command.Parameters.Add("reponse", SqlDbType.NVarChar).Value = q.Reponse;

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;
        }
        public bool Insert(Quiz q)
        {
            string sql = "insert into Quiz values(@id,@question,@cours,@reponse)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.Int).Value = q.Id;
            command.Parameters.Add("question", SqlDbType.NVarChar).Value = q.Question;
            command.Parameters.Add("cours", SqlDbType.NVarChar).Value = q.Cours;
            command.Parameters.Add("reponse", SqlDbType.NVarChar).Value = q.Reponse;

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;

        }
        public List<Quiz> SelectAll()
        {
            List<Quiz> liste = new List<Quiz>();
            string sql = "select * from Quiz";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Quiz q = new Quiz(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                liste.Add(q);

            }
            connection.Close();

            return liste;
        }

        public Quiz SelectById(int id)
        {
            Quiz q = null;
            string sql = "select * from Quiz where id=" + id;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
                q = new Quiz(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
            connection.Close();

            return q;
        }

    }
}