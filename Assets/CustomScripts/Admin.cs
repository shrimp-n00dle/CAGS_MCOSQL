// -- ADMINISTRATOR
// CREATE TABLE Administrator (
//     admin_ID       INT PRIMARY KEY,
//     admin_name     VARCHAR(100) NOT NULL,
//     admin_location VARCHAR(100),
//     venue_ID       INT,
//     CONSTRAINT fk_admin_venue
//         FOREIGN KEY (venue_ID) REFERENCES Venue(venue_ID)
// );
using SQLite4Unity3d;

public class Admin {

	[PrimaryKey, AutoIncrement]
	public int admin_ID { get; set; }
	public string admin_name { get; set; }
	public string admin_location{ get; set; }
	public int venue_ID { get; set; }
}
