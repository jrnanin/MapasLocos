using System.ComponentModel.DataAnnotations;

namespace Mapa.Models
{
    public class Point
    {
        [Key]
        public int Id { get; set; }  
        public string Name { get; set; }   
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public TypePoint typePoint { get; set; }
        

    }
    public enum TypePoint
    {
        Point,
        Polygon,
        Layer
    }

}
