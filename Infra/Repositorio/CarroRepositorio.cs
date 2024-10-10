using CrudCarros.Core.Entidades;
namespace CrudCarros.Infra.Repositorio
{
    internal class CarroRepositorio
    {
        private List<Carro> carros = new List<Carro>();
        private static int id = 1;

        public void Add(Carro carro)
        {
            carro.Id = id++;    
            carros.Add(carro);  
        }    
        public List <Carro> GetAll()
        {
            return carros;
        }
        public void Update(Carro carro)
        {
            Carro banco = carros.FirstOrDefault(c => c.Id == carro.Id);
        }
        public void Delete(Carro carro)
        {
            carros.Remove(carro);
        }
    }
}
