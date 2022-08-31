using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    public class BeaconInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string msg { get; set; }
        public string gmac { get; set; }


        public ICollection<SensorInfo> obj { get; set; }



    }
}
