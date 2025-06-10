using System.Text.Json;
using Dsw2025Ej14.Api.Domain;
using System.Linq;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria : IPersistencia
    {
        private List<Product> _products = new List<Product>();

        public PersistenciaEnMemoria()
        {
            LoadProducts();
        }
        public Product GetProduct(string sku)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products.Where(p => p._isActive);
        }
        public void LoadProducts()
        {
            const string _archivo = "products.json";

            string json = File.ReadAllText(_archivo);

            _products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? [];


        }
    }
}

