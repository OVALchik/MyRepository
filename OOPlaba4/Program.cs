using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OOPlaba2
{
    internal class Program
    {    
       
        [STAThread]
        private static void Main()
        {
            
            try
            {    
                Industry industry = new Industry(); 
                InitIndustry.InitializeOrganization(industry);
                CreateIndustryController controller = new CreateIndustryController(industry);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new CreateIndustry(controller));



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }

}
