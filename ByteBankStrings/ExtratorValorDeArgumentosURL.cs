using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankStrings
{
    public class ExtratorValorDeArgumentosURL
    {
        // PROPRIEDADES E ATRIBUTOS
        private readonly string _argumentos;

        public string URL { get; }

        // CONSTRUTORES
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio.", nameof(url));
            }

            // Armazena o número do índice onde o caractere '?' aparece na url
            int indiceInterrogacao = url.IndexOf('?');

            _argumentos = url.Substring(indiceInterrogacao + 1);

            URL = url;
        }

        // MÉTODOS
        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper(); // VALOR
            string argumentoEmCaixaAlta = _argumentos.ToUpper(); // MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR

            string termo = nomeParametro + "="; // MOEDADESTINO=
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo); // indice do M de MOEDADESTINO

            string resultado = _argumentos.Substring(indiceTermo + termo.Length); // dolar
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);
        }

    }
}
