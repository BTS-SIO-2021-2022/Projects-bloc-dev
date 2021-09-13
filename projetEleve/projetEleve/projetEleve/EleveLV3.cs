using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace projetEleve {
    class EleveLV3 : Eleve {
        private ArrayList noteLV3 = new ArrayList();

        public EleveLV3(String n) : base(n) {
            this.generateNoteLV3(2);
        }

        public void generateNoteLV3() {
            generateNoteLV3(10);
        }

        public void addNoteLV3(double n) {
            this.noteLV3.Add(n);
        }

        public void addNoteLV3(ArrayList n) {
            foreach (double e in n) {
                this.addNote(e);
            }
        }

        public void addNoteLV3(double[] t) {
            for (int i = 0; i < t.Length; ++i) {
                this.addNote(t[i]);
            }
        }

        public void generateNoteLV3(int n) {
            for (int i = 0; i < n; ++i) {
                this.noteLV3.Add(base.randomNote());
                Thread.Sleep(10);
            }
        }

        public override String getMoyenne() {
            double r = .0;
            foreach (double e in base.getTabNote()) {
                r += e;
            }

            foreach (double e in this.noteLV3) {
                r += e;
            }

            return "La moyenne de " + base.getName() + " est de " + (r / ((base.getTabNote().Count + this.noteLV3.Count)));
        }

        public override String displayNote() {
            String sb = "Voici les notes de l'élève " + base.getName() + " : {";
            foreach (double e in base.getTabNote()) {
                sb += e + "; ";
            }

            foreach (double e in this.noteLV3) {
                sb += e + "; ";
            }

            sb = sb.Substring(0, (sb.Length - 2));
            return sb + "}";
        }
    }
}
