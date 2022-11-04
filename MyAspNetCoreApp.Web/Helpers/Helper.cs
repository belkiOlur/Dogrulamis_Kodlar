using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace MyAspNetCoreApp.Web.Helpers
{
    public class Helper : IHelper
    {
        public string Upper(string text)
        {
            return text.ToUpper();
        }
    }
}
