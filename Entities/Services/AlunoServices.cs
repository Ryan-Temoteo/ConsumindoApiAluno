using Newtonsoft.Json;

namespace ConsumindoApiAluno.Entities.Services
{
    internal class AlunoServices
    {
        public async Task<Aluno> Integracao(int id)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"https://localhost:7274/aluno/{id}");
            var jsonString = await response.Content.ReadAsStringAsync();

            var jsonObject = JsonConvert.DeserializeObject<Aluno>(jsonString);

            
            if (jsonObject != null)
            {
                return jsonObject;
            }
            else
            {
               return new Aluno
                {
                    Verificacao = false
                };
            }
        }
    }
}
