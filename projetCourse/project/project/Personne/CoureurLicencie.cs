using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marathon.Atributes;


namespace Marathon.Personne {
    class CoureurLicencie : Coureur {
        private String licenseNumber;

        public CoureurLicencie(String n, String p, Telephone t, Genre g, String l) : base(n, p, t, g) {
            this.licenseNumber = l;
        }
    }
}
