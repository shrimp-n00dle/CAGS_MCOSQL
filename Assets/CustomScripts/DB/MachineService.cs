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

}
