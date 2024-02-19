using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace elearning.Models
{
    public class Avancement
    {
        private int id;
        private int idUtilisateur;
        private int question;
        private bool reponse;
        public Avancement()
        {

        }
        public Avancement(int idU, int question, bool reponse)
        {
            this.idUtilisateur = idU;
            this.question = question;
            this.reponse = reponse;
        }
        public Avancement(int id, int idU, int question, bool reponse)
        {
            this.id = id;
            this.idUtilisateur = idU;
            this.question = question;
            this.reponse = reponse;
        }
        public int Id
        {
            get { return id; }
        }
        public int IdUtilisateur
        {
            get { return idUtilisateur; }
        }
        public int Question
        {
            get { return question; }
        }
        public bool Reponse
        {
            get { return reponse; }
            set { reponse = value; }
        }

    }
}