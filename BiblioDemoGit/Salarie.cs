using BiblioDemoGit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP3Salarie
{
    public class Salarie : Personne
    {
        //Définition d'une nouvelle classe
        //L'encapsulation est mise en oeuvre par le biais de propriétés       

        #region "Propriétés d'instances"

        private int _Matricule;
        public int Matricule
        {
            get { return _Matricule; }
            set { _Matricule = value; }
        }

        private int _Service;
        public int Service
        {
            get { return _Service; }
            set { _Service = value; }
        }
        
        private int _Categorie;
        public int Categorie
        {
            get { return _Categorie; }
            set { _Categorie = value; }
        }
        
        private string _Nom;
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value.ToUpper(); }
        }

        private string _Prenom;
        public string Prenom
        {
            get { return _Prenom; }
            set { _Prenom = value.ToUpper(); }
        }

        private float _Salaire;
        public float Salaire
        {
            get { return _Salaire; }
            set { _Salaire = value; }
        }

        #endregion
        
        #region "Propriétés de classe"

        private static int _NbSalaries = 0; //pour compter le nb d'instances 

        public static int NbSalaries
        {
            get { return _NbSalaries; }           
        }

        #endregion
       
        #region "Constructeurs"

        //Constructeur d'initialisation : une valeur pour chaque propriété
        public Salarie(int matricule, string nom, string prenom, int service,
                       int categorie, float salaire)
        {
            this.Matricule = matricule;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Service = service;
            this.Categorie = categorie;
            this.Salaire = salaire;
            _NbSalaries++;
        }

        //Autre constructeur
        public Salarie(int matricule, string nom, string prenom) : 
            this(matricule, nom, prenom, 1, 1 , 0f) {}

        //Constructeur qui crée un nouveau salarié à partir des données d'une autre instance
        public Salarie(Salarie salarie)
        {
            this.Matricule = salarie.Matricule;
            this.Categorie = salarie.Categorie;
            this.Service = salarie.Service;
            this.Nom = salarie.Nom;
            this.Prenom = salarie.Prenom;
            this.Salaire = salarie.Salaire;
            _NbSalaries++;
        }        
        
        //Constructeur par défaut
        public Salarie(): this(0, "bidon", "bidon", 1, 1, 0f) {}

        //Destructeur
        ~Salarie()
        {
            Console.WriteLine("Un salarié supprimé");
            _NbSalaries--;
        }

        #endregion

        #region "Methodes"

        public void AfficherSalaire()
        {
            //Console.WriteLine("Le salaire de " + Nom.ToUpper() + " " + Prenom.ToUpper() + " est de " + Salaire);
            Console.WriteLine("Le salaire de {0} {1} est de {2}", this.Nom, this.Prenom, this.Salaire);
               
        }

        public string Identite()
        {
            return  "Matricule= " + this.Matricule + Environment.NewLine + 
                    "Nom = " + this.Nom + Environment.NewLine +
                    "Prénom = " + this.Prenom + Environment.NewLine +    
                    "Service = " + this.Service + Environment.NewLine +
                    "Categorie= " + this.Categorie + Environment.NewLine +
                    "Salaire = " + this.Salaire;
        }

        #endregion
           
    }
}
