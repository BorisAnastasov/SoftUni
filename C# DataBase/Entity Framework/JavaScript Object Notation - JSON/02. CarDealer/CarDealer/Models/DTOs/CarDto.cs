namespace CarDealer.Models.DTOs;

public class CarDto
{
       public string Make { get; set; }
       public string Model { get; set; }
       public long TraveledDistance { get; set; }
       public int[] PartsId { get; set; }


}
