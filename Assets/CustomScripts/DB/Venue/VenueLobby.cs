using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VenueLobby : MonoBehaviour
{
    
    //Venue Inputs
    VenueService machService;

    [Header ("VenueInputs")]

    //venue_ID, venue_name,venue_address
    // utid,utname,uttype;
    public TMP_InputField vid, vname,vaddress,
    /*Finding Venue Code*/
    SearchSNum, DeleteSNum,
    
    /*Update Venue Code*/
    uvid, uvname,uvaddress;


    // Start is called before the first frame update
    void Start()
    {
        machService = new VenueService();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*Venue*/

    private void ToConsole(IEnumerable<Venue> Venue){
		foreach (var m in Venue) {
			ToConsole(Venue.ToString());
		}
	}

	private void ToConsole(string msg){
		Debug.Log (msg);
	}

    public void onCreateVenueDB()
    {
        machService.CreateVenueTable();
    }

    public void onAddVenueDB()
    {
        Venue tech = new Venue
        {
            //Venue_ID,Venue_name, Venue_type
            // utid,utname,uttype;
            venue_ID = int.Parse(vid.text),
            venue_name = vname.text,
            venue_address = vaddress.text,


        };
        int key = machService.addVenue(tech);
        Debug.Log("Primary key is "  + key);

        //Venue_ID,Venue_name, Venue_type
        // utid,utname,uttype;

        vid.text = "";
        vname.text = "";
        vaddress.text = "";

    }
    public void onGetVenuesDB()
    {
        var Venues = machService.GetVenues();
        ToConsole(Venues);
    }

    public void onGetVenuesByNameDB()
    {

        var Venues = machService.GetVenues(SearchSNum.text);
        ToConsole(Venues);

        SearchSNum.text = "";
    }
    
    public void onDeleteVenuesDB()
    {
        machService.deleteAllVenues();
    }


      public void onDeleteVenueDB()
    {
        Venue Venue = new Venue
        {
            venue_ID = int.Parse(DeleteSNum.text),

        };
        int key = machService.deleteVenue(Venue);
        Debug.Log("Deleted key is  "  + key);

        DeleteSNum.text  = "";
    }


      public void onUpdateVenueDB()
    {
        Venue Venue = new Venue
        {
            
            venue_ID = int.Parse(uvid.text),
            venue_name = uvname.text,
            venue_address = uvaddress.text,


        };
        int key = machService.updateVenue(Venue);
        Debug.Log("Updated key is  "  + key);

        uvid.text = "";
        uvname.text = "";
        uvaddress.text = "";
    }
}
