using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class SensorInfo
    {
        public int id { get; set; }
        public int type { get; set; }
        public string dmac { get; set; }
        public string time { get; set; }
        public int rssi { get; set; }
        public int ver { get; set; }
        public int vbatt { get; set; }
        public double temp { get; set; }
        public double humidty { get; set; }
        public int x0 { get; set; }
        public int y0 { get; set; }
        public int z0 { get; set; }
        public string data1 { get; set; }
        public string uuid { get; set; }
        public int? majorID { get; set; }
        public int? minorID { get; set; }
        public int? refpower { get; set; }

        [ForeignKey("id")]
        public virtual BeaconInfo beaconInfo { get; set; }

    }
}
