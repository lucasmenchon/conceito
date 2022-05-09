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
