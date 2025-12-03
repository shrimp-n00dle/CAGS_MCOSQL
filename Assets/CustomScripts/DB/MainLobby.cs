using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLobby : MonoBehaviour
{
    MachineService machService;
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
}
