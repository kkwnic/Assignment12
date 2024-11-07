using System;
using SQLite;

namespace SQLiteDemo.MVVM.Models;

public class Car
{
    [PrimaryKey , AutoIncrement]
    public int ID { get ; set ;}
    
    [Column("car_id")]
    public string CarId { get; set; }
    
    [Column("name")]
    public string Name { get; set; }

    [Column("color")]
    public string Color { get; set; }
    

}