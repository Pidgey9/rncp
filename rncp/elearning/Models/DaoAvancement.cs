using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace elearning.Models
{
    public class DaoAvancement
    {
        string connectionString = @"Data Source=DESKTOP-F1NS20D;Initial Catalog=RNCP;Integrated Security=True";
        public bool Delete(int id)
        {
            string sql = "delete Avancement where id = " + id;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;
        }
        public bool Update(Avancement a)
        {
            string sql = "update Avancement set idUtilisateur=@idUtilisateur,question=@question,reponse=@reponse where id=@id ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.Int).Value = a.Id;
            command.Parameters.Add("id", SqlDbType.Int).Value = a.IdUtilisateur;
            command.Parameters.Add("question", SqlDbType.Int).Value = a.Question;
            command.Parameters.Add("reponse", SqlDbType.Bit).Value = a.Reponse;

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;
        }
        public bool Insert(Avancement a)
        {
            string sql = "insert into Avancement values(@id,@idUtilisateur,@question,@reponse)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.Int).Value = a.Id;
            command.Parameters.Add("id", SqlDbType.Int).Value = a.IdUtilisateur;
            command.Parameters.Add("question", SqlDbType.Int).Value = a.Question;
            command.Parameters.Add("reponse", SqlDbType.Bit).Value = a.Reponse;

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;

        }
        public List<Avancement> SelectAll()
        {
            List<Avancement> liste = new List<Avancement>();
            string sql = "select * from Quiz";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Avancement a = new Avancement(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetBoolean(3));
                liste.Add(a);

            }
            connection.Close();

            return liste;
        }

        public Avancement SelectById(int id)
        {
            Avancement a = null;
            string sql = "select * from Avancement where id=" + id;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
                a = new Avancement(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetBoolean(3));
            connection.Close();

            return a;
        }
    }
}