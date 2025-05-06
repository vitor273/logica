-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                                                                                    LOGICA DE PROGRAMAÇAO LISTA
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
exerciseo2
using static System.Console;
int idade;

idade =Convert.ToInt32(ReadLine());


if (idade<12 )
{
    WriteLine($" uma criança");

}
else
{

    WriteLine($"e um adolecente");
}
if (idade<17)
{
    WriteLine($"e um adolecente");

}
else
{
    WriteLine($" um adulto");
}
if (idade < 50)
{
    WriteLine($"adulto");

}
else
{
    WriteLine($" um velho");
}
ReadLine();

exerciseo 1

int n1 = 2;
if (4 % n1==0)
{
    WriteLine($"  e um numero par");
}
else
{
 WriteLine($" e um numero impar");
}
ReadLine();
int n1 = 2;
if (4 % n1==0)
{
    WriteLine($"  e um numero par");
}
else{
 WriteLine($" e um numero impar");
}
ReadLine();

EXERCISEO1


using static System.Console;
int a  , b ;
a = Convert.ToInt32(ReadLine());
b = Convert.ToInt32(ReadLine());

if (a>b)
{
    WriteLine($"{a} e maior que {b}");
}
else if (a<b)
{
    WriteLine($"{b} e maior que {a}");
}

ReadLine();

EXERCISEO2

using static System.Console;
int a  , b, c;
a = Convert.ToInt32(ReadLine());
b = Convert.ToInt32(ReadLine());
c = Convert.ToInt32(ReadLine());
int menor, maior;
if (a >= b && a >= c)
{
    maior = a;
}
else if (b >= a && b >= c)
{
    maior = b;
}
else
{
    maior = c;
}

if (a <= b && a <= c)
{
    menor = a;
}
else if (b <= a && b <= c)
{
    menor = b;
}
else
{
    menor = c;
}
WriteLine($"maior número é: {maior}");
WriteLine($"menor número é: {menor}");
ReadLine();


EXERCISEO3


using static System.Console;
int media;
media = Convert.ToInt32(ReadLine());

if (media ==10)
{
    WriteLine("aprovado com distinçao");
}
else if (media >=7)
{
    WriteLine("aprovado");
}
else
{
    WriteLine("reprovado");
}



ReadLine();


EXERCISEO4


using static System.Console;
WriteLine($"digite o preço dos produtos!");
int a , b , c ;
a = Convert.ToInt32(ReadLine());
b = Convert.ToInt32(ReadLine());
c = Convert.ToInt32(ReadLine());
if (a < b && a < c)
{
    WriteLine($"o mais barato e o valor {a}");
}
else if (b < a && b < c)
{
    WriteLine($"o mais barato e o valor {b}");
}
else
{
    WriteLine($"o mais barato e o valor {c}");
}

ReadLine();


EXERCISEO6


using static System.Console;
int n1 ;
n1 = Convert.ToInt32(ReadLine());
if ( n1%2== 0)
{
    WriteLine($"  e um numero par");
}
else
{
    WriteLine($" e um numero impar");
}

ReadLine();

using static System.Console;
WriteLine("QUAL A SUA IDADE?");
int idade = Convert.ToInt32(ReadLine());

if (idade>=18&& idade<=67)
{
    WriteLine("pode duar");

}
else
{
    WriteLine("nao pode duar infelismente;-;");

}
ReadLine();


EXERCISEO5


int n1 ;
n1 = Convert.ToInt32(ReadLine());
if ( n1%2== 0)
{
    WriteLine($"  e um numero par");
}
else
{
    WriteLine($" e um numero impar");
}

ReadLine();


exerciseo7

using static System.Console;
int a = 10, b = 20, troca;

a = a + b;
b = a - b;
a = a - b;
WriteLine($"o valor de a e {a}");
WriteLine($"o valor de b e {b}");

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                                                                                             LOGICA DE PROGRAMAÇAO: LISTA
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

EXERCISEO1

using static System.Console;
List<int> idade = new List<int>{ 10, 20, 12, 14, 15, 16, 17, 18, 11, 19 };
List<string> n = new List<string> { "Ana", "Bruno", "Carlos", "Daniela", "Eduardo", "Fernanda", "Gustavo",

  "Helena", "Igor", "Juliana" };

