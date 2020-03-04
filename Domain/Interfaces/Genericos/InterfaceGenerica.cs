using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Generico
{
    public interface InterfaceGenerica<T> where T : class
    {
        void Adcionar(T objeto);
        void Atualizar(T Objeto);
        void Excluir(T Objeto);
        T ObeterPorId(int Id);
        IList<T> Listar();
    }
}
