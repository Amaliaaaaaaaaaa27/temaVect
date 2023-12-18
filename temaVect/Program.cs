using System;
using System.Security.Claims;

//1.Gigel are un cos cu bile (in prob nu explica daca ele sunt grupate) de 3  culori diferite : rosii, verzi si galbene,
//insa acesta se gandeste cum ar putea sa le grupeze invers dupa culori astfel incat sa obttina in cosul lui urmatoarea
//ordine : galbene, verzi si rosii, realizati un program ce il poate ajuta pe Gigel sa ordoneze eficient aceste bile din cos. 

//2. Marius are un cos cu fructe : banane, portocale si mere. Merele sunt numerotate cu  m a cate 4, portocale p a cate 7 si banane b a cate 8.
//Ajutal pe Marius sa isi determine algoritmul prin care ar putea sa ordoneze fructele in functie de numarul cantitatii indicate.

//3.Gigel afla de la prietenul sau cel mai bun Marius, ca in zona Peninsulei Resort exista niste suveniruri pretioase depozitate in fuctie de o pozitie unica pe diferite rafturi, ceea ce acasta ocazie ii poate deschide usa catre imbogatire. Acesta se gandeste ca daca ar colecta
//cate un suvenir specific pozitiei ar ajunge  posibil la n suveniruri colectate astfel ajugand la dependenta finananciara. Ajutal pe Gigel sa realizeze un program ce va fi capabil sa faca suma tuturot suvenirilor colectate de pe fiecare pozitie in parte.


//using System;
//using System.Globalization;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string[] bileRosii = { "bilaRosie1", "bilaRosie2", "bilaRosie3" };

//        string text = "Bilele rosii din cos sunt: ";
//        Console.WriteLine(text);

//        for (int i = 0; i < bileRosii.Length; i++)
//        {
//            Console.WriteLine(bileRosii[i]);
//        }

//        string[] bileVerzi = { "bilaVerzi1", "bilaVerzi2", "bilaVerzi3" };

//        for (int j = 0; j < bileVerzi.Length; j++)
//        {
//            Console.WriteLine(bileVerzi[j]);
//        }

//        string[] bileGalb = { "bilaGalb1", "bilaGalb2", "bilaGalb3" };

//        for (int l = 0; l < bileGalb.Length; l++)
//        {
//            Console.WriteLine(bileGalb[l]);
//        }


//        string[,] cosBile = { { "bilaRosie1", "bilaRosie2", "bilaRosie3"},
//                              {"bilaVerzi1","bilaVerzi2","bilaVerzi3"},
//                              {"bilaGalb1","bilaGalb2", "bilaGalb3"} };

//        string text3 = "toate bilele din cos sunt :";
//        Console.WriteLine(text3);

//        foreach (string k in cosBile)
//        {
//            Console.WriteLine(k);
//        }
//        //GetLength(0) se referă la dimensiunea 0 a matricei, adică numărul de rânduri.
//        //GetLength(1) se referă la dimensiunea 1 a matricei, adică numărul de coloane.

//        for (int w = cosBile.GetLength(0) - 1; w >= 0; w--)
//        {
//            for (int z = cosBile.GetLength(1) - 1; z >= 0; z--)
//            {
//                Console.Write(cosBile[w, z] + " ");
//            }
//            Console.WriteLine();

//        }
//    }
//}


//2. Marius are un cos cu fructe : banane, portocale si mere. Merele sunt numerotate cu  m a cate 4, portocale p a cate 7 si banane b a cate 8.
//Ajutal pe Marius sa isi determine algoritmul prin care ar putea sa ordoneze fructele in functie de numarul cantitatii indicate.

//using System;
//using System.Numerics;

//class Program
//{
//    static void Main(string[] args)
//{
//        int[] cantitatiFructeDinCos = { 7, 4, 8 };


//        for(int i = 0; i < cantitatiFructeDinCos.Length;i++)
//        {
//            for(int j = i + 1; j < cantitatiFructeDinCos.Length; j++)
//            {
//                if (cantitatiFructeDinCos[i] > cantitatiFructeDinCos[j])
//                { 
//                    int varInt = cantitatiFructeDinCos[i];
//                    cantitatiFructeDinCos[i] = cantitatiFructeDinCos[j];
//                    cantitatiFructeDinCos[j] = varInt;
//                }
//            }
//        }
//        foreach(int x in cantitatiFructeDinCos)
//        {
//            Console.WriteLine(x);
//        }

//    }

//}

