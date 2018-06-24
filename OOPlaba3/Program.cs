using System;

namespace OOPlaba2
{
    internal class Program
    {           
        private static void Main()
        {
            try
            {
                Industry industry = new Industry();
                industry = Init.InitializeOrganization(industry);
                Menu.ShowClassWork(industry);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }

}
