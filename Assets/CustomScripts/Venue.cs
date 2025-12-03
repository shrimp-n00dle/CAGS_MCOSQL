// -- VENUE
// CREATE TABLE Venue (
//     venue_ID      INT PRIMARY KEY,
//     venue_name    VARCHAR(150) NOT NULL,
//     venue_address VARCHAR(255) NOT NULL
// );

using SQLite4Unity3d;

public class Game  {

	[PrimaryKey, AutoIncrement]
	public int venue_ID { get; set; }
	public string venue_name { get; set; }
	public string venue_address { get; set; }
}
