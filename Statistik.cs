using System;

namespace Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbCnt=0;
            string input;
            int actNum;
            int maxNum=0;
            int sum=0;
            double avg;

            Console.WriteLine("Geben Sie beliebig viele positive Zahlen ein (Abbruch mit Eingabe 0)!");
            do
            {
                //Zahl einlesen
                Console.Write("Zahl Nr. " + (numbCnt + 1) + ":");
                input = Console.ReadLine();
                actNum = Convert.ToInt32(input);
                if (actNum < 0)
                {
                    Console.WriteLine("Ungültige Zahl! (Zahl muss positiv sein!)");
                }
                else if (actNum != 0)
                {
                    //Gültige Zahl eingegeben -> Statistikwerte füllen
                    numbCnt = numbCnt + 1;
                    sum = sum + actNum;
                    if (actNum > maxNum)
                    {
                        maxNum = actNum;
                    }
                }
            } while (actNum != 0);

            //actNum==0 gilt da Schleife beendet

            if (numbCnt == 0)
            {
                Console.WriteLine("Es wurden keine Zahlen eingegeben!");
            }
            else
            {
                avg = Convert.ToDouble(sum) / numbCnt;
                Console.WriteLine("Summe:"+sum);
                Console.WriteLine("Mittelwert:"+avg);
                Console.WriteLine("Größte Zahl:"+maxNum);
            }
        }
    }
}

