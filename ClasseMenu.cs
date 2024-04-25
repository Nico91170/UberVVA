using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberVVA
{
    internal class menu
    {
        private string nomN;
        private string description;
        private string prix;
        private string type;
        public menu(string nomN, string description, string prix, string type)
        {
            this.nomN = nomN;
            this.description = description;
            this.prix = prix;
            this.type = type;
        }
        public string NomN { get => nomN; set => nomN = value; }
        public string Description { get => description; set => description = value; }
        public string Prix { get => prix; set => prix = value; }
        public string Type { get => type; set => type = value; }

        public void setNomN(string nomN)
        {
            this.nomN = nomN;
        }

        public string getNomN()
        {
            return nomN;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public string getDescription()
        {
            return description;
        }

        public void setPrix(string prix)
        {
            this.prix = prix;
        }

        public string getPrix()
        {
            return prix;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public string getType()
        {
            return type;
        }

        public override string ToString()
        {
            return "NomN: " + nomN + " Description: " + description + " Prix: " + prix + " Type: " + type;
        }
    }
}
