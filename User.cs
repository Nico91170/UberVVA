using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberVVA
{
    public class user
    {

        private String nom;
        private String prenom;
        private String role;
        private String username;
        private String pwd;

        public user(string nom, string prenom, string role, string username, string pwd)
        {

            this.nom = nom;
            this.prenom = prenom;
            this.role = role;
            this.username = username;
            this.pwd = pwd;

        }


        public string Getnom()
        {
            return this.nom;
        }
        public string Getprenom()
        {
            return this.prenom;
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









        public void Setnom(String newNom)
        {
            this.nom = newNom;
        }
        public void Setprenom(String newPrenom)
        {
            this.prenom = newPrenom;
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
            return this.prenom + '/' + this.nom + '/' + this.username + '/' + this.pwd+ '/'+ this.role;
        }


    }
}
