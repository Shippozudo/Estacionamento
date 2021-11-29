using ListaExercicio8_OOP_Estacionamento.Modelos.Clientes;
using ListaExercicio8_OOP_Estacionamento.Modelos.Veiculos;
using System;

namespace ListaExercicio8_OOP_Estacionamento.Estacionamentos
{
    public class Estacionamento
    {


        public Veiculo Placa { get; set; }
        public Veiculo TipoVeiculo { get; set; }


        public int CalculaPreco(Cliente cliente)
        {
            int preco = 0;

            if (cliente.TipoVeiculo == "Carro")
            {
                if (cliente.Diaria == true)
                {
                    if (cliente.Lavagem == true)
                    {
                        preco = 65;
                    }
                    else
                    {
                        preco = 50;
                    }

                }
                else
                {
                    if (cliente.HorarioPermanencia <= TimeSpan.FromMinutes(15))
                    {
                        preco = 2;
                    }

                    else if (cliente.HorarioPermanencia > TimeSpan.FromMinutes(15) && cliente.HorarioPermanencia <= TimeSpan.FromMinutes(60))
                    {
                        preco = 10;

                    }
                    else if (cliente.HorarioPermanencia > TimeSpan.FromMinutes(60))
                    {

                        var i = cliente.HorarioPermanencia.Hours;
                        preco = i * 10;

                    }
                }


            }


            if (cliente.TipoVeiculo == "Moto")
            {
                if (cliente.Diaria == true)
                {
                    preco = 25;
                }
                else
                {
                    if (cliente.HorarioPermanencia <= TimeSpan.FromMinutes(15))
                    {
                        preco = 2;
                    }

                    else if (cliente.HorarioPermanencia > TimeSpan.FromMinutes(15) && cliente.HorarioPermanencia <= TimeSpan.FromMinutes(60))
                    {
                        preco = 5;

                    }
                    else if (cliente.HorarioPermanencia > TimeSpan.FromMinutes(60))
                    {

                        var i = cliente.HorarioPermanencia.Hours;
                        preco = i * 5;

                    }
                }



            }

            return preco;


        }



    }
}




