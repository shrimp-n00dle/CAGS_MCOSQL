// -- SCORE HISTORY
// CREATE TABLE Score_History (
//     score_ID        INT PRIMARY KEY,
//     serial_number   VARCHAR(50) NOT NULL,
//     player_ID       VARCHAR(50),
//     score_value     INT,
//     score_input_date DATE,
//     CONSTRAINT fk_score_machine
//         FOREIGN KEY (serial_number) REFERENCES Machine(serial_number),
//     CONSTRAINT fk_score_player
//         FOREIGN KEY (player_ID) REFERENCES Player(player_ID)
// );

using SQLite4Unity3d;

public class ScoreHistory{

	[PrimaryKey, AutoIncrement]
	public int score_ID { get; set; }
	public int serial_number{ get; set; }

    public int player_ID{ get; set; }
	public int score_value{ get; set; }

    public string score_input_date{ get; set; }
}
