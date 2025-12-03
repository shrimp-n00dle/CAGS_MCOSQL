// -- GAME
//CREATE TABLE Game (
//     game_ID           INT PRIMARY KEY,
//     game_title        VARCHAR(100) NOT NULL,
//     game_release_year INT,
//     publisher_ID      INT,
//     CONSTRAINT fk_game_publisher
//         FOREIGN KEY (publisher_ID) REFERENCES Publisher(publisher_ID)
// );

using SQLite4Unity3d;

public class Game  {

	[PrimaryKey, AutoIncrement]
	public int game_ID { get; set; }
	public string game_title { get; set; }
	public int game_release_year { get; set; }
	public int publisher_ID { get; set; }
}
