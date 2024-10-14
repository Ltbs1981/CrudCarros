using CrudCarros.Core.Entidades;
using CrudCarros.Controller;
Console.WriteLine("Os carros mais caros do mundo");

CarroControle carroControle = new CarroControle();

carroControle.Create("Bugatti", "La Voiture Noire");
carroControle.Create("Rolls-Royce", "Sweptail");
carroControle.Create("Pagani", "Zonda HP Barchetta");
carroControle.Create("Bugatti", "Centodieci");
carroControle.Create("Mercedes-Maybach", "Exelero");
carroControle.Create("Koenigsegg", "CCXR Trevita");
carroControle.Create("Lamborghini", "Veneno Roadster");
carroControle.Create("Fiat", "Palio");

carroControle.Read();

carroControle.Delete(7);
carroControle.Editar(1, "Gol", "Gol bolinha");




carroControle.Read();