//3.Gigel afla de la prietenul sau cel mai bun Marius,ca in zona Peninsulei Resort exista niste suveniruri pretioase depozitate in fuctie
//de o pozitie unica pe diferite rafturi, ceea ce acasta ocazie ii poate deschide usa catre imbogatire. Acesta se gandeste ca daca ar
//colecta
//cate un suvenir specific pozitiei ar ajunge  posibil la n suveniruri colectate astfel ajugand la dependenta finananciara.
//Ajutal pe Gigel sa realizeze un program ce va fi capabil sa faca suma tuturot suvenirilor colectate de pe fiecare pozitie in parte.


//GetLength(0) se referă la dimensiunea 0 a matricei, adică numărul de rânduri.
//GetLength(1) se referă la dimensiunea 1 a matricei, adică numărul de coloane.
//
//         
//

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Programl
{
    static void Main(string[] args)
    {
        string[,] rafturi = { { "suvenirR1", "suvenirR1", "suvenirR1" },
                               { "suvenirR2", "suvenirR2", "suvenirR2" },
                               { "suvenirR3", "suvenirR3", "suvenirR3" } };

        PrezentareaSuvenirilor(rafturi);
        Console.WriteLine("Selectati un suvenir de pe primul raft");
        string alegereClientPrimulRaft = Console.ReadLine();
        Console.WriteLine(SelectareSuvenir(rafturi, alegereClientPrimulRaft));

        Console.WriteLine("Selectati un suvenir de pe al doilea raft");

        string alegereClientAlDoileaRaft = Console.ReadLine();
        Console.WriteLine(SelectareSuvenir(rafturi, alegereClientAlDoileaRaft));

    }
    static void PrezentareaSuvenirilor(string[,] rafturi)
    {

        Console.WriteLine("Toate suvenirurile sunt =  ");

        for (int i = 0; i < rafturi.GetLength(0); i++)
        {
            for (int j = 0; j < rafturi.GetLength(1); j++)
            {
                Console.WriteLine($"Raftul [{i} ,{j}] = {rafturi[i, j]}");
            }
            Console.WriteLine();
        }
    }
    static string SelectareSuvenir(string[,] rafturi, string alegereClientPrimulRaft)
    {

        for (int i = 0; i < rafturi.GetLength(0); i++)
        {
            for (int j = 0; j < rafturi.GetLength(1); j++)
            {
                if (rafturi[i, j] == alegereClientPrimulRaft)
                {
                    return $"ai selectat de pe raftul {i} suvenirul {alegereClientPrimulRaft} ";
                }
            }
            Console.WriteLine();
        }
        return $"nu ati luat suvenir de pe raft ";
    }
}


//1.Într - o clasă de elevi se află 36 de bănci și scaune, Gigel vrea să determine catet picioare sunt in total la fiecare dintre ele 
//știind că în clasă sunt x bănci și x scaune. Ajută-l pe Gigel să calculeze numărul de picioare aferente x băncilor și y scaune.


//2.O pisică a ieșit la vânătoare, pisica văzând un șoricel se grăbește repede înainte să îl vâneze, asta până când pisica constantă în
//momentul vânării că a intrat într-un spațiu mai puțin accesibil pentru ele, un loc unde șoriceii se ascund.
//Acea dimensiune are următoarele caracteristici: 36 cm înălțime, 18  cm lățime, 21cm lungime. Pisica se afla in punctul O,
//coordonate (0, 0) însă șoricelul între coordonatele : (5, 8)lățime.Pisica trebuie să își calculeze distanța  , 
//poziția și perimetrul x până la poziția y unde se afla șoricelul pentru al putea vâna, ajută pisica să vâneze șoricelul mult
//așteptat.



//using System;
//using System.Security.Cryptography.X509Certificates;


//class Program
//{ static void Main(string[] args)
//    {
//        int pointX1 = 0, pointX2 = 0;
//        int pointY1 = 5, pointY2 = 8;

//        int latime = 18;
//        int lungime = 21;

//        double rezultat = CalculareDistanta(pointX1,pointY1,pointX2,pointY2);
//        Console.WriteLine(rezultat);

//        int perimetru = CalculPerimetru(latime, lungime);
//        Console.WriteLine(perimetru);
//    }
//    static double CalculareDistanta(int pointX1, int pointY1, int pointX2, int pointY2)
//    {
//        return Math.Sqrt((pointX2 - pointX1) ^ 2 + (pointY2 - pointY1) ^ 2);
//    }
//    static int CalculPerimetru(int latime, int lungime)
//    {
//        return 2 * (latime + lungime);
//    }
//}

    
   
