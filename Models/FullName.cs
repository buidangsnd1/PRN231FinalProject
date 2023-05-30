using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Models
{
    public class FullName
    {
        [JsonProperty("first")]
        public string FirstName { get; set; }
        [JsonProperty("last")]
        public string LastName { get; set; }
        [JsonProperty("mid")]
        public string MidName { get; set; }
        public FullName() { }
        public FullName(string fullName) {
            //null k goi tiep rong nua
        var data = fullName?.Split(' ');
            FirstName = data[data.Length-1];
            LastName = data[0];
            var mid = "";
            for(int i = 1; i < data.Length - 1; i++)
            {
                mid += data[i] +" ";
            }
            MidName = mid.TrimEnd();           
        }

        public FullName(string fisrtName, string lastName, string midName)
        {
            FirstName = fisrtName;
            LastName = lastName;
            MidName = midName;
        }
        public override string ToString()
        {
            return $"{LastName} {MidName} {FirstName}";
        }
    }

}
