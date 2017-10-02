using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioDemoGit
{
    public class Personne
    {


        //-------------------------------- Déclaration des propriétés de la classe ---------------------

        public string Nom;

        #region Propriétés
        private string Nom;
        private string _Prenom;
        #endregion

        //-------------------------------- Déclaration des Accesseurs et mutateurs ------------------------------------

        #region Accesseurs et mutateurs
        public string GetNom()
        {
            return Nom;
        }

        public void SetNom(string nom4)
        {
            this.Nom = nom4;
        }
        //public string Nom
        //{
        //    get { return _Nom; }
        //    set { _Nom = value; }
        //}
        public string Prenom
        {
            get { return _Prenom; }
            set { _Prenom = value; }
        }
        #endregion

        //-------------------------------- Déclaration des constructeurs-----------------------------------------------

        #region Constructeurs
        public Personne(string nom, string prenom)
        {
            this.SetNom(nom);
            this.Prenom = prenom;
        }
        public Personne() { }

        #endregion

        //-------------------------------- Methodes de classes ----------------------------------------------------------------------

        #region Méthodes de classe
        public string Identite()
        {
            return String.Format("{0} {1}", Nom.ToLower(), Prenom.ToLower());
        }

      
        #endregion

        //-------------------------------- Redéfinition - Override ---------------------------------------------------

        #region Override
        public override bool Equals(object objectiflune)
        {
            if (objectiflune is Personne)
            {
                Personne jesuis = (Personne)objectiflune;
                return Nom == jesuis.Nom && Prenom == jesuis.Prenom;
            }
            else
            {
                return false;
            };
        }

        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }
        #endregion
    }
}
