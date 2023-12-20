using CompetetiveTaskEducationaAndCertificationAutomation.DataModel;
//using CompetetiveTaskEducationaAndCertificationAutomation.DataModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetetiveTaskEducationaAndCertificationAutomation.Utilities
{
    public class ReadJsonData
    {
        private readonly string _sampleJsonFilePath;
        public ReadJsonData(string sampleJsonFilePath)
        {
            _sampleJsonFilePath = sampleJsonFilePath;
        }

        public List<EducationDataModel> EducationObjectWithNewtonsoftJson()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<EducationDataModel> educations = JsonConvert.DeserializeObject<List<EducationDataModel>>(json);
            return educations;
        }
    }


    


}



