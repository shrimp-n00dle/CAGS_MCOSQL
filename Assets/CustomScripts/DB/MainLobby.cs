using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainLobby : MonoBehaviour
{
    
    //Machine Inputs
    MachineService machService;
    public TMP_InputField SNum,MVenue,MCond,MType, MScore;


    // Start is called before the first frame update
    void Start()
    {
        machService = new MachineService();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //BUTTON BEHAVIOUR
    public void onCreateMachineDB()
    {
        machService.CreateMachineTable();
    }

    public void onAddMachineDB()
    {
        Machine machine = new Machine
        {
            serial_number = int.Parse(SNum.text),
            game_ID = 12001,
            venue_ID = 3001,
            publisher_ID = 112343,


            machine_venue = MVenue.text,
            machine_condition = MCond.text,
            machine_highscore = int.Parse(MScore.text),
            machine_type = MType.text

        };
        int key = machService.addMachine(machine);
        Debug.Log("Primary key is "  + key);

        SNum.text = "";
        MVenue.text = "";
        MCond.text = "";
        MScore.text = "";
        MType.text = "";
    }
	
}
