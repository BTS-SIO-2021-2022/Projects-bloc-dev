using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon.Personne {
    public class Course {
        private String nom;
        private int distance;
        private ArrayList participants;

        public Course(String n, int d) {
            this.nom = n;
            this.distance = d;
            this.participants = new ArrayList();
        }

        public void addParticipant(Participant p) {
            participants.Add(p);
        }

        public void printAllParticipants() {
            Console.Write("Les participants à la course " + this.getCourseName() + " sont : {");
            String sb = "";
            foreach (Participant p in participants) {
                sb += p.getNom() + "; ";
            }
            sb = sb.Substring(0, (sb.Length - 2));
            Console.WriteLine(sb + "}");
        }

        public int getNumberOfParticipants() {
            return this.participants.Count;
        }

        public String getCourseName() {
            return this.nom;
        }
    }
}
