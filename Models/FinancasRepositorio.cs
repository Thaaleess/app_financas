using System.Collections.Generic;
using System.Linq;

namespace app_financas.Models
{
    public class FinancasRepositorio : IFinancasRepositorio
    {
        private DataContext context;
        public FinancasRepositorio(DataContext context){
            this.context = context;
        }

        public void Create(Financas financa)
        {
            context.financas.Add(financa);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            context.financas.Remove(GetById(id));
            context.SaveChanges();
        }

        public void Update(Financas financa){
            Delete(financa.id);
            Create(financa);
        }

        public Financas GetById(int id)
        {
            return context.financas.SingleOrDefault(x=>x.id == id);
        }

        public List<Financas> GetAll()
        {
            return context.financas.ToList();
        }
    }
}