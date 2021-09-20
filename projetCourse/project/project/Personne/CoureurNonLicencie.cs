using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marathon.Atributes;

namespace Marathon.Personne {
    class CoureurNonLicencie : Coureur {

        private Boolean certificatMedicalValide;

        public CoureurNonLicencie(String n, String p, Telephone t, Genre g, Boolean c) : base(n, p, t, g) {
            this.certificatMedicalValide = c;
        }

        public Boolean isCertificatValid() {
            return this.certificatMedicalValide;
        }


    }
}
