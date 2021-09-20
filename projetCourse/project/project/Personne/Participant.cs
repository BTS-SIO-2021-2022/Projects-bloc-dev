using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marathon.Atributes;

namespace Marathon.Personne {
    class Participant : Coureur {
        private String numeroDossart;
        private int temps;
        private int waterLevel;
        private int foodLevel;
        private String courseName;

        public Participant(Coureur r, String d, int w, int f) : base(r.getNom(), r.getPrenom(), r.getNumero(), r.getGender()) {
            this.numeroDossart = d;
            this.temps = 0;
            this.waterLevel = 100;
            this.foodLevel = 100;
        }

        public void participerCourse(Course c) {
            c.addParticipant(this);
            this.courseName = c.getCourseName();
            Console.WriteLine(this.getNom() + " est inscrit·e à la course ");
        }

        public void CalculterTemps(int duree) {
            this.temps += duree;
        }
    }
}