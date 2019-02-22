using System;

namespace URL
{
    class Program
    {
        static void Main(string[] args)
        {
            string project_name;
            string activity_name;
            string x = "y";
            while (x == "y")
            {
                Console.WriteLine("Please enter the the name of the document: ");
                project_name = Console.ReadLine();
                foreach (char z in project_name)
                {
                    if (z <= (char)1F || z>= (char) 00 || z == (char)7f)
                    {
                        Console.WriteLine("Please refrain from using control characters, and try again: ");
                        project_name = Console.ReadLine();
                        break;
                    }
                }
                Console.WriteLine("Enter the activity name: ");
                activity_name = Console.ReadLine();
                foreach (char z in activity_name)
                {
                    if (z <= (char)1F || z>= (char) 00 || z == (char)7f)
                    {
                        Console.WriteLine("Please refrain from using control characters, and try again: ");
                        activity_name = Console.ReadLine();
                        break;
                    }
                }
                project_name = project_name.Replace("%", "%25");
			    project_name = project_name.Replace(" ", "%20");
			    project_name = project_name.Replace("<", "%3C");
			    project_name = project_name.Replace(">", "%3E");
			    project_name = project_name.Replace("#", "%23");
			    project_name = project_name.Replace("\"","%22");
			    project_name = project_name.Replace(";", "%3B");
			    project_name = project_name.Replace("/", "%2F");
			    project_name = project_name.Replace("?", "%3F");
			    project_name = project_name.Replace(":", "%3A");
			    project_name = project_name.Replace("@", "%40");
			    project_name = project_name.Replace("&", "%26");
			    project_name = project_name.Replace("=", "%3D");
			    project_name = project_name.Replace("+", "%2B");
			    project_name = project_name.Replace("$", "%24");
			    project_name = project_name.Replace("{", "%7B");
			    project_name = project_name.Replace("}", "%7D");
			    project_name = project_name.Replace("|", "%7C");
			    project_name = project_name.Replace("\\", "%5C");
			    project_name = project_name.Replace("^", "%5E");
			    project_name = project_name.Replace("[", "%5B");
			    project_name = project_name.Replace("]", "%5D");
			    project_name = project_name.Replace("`", "%60");
			    activity_name = activity_name.Replace("%", "%25");
			    activity_name = activity_name.Replace(" ", "%20");
			    activity_name = activity_name.Replace("<", "%3C");
			    activity_name = activity_name.Replace(">", "%3E");
			    activity_name = activity_name.Replace("#", "%23");
			    activity_name = activity_name.Replace("\"", "%22");
			    activity_name = activity_name.Replace(";", "%3B");
			    activity_name = activity_name.Replace("/", "%2F");
			    activity_name = activity_name.Replace("?", "%3F");
			    activity_name = activity_name.Replace(":", "%3A");
			    activity_name = activity_name.Replace("@", "%40");
			    activity_name = activity_name.Replace("&", "%26");
			    activity_name = activity_name.Replace("=", "%3D");
			    activity_name = activity_name.Replace("+", "%2B");
			    activity_name = activity_name.Replace("$", "%24");
			    activity_name = activity_name.Replace("{", "%7B");
			    activity_name = activity_name.Replace("}", "%7D");
			    activity_name = activity_name.Replace("|", "%7C");
			    activity_name = activity_name.Replace("\\", "%5C");
			    activity_name = activity_name.Replace("^", "%5E");
			    activity_name = activity_name.Replace("[", "%5B");
			    activity_name = activity_name.Replace("]", "%5D");
			    activity_name = activity_name.Replace("`", "%60");

                Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", project_name, activity_name);
                Console.WriteLine("If you would like another URL, please enter 'y'. If you wish to exit enter any other character.");
                x = Console.ReadLine();
            }
        }
    }
}
