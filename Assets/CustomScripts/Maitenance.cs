// -- MAINTENANCE
// CREATE TABLE Maintenance (
//     maintenance_ID    VARCHAR(50) PRIMARY KEY,
//     serial_number     VARCHAR(50) NOT NULL,
//     technician_ID     INT,
//     maintenance_type  VARCHAR(100),
//     maintenance_status VARCHAR(50),
//     maintenance_date  DATE,
//     maintenance_cost  DECIMAL(10,2),
//     CONSTRAINT fk_maint_machine
//         FOREIGN KEY (serial_number) REFERENCES Machine(serial_number),
//     CONSTRAINT fk_maint_technician
//         FOREIGN KEY (technician_ID) REFERENCES Technician(technician_ID)
// );

using SQLite4Unity3d;

public class Maitenance{

	[PrimaryKey, AutoIncrement]
	public int maintenance_ID { get; set; }
	public int serial_number{ get; set; }
	public int technician_ID{ get; set; }
    public string maintenance_type { get; set; }
    public string maintenance_status { get; set; }
    public string maintenance_date { get; set; }

     public float maintenance_cost { get; set; }




}
