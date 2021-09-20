using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marathon.Atributes;

namespace Marathon.Personne {
    abstract class Coureur {
        private String nom;
        private String prenom;
        private Telephone numero;
        private Genre gender;
        private Boolean handicap = false;

        public Coureur() : this(null, null, null, Genre.NULL) { }
        public Coureur(String n, String p, Telephone t, Genre g) {
            this.nom = n;
            this.prenom = p;
            this.numero = t;
            this.gender = g;
        }

        public void toRegister {
            
        }

        public void courreurHandi() {
            this.handicap = true;
        }

        /* GETTERS */

        public String getNom() {
            return this.nom;
        }

        public String getPrenom() {
            return this.prenom;
        }

        public Telephone getNumero() {
            return this.numero;
        }

        public Genre getGender() {
            return this.gender;
        }

        /* SETTERS*/

        protected void setNom(String n) {
            this.nom = n;
        }

        protected void setPrenom(String p) {
            this.prenom = p;
        }

        protected void setNumero(Telephone t) {
            this.numero = t;
        }

        protected void setGender(Genre g) {
            this.gender = g;
        }

    }
}
