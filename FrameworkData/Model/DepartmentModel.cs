namespace FrameworkData.Model
{
    public class DepartmentModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DepartmentModel(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}
