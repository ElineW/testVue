namespace PrimeServices
{
    internal class HomeController
  
        {
            public string GetEmplyeeName(int empId)
            {
                string name;
                if (empId == 1)
                {
                    name = "Jignesh";
                }
                else if (empId == 2)
                {
                    name = "Rakesh";
                }
                else
                {
                    name = "Not Found!";
                }
                return name;
            }

        }

    }