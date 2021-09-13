using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace projetEleve {
    class Eleve {
        private String nom;
        private ArrayList tabNote = new ArrayList();

        public Eleve(String n) {
            this.nom = n;
            this.generateNote(2);

        }

        public double randomNote() {
            Random rnd = new Random();
            double r = rnd.Next(0, 21);
            return r;
        }

        public void generateNote() {
            generateNote(10);
        }

        public void generateNote(int n) {
            for (int i = 0; i < n; ++i) {
                tabNote.Add(randomNote());
                Thread.Sleep(10);
            }
        }

        public double getNbNote() {
            return this.tabNote.Count;
        }

        public void addNote(double n) {
            this.tabNote.Add(n);
        }

        public void addNote(ArrayList n) {
            foreach (double e in n) {
                this.addNote(e);
            }
        }

        public void addNote(double[] t) {
            for (int i = 0; i < t.Length; ++i) {
                this.addNote(t[i]);
            }
        }

        public virtual String getMoyenne() {
            double r = .0;
            foreach (double e in this.tabNote) {
                r += e;
            }
            return "La moyenne de " + nom + " est de " + (r/this.tabNote.Count);
        }

        public virtual String displayNote() {
            String sb = "Voici les notes de l'élève " + nom + " : {";
            foreach (double e in tabNote) {
                sb += e + "; ";
            }
            sb = sb.Substring(0, (sb.Length - 2));
            return sb + "}";
        }

        public String getName() {
            return this.nom;
        }

        public ArrayList getTabNote() {
            return this.tabNote;
        }
    }
}
