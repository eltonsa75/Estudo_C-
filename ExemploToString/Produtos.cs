using System.Globalization;

namespace ExemploToString{
    class Produtos{

        public string Nome;
        public double Preco;
        public int Quantidade;

        // Method Preço * Valor

        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
        }

        public override string ToString(){
            return Nome 
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}