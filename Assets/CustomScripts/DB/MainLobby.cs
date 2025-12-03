using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainLobby : MonoBehaviour
{
    
    //Machine Inputs
    MachineService machService;
    public TMP_InputField SNum,MVenue,MCond,MType, MScore,
    /*Finding Machine Code*/
    SearchSNum, DeleteSNum;


    // Start is called before the first frame update
    void Start()
    {
        machService = new MachineService();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*Machine*/

    private void ToConsole(IEnumerable<Machine> machine){
		foreach (var m in machine) {
			ToConsole(machine.ToString());
		}
	}

	private void ToConsole(string msg){
		Debug.Log (msg);
	}

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


       public void onAddMachinesDB()
    {
        Machine[] machines = new[]{
			new Machine{

			serial_number = 121,
            game_ID = 12001,
            venue_ID = 3001,
            publisher_ID = 112343,


            machine_venue = "Eastwood",
            machine_condition = "Working",
            machine_highscore = 67,
            machine_type = "Claw Machine"
			},
			new Machine{

	        serial_number = 121,
            game_ID = 12001,
            venue_ID = 3001,
            publisher_ID = 112343,


            machine_venue = "Eastwood",
            machine_condition = "Working",
            machine_highscore = 67,
            machine_type = "Claw Machine"
			},
			new Machine{
			serial_number = 121,
            game_ID = 12001,
            venue_ID = 3001,
            publisher_ID = 112343,


            machine_venue = "Eastwood",
            machine_condition = "Working",
            machine_highscore = 67,
            machine_type = "Claw Machine"
			},
			new Machine{
			serial_number = 121,
            game_ID = 12001,
            venue_ID = 3001,
            publisher_ID = 112343,


            machine_venue = "Eastwood",
            machine_condition = "Working",
            machine_highscore = 67,
            machine_type = "Claw Machine"
			}
        };
        int key = machService.addMachines(machines);
        Debug.Log("Primary key is "  + key);

        SNum.text = "";
        MVenue.text = "";
        MCond.text = "";
        MScore.text = "";
        MType.text = "";
    }

    public void onGetMachinesDB()
    {
        var machines = machService.GetMachines();
        ToConsole(machines);
    }

    public void onGetMachinesByNameDB()
    {

        var machines = machService.GetMachines(int.Parse(SearchSNum.text));
        ToConsole(machines);

        SearchSNum.text = "";
    }
    
    public void onDeleteMachinesDB()
    {
        machService.deleteAllMachines();
    }


      public void onDeleteMachineDB()
    {
        Machine machine = new Machine
        {
            serial_number = int.Parse(DeleteSNum.text),

        };
        int key = machService.deleteMachine(machine);
        Debug.Log("Deleted key is  "  + key);

        DeleteSNum.text  = "";
    }
}
