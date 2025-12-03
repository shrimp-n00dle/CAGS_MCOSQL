using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AdminLobby : MonoBehaviour
{
    
    //Admin Inputs
    AdminService AdminService;

    [Header ("AdminInputs")]
    public TMP_InputField SID,AName,ALoc,VenId,
    /*Finding Admin Code*/
    SearchSNum, DeleteSNum,
    
    /*Update Admin Code*/
    USID,UAName,UALoc,UVenId;


    // Start is called before the first frame update
    void Start()
    {
        AdminService = new AdminService();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*Admin*/

    private void ToConsole(IEnumerable<Admin> Admin){
		foreach (var m in Admin) {
			ToConsole(Admin.ToString());
		}
	}

	private void ToConsole(string msg){
		Debug.Log (msg);
	}

    public void onCreateAdminDB()
    {
        AdminService.CreateAdminTable();
    }

    public void onAddAdminDB()
    {
        Admin Admin = new Admin
        {
            //SID,AName,ALoc,VenId
            admin_ID = int.Parse(SID.text),
            admin_name = AName.text,
            admin_location = ALoc.text,
            venue_ID = int.Parse(VenId.text)

        };
        int key = AdminService.addAdmin(Admin);
        Debug.Log("Primary key is "  + key);

        SID.text=AName.text=ALoc.text=VenId.text = "";
    }

    public void onGetAdminsDB()
    {
        var Admins = AdminService.GetAdmins();
        ToConsole(Admins);
    }

    public void onGetAdminsByNameDB()
    {

        var Admins = AdminService.GetAdmins(int.Parse(SearchSNum.text));
        ToConsole(Admins);

        SearchSNum.text = "";
    }
    
    public void onDeleteAdminsDB()
    {
        AdminService.deleteAllAdmins();
    }


      public void onDeleteAdminDB()
    {
        Admin Admin = new Admin
        {
            admin_ID  = int.Parse(DeleteSNum.text),

        };
        int key = AdminService.deleteAdmin(Admin);
        Debug.Log("Deleted key is  "  + key);

        DeleteSNum.text  = "";
    }


      public void onUpdateAdminDB()
    {
        Admin Admin = new Admin
        {
            admin_ID = int.Parse(USID.text),
            admin_name = UAName.text,
            admin_location = UALoc.text,
            venue_ID = int.Parse(UVenId.text)

        };
        int key = AdminService.updateAdmin(Admin);
        Debug.Log("Deleted key is  "  + key);

        SID.text=AName.text=ALoc.text=VenId.text = "";
    }
}