for (int i = 0; i < 10; i++)
{
    WriteLine(n[i]);
    for (int j = i + 1; j < idade.Count; j++)
       if (idade[i] > idade[j])
        {
            int t = idade[i];
           idade[i] = idade[j];
            idade[j] = t;
           string Nome = n[i];
            n[i] = n[j];
            n[j] = Nome;
        }
}

WriteLine(" idadedos estudantes");

for (int i = 0; i < 10; i++)

{
    WriteLine($"{n[i]} - {idade[i]} anos");
}
WriteLine($"Mais novo: {n[0]} ({idade[0]} anos)");
WriteLine($"Mais velho: {n[9]} {idade[9]} anos)");
ReadKey();



exerciseo3

using static System.Console;
List<int> idade = new List<int>{ 17, 18, 20, 22, 19, 21, 18, 17, 20, 19,
            16, 18, 20, 23, 19, 18, 17, 21, 20, 18};
List<string> boa = new List<string>();
List<string> n = new List<string> { "ana", "beatriz", "camila","daniela","elisa","fernanda","gabriela","helena", "isadora", "julia", "karina",
    "larissa",
    "mariana",
    "natalia",
    "olivia",
    "patricia",
    "rafaela" };

for (int i = 0; i < n.Count; i++)
{
    WriteLine($"Nome: {n[i]} - Idade: {idade[i]}"); 
    if (idade[i] >= 18 && idade[i] <= 20)
    {
        boa.Add(n[i]);
       
    }
}
WriteLine(" ==================  ================== CANDIDATAS  ================== ================== ");

for (int i = 0; i < boa.Count; i++)
{
    WriteLine($"Nome: {boa[i]}");
}
ReadKey();


EXERCISEO4

using static System.Console;
List<int> n = new List<int> { 37, 5, 92, 14, 83, 61, 28, 46, 77, 10,
    55, 3, 88, 19, 42, 69, 12, 74, 6, 90, };
List<int> a = new List<int> { 33, 50, 81, 17, 11, 96, 8, 23, 71, 38,
    64, 2, 59, 87, 30, 99, 12, 68, 45, 35};
int numero = 0;
for (int i = 0; i < 20; i++)
{
    if ( n[i] == a[i])
    {
        WriteLine(numero++);
    }           

}
WriteLine($"V1 e V2 possuem {numero} valore idênticos");

ReadKey();

EXERCISEO5

using static System.Console;
int b = 0;
bool c = false;
List<double> a = new List<double>();

for (int i = 0; i < 15; i++)
{
    Write($"Digite a nota do {i + 1}º Aluno(a):");
    a.Add(Convert.ToDouble(ReadLine()));

    foreach (var item in a)
    {
        if (item >= 7)
        {
            b++;
            
        }
        c = item >= 5 ? true : false;
        
        
    }
}
for (int i = 0; i < a.Count; i++)
{
    WriteLine($"notas {a[i]}");
}
WriteLine("____________________________________________");
WriteLine( c?$"{b} alunos estão com a média acima de 7.0!" : "Nenhum aluno(a) tirou nota acima de 5.0!");

ReadKey();

EXERCISEO6

using System.Text.Json.Serialization;
using static System.Console;

List<double> a = new List<double> {};
double MelhorTempo, M = 0;
int V = 0;

for (int i = 0; i < 12; i++)
{
    Write($"Digite o tempo da {i + 1}º Volta: ");
    a.Add(Convert.ToDouble(ReadLine()));
}
MelhorTempo = a[0];
for (int i = 0; i < 12; i++)
{
	if (a[i] < MelhorTempo)
	{
		MelhorTempo = a[i];
		V = i;
	}
	M += a[i]; 
}
for (int i = 0; i < a.Count; i++)
{
    WriteLine($"Voltas: {a[i]}");
}
M = M / 12;

WriteLine($"O maior tempo {MelhorTempo:F2}");
WriteLine($"a volta em que o melhor tempo ocorreu foi: {V}");
WriteLine($"Media: {M}");

ReadLine();

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------                                                                                                       CLASS 
                                                                                          class
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using static System.Console;

class cool { 
    public static int colina(int num) {
        return DateTime.Today.Year - num;
    }
    static void Main()
    {
        WriteLine("digite o ano que vc nasceu");
        int ano = Convert.ToInt32(ReadLine());
        WriteLine($"a sua idade {colina(ano)}");


    }
}




using static System.Console;

