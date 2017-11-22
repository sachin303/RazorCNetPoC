using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace RazorC.AdminApp.App_Code
{
    public static class ApplicationDirectory
    {
        static ApplicationDirectory()
        {
            var basePath = HttpContext.Current.Request.PhysicalApplicationPath;
            var textJson = File.ReadAllText(basePath + "/ApplicationDirectory.json");
            AppFiles = JsonConvert.DeserializeObject<ApplicationFile>(textJson);
        }

        public static ApplicationFile AppFiles { get; set; }
        
    }

    public class ApplicationFile {

        public IEnumerable<string> addOns { get; set; }

        public IEnumerable<string> bodyPages { get; set; }

        public IEnumerable<string> templates { get; set; }
        public IEnumerable<string> layouts { get; set; }

        public IEnumerable<MasterPageCss> masterPageCss { get; set; }


    }

    public class MasterPageCss {
        public string Name { get; set; }
        public string DirectoryName { get; set; }

    }
}