using System;

namespace Auto.Mapper
{
    public class ClienteListViewModel
    {
        public long Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }

        public override string ToString()
            => $"{Id} - {NomeCompleto} - {DataNascimento}";
    }
}