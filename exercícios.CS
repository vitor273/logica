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
