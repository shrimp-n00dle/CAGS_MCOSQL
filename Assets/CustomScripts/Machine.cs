using SQLite4Unity3d;


/*
-- MACHINE
CREATE TABLE Machine (
    serial_number    VARCHAR(50) PRIMARY KEY,
    game_ID          INT,
    venue_ID         INT,
    publisher_ID     INT,
    machine_venue    VARCHAR(150),
    machine_condition VARCHAR(50),
    machine_type     VARCHAR(50),
    machine_highscore INT,
    CONSTRAINT fk_machine_game
        FOREIGN KEY (game_ID) REFERENCES Game(game_ID),
    CONSTRAINT fk_machine_venue
        FOREIGN KEY (venue_ID) REFERENCES Venue(venue_ID),
    CONSTRAINT fk_machine_publisher
        FOREIGN KEY (publisher_ID) REFERENCES Publisher(publisher_ID)
);
*/
public class Machine  {

	[PrimaryKey, AutoIncrement]
	public char serial_number { get; set; }

    //IDs
	public int game_ID { get; set; }
    public int venue_ID { get; set; }
    public int publisher_ID { get; set; }

    //MACHINE STUFF
    public char machine_venue { get; set; }
    public char machine_condition { get; set; }
    public char machine_type{ get; set; }
    public int machine_highscore{ get; set; }

	// public override string ToString ()
	// {
	// 	return string.Format ("[Person: Id={0}, Name={1},  Surname={2}, Age={3}]", Id, Name, Surname, Age);
	// }
}
