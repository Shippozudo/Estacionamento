using System;

namespace ListaExercicio8_OOP_Estacionamento.Modelos.Clientes
{
    public class Cliente
    {
        public Cliente(string nome,
                       string tipoVeiculo,
                       string veiculo,
                       DateTime horarioChegada,
                       DateTime horarioSaida,
                       bool diaria,
                       bool lavagem)
        {
            Nome = nome;
            TipoVeiculo = tipoVeiculo;
            Veiculo = veiculo;
            HorarioChegada = horarioChegada;
            HorarioSaida = horarioSaida;
            HorarioPermanencia = HorarioSaida - HorarioChegada;
            Diaria = diaria;
            Lavagem = lavagem;
        }

        public string Nome { get; set; }
        public string TipoVeiculo { get; set; }
        public string Veiculo { get; set; }
        public DateTime HorarioChegada { get; set; }
        public DateTime HorarioSaida { get; set; }
        public TimeSpan HorarioPermanencia { get; set; }
        public bool Diaria { get; set; }
        public bool Lavagem { get; set; }

    }
}




