//using System;
//using System.Globalization;
//using System.Collections.Generic;
//using System.Text;

//namespace nsCursoCsharp
//{
//    class S5_Produto // Esta classe pode ser acessada apenas dentro do mesmo projeto (ExercisesProject) pois é INTERAL (qdo é omitido o escopo a classe por padrão é INTERNAL)
//    {

//        // ====================================================================================================================================================================================
//        // P R I V A T E D  A T R I B U T E S - Devido ao conceito de encapsulamento os atributos devem ser private e devido a isso em C# devem seguir o padrão de escrita abaixo, underline + camelCase
//        // ====================================================================================================================================================================================

//        private string _nome;    // O atributo _nome possue regra específica para setá-lo portanto não pode ser utilizado o conceito de AUTO PROPERTIE sendo necessário utilizar uma PROPERTY


//        // ====================================================================================================================================================================================
//        // P R O P R I E D A D E S   A U T O I M P L E M E N T A D A  
//        // ====================================================================================================================================================================================

//        public double Preco { get; private set; }       // Exemplo de aplicação de AUTO PROPERTY. Foi possível pois o atributo preco NÃO TEM REGRA ESPECÍFICA para setá-lo caracterizando a possibilidade do uso de AUTO PROPERTY
//        public double Quantidade { get; private set; }  // Exemplo de aplicação de AUTO PROPERTY. Foi possível pois o atributo quantidade NÃO TEM REGRA ESPECÍFICA para setá-lo caracterizando a possibilidade do uso de AUTO                                                          PROPERTIE


//        // ====================================================================================================================================================================================
//        // C O N S T R U C T O R S
//        // ====================================================== ==============================================================================================================================

//        //CONSTRUTOR PADRÃO  - Aceita que seja instanciado objetos sem passar nenhum parâmetro
//        public S5_Produto()
//        {
//        }

//        //CONSTRUTOR_I - (Exige que apenas o Nome do produto seja passado como parâmetro)
//        public S5_Produto(string nomeInformado) // Em C# é convencionado utilizar padrão camelCase para variáveis do construtor
//        {
//            this._nome = nomeInformado;
//        }

//        //CONSTRUTOR_II - Exige que o Preco sejam passados como parâmetro E a Quantidade será atribuida como 50 sempre que um objeto for instanciado
//        public S5_Produto(double precoInformado)
//        {
//            this.Preco = precoInformado;
//            this.Quantidade = 50;
//        }

//        //CONSTRUTOR_III - Exige que o Nome e o Preco sejam passado como parâmetro mas o Preco será reaproveitado do CONSTRUTOR_I que ja o exige
//        public S5_Produto(string nomeInformado, double precoInformado) : this(nomeInformado)
//        {
//            this.Preco = precoInformado;
//        }


//        //CONSTRUTOR_IV - Exige que o Nome, o Preco e a quantidade sejam passado como parâmetro mas o Nome e o Preco serão reaproveitado do outros construtores
//        public S5_Produto(string nomeInformado, double precoInformado, int quantidadeInformada) : this(nomeInformado, precoInformado)
//        {
//            this.Quantidade = quantidadeInformada;
//        }

//        // ====================================================================================================================================================================================
//        // G E T / S E T   M E T H O D S - Não são muito utilizados em C# pois o conceito de PROPERTIRES é mais robusto
//        // ====================================================================================================================================================================================


//        //public string GetNome()
//        //{
//        //    return _nome;
//        //}

//        //public void SetNome(string nomeInformado)
//        //{
//        //    if (nomeInformado != null && nomeInformado.Length > 1)
//        //    {
//        //        _nome = nomeInformado;
//        //    }
//        //}

//        //public double GetPreco()
//        //{
//        //    return Preco;
//        //}

//        //public int GetQuantidade()
//        //{
//        //    return Quantidade;
//        //}


//        // ====================================================================================================================================================================================
//        // P R O P E R T I E S - (Propriedades Customizadas) Modo mais funcional (em detrimento dos métodos Get/Set) de acessar e setar valores dos atributos
//        // ====================================================================================================================================================================================

//        //Esta PROPERTIE faz-se necessária (em detrimento da implementação de uma AUTO PROPERTIE) pois como existe regra específica para SETAR valores para o atributo _nome, o conceito de AUTO PROPERTIE não pode ser utilizando
//        public string Nome
//        {
//            get { return _nome; }

//            set
//            {
//                if (value != null && value.Length > 1)
//                {
//                    _nome = value;
//                }
//            }
//        }
//        //A PROPERTIE Preco não faz-se necessária sua implementação pois como em seu método Set não há regras específicas, o conceito de AUTO PROPERTIE pode ser aplicado diretamente na hora de declaras os atributos
//        //public double Preco
//        //{
//        //    get { return Preco; }
//        //}

//        //A PROPERTIE Quantidade não faz-se necessária sua implementação pois como em seu método Set não há regras específicas, o conceito de AUTO PROPERTIE pode ser aplicado diretamente na hora de declaras os atributos
//        //public int Quantidade
//        //{
//        //    get { return Quantidade; }
//        //}


//        // ====================================================================================================================================================================================
//        // O T H E R S   M E T H O D S 
//        // ====================================================================================================================================================================================


//        public double ValorTotalEmEstoque()
//        {
//            return Preco * Quantidade;
//        }

//        public void AdicionarProdutos(int quantidadeInformada)
//        {
//            Quantidade += quantidadeInformada;
//        }

//        public void RemoverProdutos(int quantidadeInformada)
//        {
//            Quantidade -= quantidadeInformada;
//        }

//        //Override Sample
//        public override string ToString()
//        {
//            return
//            "Dados atualizados (Override Method): "
//            + _nome
//            + ", $ "
//            + Preco.ToString("F2", CultureInfo.InvariantCulture)
//            + ", "
//            + Quantidade
//            + " unidades, Total: $ "
//            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
//        }

//        public void ImprimirResultado()
//        {
//            Console.WriteLine(
//            "Dados atualizados (Método Simples): "
//            + _nome
//            + ", $ "
//            + Preco.ToString("F2", CultureInfo.InvariantCulture)
//            + ", "
//            + Quantidade
//            + " unidades, Total: $ "
//            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
//            );

//        }

//    }
//}
