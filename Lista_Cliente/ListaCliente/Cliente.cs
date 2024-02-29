using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

// 1 passo : criar a lista com os atributos
namespace ListaCliente
{
    public class Cliente
    {
        public string nome;
        public int id;
        public double[]? valorproduto;
        public string[]? nomeproduto;
        public Cliente? prox;
        public Endereco? endereco;


    }
}
