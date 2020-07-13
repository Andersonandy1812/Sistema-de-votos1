using System;

namespace Sistema_d_votos_automatico
{
    class Program
    {
        static void Main(string[] args)
        {
            menuprincipal();
        }
        private static void menuprincipal()
        {
            int[] nrandom = new int[1000];
            string[] partidos = new string[4];
            partidos[0] = "PDC";
            partidos[1] = "PDC";
            partidos[2] = "PMM";
            partidos[3] = "PDL";
            string[] fechafundacion = new string[4];
            fechafundacion[0] = "21/01/2000";
            fechafundacion[1] = "13/07/1990";
            fechafundacion[2] = "2/03/1999";
            fechafundacion[3] = "26/12/1953";
            string[] nombre = new string[4];
            nombre[0] = "Partido De corrupccion";
            nombre[1] = "Partido Dominicano Chopotown";
            nombre[2] = "Partido Miguel Moreta";
            nombre[3] = "Partido Del Lider(leonel Fernandez Reyna)";
            string[] candidatos = new string[4];
            candidatos[0] = "Dionicio Lopez(Precidente)";
            candidatos[0] = "Wawawa Mayor(Precidente)";
            candidatos[0] = "Miguel Moreta(Precidente)";
            candidatos[0] = "Leonel Fernandez Reyna(Precidente)";
            Console.WriteLine("#####################################");
            Console.Write("#");
            Console.Write("Bienvenido al sistema de votaciones");
            Console.WriteLine("#");
            Console.WriteLine("#####################################");
            Console.WriteLine("\n\n\nMenu principal: Elija la opcion deseada.\n");
            Console.WriteLine("1- Ver partidos\n2-resultados");
            int respuesta = Convert.ToInt32(Console.ReadLine());
            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Estos son los partidos eliga el numero del que desea ver:");
                    for (int i = 1; i < partidos.Length; i++)
                    {
                        string elementosp = partidos[i];
                        Console.WriteLine(i + "-" + elementosp);
                    }
                    int R2 = Convert.ToInt32(Console.ReadLine());
                    switch (R2)
                    {
                        case 1:
                            Console.WriteLine("Estas son las caraccteristicas del: " + partidos[0]);
                            Console.WriteLine("Fecha de inicio: " + fechafundacion[0]);
                            Console.WriteLine("Nombre de partido: " + nombre[0]);
                            Console.WriteLine("Nombre del candidato: " + candidatos[0]);
                            break;
                        case 2:
                            Console.WriteLine("Estas son las caraccteristicas del: " + partidos[1]);
                            Console.WriteLine("Fecha de inicio: " + fechafundacion[1]);
                            Console.WriteLine("Nombre de partido: " + nombre[1]);
                            Console.WriteLine("Nombre del candidato: " + candidatos[1]);
                            break;
                        case 3:
                            Console.WriteLine("Estas son las caraccteristicas del: " + partidos[2]);
                            Console.WriteLine("Fecha de inicio: " + fechafundacion[2]);
                            Console.WriteLine("Nombre de partido: " + nombre[2]);
                            Console.WriteLine("Nombre del candidato: " + candidatos[2]);
                            break;
                        case 4:
                            Console.WriteLine("Estas son las caraccteristicas del: " + partidos[3]);
                            Console.WriteLine("Fecha de inicio: " + fechafundacion[3]);
                            Console.WriteLine("Nombre de partido: " + nombre[3]);
                            Console.WriteLine("Nombre del candidato: " + candidatos[3]);
                            break;
                    }
                    break;
                case 2:

                    break;
                case 3:
                    for (int i = 0; i < nrandom.Length; i++)
                    {
                        Random aleatory = new Random();
                        nrandom[i] = aleatory.Next(1, 5);
                        Console.ReadKey();
                    }

                    break;
            }
        }
    }
}
