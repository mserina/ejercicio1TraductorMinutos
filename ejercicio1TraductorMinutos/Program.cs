namespace Ejercicio1TraductorMinutos
{
    class Program
    {

        static void Main(String[] args) 
        {
            int totalMinutos;
            int dias;
            int horas;
            int minutos;
            int minutosHora = 60;
            int jornadaHora = 8;
          //Se introduce el número de minutos trabajados por un empleado en un mes
            Console.WriteLine("Inserte el nº de minutos que un empleado trabaja por mes");
            totalMinutos = Convert.ToInt32(Console.ReadLine());

            //Traducir minutos en dia, horas y minutos
            //DIAS
              dias = totalMinutos / (minutosHora * jornadaHora);

            //HORAS
              horas = (totalMinutos / minutosHora) % jornadaHora;

            //MINUTOS
              minutos = totalMinutos % minutosHora;

            //Resultado

            //filtro del 0
            if (dias > 0)   
            {
                if (horas > 0)
                {
                    if (minutos > 0)
                    {
                        Console.WriteLine(totalMinutos + " minutos con: " + dias + " Dias " + horas + " Horas" + " y " + minutos + " Minutos");
                    }
                    else
                    {
                        Console.WriteLine(totalMinutos + " minutos con: " + dias + " Dias " + " y " + horas +" Horas");

                    }
                }
                else
                {
                    if (minutos > 0)
                    {
                        Console.WriteLine(totalMinutos + " minutos con: " + dias + " Dias " + " y " + minutos + " Minutos");
                    }
                    else
                    {
                        Console.WriteLine(totalMinutos + " minutos con: " + dias + " Dias ");
                    }
                }
            }
            else
            {
                if (horas > 0)
                {
                    if (minutos > 0)
                    {
                        Console.WriteLine(totalMinutos + " minutos con: " + horas + " Horas" + " y " + minutos + " Minutos");
                    }
                    else
                    {
                        Console.WriteLine(totalMinutos + " minutos con: " + horas + " Horas");
                    }
                }
                else
                {
                    Console.WriteLine(totalMinutos + " minutos con: " + minutos + " Minutos");
                }
            }

            //filtro plural o singular
            if (dias > 1)
            {
                if (horas > 1)
                {
                    if (minutos > 1)
                    {
                        Console.WriteLine(totalMinutos + " minutos con: " + dias + " Dias " + horas + " Horas" + " y " + minutos + " Minutos");
                    }
                    else
                    {
                        Console.WriteLine(totalMinutos + " minutos con: " + dias + " Dias " + horas + " Horas" + " y " + minutos + " Minuto");

                    }
                }
                else
                {
                    if (minutos > 1)
                    {
                        Console.WriteLine(totalMinutos + " minutos con: " + dias + " Dias " + horas + " Hora" + " y " + minutos + " Minutos");
                    }
                }
            }
            else
            {
                if (horas > 1)
                {
                    if (minutos > 1)
                    {
                        Console.WriteLine(totalMinutos + " minutos con: " + dias + " Dia " + horas + " Horas" + " y " + minutos + " Minutos");
                    }
                }
            }
              
             

        }
    }
}