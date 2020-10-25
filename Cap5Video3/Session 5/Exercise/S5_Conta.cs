using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace ExercisesProject.Session_5
{
    class S5_Conta
    {

        // ====================================================================================================================================================================================
        // P R I V A T E D  A T R I B U T E S - Devido ao conceito de encapsulamento os atributos devem ser private e devido a isso em C# devem seguir o padrão de escrita abaixo, underline + camelCase
        // ====================================================================================================================================================================================

        private string _nome;

        // ====================================================================================================================================================================================
        // A U T O  P R O P E R T I E S 
        // ====================================================================================================================================================================================

        public int NumConta { get; private set; }
        public bool HaveraDP { get; set; }
        public double Saldo { get; private set; } = 0;
        public double Taxa { get; } = 5;

        // ====================================================================================================================================================================================
        // C O N S T R U C T O R S
        // ====================================================== ==============================================================================================================================

        public S5_Conta(int numContaInformado, string nomeInformado)
        {
            this.NumConta = numContaInformado;
            this._nome = nomeInformado;
        }

        public S5_Conta(int numContaInformado, string nomeInformado, double depositoInformado) : this(numContaInformado, nomeInformado)
        {
            RealizarDeposito(depositoInformado);
        }

        // ====================================================================================================================================================================================
        // P R O P E R T I E S - (Propriedades Customizadas) Modo mais funcional (em detrimento dos métodos Get/Set) de acessar e setar valores dos atributos
        // ====================================================================================================================================================================================

        public string Nome
        {
            get { return _nome; }

            set
            {
                if (value != null && value.Length > 0)
                    _nome = value;
                else
                    Console.WriteLine("Informe um nome válido");
            }
        }



        // ====================================================================================================================================================================================
        // O T H E R S   M E T H O D S 
        // ====================================================================================================================================================================================

        public void RealizarDeposito(double ValorIndormado)
        {
            this.Saldo += ValorIndormado;
        }

        public void RealizarSaque(double ValorIndormado)
        {
            this.Saldo = this.Saldo - ValorIndormado - this.Taxa;
        }

        // public void PrintDadosDaConta()
        //{
        //   Console.WriteLine("Dados da conta:" + Environment.NewLine + "Conta " + NumConta + ", Titular: " + Nome + ", Saldo: " + Saldo);
        //}


        public override string ToString()
        {
            return
            Environment.NewLine +
            "Conta " +
            NumConta +
            ", Titular: " +
            Nome +
            ", Saldo: " +
            Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
