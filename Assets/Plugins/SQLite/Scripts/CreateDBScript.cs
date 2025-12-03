using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class CreateDBScript : MonoBehaviour {

	public Text DebugText;

	// Use this for initialization
	void Start () {
		StartSync();
	}

    private void StartSync()
    {
        var ds = new DataService("arcade.db");
        //ds.CreateDB();

        /*var people = ds.GetPersons ();
        ToConsole (people);
        people = ds.GetPersonsNamedRoberto ();
        ToConsole("Searching for Roberto ...");
        ToConsole (people); */

        /*var titles = ds.GetAllGames();
        ToConsole("Games in DB:");
        foreach (var t in titles)
        {
            ToConsole(t);
        }*/

        ToConsole("All games (ID, Title, Year):");

        var games = ds.GetAllGames();           // call the new method

        foreach (var g in games)
        {
            ToConsole($"{g.game_ID} - {g.game_title} ({g.game_release_year})");
        }
    }
	
	private void ToConsole(IEnumerable<Person> people){
		foreach (var person in people) {
			ToConsole(person.ToString());
		}
	}
	
	private void ToConsole(string msg){
		DebugText.text += System.Environment.NewLine + msg;
		Debug.Log (msg);
	}
}
