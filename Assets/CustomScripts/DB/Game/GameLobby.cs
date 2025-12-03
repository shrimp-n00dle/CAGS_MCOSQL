using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameLobby : MonoBehaviour
{

    // 	public int game_ID { get; set; }
	// public string game_title { get; set; }
	// public int game_release_year { get; set; }
	// public int publisher_ID { get; set; }
    
    //Game Inputs
    GameService gameService;

    [Header ("GameInputs")]
    public TMP_InputField SID,GName,GYear,VenId,
    /*Finding Game Code*/
    SearchSNum, DeleteSNum,
    
    /*Update Game Code*/
    USID,UGName,UGYear;


    // Start is called before the first frame update
    void Start()
    {
        gameService = new GameService();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*Game*/

    private void ToConsole(IEnumerable<Game> Game){
		foreach (var m in Game) {
			ToConsole(Game.ToString());
		}
	}

	private void ToConsole(string msg){
		Debug.Log (msg);
	}

    public void onCreateGameDB()
    {
        gameService.CreateGameTable();
    }

    public void onAddGameDB()
    {
        Game Game = new Game
        {
           //SID,GName,GYear,VenId,
            game_ID = int.Parse(SID.text),
            game_title = GName.text,
            game_release_year = int.Parse(GYear.text),
            publisher_ID = int.Parse(VenId.text)

        };
        int key = gameService.addGame(Game);
        Debug.Log("Primary key is "  + key);

        SID.text=GName.text=GYear.text=VenId.text = "";
    }

    public void onGetGamesDB()
    {
        var Games = gameService.GetGames();
        ToConsole(Games);
    }

    public void onGetGamesByNameDB()
    {

        var Games = gameService.GetGames(SearchSNum.text);
        ToConsole(Games);

        SearchSNum.text = "";
    }
    
    public void onDeleteGamesDB()
    {
        gameService.deleteAllGames();
    }


      public void onDeleteGameDB()
    {
        Game Game = new Game
        {
            game_ID  = int.Parse(DeleteSNum.text),

        };
        int key = gameService.deleteGame(Game);
        Debug.Log("Deleted key is  "  + key);

        DeleteSNum.text  = "";
    }


      public void onUpdateGameDB()
    {
        Game game = new Game
        {
            //SID,GName,GYear,VenId,
            game_ID = int.Parse(USID.text),
            game_title = UGName.text,
            game_release_year = int.Parse(UGYear.text),

        };
        int key = gameService.updateGame(game);
        Debug.Log("Updated key is  "  + key);

        SID.text=GName.text=GYear.text=VenId.text = "";
    }
}
