using System.Runtime.CompilerServices;

namespace myBookAPI.Services
{
    public class CSSServices
    {
        public IWebHostEnvironment _environment;

        public CSSServices(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        private string filePath { get {
                return Path.Combine(_environment.WebRootPath, "css", "MyCSS.css");
            } }
       

        public string getCss()
        {
            using(var fs = new StreamReader(filePath))
            {
                return  fs.ReadToEnd();
            }
        }


    }
}
