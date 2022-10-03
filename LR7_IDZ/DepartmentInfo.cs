using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_IDZ
{
    internal class DepartmentInfo
    {
        private string name;
        private string location;
        private List<UserInfo> users;

        public DepartmentInfo(string pName, string pLocation)
        {
            name = pName;
            location = pLocation;
            users = new List<UserInfo>();
        }
        public void Add(UserInfo user)
        {
            users.Add(user);
        }
        public void Delete(UserInfo user)   
        {
            if (users.Contains(user))
            {
                users.Remove(user);
            }
            else
            {
                Console.WriteLine("Данного пользователя не существует");
                Console.WriteLine();
            }
        }
        public void GetInfo()
        {
            Console.WriteLine($"Название отдела: {name} \nМеторасположение отдела: {location} \nКоличество сотрудников: {users.Count.ToString()}");
            Console.WriteLine();
        }
        public List<UserInfo> GetList()
        {
            return users;
        }
    }
}
