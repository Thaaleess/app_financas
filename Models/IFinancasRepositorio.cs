using System.Collections.Generic;

namespace app_financas.Models
{
    public interface IFinancasRepositorio
    {
        void Create(Financas financa);
        void Delete(int id);
        void Update(Financas financas);
        List<Financas>GetAll();
        Financas GetById(int id);
    }
}