// -- PUBLISHER
// CREATE TABLE Publisher (
//     publisher_ID   INT PRIMARY KEY,
//     publisher_name VARCHAR(100) NOT NULL
// );

using SQLite4Unity3d;

public class Publisher {

	[PrimaryKey, AutoIncrement]
	public int publisher_ID { get; set; }
	public string publisher_name { get; set; }
}
