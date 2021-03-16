using System;
namespace DecouverteLangage
{
    public class Employe : Personne
    {
        public double Salaire { get; set; }

        public Employe(string nom, string prenom, DateTime dateNaissance, double salaire)
            : base(nom, prenom, dateNaissance)
        {
            Salaire = salaire;
        }

        public override string Afficher()
        {
            return base.Afficher() + " Salaire: " + Salaire;
        }

        public override object Clone()
        {
            return new Employe(Nom, Prenom, DateNaissance, Salaire);
        }
    }
}
