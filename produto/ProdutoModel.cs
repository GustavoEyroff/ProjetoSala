﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produto
{
    public class ProdutoModel
    {
        private List<Produto> produtos = new List<Produto>();

        public void Create()
        {
            Produto produto = new Produto();
            produto.Popular();
            produtos.Add(produto);
        }
        public void Read()
        {
            for(int i = 0; i < produtos.Count; i++)
            {
                Console.Write(i);
                produtos[i].Listar();
            }
        }
        public void Update()
        {
            Read();
            Console.WriteLine("Digite o codigo/id do produto:");
            int index = Convert.ToInt32(Console.ReadLine());
            produtos[index].Popular();
        }
        public void Delete() 
        {
            Read();
            Console.WriteLine("Digite o codigo/id do produto:");
            int index = Convert.ToInt32(Console.ReadLine());
            produtos.RemoveAt(index);
        }
    }
}
