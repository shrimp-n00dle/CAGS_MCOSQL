using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLobby : MonoBehaviour
{
    
    //Player Inputs
    PlayerService machService;

    [Header ("PlayerInputs")]

    //player_ID, player_name,player_highscore
    public TMP_InputField Pid,PName, PScore,
    /*Finding Player Code*/
    SearchSNum, DeleteSNum,
    
    /*Update Player Code*/
    UPid,UPName, UPScore;


    // Start is called before the first frame update
    void Start()
    {
        machService = new PlayerService();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*Player*/

    private void ToConsole(IEnumerable<Player> Player){
		foreach (var m in Player) {
			ToConsole(Player.ToString());
		}
	}

	private void ToConsole(string msg){
		Debug.Log (msg);
	}

    public void onCreatePlayerDB()
    {
        machService.CreatePlayerTable();
    }

    public void onAddPlayerDB()
    {
        Player Player = new Player
        {
            //Pid,PName, PScore
            player_ID = int.Parse(Pid.text),
            player_name = PName.text,
            player_highscore = int.Parse(PScore.text)


        };
        int key = machService.addPlayer(Player);
        Debug.Log("Primary key is "  + key);

        Pid.text = "";
        PName.text = "";
        PScore.text  = "";
    }
    public void onGetPlayersDB()
    {
        var Players = machService.GetPlayers();
        ToConsole(Players);
    }

    public void onGetPlayersByNameDB()
    {

        var Players = machService.GetPlayers(SearchSNum.text);
        ToConsole(Players);

        SearchSNum.text = "";
    }
    
    public void onDeletePlayersDB()
    {
        machService.deleteAllPlayers();
    }


      public void onDeletePlayerDB()
    {
        Player Player = new Player
        {
            player_ID = int.Parse(DeleteSNum.text),

        };
        int key = machService.deletePlayer(Player);
        Debug.Log("Deleted key is  "  + key);

        DeleteSNum.text  = "";
    }


      public void onUpdatePlayerDB()
    {
        Player player = new Player
        {
               //Pid,PName, PScore
            player_ID = int.Parse(UPid.text),
            player_name = UPName.text,
            player_highscore = int.Parse(UPScore.text)

        };
        int key = machService.updatePlayer(player);
        Debug.Log("Deleted key is  "  + key);

        UPid.text = "";
        UPName.text = "";
        UPScore.text  = "";
    }
}
