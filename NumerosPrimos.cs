
class NumerosPrimos
    {
        public string CalculaPrimos(int primoInicial,int primoFinal) {

            int contadorPrimo;
            string primos = "";

            // calculo de numeros primos
            for (int i = primoInicial; i <= primoFinal; i++)
            {
                // el calculo de numeros primos no aplica para el numero 1
                if (i != 1)
                {
                    contadorPrimo = 0;

                    // inicia desde 1 y divide los valores hasta llegar al numero
                    for (int j = 1; j <= i; j++)
                    {
                        // realiza los calculos correspondientes para determinar si el numero es primo o no
                        if (i % j == 0)
                        {
                            contadorPrimo++;
                        }
                    }

                    // determinamos si el numero es primo, los numeros primos solo son divisibles entre 1 y entre su
                    // mismo numero, en el contador almacenamos la cantidad de veces que puede ser dividido el numero.
                    // (si el numero de veces divisible es igual a dos es primo)

                    if (contadorPrimo == 2)
                    {
                        if (primos.Length == 0)
                        {
                            primos = i.ToString();
                        }
                        else
                        {
                            primos += "," + i.ToString();
                        }
                    }
                }
            }
         return primos;
        }
    }