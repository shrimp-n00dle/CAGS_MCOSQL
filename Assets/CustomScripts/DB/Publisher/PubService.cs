using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PubService : MonoBehaviour
{
    PubDB db;

    public PubService()
    {
        this.db =  new PubDB();
    }

    public void CreatePublisherTable(){
		db.GetConnection().DropTable<Publisher> ();
		db.GetConnection().CreateTable<Publisher> ();
    }

    public int addPublisher(Publisher Publisher)
    {
      return db.GetConnection().Insert(Publisher);
    }

    public int addPublishers(Publisher[] Publishers)
    {
      return db.GetConnection().InsertAll(Publishers);
    }

    public IEnumerable<Publisher> GetPublishers()
    {
		  return db.GetConnection().Table<Publisher>();
	  }

    public IEnumerable<Publisher> GetPublishers(string value)
    {
		  return db.GetConnection().Table<Publisher>().Where(x => x.publisher_name == value);
	  }

     public int deletePublisher(Publisher Publisher)
    {
      return db.GetConnection().Delete(Publisher);
    }

     public int deleteAllPublishers()
    {
      return db.GetConnection().DeleteAll<Publisher>();
    }

     public int updatePublisher(Publisher Publisher)
    {
      return db.GetConnection().Update(Publisher);
    }
}
