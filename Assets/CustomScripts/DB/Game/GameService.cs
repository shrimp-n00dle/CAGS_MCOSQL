using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameService : MonoBehaviour
{
    GameDB db;

    public GameService()
    {
        this.db =  new GameDB();
    }

    public void CreateGameTable(){
		db.GetConnection().DropTable<Game> ();
		db.GetConnection().CreateTable<Game> ();
    }

    public int addGame(Game Game)
    {
      return db.GetConnection().Insert(Game);
    }

    public int addGames(Game[] Games)
    {
      return db.GetConnection().InsertAll(Games);
    }

    public IEnumerable<Game> GetGames()
    {
		  return db.GetConnection().Table<Game>();
	  }

    public IEnumerable<Game> GetGames(string value)
    {
		  return db.GetConnection().Table<Game>().Where(x => x.game_title == value);
	  }

     public int deleteGame(Game Game)
    {
      return db.GetConnection().Delete(Game);
    }

     public int deleteAllGames()
    {
      return db.GetConnection().DeleteAll<Game>();
    }

     public int updateGame(Game Game)
    {
      return db.GetConnection().Update(Game);
    }
}
