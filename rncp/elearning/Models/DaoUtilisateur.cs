using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace elearning.Models
{
    public class DaoUtilisateur
    {
        string connectionString = @"Data Source=DESKTOP-F1NS20D;Initial Catalog=RNCP;Integrated Security=True";
        public bool Delete(int id)
        {
            string sql = "delete Utilisateur where id = " + id;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;
        }
        public bool Update(Utilisateur u)
        {
            string sql = "update Utilisateur set login=@login,password=@password,nom=@nom,prenom=@prenom,email=@email where id=@id ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.Int).Value = u.Id;
            command.Parameters.Add("login", SqlDbType.NVarChar).Value = u.Login;
            command.Parameters.Add("password", SqlDbType.NVarChar).Value = u.Password;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = u.Nom;
            command.Parameters.Add("prenom", SqlDbType.NVarChar).Value = u.Prenom;
            command.Parameters.Add("email", SqlDbType.NVarChar).Value = u.Email;


            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;
        }
        public bool Insert(Utilisateur u)
        {
            string sql = "insert into Utilisateur values(@id,@login,@password,@nom,@prenom,@email)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("id", SqlDbType.Int).Value = u.Id;
            command.Parameters.Add("login", SqlDbType.NVarChar).Value = u.Login;
            command.Parameters.Add("password", SqlDbType.NVarChar).Value = u.Password;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = u.Nom;
            command.Parameters.Add("prenom", SqlDbType.NVarChar).Value = u.Prenom;
            command.Parameters.Add("email", SqlDbType.NVarChar).Value = u.Email;

            connection.Open();
            int nb = command.ExecuteNonQuery();
            connection.Close();

            if (nb > 0)
                return true;
            return false;

        }
        public List<Utilisateur> SelectAll()
        {
            List<Utilisateur> liste = new List<Utilisateur>();
            string sql = "select * from Utilisateur";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Utilisateur u = new Utilisateur(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5));
                liste.Add(u);

            }
            connection.Close();

            return liste;
        }

        public Utilisateur SelectById(int id)
        {
            Utilisateur u = null;
            string sql = "select * from Utilisateur where id=" + id;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
                u = new Utilisateur(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5));
            connection.Close();

            return u;
        }

    }
}