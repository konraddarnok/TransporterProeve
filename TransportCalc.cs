using System;
using System.Transactions;

namespace Opg1StaticMethod
{
    public class TransportCalc
    {
        public static double Average(int antalKm, double antalLiter)
        {
            double result = 0.0;
            if (antalKm > 2000 || antalKm < 0) throw new ArgumentOutOfRangeException();

            result = (antalKm / antalLiter) * 100;

            return result;

        }
        public static int Total(string transporter)
        {
            int result = 0;
            string[] myString = transporter.Split(' ');
            foreach (var s in myString)
            {
                int kørsel = Int32.Parse(s);
                result += kørsel;
            }
            return result;
        }

    }
   
}

//b.Udvid derefter din anden metode Average, så der kastes en passende Exception, hvis antal km falder uden for det tilladte interval: 0 - 2000 (se domænebeskrivelsen). 




//a.Opret flg. static metoder i TransportCalc: 
//•	double Average(int antalKm, double antalLiter)
//Returnerer gennemsnittet ud fra antalKm og antalLiter iht.ovenstående formel.

//•	int Total(string transporter)
//Strengen, transporter, indeholder to eller flere heltal (kilometer) adskilt af mellemrum (space).
//Metoden opdeler først transporter i de enkelte heltal-strings, som så konverteres til heltalsværdier, og derefter returneres summen af tallene.

//b.Giv beskrivende kommentarer til dine metoder.  
//c.Generer en DLL-fil.


//Summen af 5 transporter(km1, km2 …. km5) udregnes ved følgende formel:
//total = km1 + km2 + ……. + km5
//Hvis der f.eks.er tre transporter på hhv. 155, 45 og 150 km er:

//    total = 155 + 245 + 150 = 450 km
//Brændstofforbruget udregnes ved følgende formel:

//    gennemsnit = (antalLiter / antalKm) x 100
//F.eks. for 300 km og et forbrug på 22.5 liter er

//    gennemsnit = (22.7 / 300) x 100 = 7.67 (afrundet)
//For en transport for én lastbil på samme dag gælder: at: 0 < antalKm <= 2000. (kører også i Tyskland!)
