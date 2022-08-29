using System;
namespace ICETask3
{
	public class Employee
	{
		
        public int depID { get; set; }
        public string empSurname { get; set; }	

        //Class Constructor
        public Employee(int depID, string empSurname)
		{
			this.depID = depID;
			this.empSurname = empSurname;
		}
	}
}

