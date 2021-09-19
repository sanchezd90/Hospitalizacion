using System.Runtime.CompilerServices;
using System.Collections.Generic;
using Hospi.App.Dominio.Entidades;

namespace Hospi.App.Persistencia.AppRepositorios

{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
    }
}