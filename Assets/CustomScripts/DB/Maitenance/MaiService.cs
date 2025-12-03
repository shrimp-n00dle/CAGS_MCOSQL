using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaiService : MonoBehaviour
{
    MaiDB db;

    public MaiService()
    {
        this.db =  new MaiDB();
    }

    public void CreateMaitenanceTable(){
		db.GetConnection().DropTable<Maitenance> ();
		db.GetConnection().CreateTable<Maitenance> ();
    }

    public int addMaitenance(Maitenance Maitenance)
    {
      return db.GetConnection().Insert(Maitenance);
    }

    public int addMaitenances(Maitenance[] Maitenances)
    {
      return db.GetConnection().InsertAll(Maitenances);
    }

    public IEnumerable<Maitenance> GetMaitenances()
    {
		  return db.GetConnection().Table<Maitenance>();
	  }

    public IEnumerable<Maitenance> GetMaitenances(int value)
    {
		  return db.GetConnection().Table<Maitenance>().Where(x => x.serial_number == value);
	  }

     public int deleteMaitenance(Maitenance Maitenance)
    {
      return db.GetConnection().Delete(Maitenance);
    }

     public int deleteAllMaitenances()
    {
      return db.GetConnection().DeleteAll<Maitenance>();
    }

     public int updateMaitenance(Maitenance Maitenance)
    {
      return db.GetConnection().Update(Maitenance);
    }
}
