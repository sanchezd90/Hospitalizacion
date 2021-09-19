using System;
namespace Hospi.App.Dominio.Entidades
{
    public class Paciente
    {
        public int id { get; set;}
        public string Nombre { get; set;}
        public string Apellidos { get; set;}
        public string NumeroTelefono { get; set;}
        public Genero Genero { get; set;}
    }
}