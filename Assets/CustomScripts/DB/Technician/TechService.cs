using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechService : MonoBehaviour
{
    TechDB db;

    public TechService()
    {
        this.db =  new TechDB();
    }

    public void CreateTechnicianTable(){
		db.GetConnection().DropTable<Technician> ();
		db.GetConnection().CreateTable<Technician> ();
    }

    public int addTechnician(Technician Technician)
    {
      return db.GetConnection().Insert(Technician);
    }

    public int addTechnicians(Technician[] Technicians)
    {
      return db.GetConnection().InsertAll(Technicians);
    }

    public IEnumerable<Technician> GetTechnicians()
    {
		  return db.GetConnection().Table<Technician>();
	  }

    public IEnumerable<Technician> GetTechnicians(string value)
    {
		  return db.GetConnection().Table<Technician>().Where(x => x.technician_name == value);
	  }

     public int deleteTechnician(Technician Technician)
    {
      return db.GetConnection().Delete(Technician);
    }

     public int deleteAllTechnicians()
    {
      return db.GetConnection().DeleteAll<Technician>();
    }

     public int updateTechnician(Technician Technician)
    {
      return db.GetConnection().Update(Technician);
    }
}