class cool { 
    public static int colina(int num) {
        return DateTime.Today.Year - num;
    }
    static void Main()
    {
        WriteLine("digite o ano que vc nasceu");
        int ano = Convert.ToInt32(ReadLine());
        WriteLine($"a sua idade {colina(ano)}");


    }
}





using static System.Console;

class cool { 
    public static void colina(string[]opitions) {
        foreach (string item in opitions)
        {
            WriteLine(item);
        }
        WriteLine("escolha sua opçao");
    }
    public static void option1(){ WriteLine("executando a opçao 1..."); }
        public static void option2() { WriteLine("executando a opçao 2..."); }
        public static void option3() { WriteLine("executando a opçao 3..."); }
    private static void Exit()
    {
        ForegroundColor = ConsoleColor.Blue;
       
        WriteLine("ta processando calma ai!!!!");
        ForegroundColor = ConsoleColor.Black;
        Environment.Exit(0);
       
    }
    public static void Main(string[] args)
    {
        Title = "hack";
        ForegroundColor = ConsoleColor.Green;
        WriteLine("<<<<<menu>>>>>>");
        string[] opition = { "1 - free fire", "2 - pubg", "3 - fornite", "4 - sub surf", "5 - fnf", };
        int option = 0;
        while (true)
        {
            colina(opition);
            try
            {
                ForegroundColor = ConsoleColor.Red;
                option = Convert.ToInt32(ReadLine());
            }
            catch (System.FormatException)
            {
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("por favor, digite uma opçao entre 1 e" + opition.Length);

            }


            switch (option)
            {
                case 1:
                    option1();
                    break;
                case 2:
                    option2();
                    break;
                case 3:
                    option3();
                    break;
                case 4:
                    Exit();
                    break;
                default:
                    WriteLine("porfavor, digite uma opçao entre 1 e" + opition.Length);
                    break;
                   
            }
        }
        

    }
}
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------                                                                                                       CLASS 
                                                                                          SISTEMA
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




using static System.Console;


namespace menu
{
    class MainClass
    {
        public static void printMenu(String[] options)
        {
            foreach (String option in options)
            {
                Console.WriteLine(option);
            }
            Console.Write("ESCOLHA UM NOME:");
        }



        public static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<<<<<<<<<<<<NOMES>>>>>>>>>>>>>>>>");
            String[] options = {"1- CADASTRAR 1",
                            "2- EDITAR 2",
                            "3- EXCLUIR 3",
                            "4- CARREAGAR" +
                            "5-CARREGAR" +
                            "6 - SAIR",
                                };

