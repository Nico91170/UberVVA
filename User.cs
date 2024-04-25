using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberVVA
{
    public class user
    {

        private String Nom;
        private String Prenom;
        private String role;
        private String username;
        private String pwd;

        public user(string Nom, string Prenom, string role, string username, string pwd)
        {

            this.Nom = Nom;
            this.Prenom = Prenom;
            this.role = role;
            this.username = username;
            this.pwd = pwd;

        }


        public string GetNom()
        {
            return this.Nom;
        }
        public string GetPrenom()
        {
            return this.Prenom;
        }
        public string Getrole()
        {
            return this.role;
        }
        public string Getusername()
        {
            return this.username;
        }

        public string Getpwd()
        {
            return this.pwd;
        }









        public void SetNom(String newNom)
        {
            this.Nom = newNom;
        }
        public void SetPrenom(String newPrenom)
        {
            this.Prenom = newPrenom;
        }
        public void Setrole(String newrole)
        {
            this.role = newrole;
        }
        public void Setusername(String newusername)
        {
            this.username = newusername;
        }
        public void Setpwd(String newpwd)
        {
            this.pwd = newpwd;
        }






        public override string ToString()
        {
            return this.Prenom + '/' + this.Nom + '/' + this.username + '/' + this.pwd+ '/'+ this.role;
        }


    }
}
