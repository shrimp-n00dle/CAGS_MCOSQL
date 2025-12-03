using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreService : MonoBehaviour
{
    ScoreDB db;

    public ScoreService()
    {
        this.db =  new ScoreDB();
    }

    public void CreateScoreTable(){
		db.GetConnection().DropTable<ScoreHistory> ();
		db.GetConnection().CreateTable<ScoreHistory> ();
    }

    public int addScore(ScoreHistory ScoreHistory)
    {
      return db.GetConnection().Insert(ScoreHistory);
    }

    public int addScoreHistorys(ScoreHistory[] ScoreHistorys)
    {
      return db.GetConnection().InsertAll(ScoreHistorys);
    }

    public IEnumerable<ScoreHistory> GetScoreHistorys()
    {
		  return db.GetConnection().Table<ScoreHistory>();
	  }

    public IEnumerable<ScoreHistory> GetScoreHistorys(int value)
    {
		  return db.GetConnection().Table<ScoreHistory>().Where(x => x.player_ID == value);
	  }

     public int deleteScoreHistory(ScoreHistory ScoreHistory)
    {
      return db.GetConnection().Delete(ScoreHistory);
    }

     public int deleteAllScoreHistorys()
    {
      return db.GetConnection().DeleteAll<ScoreHistory>();
    }

     public int updateScoreHistory(ScoreHistory ScoreHistory)
    {
      return db.GetConnection().Update(ScoreHistory);
    }
}
