using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenueService : MonoBehaviour
{
    VenueDB db;

    public VenueService()
    {
        this.db =  new VenueDB();
    }

    public void CreateVenueTable(){
		db.GetConnection().DropTable<Venue> ();
		db.GetConnection().CreateTable<Venue> ();
    }

    public int addVenue(Venue Venue)
    {
      return db.GetConnection().Insert(Venue);
    }

    public int addVenues(Venue[] Venues)
    {
      return db.GetConnection().InsertAll(Venues);
    }

    public IEnumerable<Venue> GetVenues()
    {
		  return db.GetConnection().Table<Venue>();
	  }

    public IEnumerable<Venue> GetVenues(string value)
    {
		  return db.GetConnection().Table<Venue>().Where(x => x.venue_name == value);
	  }

     public int deleteVenue(Venue Venue)
    {
      return db.GetConnection().Delete(Venue);
    }

     public int deleteAllVenues()
    {
      return db.GetConnection().DeleteAll<Venue>();
    }

     public int updateVenue(Venue Venue)
    {
      return db.GetConnection().Update(Venue);
    }
}
