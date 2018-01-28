using Data.Dtos;
using Data.Entities;
using Xunit;

namespace DataTests.Dtos
{
    public class BiscuitDtoTests
    {
        [Fact]
        public void BiscuitDto_DtoSetFromEntity()
        {
            var entity = new Biscuit
            {
                Id = 102,
                Name = "Tasty biscuit",
                Description = "test description",
                Price = 12.99
            };

            var result = new BiscuitDto(entity);

            Assert.Equal(entity.Id, result.Id);
            Assert.Equal(entity.Name, result.Name);
            Assert.Equal(entity.Description, result.Description);
            Assert.Equal(entity.Price, result.Price);
        }

        [Fact]
        public void ConvertToEntity_SetsEntityCorrectly()
        {
            var dto = new BiscuitDto
            {
                Id = 1312,
                Name = "Dto biscuit",
                Description = "test description",
                Price = 1.99
            };

            var result = dto.ConvertToEntity();

            Assert.Equal(dto.Id, result.Id);
            Assert.Equal(dto.Name, result.Name);
            Assert.Equal(dto.Description, result.Description);
            Assert.Equal(dto.Price, result.Price);
        }
    }
}