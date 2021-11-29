using ListaExercicio8_OOP_Estacionamento.Modelos.Clientes;

namespace ListaExercicio8_OOP_Estacionamento.Modelos.Veiculos
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string TipoVeiculo { get; set; }
        public Cliente Dono { get; set; }
    }

    public class Carro : Veiculo
    {
        public Carro(string placa, string tipoVeiculo, Cliente dono)
        {
            Placa = placa;
            TipoVeiculo = tipoVeiculo;
            Dono = dono;
        }

        public string Placa { get; set; }
        public string TipoVeiculo { get; set; }
        public Cliente Dono { get; set; }
    }

    public class Moto : Veiculo
    {
        public Moto(string placa, string tipoVeiculo, Cliente dono)
        {
            Placa = placa;
            TipoVeiculo = tipoVeiculo;
            Dono = dono;
        }

        public string Placa { get; set; }
        public string TipoVeiculo { get; set; }
        public Cliente Dono { get; set; }
    }

}




