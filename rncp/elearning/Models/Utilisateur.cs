using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace elearning.Models
{
    public class Utilisateur
    {
        private int id;
        private string login;
        private string password;
        private string nom;
        private string prenom;
        private string email;
        public Utilisateur()
        {

        }
        public Utilisateur(string login, string password, string nom, string prenom, string email)
        {
            this.login = login;
            this.password = password;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
        }
        public int Id
        {
            get { return id; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}