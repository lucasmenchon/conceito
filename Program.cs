using System;

namespace alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string opUser = OpUser();
            Aluno[] alunos = new Aluno[2];
            var q = 0;


            while (opUser.ToUpper() != "X")
            {

                switch (opUser)
                {
                    case "1":
                        var aluno = new Aluno();
                        Console.WriteLine("");
                        Console.WriteLine("Informe o nome do aluno:");
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Informe a nota do aluno:");
                        //aluno.Nota = int.Parse(Console.ReadLine());
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal.");
                        }

                        alunos[q] = aluno;
                        q++;

                        break;

                    case "2":
                        foreach (Aluno x in alunos)
                        {
                            if (!string.IsNullOrEmpty(x.Nome))
                            {
                                Console.WriteLine("");
                                Console.WriteLine($"Aluno: {x.Nome} Nota: {x.Nota}");
                            }

                        }
                        /*foreach (Aluno x in alunos)
                        {
                            Console.WriteLine($"Aluno: {x.Nome} Nota: {x.Nota}");
                        }*/

                        break;

                    case "3":
                        decimal totalNota = 0;
                        var nAlunos = 0;
                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                totalNota = totalNota + alunos[i].Nota;
                                nAlunos++;

                            }
                            
                        }

                        var mediaGeral = totalNota / nAlunos;

                        Conceito conceitoGeral;

                        if (mediaGeral < 2)
                        {
                            conceitoGeral = Conceito.A;
                        }
                        else if (mediaGeral < 4)
                        {
                            conceitoGeral= Conceito.B;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if (mediaGeral < 8)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else
                        {
                            conceitoGeral = Conceito.E;
                        }

                        Console.WriteLine($"Média geral: {mediaGeral} - CONCEITO: {conceitoGeral}");

                        break;

                    case "x":
                        break;

                    default:

                        if (opUser.ToUpper() != "X")
                        {
                            Console.WriteLine("opcao errada");
                            opUser = OpUser();
                            Console.Clear();
                        }
                        break;

                }//endswitch

                opUser = OpUser();

            }//endwhile


        }

        private static string OpUser()
        {
            Console.WriteLine("");
            Console.WriteLine("Informe a Opção desejada.");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir novo aluno: ");
            Console.WriteLine("");
            Console.WriteLine("2 - Listar alunos: ");
            Console.WriteLine("");
            Console.WriteLine("3 - Calcular média geral: ");
            Console.WriteLine("");
            Console.WriteLine("X - Sair");
            Console.WriteLine("");
            string opUser = Console.ReadLine();
            return opUser;
        }
    }
}
