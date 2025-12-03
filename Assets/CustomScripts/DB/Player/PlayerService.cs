using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : MonoBehaviour
{
    PlayerDB db;

    public PlayerService()
    {
        this.db =  new PlayerDB();
    }

    public void CreatePlayerTable(){
		db.GetConnection().DropTable<Player> ();
		db.GetConnection().CreateTable<Player> ();
    }

    public int addPlayer(Player Player)
    {
      return db.GetConnection().Insert(Player);
    }

    public int addPlayers(Player[] Players)
    {
      return db.GetConnection().InsertAll(Players);
    }

    public IEnumerable<Player> GetPlayers()
    {
		  return db.GetConnection().Table<Player>();
	  }

    public IEnumerable<Player> GetPlayers(string value)
    {
		  return db.GetConnection().Table<Player>().Where(x => x.player_name == value);
	  }

     public int deletePlayer(Player Player)
    {
      return db.GetConnection().Delete(Player);
    }

     public int deleteAllPlayers()
    {
      return db.GetConnection().DeleteAll<Player>();
    }

     public int updatePlayer(Player Player)
    {
      return db.GetConnection().Update(Player);
    }
}
