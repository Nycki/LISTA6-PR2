using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("-----MENU-----");
            Console.WriteLine("1- EXERCÍCIO 1");
            Console.WriteLine("2- EXERCÍCIO 2");
            Console.WriteLine("3- EXERCÍCIO 3");
            Console.WriteLine("4- EXERCÍCIO 4");
            Console.WriteLine("5- EXERCÍCIO 5");
            Console.WriteLine("6- EXERCÍCIO 6");
            Console.WriteLine("7- EXERCÍCIO 7");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    double compraT = 0, valorT = 0, item = 1, valor;
                    for (int i = 0; ; i++)
                    {
                        Console.WriteLine("quantos produtos?");
                        item = double.Parse(Console.ReadLine());
                        if (item <= 0)
                        {
                            break;
                        }

                        Console.WriteLine("qual o valor do produto?");
                        valor = double.Parse(Console.ReadLine());

                        valorT = (valor * item) + valorT;
                        compraT = item + compraT;


                    }
                    Console.WriteLine("valor total " + compraT);
                    Console.WriteLine("quantidade de itens " + valorT);

                    break;
                case 2:
                    string nome, nmenor = "", nmaior = "";
                    int numItens, parada = 1;
                    float preco, menor, maior, total;

                    menor = float.MaxValue;
                    maior = float.MinValue;

                    for (; parada != 0;)//infinito
                    {
                        Console.WriteLine("Nome do produto: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Número de itens: ");
                        numItens = int.Parse(Console.ReadLine());
                        Console.WriteLine("Preço unitário: ");
                        preco = float.Parse(Console.ReadLine());

                        total = numItens * preco;

                        if (total > maior)
                        {
                            maior = total;
                            nmaior = nome;
                        }

                        if (total < menor)
                        {
                            menor = total;
                            nmenor = nome;
                        }

                        Console.WriteLine("digite 0 para SAIR ou 1 para continuar");
                        parada = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("maior quantia investida {0} no profuto {1}" + maior + menor);
                    Console.WriteLine("menor quantia investida {0} no profuto {1}" + nmaior + nmenor);

                    Console.ReadKey();
                    break;
                case 3:

                    float pesos, tpesos = 0;
                    Console.WriteLine("Digite a quantidade de avaliaçoes que voce fará:");
                    int quantavali = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= quantavali; i++)
                    {
                        Console.WriteLine("Digite os pesos das notas {i}:");
                        pesos = float.Parse(Console.ReadLine());
                        tpesos += pesos;
                    }
                    Console.WriteLine("a soma dos pesos é: " + tpesos);
                    if (tpesos < 100)
                        Console.WriteLine("Pesos insuficientes");

                    else if (tpesos > 100)
                        Console.WriteLine("superior a 100% alcansada");


                    else
                    {
                        Console.WriteLine("porcentagem de 100% alcansada");
                    }
                    Console.ReadKey();

                    break;
                case 4:
                    int es;
                    Console.WriteLine("ESCOLHA A SIGLA DO ESTADO: ");
                    Console.WriteLine("1-AC");
                    Console.WriteLine("2-AL");
                    Console.WriteLine("3-AP");
                    Console.WriteLine("4-AM");
                    Console.WriteLine("5-BA");
                    Console.WriteLine("6-CE");
                    Console.WriteLine("7-DF");
                    Console.WriteLine("8-ES");
                    Console.WriteLine("9-GO");
                    Console.WriteLine("10-MA");
                    Console.WriteLine("11-MT");
                    Console.WriteLine("12-MS");
                    Console.WriteLine("13-MG");
                    Console.WriteLine("14-PA");
                    Console.WriteLine("15-PB");
                    Console.WriteLine("16-PR");
                    Console.WriteLine("17-PB");
                    Console.WriteLine("18-PI");
                    Console.WriteLine("19-RJ");
                    Console.WriteLine("20-RN");
                    Console.WriteLine("21-RS");
                    Console.WriteLine("22-RO");
                    Console.WriteLine("23-RR");
                    Console.WriteLine("24-SC");
                    Console.WriteLine("25-SP");
                    Console.WriteLine("26-SE");
                    Console.WriteLine("27-TO");
                    es = int.Parse(Console.ReadLine());
                    switch (es)
                    {
                        case 1:
                            Console.WriteLine("ACRE");
                            break;
                        case 2:
                            Console.WriteLine("ALAGOAS");
                            break;
                        case 3:
                            Console.WriteLine("AMAPÁ");
                            break;
                        case 4:
                            Console.WriteLine("AMAZONAS");
                            break;
                        case 5:
                            Console.WriteLine("BAHIA");
                            break;
                        case 6:
                            Console.WriteLine("CEARA");
                            break;
                        case 7:
                            Console.WriteLine("DISTRITO FEDERAL");
                            break;
                        case 8:
                            Console.WriteLine("ESPIRITO SANTO");
                            break;
                        case 9:
                            Console.WriteLine("GOIAS");
                            break;
                        case 10:
                            Console.WriteLine("MARANHÃO");
                            break;
                        case 11:
                            Console.WriteLine("MATO GROSSO");
                            break;
                        case 12:
                            Console.WriteLine("MATO GROSSO DO SUL");
                            break;
                        case 13:
                            Console.WriteLine("MINAS GERAIS");
                            break;
                        case 14:
                            Console.WriteLine("PARA");
                            break;
                        case 15:
                            Console.WriteLine("PARAIBA");
                            break;
                        case 16:
                            Console.WriteLine("PARANA");
                            break;
                        case 17:
                            Console.WriteLine("PERNAMBUCO");
                            break;
                        case 18:
                            Console.WriteLine("PIAUI");
                            break;
                        case 19:
                            Console.WriteLine("RIO DE JANEIRO");
                            break;
                        case 20:
                            Console.WriteLine("RIO GRANDE DO NORTE");
                            break;
                        case 21:
                            Console.WriteLine("RIO GRANDE DO SUL");
                            break;
                        case 22:
                            Console.WriteLine("RONDONIA");
                            break;
                        case 23:
                            Console.WriteLine("RORAIMA");
                            break;
                        case 24:
                            Console.WriteLine("SANTA CATARINA");
                            break;
                        case 25:
                            Console.WriteLine("SAO PAULO");
                            break;
                        case 26:
                            Console.WriteLine("SERGIPE");
                            break;
                        case 27:
                            Console.WriteLine("TOCANTINS");
                            break;
                        default:
                            Console.WriteLine("NÃO EXISTE ESSE ESTADO NO BRASIL");
                            break;

                    }

                    Console.ReadKey();

                    break;
                case 5:
                    int esc;
                    Console.WriteLine("ESCOLHA O MÊS: ");
                    Console.WriteLine("1- JANEIRO");
                    Console.WriteLine("2- FEVEREIRO");
                    Console.WriteLine("3- MARÇO");
                    Console.WriteLine("4- ABRIL");
                    Console.WriteLine("5- MAIO");
                    Console.WriteLine("6- JUNHO");
                    Console.WriteLine("7- JULHO");
                    Console.WriteLine("8- AGOSTO");
                    Console.WriteLine("9- SETEMBRO");
                    Console.WriteLine("10- OUTUBRO");
                    Console.WriteLine("11- NOVEMBRO");
                    Console.WriteLine("12- DEZEMBRO");
                    esc = int.Parse(Console.ReadLine());
                    switch (esc)
                    {
                        case 1:
                            Console.WriteLine("JANEIRO-VERÃO");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.WriteLine("FEVEREIRO-VERÃO");
                            Console.ReadKey();
                            break;
                        case 3:
                            int dia;
                            Console.WriteLine("Qual dia de Março? ");
                            dia = int.Parse(Console.ReadLine());

                            if (dia >= 20)
                            {
                                Console.WriteLine("MARÇO-OUTONO");
                            }
                            else
                            {
                                Console.WriteLine("MARÇO-VERÃO");
                            }
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("ABRIL-OUTONO");
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.WriteLine("MAIO-OUTONO");
                            Console.ReadKey();
                            break;
                        case 6:
                            int day;

                            Console.WriteLine("Qual dia de junho?");
                            day = int.Parse(Console.ReadLine());
                            if (day >= 21)
                            {
                                Console.WriteLine("JUNHO-INVERNO");
                            }
                            else
                            {
                                Console.WriteLine("JUNHO-OUTONO");
                            }
                            Console.ReadKey();
                            break;
                        case 7:
                            Console.WriteLine("JULHO-INVERNO");
                            Console.ReadKey();
                            break;
                        case 8:
                            Console.WriteLine("AGOSTO-INVERNO");
                            Console.ReadKey();
                            break;
                        case 9:
                            int iad;
                            Console.WriteLine("Qual dia de setembro?");
                            iad = int.Parse(Console.ReadLine());
                            if (iad >= 23)
                            {
                                Console.WriteLine("SETEMBRO-PRIMAVERA");
                            }
                            else
                            {
                                Console.WriteLine("SETEMBRO-INVERNO");
                            }
                            Console.ReadKey();
                            break;
                        case 10:
                            Console.WriteLine("OUTUBRO-PRIMAVERA");
                            Console.ReadKey();
                            break;
                        case 11:
                            Console.WriteLine("NOVEMBRO-PRIMAVERA");
                            Console.ReadKey();
                            break;
                        case 12:
                            int aid;
                            Console.WriteLine("Qual dia de dezembro");
                            aid = int.Parse(Console.ReadLine());
                            if (aid >= 22)
                            {
                                Console.WriteLine("DEZEMBRO-VERÃO");
                            }
                            else
                            {
                                Console.WriteLine("DEZEMBRO-PRIMAVERA");
                            }
                            Console.ReadKey();
                            break;
                    }

                    break;
                case 6:
                    float peso, altura, imc;
                    Console.WriteLine("diga sua altura:");
                    altura = float.Parse(Console.ReadLine());
                    Console.WriteLine("diga o seu peso:");
                    peso = float.Parse(Console.ReadLine());
                    imc = peso / (altura * altura);

                    if (imc < 18.5)
                        Console.WriteLine("esta abaixo do peso");
                    else if (imc > 18.5 && imc < 34.90)
                        Console.WriteLine("Peso normal");
                    else if (imc > 25.0 && imc < 29.9)
                        Console.WriteLine("Sobrepeso");
                    else if (imc > 30.0 && imc < 34.9)
                        Console.WriteLine("obesidade grau 1");
                    else if (imc > 35.0 && imc < 39.9)
                        Console.WriteLine("obesidade de grau 2");
                    else
                        Console.WriteLine("Obesidade de grau 3(morbita)");

                    break;
                case 7:
                    int numero;
                    Console.WriteLine("digite um numero maior que zero:");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Divisores de " + numero + ":");

                    for (int i = 1; i <= numero; i++)
                    {
                        if (numero % i == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }


                    break;
                default:
                    Console.WriteLine("não existe esse exrcicio");
                    break;
            }


        }
    }
}