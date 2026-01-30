namespace RickAndMortyBlazor.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Status { get; set; } = "";
        public string Species { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Image { get; set; } = "";
        public int Score { get; set; } = 0;
        
    }
    public class ApiInfo
    {
        public int Pages { get; set; }
        public string Next { get; set; }
        public string Prev { get; set; }
    }

    public class CharacterResponse
    {
        public ApiInfo Info { get; set; } = new();
        public List<Character> Results { get; set; } = new();
    }

}
