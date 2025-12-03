using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PubLobby : MonoBehaviour
{
    
    //Publisher Inputs
    PubService machService;

    [Header ("PublisherInputs")]

    //	public int publisher_ID, publisher_name
    public TMP_InputField Pid,PName,
    /*Finding Publisher Code*/
    SearchSNum, DeleteSNum,
    
    /*Update Publisher Code*/
    UPid,UPName;


    // Start is called before the first frame update
    void Start()
    {
        machService = new PubService();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*Publisher*/

    private void ToConsole(IEnumerable<Publisher> Publisher){
		foreach (var m in Publisher) {
			ToConsole(Publisher.ToString());
		}
	}

	private void ToConsole(string msg){
		Debug.Log (msg);
	}

    public void onCreatePublisherDB()
    {
        machService.CreatePublisherTable();
    }

    public void onAddPublisherDB()
    {
        Publisher Publisher = new Publisher
        {
            //Pid,PName, PScore
            publisher_ID = int.Parse(Pid.text),
            publisher_name = PName.text,


        };
        int key = machService.addPublisher(Publisher);
        Debug.Log("Primary key is "  + key);

        Pid.text = "";
        PName.text = "";
    }
    public void onGetPublishersDB()
    {
        var Publishers = machService.GetPublishers();
        ToConsole(Publishers);
    }

    public void onGetPublishersByNameDB()
    {

        var Publishers = machService.GetPublishers(SearchSNum.text);
        ToConsole(Publishers);

        SearchSNum.text = "";
    }
    
    public void onDeletePublishersDB()
    {
        machService.deleteAllPublishers();
    }


      public void onDeletePublisherDB()
    {
        Publisher Publisher = new Publisher
        {
            publisher_ID = int.Parse(DeleteSNum.text),

        };
        int key = machService.deletePublisher(Publisher);
        Debug.Log("Deleted key is  "  + key);

        DeleteSNum.text  = "";
    }


      public void onUpdatePublisherDB()
    {
        Publisher publisher = new Publisher
        {
               //Pid,PName, PScore
            publisher_ID = int.Parse(UPid.text),
            publisher_name = UPName.text,


        };
        int key = machService.updatePublisher(publisher);
        Debug.Log("Deleted key is  "  + key);

        UPid.text = "";
        UPName.text = "";
    }
}
