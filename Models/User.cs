namespace mapping_complex_type_to_primitve_type.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}
