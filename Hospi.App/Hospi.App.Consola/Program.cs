using System.Runtime.ExceptionServices;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System;
using Hospi.App.Dominio.Entidades;
using Hospi.App.Persistencia.AppRepositorios;

namespace Hospi.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppRepositorios.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Qué dificil es llegar hasta acá");
            BuscarPaciente(1);
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente{
                Nombre="Nicolas",
                Apellidos="Perez",
                NumeroTelefono="123",
                Genero=Genero.masculino
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
        }
    }
}
