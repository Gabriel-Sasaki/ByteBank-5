using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBankStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object conta = new ContaCorrente(456, 687876);
            object desenvolvedor = new Desenvolvedor("4564654");

            string contaToString = conta.ToString();

            Console.WriteLine("Resultado: " + contaToString);
            Console.WriteLine(conta);

            // --------------------------------------------------------------------------------------------------------

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120.03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120.03";
            carlos_2.Profissao = "Designer";

            ContaCorrente conta_2 = new ContaCorrente(456, 87654);

            if(carlos_1.Equals(conta_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }

            Console.ReadLine();
        }

        static void TestaString()
        {
// ESSE CÓDIGO FOI SEPARADO EM PARTES CONFORME O AVANÇO DA AULA, ELES ESTÃO COMENTADOS PARA NÃO ENTRAREM EM CONFLITO
// --------------------------------------------------------------------------------------------------------------------
            /*

            // O [] representa um grupo de chacacteres ou um intervalo - usando um hífen ele separa o começo do fim
            // [012345]
            // [0-5]

            // O {} representa um quantificador, define quantos grupos, intervalos ou characteres vão se repetir
            // [0-5]{2} é a mesma coisa que [0-5][0-5]

            // A vírgula dentro do {} mostra o intervalo de vezes que um grupo ou charactere pode repetir
            // [123]{1,2} define que pode ser tanto [123]{1} quanto [123]{2}

            // Quando um charactere não compõe um grupo, ele pode ser colocado fora do []
            // 5 é a mesma coisa que [5]

            // Para characteres que podem ou não estar presentes, pode-se usar o interrogação para definir isso
            // 0? define que pode ter um zero ou não, então ele captura as duas formas, com e sem o zero

            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Gabriel, me liguem em 1234-5678";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado);


// --------------------------------------------------------------------------------------------------------------------


            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));
            Console.WriteLine(urlTeste.Contains("bytebank"));


// --------------------------------------------------------------------------------------------------------------------


            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valor2 = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valor2);

            string valor3 = extratorDeValores.GetValor("Valor");
            Console.WriteLine("Valor de valor: " + valor3);


// --------------------------------------------------------------------------------------------------------------------
            

            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));

            // Definindo as variáveis
            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            // Pegando o valor do indice "nomeArgumento" dentro de "palavra" e escrevendo em tela
            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            // Escrevendo em tela o tamanho (Length) da variável nomeArgumento
            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            // Escrevendo em tela a variável palavra
            Console.WriteLine(palavra);

            // Escrevendo em tela a parte cortada da "palavra" a partir do valor do indice
            Console.WriteLine(palavra.Substring(indice));

            // Escrevendo em tela a parte cortada da "palavra" a partir dos parâmetros definidos
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));

            
// --------------------------------------------------------------------------------------------------------------------


            string palavra = "moedaDestino=real";
            int indice = palavra.IndexOf("real");

            Console.WriteLine(indice);
            Console.ReadLine();

            // Testando or IsNullOrEmpty
            string textoVazio = "";
            string textoNulo = null;

            Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            Console.WriteLine(string.IsNullOrEmpty(textoNulo));
            Console.ReadLine();


// --------------------------------------------------------------------------------------------------------------------


            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(null);

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);

            */

            Console.ReadLine();
        }
    }
}
