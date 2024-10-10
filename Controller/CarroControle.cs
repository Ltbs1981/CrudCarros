using CrudCarros.Core.Entidades;
using CrudCarros.Servicos;

namespace CrudCarros.Controller
{
    internal class CarroControle
    {
        private CarroServico _carroServico;
        public void Add(string marca, string modelo)
        {
            Carro carro = new Carro()
            {
                Marca = marca,
                Modelo = modelo
            };
            _carroServico = new CarroServico();
            _carroServico.Add(carro);
        }
        public void GetAll()
        {
            var carros = _carroServico.GetAll();
            foreach (var carro in carros)
            {
                Console.WriteLine($"Carros Registrados:\n{carro.Id}\t\t{carro.Marca}\t\t{carro.Modelo}");
            }
        }
        public void Update(int id, string novaMarca, string novoModelo)
        {
            _carroServico = new CarroServico();
            _carroServico.Update(id, novaMarca, novoModelo);
        }
        public void Delete(int id)
        {
            _carroServico = new CarroServico();
            _carroServico.Delete(id);
        } 
    }
}
