using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetCatories(); // Assinatura de método, que retorna uma lista de Produto.
        Task<Product> GetByIdAsync(int? id); // Assinatura de método, Retona um Produto pelo ID.
        Task<Product> GetProductCategoryAsync(int? id); // Assinatura de método, Retornando um Produto pelo Id de uma categoria.

        Task<Product> Create(Product Product); //Criando categoria
        Task<Product> Update(Product Product); //Atualizando categoria
        Task<Product> Remove(Product Product); //Removendo categoria

        //O Task significa de a Interface são assincronas. 
    }
}
