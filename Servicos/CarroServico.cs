using CrudCarros.Core.Entidades;
using CrudCarros.Infra.Repositorio;
namespace CrudCarros.Servicos
{
    internal class CarroServico
    {
        private CarroRepositorio _carroRepositorio;

        public void Add(Carro carro)
        {
            _carroRepositorio.Add(carro);
            //Console.WriteLine("Item inserido no sistema");
            Console.WriteLine($"O carro {carro.Modelo}, foi inserido no sistema");
        }
        public List <Carro> GetAll()
        {
            return _carroRepositorio.GetAll();
                    }
        public void Update(int id, string novaMarca, string novoModelo)
        {
            var carro = _carroRepositorio.GetAll().FirstOrDefault(x => x.Id == id);
            carro.Marca = novaMarca;
            carro.Modelo = novoModelo;
            _carroRepositorio.Update(carro);
            Console.WriteLine("Item atualizado");
        }
        public void Delete(int id)
        {
            var carro = _carroRepositorio.GetAll().FirstOrDefault(c => c.Id == id);
            _carroRepositorio.Delete(carro);
            Console.WriteLine($"O carro: {carro.Marca}, foi apagado do sistema.");
        }
    }
}
