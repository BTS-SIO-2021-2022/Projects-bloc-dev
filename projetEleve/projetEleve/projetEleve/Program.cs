using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetEleve {
    class Program {
        static void Main(string[] args) {
            Eleve martin = new Eleve("Martin");
            martin.generateNote();

            Eleve luigi = new EleveLV3("Luigi");
            luigi.generateNote();

            Console.WriteLine(martin.displayNote());
            Console.WriteLine(martin.getMoyenne());

            Console.WriteLine(luigi.displayNote());
            Console.WriteLine(luigi.getMoyenne());

            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }
    }
}
