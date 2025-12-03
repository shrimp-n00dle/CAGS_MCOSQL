using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdminService : MonoBehaviour
{
    AdminDB db;

    public AdminService()
    {
        this.db =  new AdminDB();
    }

    public void CreateAdminTable(){
		db.GetConnection().DropTable<Admin> ();
		db.GetConnection().CreateTable<Admin> ();
    }

    public int addAdmin(Admin Admin)
    {
      return db.GetConnection().Insert(Admin);
    }

    public int addAdmins(Admin[] Admins)
    {
      return db.GetConnection().InsertAll(Admins);
    }

    public IEnumerable<Admin> GetAdmins()
    {
		  return db.GetConnection().Table<Admin>();
	  }

    public IEnumerable<Admin> GetAdmins(string value)
    {
		  return db.GetConnection().Table<Admin>().Where(x => x.admin_name == value);
	  }

     public int deleteAdmin(Admin Admin)
    {
      return db.GetConnection().Delete(Admin);
    }

     public int deleteAllAdmins()
    {
      return db.GetConnection().DeleteAll<Admin>();
    }

     public int updateAdmin(Admin Admin)
    {
      return db.GetConnection().Update(Admin);
    }
}
