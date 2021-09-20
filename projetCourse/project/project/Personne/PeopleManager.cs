using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marathon.Atributes;

namespace Marathon.Personne {
    class PeopleManager {

        public Telephone buildNumber(String i, String n) {
            if (isNumberValid(n)) {
                return new Telephone(i, n);
            } else {
                return null;
            }
        }

        private static Boolean isNumberValid(String n) {
            return ((n.Length.Equals(10) && (n[0].Equals('0'))));
        }
    }
}
