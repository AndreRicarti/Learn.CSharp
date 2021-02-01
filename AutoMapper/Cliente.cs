using System;

namespace Auto.Mapper
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Renda { get; set; }
        public string Profissao { get; set; }

        public override string ToString()
            => $"{Id} - {Nome} - {Sobrenome} - {DataNascimento} - {Renda} - {Profissao}";
    }
}