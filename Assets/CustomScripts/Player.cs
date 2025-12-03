// -- PLAYER
// CREATE TABLE Player (
//     player_ID        VARCHAR(50) PRIMARY KEY,
//     player_name      VARCHAR(100) NOT NULL,
//     player_highscore INT
// );

using SQLite4Unity3d;

public class Player{

	[PrimaryKey, AutoIncrement]
	public int player_ID { get; set; }
	public string player_name{ get; set; }
	public int player_highscore{ get; set; }
}
