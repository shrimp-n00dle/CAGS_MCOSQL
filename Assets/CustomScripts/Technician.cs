// -- TECHNICIAN
// CREATE TABLE Technician (
//     technician_ID   INT PRIMARY KEY,
//     technician_name VARCHAR(100) NOT NULL,
//     technician_type VARCHAR(100)
// );

using SQLite4Unity3d;

public class Technician {

	[PrimaryKey, AutoIncrement]
	public int technician_ID_ID { get; set; }
	public string technician_name { get; set; }
	public string technician_type{ get; set; }
}
