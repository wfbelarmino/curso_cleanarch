using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    #region ///Método Assincrono
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCatories(); // Assinatura de método, que retorna uma lista de categoria.
        Task<Category> GetById(int? id); // Assinatura de método, onde uso o Id que retorna uma categoria.

        Task<Category> Create(Category category); //Criando categoria
        Task<Category> Update(Category category); //Atualizando categoria
        Task<Category> Remove(Category category); //Removendo categoria

        //O Task significa de a Interface são assincronas. 
    }  
#endregion 
}
