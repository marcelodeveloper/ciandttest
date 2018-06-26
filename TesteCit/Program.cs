using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCit
{
    class Program
    {
        static void Main(string[] args)
        {
            //dos cupcakes
            Exercicio1();
            //Exercicio2();

            Console.Read();
        }


        static void Exercicio1()
        {
            string[] trips = new string[] { "3", "10 2 5", "12 4 4", "6 2 2" };
            maximumCupcakes(trips);

            //string[] trips2 = new string[] { "3", "10 2 5", "12 4 4", "6 2 2" };
            //maximumCupcakes(trips2);
        }

        #region Exercicio 1

        static void maximumCupcakes(string[] trips)
        {
            int t = int.Parse(trips[0].ToString());
            int n, c, m;

            for (int i = 0; i < t; i++)
            {
                int cupcakes = 0;
                int wrappers = 0;

                n = int.Parse(trips[(i + 1)].ToString().Split(' ')[0]);
                c = int.Parse(trips[(i + 1)].ToString().Split(' ')[1]);
                m = int.Parse(trips[(i + 1)].ToString().Split(' ')[2]);

               if(ConstraintIsValid(t, n, c, m))
                {
                    cupcakes = (n / c);
                    int prizes = 0;
                    wrappers = cupcakes;

                    while((wrappers + 1) > 0)
                    {
                        if(wrappers >= m)
                            prizes += 1;

                        wrappers = ((wrappers + 1) - m);
                    }

                    cupcakes = (cupcakes + prizes);

                    Console.WriteLine("{0}", cupcakes);
                }

            }
        }

        static bool ConstraintIsValid(int t,int n, int c, int m)
        {
            bool validT = (1 <= t && t <= Math.Pow(10, 3));
            bool validN = (2 <= n && n <= Math.Pow(10,5));
            bool validC = (1 <= c && c <= n);
            bool validM = (2 <= m && m <= n);

            return (validT && validN && validC && validM);
        }

        #endregion

        #region Exercicio 2

        static void Exercicio2()
        {
            string[] wheel = new string[] { "137", "256", "134", "125" };
            SpeedWheel(wheel);
        }

        static void SpeedWheel(string[] wheels)
        {
            string[][] matr = new string[wheels.Length][];

            for (int i = 0; i < wheels.Length; i++)
            {
                matr[i] = new string[] { wheels[i].Substring(0, 1), wheels[i].Substring(1, 1), wheels[i].Substring(2, 1) };
            }

            int maiorValor = int.MinValue;

            foreach (var item in matr)
            {
                foreach (var sub in item)
                {
                    if (int.Parse(sub) > maiorValor)
                        maiorValor = int.Parse(sub);

                }
            }
        }

        #endregion

    }
}
