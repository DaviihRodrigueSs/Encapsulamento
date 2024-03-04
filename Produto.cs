using System.Globalization;
namespace Course
{
    class Produto
    {//Isso e um pouco sobre ENCAPSULAMENTO


        //Private indica que esse atributo e privativo,sendo assim não pode ser acessado por outra classe.

        // Quando se trabalha com atributo privativo, você precisa colocar _ e tudo em minusculo.
        private string _nome;
        private double _preco;
        private int _quantidade;
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string GetNome()
        {
            return _nome;
        } 
        /*Utilizando o Setnome para acessar o atributo e conseguir alterar o nome com a classe private, sendo assim aumenta a segurança.
        todas as vezes que você quiser alterar o conteudo de uma classe você deve utilizar o Set, pois ele faz com que o conteudo da classe seja alterado.

        */


        public void Setnome(string nome)
        {
            _nome = nome;
        }
        public void SetNome(string nome)
        {
            //vazio e = null 
            //Lenght = tamanho maior que 1 
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}