            int option = 0;
            while (true)
            {
                printMenu(options);
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Por favor, digite uma opção entre 1 e " + options.Length);
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("Um erro aconteceu! Tente novamente.");
                    continue;
                }
                switch (option)
                {
                    case 1:
                        CADASTRAR();
                        break;
                    case 2:
                        EDITAR();
                        break;
                    case 3:
                        EXCLUIR();
                        break;
                    case 4:
                        GRAVAR();
                        break;
                    case 5:
                        CARREGAR();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Por favor, digite uma opção entre 1 e  " + options.Length);
                        break;
                }

            }
        }
        static List<string> nomes = new List<string>();
        private static void CADASTRAR()
        {
            Clear();
            WriteLine("=====================================================");
            WriteLine("=                    cadastrar nome                 =");
            WriteLine();
            WriteLine("digite um nome");
            string nome = ReadLine();
            var repetido = nomes.Any(x => x.Contains(nome));
            if (repetido == true)
            {
                WriteLine("O nome digitado ja se encontara nos nossos registros!");
                return;

            }
            else
            {
                nomes.Add(nome);
            }
        }

        private static void EDITAR()
        {
            Clear();
            WriteLine("=====================================================");
            WriteLine("=                    EDITAR NOME                    =");
            WriteLine("=====================================================");
            foreach (var item in nomes)
            {
                WriteLine(item);
                string nome = "";
                WriteLine("digite o nome que voce quer editar:");
                nome = ReadLine();
                int index = nomes.IndexOf(nome);
                if (index >= 0)
                {
                    WriteLine();
                    WriteLine($"o nome que sera editado e {nomes[index]}");
                    WriteLine();
                    WriteLine("digite o nome:");
                    string novonome = ReadLine();
                    var repetindo = nomes.Any(x => x.Contains(novonome));
                    if (repetindo == true)

                    {
                        WriteLine($"esse nome ja conta em nosso registros!");
                        return;
                    }
                    else
                    {
                        nomes[index] = novonome;
                    }

                    WriteLine("=====================================================");
                    WriteLine("=                 LISTAGEM DE NOMES                 =");
                    WriteLine("=====================================================");
                    foreach (var o in nomes)
                    {
                        WriteLine(o);

                    }
                }
            }
        }
        private static void EXCLUIR()
        {
            Clear();
            WriteLine("=====================================================");
            WriteLine("=                   EXCLUIR NOME                    =");
            WriteLine("=====================================================");
            WriteLine();
            string nome;
            WriteLine("digite o nome que vc quer excluir");
            nome = ReadLine();
            int index = nomes.IndexOf(nome);
            if (index >= 0)
            {
                WriteLine();
                WriteLine($"o nome que sera editado e {nomes[index]}");
                WriteLine();
                WriteLine("digite o nome:");
                string confirmar = ReadLine();
                if (confirmar == "s")
                {
                    nomes.RemoveAt(index);
                }

            }
            WriteLine("=====================================================");
            WriteLine("=                 LISTAGEM DE NOMES                 =");
            WriteLine("=====================================================");
            foreach (var o in nomes)
            {
                WriteLine(o);

            }
        }
        private static void GRAVAR()
        {
            Clear();
            WriteLine("=====================================================");
            WriteLine("=                   GRAVAR NO ARQUIVO               =");
            WriteLine("=====================================================");
            WriteLine();

            try
            {
                StreamWriter DADOSNOMES;
                string arq = @"C\NOMES\nomes.txt";
                DADOSNOMES = File.CreateText(arq);
                foreach (var item in nomes)
                {
                    DADOSNOMES.WriteLine($"{item}");
                }
                DADOSNOMES.Close();
            }
            catch (Exception e)
            {
                WriteLine($"{e.Message}");

            }
            finally
            {
                WriteLine("<<<<<dados gravados com sucesso!>>>>>>>>>");
            }
        }
        private static void CARREGAR()
        {
            Clear();
            WriteLine("=============================================");
            WriteLine("=              LER ARQUIVO                  =");
            WriteLine("=============================================");
            WriteLine();
            var nome = File.ReadAllLines(@"C:\NOMES\NOMES.txt");
            for (int i = 0; i < nome.Length; i++)
            {
                nomes.Add(nome[i]);
            }
            WriteLine("<<<<<<< LEITURA REALIZADA COM SUCESSO! >>>>>>>");
        }
    }
}



------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

<!DOCTYPE html>
<html lang="pt-br">
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
        <title>Palavra Secreta</title>
    </head>
    <body>
        <center><h2>calculadora imc</h2></center>
        <hr/>
        <div class="row justify-content-center row-cols-1 row-cols-md-2 mb-3 text-center">
            <div class="col">
                <div class="card mb-4 rounded-3 shadow-sw">
                    <div class="card-header py-3">
                        <svg xmlns="http://www.w3.org/2000/svg" width="30" height="30" fill="red" class="bi bi-ui-checks" viewBox="0 0 16 16">
                        <path d="M7 2.5a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-7a.5.5 0 0 1-.5-.5zM2 1a2 2 0 0 0-2 2v2a2 2 0 0 0 2 2h2a2 2 0 0 0 2-2V3a2 2 0 0 0-2-2zm0 8a2 2 0 0 0-2 2v2a2 2 0 0 0 2 2h2a2 2 0 0 0 2-2v-2a2 2 0 0 0-2-2zm.854-3.646a.5.5 0 0 1-.708 0l-1-1a.5.5 0 1 1 .708-.708l.646.647 1.646-1.647a.5.5 0 1 1 .708.708zm0 8a.5.5 0 0 1-.708 0l-1-1a.5.5 0 0 1 .708-.708l.646.647 1.646-1.647a.5.5 0 0 1 .708.708zM7 10.5a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-7a.5.5 0 0 1-.5-.5zm0-5a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5m0 8a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5"/>
                        </svg>&nbsp;&nbsp;<font style="font-size: 30px;"><b>PALAVRA SECRETA</b></font>
                    </div>
                    <div class="card-body">
                       <?php 
                       $numero = $_POST['numero'];
                         if($numero % 2 == 0){
                            echo"seu numero e par";
                         } 
                         else
                         {echo"seu numero e impar";
                         }
                       ?>
                        </form>                       
                    </div>
                </div>
            </div>
        </div>
    </body>
</html>
