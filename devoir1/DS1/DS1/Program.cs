using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DateTime ;


namespace DS1 {
    class Program {

        public class Commande {
            private int idCde ;
            private int numCli ;
        	private DateTime dateCde ;
            private int[] tabProd ;
            private int[] tabQte ;
            private int nbProd ;

        public Commande(int n) {
	        this.idCde = MaxIdCde()+1 ; //ennoncé
	        this.numCli = n ;
	        this.dateCde = SYSDATE() ; //ennoncé
	        this.tabProd = new int[10];
	        this.tabQte = new int[10] ;
	        this.nbProd = 0 ;

            for (int i = 0; i < 10; ++i) {
                this.tabProd[i] = 0;
                this.tabQte[i] = 0;
            }
        }

        public void ajoutProd(int num, int qte) {
            this.tabProd[nbProd] = num;
        	this.tabQte[nbProd] = qte;
        	this.nbProd++;
        }   
        public void supprProd(int num, int qte) {
        	this.tabProd[nbProd] = num;
        	this.tabQte[nbProd] = qte;
        	this.nbProd--;
        
        	for(int i = num; i < 10; ++i) {
        		if(i != 9) {
        			tabQte[i] = tabQte[i+1];
        		}
        	}
        	tabQte[9] = 0;
        }

        public void ValideCde() {
        	//envoi sur SGBD je n'ai pas la DLL
        }

        public Boolean isFull() {
            return !(this.nbProd <= 9);
        }
    }
        static void Main(string[] args) {
            Console.WriteLine("Bonjour, entrez votre numero de client :");
            String su = Console.ReadLine();
            int u = Int32.Parse(su);
            Commande cmd = new Commande(u);

            String input = "input";

            while ((!input.Equals("exit")) && (!cmd.isFull())) {
                Console.WriteLine("Merci de rentrer le numéro de produit :");
                input = Console.ReadLine();
                Console.WriteLine("Merci de rentrer la quantité de produit :");
                input = Console.ReadLine();
                Console.WriteLine("Votre commande a été enregistrée, voulez vous recommencer?");
                input = Console.ReadLine();
                
                if (input.Equals("no") || input.Equals("n") || input.Equals("non")) {
                    input = "exit";
                }
            }


        }
    }
}
