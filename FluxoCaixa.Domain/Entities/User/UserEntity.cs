namespace FluxoCaixa.Domain.Entities.User
{
    class UserEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string HashPassword { get; set; }
        public string Email { get; set; }
    }
}
