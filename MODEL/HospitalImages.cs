using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
  public class HospitalImages
    {
        public int HospitalImagesID { get; set; }
        public int HospitalID { get; set; }
       //public string GeneralAssetURL1 { get; set; }
        public string AssetURL { get; set; }
        public string AssetText { get; set; }
        public string AssetImage { get; set; }
        public byte? AssetPositionID { get; set; }
      //  public Nullable<byte> AssetPositionID { get; set; }
       // public int AssetPosition { get; set; }
        public string LoggedInUser { get; set; }
                         
    }
}
