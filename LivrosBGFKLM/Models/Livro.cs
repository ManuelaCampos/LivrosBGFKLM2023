namespace LivrosBGFKLM.Models
{
    public abstract class Livro
    {
        public long? Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public string Genero { get; set; }
        public double Preco { get; set; }
    }
    
}
