using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace phazor.Data
{
    public class DogService {
        public async Task<Dog> GetRandomDogImageAsync() {
            Dog dog = new Dog();
            var uri = "https://dog.ceo/api/breeds/image/random";
            using (var client = new HttpClient()) {
                var json = await client.GetStringAsync(uri);
                dog = JsonConvert.DeserializeObject<Dog>(json);
            }
            return dog;
        }
    }
}
