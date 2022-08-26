using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_e_media
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, l1, lado2, opcao, opcao2,
                b1, a1, a2, bM, bm, resultado;

            do
            {
                Console.WriteLine("SELECIONE UMA OPÇÃO");
                Console.WriteLine("1- CALCULAR MÉDIA");
                Console.WriteLine("2-CALCULAR AREA ");
                Console.WriteLine("0-SAIR");

                opcao = Convert.ToDouble(Console.ReadLine()); 

                if (opcao == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Insira o primeiro valor");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Insira o segundo valor");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    resultado = n1 + n2 / 2;
                    Console.WriteLine("A média é:" + resultado);
                    Console.ReadKey();
                }
                else if (opcao == 2)
                {
                    Console.Clear();
                    Console.WriteLine("SELECIONE UMA OPÇÃO:");
                    Console.WriteLine("1-TRIANGULO");
                    Console.WriteLine("2-QUADRILATERO");
                    Console.WriteLine("3-TRAPÉZIO");
                    Console.WriteLine("0-SAIR");
                    Console.ReadKey();
                    opcao2 = Convert.ToDouble(Console.ReadLine());

                    do
                    {
                        if (opcao == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("insira a altura");
                            a1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("insira a base");
                            b1 = Convert.ToDouble(Console.ReadLine());

                            resultado = a1 * b1 / 2;
                            Console.WriteLine("a aréa do triangulo é:" + resultado);
                            Console.ReadKey();
                        }
                        else if (opcao == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("insira o lado 1");
                            l1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("insira o lado 2");
                            lado2 = Convert.ToDouble(Console.ReadLine());

                            resultado = l1 * lado2;
                            Console.WriteLine("a aréa do quadrilátero é:" + resultado);
                            Console.ReadKey();
                        }
                        else if (opcao == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("insira a base maior");
                            bM = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("insira a base menor");
                            bm = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("insira a altura");
                            a2 = Convert.ToDouble(Console.ReadLine());
                            resultado = bM + bm * a2 / 2;
                            Console.WriteLine("a aréa do trapézio é:" + resultado);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("saindo");
                            Console.ReadKey();
                        }

                    } while (opcao != 0);
                }

                else if (opcao == 0)
                {
                    Console.WriteLine("Encerrando o programa...");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("VOCE INSERIU UM VALOR INVÁLIDO");
                    Console.ReadKey();
                }

            }


            while (opcao != 0);
            Console.ReadKey();
        }
    }
}
