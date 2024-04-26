using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UberVVA
{
    internal class ClassMenu
    {
        // MySqlConnection connexion = new MySqlConnection("Server=localhost;Database=r;Uid=root;Pwd=;");
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connexion = new MySqlConnection("Server=localhost;database=foodmaps;Uid=root;Pwd=;");
            connexion.Open();
            return connexion;


        }



        public static List<user> GetTousLesuser()
        {

            List<user> listeU = new List<user>();

            string reqQueryEtus = "Select nom, prenom, role ,username ,password from user ";
            MySqlCommand cmd = ClassMenu.GetConnection().CreateCommand();
            cmd.CommandText = reqQueryEtus;
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listeU.Add(new user(rdr.GetString("nom"), rdr.GetString("prenom"), rdr.GetString("role"), rdr.GetString("username"), rdr.GetString("password")));
            }
            rdr.Close();
            return listeU;
        }
        public static void AjoutUser(user u)
        {
            MySqlCommand cmd = ClassMenu.GetConnection().CreateCommand();

            //String reqUPar = "UPDATE participant SET balance = balance -" + d.GetMontant()/pconcernes.Count+ " where id = " + p.GetId();
            String reqUPar = "INSERT into user (nom,prenom,role,username,password) VALUES (" + u.Getnom() + ",'" + u.Getprenom() + "','" + u.Getrole() + "','" + u.Getusername() + "','" + u.Getusername() + "','" + u.Getpwd() + "')";
            cmd.CommandText = reqUPar;


            int nbI = cmd.ExecuteNonQuery();

        }

        public static void supprimeruser(user u)
        {
            MySqlCommand cmd = ClassMenu.GetConnection().CreateCommand();

            //String reqUPar = "UPDATE participant SET balance = balance -" + d.GetMontant()/pconcernes.Count+ " where id = " + p.GetId();
            String reqUPar = "DELETE FROM `user`WHERE `nom` = '" + u.Getnom() + "' AND `prenom` = '" + u.Getprenom() + "'  AND `role` = '" + u.Getrole() + "'  AND `username` = '" + u.Getusername() + "' AND `password` = '" + u.Getpwd() + "';";
            cmd.CommandText = reqUPar;


            int nbI = cmd.ExecuteNonQuery();

        }

        public static void modifieruser(user u)
        {
            MySqlCommand cmd = ClassMenu.GetConnection().CreateCommand();

            String reqUPar = "UPDATE `user` SET `nom` = '" + u.Getnom() + "', `prenom` = '" + u.Getprenom() + "', `role` = '" + u.Getrole() + "', `username` = '" + u.Getusername() + "',`password` = '" + u.Getpwd() + "' where id =   ";
            // String reqUPar = "DELETE FROM `menu`WHERE `Formule` = '" + m.GetFormule() + "' AND `Boisson` = '" + m.Getboisson() + "'  AND `Sandwich` = '" + m.Getsandwich() + "'  AND `Viennoiserie` = '" + m.Getviennoiserie() + "';";
            cmd.CommandText = reqUPar;


            int nbI = cmd.ExecuteNonQuery();

        }

    }
}

