using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineService : MonoBehaviour
{
    DB db;

    public MachineService()
    {
        this.db =  new DB();
    }

    public void CreateMachineTable(){
		db.GetConnection().DropTable<Machine> ();
		db.GetConnection().CreateTable<Machine> ();
    }

    public int addMachine(Machine machine)
    {
      return db.GetConnection().Insert(machine);
    }

    public int addMachines(Machine[] machines)
    {
      return db.GetConnection().InsertAll(machines);
    }

    public IEnumerable<Machine> GetMachines(){
		  return db.GetConnection().Table<Machine>();
	}
}
