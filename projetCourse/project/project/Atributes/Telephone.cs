using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon.Atributes {
    class Telephone {

        private String indicatif;
        private String numero;

        public Telephone(String i, String n) {
            this.indicatif = i;    
            this.numero = n;
        }
    }
}
