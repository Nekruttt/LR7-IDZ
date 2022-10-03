using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_IDZ
{
    class Programm
    {
        static void Main(string[] args)
        {
            UserInfo user1 = new UserInfo("EvgenBro", "423423", "Moscow");
            UserInfo user2 = new UserInfo("Vladimir", "13255", "Moscow");
            UserInfo user3 = new UserInfo("Bolis", "ASddsa", "Paris");
            UserInfo user4 = new UserInfo("Kapot", "ASDda", "Paris");
            UserInfo user5 = new UserInfo("Olga", "#$@!$@", "Stavropol");
            UserInfo user6 = new UserInfo("Katya", "*)($#", "Stavropol");
            DepartmentInfo dep1 = new DepartmentInfo("Techno", "Moscow");
            dep1.Add(user1);
            dep1.Add(user2);
            dep1.Delete(user2);
            dep1.Delete(new UserInfo("User", "11231", "Dnepr"));
            DepartmentInfo dep2 = new DepartmentInfo("Writer", "Paris");
            dep2.Add(user3);
            dep2.Add(user4);
            DepartmentInfo dep3 = new DepartmentInfo("Reader", "Stavropol");
            dep3.Add(user5);
            dep3.Add(user6);
            Storage data = new Storage();
            data.Add(dep1);
            data.Add(dep2);
            data.Add(dep3);
            data.Delete(dep2);

            data.Find("EvgenBro");
        }
    }
}
