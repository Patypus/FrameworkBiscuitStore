using Data.Entities;

namespace Data.Dtos
{
    public class BiscuitDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set;}
        public double Price { get; set; }

        public BiscuitDto (Biscuit biscuitEntity)
        {
            Id = biscuitEntity.Id;
            Name = biscuitEntity.Name;
            Description = biscuitEntity.Description;
            Price = biscuitEntity.Price;
        }

        public Biscuit ConvertToEntity()
        {
            return new Biscuit
            {
                Id = Id,
                Name = Name,
                Description = Description,
                Price = Price
            };
        }
    }
}