namespace c135api.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; } // Administrator
        public string Key { get; set; } // admin
        public bool IsDeleted { get; set; }
        public List<Permission> Permissions { get; set; }
    }
}
