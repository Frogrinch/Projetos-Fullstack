namespace Series
{
  public class Serie : EntidadeBase
  {
    // Atributos
    public Serie(int id, Genero genero, string titulo, string descricao, int ano, bool excluido)
    {
      this.Id = id;
      this.Genero = genero;
      this.Titulo = titulo;
      this.Descricao = descricao;
      this.Ano = ano;
      this.Excluido = false;

    }

    internal void Excluir()
    {
      throw new NotImplementedException();
    }

    private int Id { get; set; }
    private Genero Genero { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private int Ano { get; set; }
    private bool Excluido { get; set; }

    internal object retornaExcluido()
    {
      throw new NotImplementedException();
    }

    internal int retornaId()
    {
      throw new NotImplementedException();
    }

    internal int retornaTitulo()
    {
      throw new NotImplementedException();
    }
  }


  public override string ToString()
  {

    string retorno = "";
    retorno += "Gênero: " + this.Genero + Environment.NewLine;
    retorno += "Titulo: " + this.Titulo + Environment.NewLine;
    retorno += "Descrição: " + this.Descricao + Environment.NewLine;
    retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
    retorno += "Excluido: " + this.Excluido;
    return retorno;
  }

  public string retornaTitulo()
  {
    return this.Titulo;
  }

  public int retornaId()
  {
    return this.Id;
  }

  public bool retornaExcluido()
  {
    return this.Excluido;
  }

  public void Excluir()
  {
    this.Excluido = true;
  }
}

