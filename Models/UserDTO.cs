namespace mapping_complex_type_to_primitve_type.Models
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public AddressDTO Address { get; set; }
        
    }
}
