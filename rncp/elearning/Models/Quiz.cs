using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace elearning.Models
{
    public class Quiz
    {
        private int id;
        private string question;
        private string cours;
        private string reponse;
        public Quiz()
        {

        }
        public Quiz(int id, string question, string cours, string reponse)
        {
            this.id = id;
            this.question = question;
            this.cours = cours;
            this.reponse = reponse;
        }
        public int Id
        {
            get { return id; }
        }
        public string Question
        {
            get { return question; }
            set { question = value; }
        }
        public string Cours
        {
            get { return cours; }
            set { cours = value; }
        }
        public string Reponse
        {
            get { return reponse; }
            set { reponse = value; }
        }
    }
}