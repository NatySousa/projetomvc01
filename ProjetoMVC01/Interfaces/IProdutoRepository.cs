using ProjetoMVC01.Entities;
using ProjetoMVC01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC01.Interfaces
{
   public interface IProdutoRepository
    {

        //métodos abstratos ele é declarado assim e na repository é que ele é programado(programado é o que fica entre chaves
        //{
        //}
        void Inserir(Produto produto);
        void Alterar(Produto produto);
        void Excluir(Produto produto);

        List<Produto> Consultar();
        Produto ObterPorId(Guid idProduto);
        List<Produto> ConsultarPorDatas(DateTime dataMin, DateTime dataMax);//Método que vai retornar a lista de produtos cadastrados dentro da data que eu estipular (data de inicio e data de fim)

        List<ProdutoGraficoModel> ConsultarTotal();// método que vai retornar do banco de dados o resultado da procedure CONSULTARTOTAL

    }
}
