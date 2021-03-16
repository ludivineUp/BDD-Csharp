using System;
using System.Linq;
namespace DecouverteLangage
{
    public class Personne : ICloneable, ITravailleur
    {
        public static string Test { get; set; } = "TEST";

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        public Personne()
        {
        }

        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public virtual void Inverser()
        {
            Prenom = new String(Prenom.Reverse().ToArray());
        }

        public virtual string Afficher()
        {
            return string.Format("Nom: {0}, Prénom: {1}, Date de naissance: {2}", Nom, Prenom, DateNaissance.ToShortDateString());
        }

        public override string ToString()
        {
            return $"Nom: {Nom}, Prénom: {Prenom}, Date de naissance: {DateNaissance.ToShortDateString()}";
        }

        public virtual object Clone()
        {
            return new Personne(Nom, Prenom, DateNaissance);
        }
    }
}
