using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaAutomotiva
{
    class Veiculo : Veiculos
    {
        public Veiculo GetVeiculo(int id)
        {
            using (var dbContext = new AgenciaAutomotivaBDEntities())
            {
                var entVeiculo = dbContext.Veiculos.Find(id);

                if (entVeiculo != null)
                {
                    var veiculo = new Veiculo();

                    veiculo.id = entVeiculo.id;
                    veiculo.marca = entVeiculo.marca;
                    veiculo.modelo = entVeiculo.modelo;
                    veiculo.ano = entVeiculo.ano;
                    veiculo.cor = entVeiculo.cor;
                    veiculo.fabricacao = entVeiculo.fabricacao;
                    veiculo.valor = entVeiculo.valor;
                    veiculo.combustivel = entVeiculo.combustivel;
                    veiculo.automatico = entVeiculo.automatico;
                    veiculo.ativo = entVeiculo.ativo;
                    return veiculo;
                }
                else
                    return null;
            }
        }

        public static List<Veiculo> GetVeiculos(string marca)
        {
            using (var dbContext = new AgenciaAutomotivaBDEntities())
            {
                var entListaveiculos = dbContext.Veiculos.Where(v => v.marca.Contains(marca));

                if (entListaveiculos != null)
                {
                    var listaVeiculos = new List<Veiculo>();

                    foreach (var item in entListaveiculos)
                    
                        listaVeiculos.Add(new Veiculo{ id = item.id, marca = item.marca, modelo = item.modelo, ano = item.ano, cor = item.cor,
                            fabricacao = item.fabricacao, valor = item.valor, combustivel = item.combustivel, automatico = item.automatico,
                            ativo = item.ativo });

                    return listaVeiculos;
                }
                else
                    return null;
            }
        }
    }
}
