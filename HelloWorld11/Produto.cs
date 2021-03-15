using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld11
{
    //this: É uma referência para o próprio objeto (mesmo nome)
    // - Diferenciar atributos de variáveis local (java usa bastante por nao ter padrões com letras maiúsculas)
    // - Referenciar outro construtor em um construtor (nomes iguais, reaproveitando o codigo)
    // - Passar o próprio objeto como argumento na chamada de um método ou construtor
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 0;
        }
        public Produto(string nome, double preco) : this() // usando 'this()' para fazer referencia ao contrutor Produto() dentro do próprio objeto
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) // usando 'this(nome, preco)' para fazer referencia ao objeto  'Produto(string nome, double preco)'
        {
            Quantidade = quantidade;
        }
         
        /* Exemplo em java:
        public Produto(string Nome, double Preco)
        {
            this.Nome = Nome; // 'this.Nome' se refere ao 'Nome' declarado no objeto como um todo, já o 'Nome' se refere a variavel local do construtor declarada dentro dos parametros
            this.Preco = Preco;
            Quantidade = 0;
        }
 
        */


    } 
}


