
namespace BreakingNewsTobiasOlsson.Classes
{
    /// <summary>
    /// Contains global variabels for the project.
    /// </summary>
    public class GlobalVariabels
    {
        private static string url = ("");
        private static string serchCriteria = ("");
        private static string htmlCode { get; set; }
        private static string statusbarNr = "0";

        /// <summary>
        /// Keeps track of the current selected web site of the user.
        /// </summary>
        public static string Url
        {
            get { return url; }
            set { url = value; }
        }

        /// <summary>
        /// Keeps track of the current selected search criteria made by the user.
        /// </summary>
        public static string SerchCriteria
        {
            get { return serchCriteria; }
            set { serchCriteria = value; }
        }

        public static string HtmlCode
        {
            get { return htmlCode; }
            set { htmlCode = value; }
        }

        public static string StatusBarNr
        {
            get { return statusbarNr; }
            set { statusbarNr = value; }
        }
    }
}