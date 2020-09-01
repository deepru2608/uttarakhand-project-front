using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uttarakhand_project_front.Models
{
    public class StateData
    {
        public string id { get; set; }
        public string state { get; set; }
        public string active { get; set; }
        public string confirmed { get; set; }
        public string recovered { get; set; }
        public string deaths { get; set; }
        public string aChanges { get; set; }
        public string cChanges { get; set; }
        public string rChanges { get; set; }
        public string dChanges { get; set; }
        public IEnumerable<DistrictClass> districtData { get; set; }
        public string achanges { get; set; }
        public string dchanges { get; set; }
        public string rchanges { get; set; }
        public string cchanges { get; set; }
    }

    public class DistrictClass
    {
        public string id { get; set; }
        public string state { get; set; }
        public string name { get; set; }
        public string confirmed { get; set; }
        public string recovered { get; set; }
        public string deaths { get; set; }
        public string oldConfirmed { get; set; }
        public string oldRecovered { get; set; }
        public string oldDeaths { get; set; }
        public string zone { get; set; }
    }
}
