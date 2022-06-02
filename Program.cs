using System;

namespace Ejercicios_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Hacer un programa para ingresar 10 números.El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            Console.WriteLine("Hacer un programa para ingresar 10 números.El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos");


            int n, conPrimos, primos = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingresar un numero : ");
                n = int.Parse(Console.ReadLine());

                conPrimos = 0;

               for (int y = 1; y <= n; y++)

                {
                    if (n % y == 0)
                    {
                        conPrimos++;
                    }
                }

               if (conPrimos == 2)

                    {
                         primos++;
                    }
            }

            Console.WriteLine("La cantidad de primos son : " + primos);


            // 2.Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar.
            // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            Console.WriteLine("2.Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar");
            Console.WriteLine("El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo");
            Console.WriteLine("Informar cuántos grupos están formados por todos números ordenados de mayor a menor.");



            int num, conteoImpares, conteoNumeros ,  grupo = 0, min, numerosOrdenados=0;
            float porcentaje , mayorPorcentaje = -1;
            bool ordenados;

            for (int x = 0; x < 3; x++)
            {
                
                Console.WriteLine("Ingresar un numero : ");
                num = int.Parse(Console.ReadLine());
                min = num;

                ordenados = true;          
                conteoImpares = 0;
                conteoNumeros = 0;
                

                    while (num != 0)

                    {
                       conteoNumeros++;

                    if (num % 2 != 0)
                        {
                        conteoImpares ++;


                        if (num <= min)
                        {
                            min = num;
                        }
                        else ordenados = false;

                    }



                    Console.WriteLine("Ingresar otro numero : ");
                    num = int.Parse(Console.ReadLine());

                    }

                porcentaje = (conteoImpares * 100f) / conteoNumeros;

                if (porcentaje > mayorPorcentaje)
                {
                    mayorPorcentaje = porcentaje ;
                    grupo = x + 1;
                }

                if (ordenados)
                {
                    numerosOrdenados++;
                }

            }

            Console.WriteLine("El grupo con mayor porcentaje es : " + grupo);
            Console.WriteLine("La cantidad de grupos ordenados son : " + numerosOrdenados);




            // 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la 
            // carga se notifica con un número negativo.Luego mostrar cuántos números tiene cada lista.

            Console.WriteLine("3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo ");
            Console.WriteLine("Luego mostrar cuántos números tiene cada lista.");


            int numero, con, grupote = 0 ;


            do
            {   
                Console.WriteLine("Ingresar un numero : ");
                numero = int.Parse(Console.ReadLine());
                con = 0;
              

                while (numero>0)
                {

                    con++;

                    Console.WriteLine("Ingresar otro numero : ");
                    numero = int.Parse(Console.ReadLine());

                }

                grupote++;

                Console.WriteLine("El grupo" + grupote + "tiene" + con);

            } while (numero>=0);



        }
    }
}
