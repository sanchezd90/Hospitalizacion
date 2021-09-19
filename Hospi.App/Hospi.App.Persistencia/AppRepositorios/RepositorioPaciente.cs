using System.Collections.Generic;
using System.Linq;
using Hospi.App.Dominio.Entidades;

namespace Hospi.App.Persistencia.AppRepositorios
{
    public class RepositorioPaciente:IRepositorioPaciente
    {
        private readonly AppContext _appContext;

        ///<param name="appContext"></param>

        public RepositorioPaciente(AppContext appContext)
        {
            _appContext=appContext;
        }

        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;            
        }

        void IRepositorioPaciente.DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.id==idPaciente);
            if(pacienteEncontrado==null)
                return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;
        }

        Paciente IRepositorioPaciente.GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.id==idPaciente);            
        }

        Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.id==paciente.id);
            if(pacienteEncontrado!=null)
            {
                pacienteEncontrado.Nombre=paciente.Nombre;
                pacienteEncontrado.Apellidos=paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono=paciente.NumeroTelefono;
                pacienteEncontrado.Genero=paciente.Genero;

                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }

    }
}