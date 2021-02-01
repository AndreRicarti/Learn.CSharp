using AutoMapper;
using System;
using System.Collections.Generic;

namespace Auto.Mapper
{
    class Program
    {
        static void Main()
        {
            //var cliente = new Cliente()
            //{
            //    Id = 1,
            //    Nome = "Carlos",
            //    Sobrenome = "Silva",
            //    DataNascimento = new DateTime(1980, 03, 12),
            //    Renda = 4012.04
            //};

            //var configuration = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Cliente, ClienteListViewModel>();
            //});

            //var configuration = new MapperConfiguration(cfg =>
            //{
            //    cfg.AddMaps(typeof(Program).Assembly);
            //});

            List<Cliente> cliente = new List<Cliente>
            {
                new Cliente
                {
                    Id = 1,
                    Nome = "Carlos",
                    Sobrenome = "Silva",
                    DataNascimento = new DateTime(1980, 03, 12),
                    Renda = 4012.04,
                    Profissao = "Fazendeiro"
                },
                new Cliente
                {
                    Id = 2,
                    Nome = "André",
                    Sobrenome = "Ricarti",
                    DataNascimento = new DateTime(1990, 10, 26),
                    Renda = 5000,
                    Profissao = "Programador"
                }
            };

            ClienteListModel clienteListModel = new ClienteListModel
            {
                Cliente = cliente
            };

            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ClienteProfile>();
            });

            var mapper = configuration.CreateMapper();

            var clienteViewModel = mapper.Map<List<ClienteListViewModel>>(clienteListModel.Cliente);

            Console.WriteLine(clienteViewModel);
        }
    }
}