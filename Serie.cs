namespace DIO.Series
{
  public class Serie : EntidadeBase
  {
    //Atributos 
    private Genero Genero { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private string Ano { get; set; }

    private bool Excluido { get; set; }    
    
    //Metodos de construtor
    public Serie(int id, Genero Genero, string Titulo,string Descricao, int Ano)
    {
      this.Id = id;
      this.Genero = Genero;
      this.Titulo = Titulo;
      this.Descricao = Descricao;
      this.Ano = Ano;
      this.Excluido = false;
    }
    public override string ToString()
    {
    //Environment,NewLine 
    string retorno = " ";
    retorno += "Gênero: " + this.Genero + Environment.NewLine;
    retorno += "Título: " + this.Titulo + Environment.NewLine;
    retorno += "Descrição: " + this.Descricao + Environment.NewLine;
    retorno += "Ano: " + this.Ano;
    return retorno;
    }

    public string retornoTitulo()
      {
       return this.Titulo;
      }

    internal int retornaId()
    {
      return this.id;
    }

    public void Exclui()
    {
        this.Excluido = true;
    }
    
  }

}