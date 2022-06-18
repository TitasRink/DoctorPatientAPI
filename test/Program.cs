using FrameworkData.DataContext;
using FrameworkData.Model;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new DataConection();
            DepartmentModel dep = new DepartmentModel("fghgfh","fghgfh");
            context.Departments.Add(dep);
            context.SaveChanges();
        }
    }
}
