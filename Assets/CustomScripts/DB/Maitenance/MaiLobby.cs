using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MaiLobby : MonoBehaviour
{


    
    //Maitenance Inputs
    MaiService maiService;

    // maintenance_ID,serial_number,technician_ID,maintenance_type 
    // maintenance_status, maintenance_date,maintenance_cost 

    [Header ("MaiInputs")]
    public TMP_InputField SID,MID, Tid, MType, MStatus, MDate, MCost,
    /*Finding Maitenance Code*/
    SearchSNum, DeleteSNum,
    
    /*Update Maitenance Code*/
    USID,UMID, UTid, UMType, UMStatus, UMDate, UMCost;


    // Start is called before the first frame update
    void Start()
    {
        maiService = new MaiService();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*Maitenance*/

    private void ToConsole(IEnumerable<Maitenance> Maitenance){
		foreach (var m in Maitenance) {
			ToConsole(Maitenance.ToString());
		}
	}

	private void ToConsole(string msg){
		Debug.Log (msg);
	}

    public void onCreateMaitenanceDB()
    {
        maiService.CreateMaitenanceTable();
    }

    public void onAddMaitenanceDB()
    {
        Maitenance Maitenance = new Maitenance
        {
        // maintenance_ID,serial_number,technician_ID,maintenance_type 
        // maintenance_status, maintenance_date,maintenance_cost 
        // SID,MID, Tid, MType, MStatus, MDate, MCost,

            maintenance_ID = int.Parse(MID.text),
            serial_number = int.Parse(SID.text),
            technician_ID = int.Parse(Tid.text),
            maintenance_type = MType.text,
            maintenance_status = MStatus.text,
            maintenance_date = MDate.text,
            maintenance_cost = float.Parse(MCost.text)

        };
        int key = maiService.addMaitenance(Maitenance);
        Debug.Log("Primary key is "  + key);

        MID.text = "";
        SID.text = "";
        Tid.text = "";
        MType.text = "";
        MStatus.text = "";
        MDate.text = "";
        MCost.text = "";
        
    }

    public void onGetMaitenancesDB()
    {
        var Maitenances = maiService.GetMaitenances();
        ToConsole(Maitenances);
    }

    public void onGetMaitenancesByNameDB()
    {

        var Maitenances = maiService.GetMaitenances(int.Parse(SearchSNum.text));
        ToConsole(Maitenances);

        SearchSNum.text = "";
    }
    
    public void onDeleteMaitenancesDB()
    {
        maiService.deleteAllMaitenances();
    }


      public void onDeleteMaitenanceDB()
    {
        Maitenance Maitenance = new Maitenance
        {
            maintenance_ID  = int.Parse(DeleteSNum.text),

        };
        int key = maiService.deleteMaitenance(Maitenance);
        Debug.Log("Deleted key is  "  + key);

        DeleteSNum.text  = "";
    }


      public void onUpdateMaitenanceDB()
    {
        Maitenance maitenance = new Maitenance
        {
            maintenance_ID = int.Parse(MID.text),
            serial_number = int.Parse(SID.text),
            technician_ID = int.Parse(Tid.text),
            maintenance_type = MType.text,
            maintenance_status = MStatus.text,
            maintenance_date = MDate.text,
            maintenance_cost = float.Parse(MCost.text)

        };
        int key = maiService.updateMaitenance(maitenance);
        Debug.Log("Updated key is  "  + key);

        UMID.text = "";
        USID.text = "";
        UTid.text = "";
        UMType.text = "";
        UMStatus.text = "";
        UMDate.text = "";
        UMCost.text = "";
    }
}
