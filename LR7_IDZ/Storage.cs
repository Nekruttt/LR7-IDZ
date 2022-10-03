using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_IDZ
{
    internal class Storage
    {
        private List<DepartmentInfo> data;

        public Storage()
        {
            data = new List<DepartmentInfo>();
        }
        public void Add(DepartmentInfo department)
        {
            data.Add(department);
        }
        public void Delete(DepartmentInfo department)
        {
            if (data.Contains(department))
            {
                data.Remove(department);
            }
            else
            {
                Console.WriteLine("Данного депортамента не существует");
            }
        }
        public void Find(string name)
        {
            bool found = false;
            foreach (DepartmentInfo department in data)
            {
                List<UserInfo> users = department.GetList();
                foreach (UserInfo user in users)
                {
                    if (name.Equals(user.fio))
                    {
                        Console.WriteLine("Пользователь найден! Вывожу информацию об отделе");
                        department.GetInfo();
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("Пользователь не найден");
            }
        }
    }
}
