using Domain.Interfaces.Generico;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio.Generico
{
    public class RepositorioGenerico<T> : InterfaceGenerica<T>, IDisposable where T : class
    {
        private readonly DbCone
        public RepositorioGenerico()
        {

        }
        public void Adcionar(T objeto)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(T Objeto)
        {
            throw new NotImplementedException();
        }

        public void Excluir(T Objeto)
        {
            throw new NotImplementedException();
        }

        public IList<T> Listar()
        {
            throw new NotImplementedException();
        }

        public T ObeterPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
