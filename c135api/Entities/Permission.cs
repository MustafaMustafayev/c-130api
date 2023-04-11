namespace c135api.Entities
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public bool IsDeleted { get; set; } 
        public List<Role> Roles { get; set; }
    }
}
