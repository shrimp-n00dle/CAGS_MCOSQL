using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLobby : MonoBehaviour
{
    
    //ScoreHistory Inputs
    ScoreService machService;

    [Header ("ScoreHistoryInputs")]

    // score_ID, serial_number,player_ID,score_value,score_input_date
    public TMP_InputField Sid,SNum,Pid,SScore,SDate,
    /*Finding ScoreHistory Code*/
    SearchSNum, DeleteSNum,
    
    /*Update ScoreHistory Code*/
    USid,USNum,UPid,USScore,USDate;


    // Start is called before the first frame update
    void Start()
    {
        machService = new ScoreService();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*ScoreHistory*/

    private void ToConsole(IEnumerable<ScoreHistory> ScoreHistory){
		foreach (var m in ScoreHistory) {
			ToConsole(ScoreHistory.ToString());
		}
	}

	private void ToConsole(string msg){
		Debug.Log (msg);
	}

    public void onCreateScoreHistoryDB()
    {
        machService.CreateScoreTable();
    }

    public void onAddScoreHistoryDB()
    {
        ScoreHistory ScoreHistory = new ScoreHistory
        {
            // score_ID, serial_number,player_ID,score_value,score_input_date
            // Sid,SNum,Pid,SScore,SDate,
            score_ID = int.Parse(Sid.text),
            serial_number = int.Parse(SNum.text),
            player_ID = int.Parse(Pid.text),
            score_value = int.Parse(SScore.text),
            score_input_date = SDate.text


        };
        int key = machService.addScore(ScoreHistory);
        Debug.Log("Primary key is "  + key);

        Sid.text = "";
        SNum.text = "";
        Pid.text = "";
        SScore.text = "";
        SDate.text = "";
    }
    public void onGetScoreHistorysDB()
    {
        var ScoreHistorys = machService.GetScoreHistorys();
        ToConsole(ScoreHistorys);
    }

    public void onGetScoreHistorysByNameDB()
    {

        var ScoreHistorys = machService.GetScoreHistorys(int.Parse(SearchSNum.text));
        ToConsole(ScoreHistorys);

        SearchSNum.text = "";
    }
    
    public void onDeleteScoreHistorysDB()
    {
        machService.deleteAllScoreHistorys();
    }


      public void onDeleteScoreHistoryDB()
    {
        ScoreHistory ScoreHistory = new ScoreHistory
        {
            score_ID = int.Parse(DeleteSNum.text),

        };
        int key = machService.deleteScoreHistory(ScoreHistory);
        Debug.Log("Deleted key is  "  + key);

        DeleteSNum.text  = "";
    }


      public void onUpdateScoreHistoryDB()
    {
        ScoreHistory scoreHistory = new ScoreHistory
        {
            score_ID = int.Parse(USid.text),
            serial_number = int.Parse(USNum.text),
            player_ID = int.Parse(UPid.text),
            score_value = int.Parse(USScore.text),
            score_input_date = USDate.text


        };
        int key = machService.updateScoreHistory(scoreHistory);
        Debug.Log("Updated key is  "  + key);

        USid.text = "";
        USNum.text = "";
        UPid.text = "";
        USScore.text = "";
        USDate.text = "";
    }
}
