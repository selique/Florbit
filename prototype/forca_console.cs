int n = -1;
int d = -1;
Forca[] vetor = new Forca[100];
if (File.Exists("JogoForca.txt"))
{
string[] linhas = File.ReadAllLines("JogoForca.txt");
for (int a = 0; a < linhas.Length; a++)
{
if (linhas[a].ToUpper()[0] == 'P')
{

n++;
vetor[n].palavras = linhas[a].Substring(2);
vetor[n].dicas = new string[10];
d = 0;

}

else
{
d++;
vetor[n].dicas[d] = linhas[a].Substring(2);
vetor[n].qtdedicas++;


}
}

}
Console.WriteLine();

Random gerador = new Random();
int palavraAtual = gerador.Next(0, n + 1);
string palavraJogo = vetor[palavraAtual].palavras;

string[] palavraFinal = new string[palavraAtual];
char[] letra = palavraJogo.ToCharArray();
char[] forca = palavraJogo.ToCharArray();


for (int i = 0; i < palavraJogo.Length; i++)
{
if (letra[i] == ' ')
{
forca[i] = ' ';
}
else
{
forca[i] = '_';
}
}

TextoForca(" ***************JOGO DA FORCA**************** \n\n\n");
Console.WriteLine(" __________________ ");
Console.WriteLine(" |/ |");
Console.WriteLine(" | ");
Console.WriteLine(" | ");
Console.WriteLine(" | ");
Console.WriteLine(" | ");
Console.WriteLine(" | ");
Console.WriteLine(" | ");
Console.WriteLine(" | ");
Console.WriteLine(" | ");
Console.WriteLine(" | ");
Console.WriteLine(" | ");
int vida = 6;
int acertos = 0;
bool correto;
char l;
string boneco = " ";
//char resp = ' ';

do
{

DesenhaPalavra(palavraJogo, forca);

correto = false;
ConsoleKeyInfo palpite;

Console.WriteLine("\n\n\n\n\t\t\t\t\tDigite uma letra");
palpite = Console.ReadKey(true);

char palpiteChar = Convert.ToChar(palpite.KeyChar);
l = char.ToUpper(palpite.KeyChar);

for (int i = 0; i < palavraJogo.Length; i++)
{

if (palpite.KeyChar == forca[i])
{
Console.WriteLine("\nLetra já digitada: {0} ", l);
correto = true;
break;
}


else if (palpite.KeyChar == letra[i])
{
forca[i] = palpite.KeyChar;
correto = true;
//Console.WriteLine(palpite.KeyChar);
acertos++;

}
/*if (palpite.Key == ConsoleKey.F2)
{

}
*/



}
if (correto == false)
{
vida--;
BonecoForca(boneco, vida);
}

}
while (acertos < palavraJogo.Length && vida > 0);
DesenhaPalavra(palavraJogo, forca);
