using CrudCarros.Core.Entidades;
using CrudCarros.Servicos;

namespace CrudCarros.Controller
{
    internal class CarroControle
    {
        private CarroServico _carroServico;

        public CarroControle()
        {
            _carroServico = new CarroServico(); // Mova a inicialização para o construtor
        }
        public void Create(string marca, string modelo)
        {
            Carro carro = new Carro()
            {
                Marca = marca,
                Modelo = modelo
            };
            _carroServico = new CarroServico();
            _carroServico.Add(carro);
        }
        public void Read()
        {
            var carros = _carroServico.GetAll();
            foreach (var carro in carros)
            {
                Console.WriteLine($"Carros Registrados:\n{carro.Id}\t\t{carro.Marca}\t\t{carro.Modelo}");
            }
        }
        public void Editar(int id, string novaMarca, string novoModelo)
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
