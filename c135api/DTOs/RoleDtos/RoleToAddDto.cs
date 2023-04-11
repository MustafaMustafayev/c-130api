namespace c135api.DTOs.RoleDtos
{
    public record RoleToAddDto
    {
        public string Name { get; set; }
        public string Key { get; set; }
        public List<PermissionToAddDto> Permissions { get; set; }
    }
}
