using System;
using PPM.Main.PPM.Model;
namespace PPM.Main.PPM.Domain
{
    //Class which consists of methods for adding and viewing projects
    public class ProjectManagement
    {

        public List<Project> Projects = new List<Project>();


        //Method for adding projects
        public void AddingProjects(Project project)
        {
            Projects.Add(project);
        }
        public void displayProject(Project project)
        {
            Console.WriteLine(" Name of the project - " + project.ProjectName + "\n Project Id - " + project.id + "\n Start date of project - " + project.Startdate + "\n End date of project - " + project.Enddate);
            Console.WriteLine("");
        }

        public void displayAllProjects()
        {
            foreach (var e in Projects)
            {
                displayProject(e);
            }
        }

        //Method to view all projects
        public void ShowProject(int eid)
        {
            foreach (Project e in Projects)
            {

                if (e.id == eid)
                {
                    Console.WriteLine(" Name of the project - " + e.ProjectName + "\n Project Id - " + e.id + "\n Start date of project - " + e.Startdate + "\n End date of project - " + e.Enddate);
                }
                else
                {
                    Console.WriteLine("Id not found");
                }
            }
        }

        public void SearchProject(string search)
        {
            var match = Projects.Where(c => c.ProjectName.Contains(search));
            foreach (var e in match)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(" Name of the project - " + e.ProjectName + "\n Project Id - " + e.id + "\n Start date of project - " + e.Startdate + "\n End date of project - " + e.Enddate);
            }
        }
    }
    //Class which consists of methods for adding and viewing Employees
    public class EmpManagement
    {
        public List<Employee> empList = new List<Employee>();



        //Method for adding new employee
        public void AddEmp(Employee emp)
        {
            empList.Add(emp);
        }


        public void displayEmp(Employee emp)
        {
            Console.WriteLine(" Employee Id - " + emp.EmployeeID + "\n Employee first name - " + emp.EmpFirstName + "\n Employee last name - " + emp.lastName + "\n Employee email id - " + emp.email + "\n Employee mobile number - " + emp.mobile + "\n Employee address - " + emp.address + "\n Role Id - " + emp.roleid + "\n Role Name - " + emp.roleName);
            Console.WriteLine("");
            Console.WriteLine("");
        }


        public string ep(int eid)
        {
            string emp1 = "";
            Employee emp = new Employee();
            for (int i = 0; i > empList.Count; i++)
            {
                if (eid == emp.EmployeeID)
                {
                    emp1 = emp.EmpFirstName;
                    return emp1;
                }
            }
            return emp1;
        }



        /*   public void emptopro(int pid,String ename)
               {
                   ProjectManagement obj = new ProjectManagement();
                Project project = new Project();
               for(int i=0; i>obj.Projects.Count-1;i++)
                   {
                       if (project.id == pid)
                   {
                           project.AddEmployee(pid, ename);
                   }
               }
           }*/

        //Method for viewing all employees
        public void ShowEmp()
        {
            foreach (var e in empList)
            {
                displayEmp(e);
            }
        }

        public void ShowEmployee(int eid)
        {
            foreach (Employee e in empList)
            {

                if (e.EmployeeID == eid)
                {
                    Console.WriteLine(" Name of the Employee - " + e.EmpFirstName + " " + e.lastName + "\n Employee Id - " + e.EmployeeID);
                }
                else
                {
                    Console.WriteLine("Id not found");
                }
            }
        }
    }

    //Class which consists of methods for adding and viewing roles
    public class RoleManagement
    {


        public List<Role> RoleList = new List<Role>();



        //Method for adding roles
        public void RoleAdd(Role role)
        {
            RoleList.Add(role);
        }

        //Method for viewing all roles
        public void displayRole()
        {
            foreach (var e in RoleList)
            {
                Console.WriteLine(" Name of the Role - " + e.RoleName + "\n Role Id - " + e.RoleId);
                Console.WriteLine();
            }
        }
    }
}


/*public class AddingEmptoProject
{
    public List<AddEmptoProject> AddingEmplist = new List<AddEmptoProject>();

    public void addingemp(AddEmptoProject add)
    {
        AddingEmplist.Add(add);
    }
    
    
    
    public void displayingemp()
    {
        foreach (AddEmptoProject e in AddingEmplist)
        {
            Console.WriteLine("Project list with employees \nName of the project - "+e.ProjectName+ "\n projectmembers - "+e.EMPfirstName);
        }
    }
}
}*/
