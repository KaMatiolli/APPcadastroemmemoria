using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
  
  public class SeriesRepositorio : IRepositorio<Serie>
  {
      private List<Serie> listaSerie = new List<Serie>();
      public void Atualiza(int id, Serie objeto)
    {
      listaSerie[id] = objeto;
    }
   
    public void Exclui(int id)
    {
      listaSerie.Excluir();
      //Posso implementar e-mail aqui, toda vez que há uma exlusão.
      
    }
    
    public void Insere(Serie entidade)
    {
      listaSerie.Add(objeto);
    }
   
    public List<Serie> Lista()
    {
      return listaSerie;
    }

    public int ProximoId()
    {
      return listaSerie.Count;
    }

    public Serie RetornoPorId(int id)
    {
      return listaSerie[id];
    }
    
  }

}