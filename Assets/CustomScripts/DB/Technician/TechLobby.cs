using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TechLobby : MonoBehaviour
{
    
    //Technician Inputs
    TechService machService;

    [Header ("TechnicianInputs")]

    //technician_ID,technician_name, technician_type
    // utid,utname,uttype;
    public TMP_InputField tid,tname,ttype,
    /*Finding Technician Code*/
    SearchSNum, DeleteSNum,
    
    /*Update Technician Code*/
    utid,utname,uttype;


    // Start is called before the first frame update
    void Start()
    {
        machService = new TechService();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*Technician*/

    private void ToConsole(IEnumerable<Technician> Technician){
		foreach (var m in Technician) {
			ToConsole(Technician.ToString());
		}
	}

	private void ToConsole(string msg){
		Debug.Log (msg);
	}

    public void onCreateTechnicianDB()
    {
        machService.CreateTechnicianTable();
    }

    public void onAddTechnicianDB()
    {
        Technician tech = new Technician
        {
            //technician_ID,technician_name, technician_type
            // utid,utname,uttype;
            technician_ID = int.Parse(tid.text),
            technician_name = tname.text,
            technician_type= ttype.text,


        };
        int key = machService.addTechnician(tech);
        Debug.Log("Primary key is "  + key);

        //technician_ID,technician_name, technician_type
        // utid,utname,uttype;

        tid.text = "";
        tname.text = "";
        ttype.text = "";

    }
    public void onGetTechniciansDB()
    {
        var Technicians = machService.GetTechnicians();
        ToConsole(Technicians);
    }

    public void onGetTechniciansByNameDB()
    {

        var Technicians = machService.GetTechnicians(SearchSNum.text);
        ToConsole(Technicians);

        SearchSNum.text = "";
    }
    
    public void onDeleteTechniciansDB()
    {
        machService.deleteAllTechnicians();
    }


      public void onDeleteTechnicianDB()
    {
        Technician Technician = new Technician
        {
            technician_ID = int.Parse(DeleteSNum.text),

        };
        int key = machService.deleteTechnician(Technician);
        Debug.Log("Deleted key is  "  + key);

        DeleteSNum.text  = "";
    }


      public void onUpdateTechnicianDB()
    {
        Technician Technician = new Technician
        {
              //technician_ID,technician_name, technician_type
            // utid,utname,uttype;
            technician_ID = int.Parse(utid.text),
            technician_name = utname.text,
            technician_type= uttype.text,


        };
        int key = machService.updateTechnician(Technician);
        Debug.Log("Updated key is  "  + key);

        utid.text = "";
        utname.text = "";
        uttype.text = "";
    }
}
