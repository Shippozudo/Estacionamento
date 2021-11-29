
using System;
using ListaExercicio8_OOP_Estacionamento.Estacionamentos;
using ListaExercicio8_OOP_Estacionamento.Modelos.Clientes;
using ListaExercicio8_OOP_Estacionamento.Modelos.Veiculos;

namespace ListaExercicio8_OOP_Estacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var estacionamento = new Estacionamento();
            var cliente1 = new Cliente("Denis", "Carro", "DVC7536", DateTime.Now, DateTime.Now.AddMinutes(120), true, true);
            var carro1 = new Carro("DVC7536", "Carro", cliente1);



            var cliente2 = new Cliente("Daniel", "Moto", "TRE4515", DateTime.Now, DateTime.Now.AddMinutes(1), false, false);
            var moto1 = new Moto("TRE4512", "Moto", cliente2);

            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Placa: " + cliente1.Veiculo);
            Console.WriteLine("Veiculo: " + cliente1.TipoVeiculo);
            Console.WriteLine("Chegada   " + cliente1.HorarioChegada);
            Console.WriteLine("Saida   " + cliente1.HorarioSaida);
            Console.WriteLine("Diária: {0} e Lavagem: {1} ", cliente1.Diaria, cliente1.Lavagem);
            Console.WriteLine("Horario de permanencia:  " + cliente1.HorarioPermanencia.ToString(@"dd\.hh\:mm") + " minutos");
            Console.WriteLine("Valor a pagar: R$" + estacionamento.CalculaPreco(cliente1));

            Console.WriteLine("\n");


            Console.WriteLine("Nome: " + cliente2.Nome);
            Console.WriteLine("Placa: " + cliente2.Veiculo);
            Console.WriteLine("Veiculo: " + cliente2.TipoVeiculo);
            Console.WriteLine("Chegada   " + cliente2.HorarioChegada);
            Console.WriteLine("Saida   " + cliente2.HorarioSaida);
            Console.WriteLine("Diária: {0} e Lavagem: {1} ", cliente2.Diaria, cliente2.Lavagem);
            Console.WriteLine("Horario de permanencia:  " + cliente2.HorarioPermanencia.ToString(@"dd\.hh\:mm") + " minutos");
            Console.WriteLine("Valor a pagar: R$" + estacionamento.CalculaPreco(cliente2));


        }
    }
}




