using Data.Dtos;
using System.Collections.Generic;

namespace Data.Collections
{
    public interface IBiscuitCollection
    {
        List<BiscuitDto> GetAllBiscuits();

        BiscuitDto GetBiscuitById(int biscuitId);

        BiscuitDto AddBiscuit(BiscuitDto);

        BiscuitDto UpdateBiscuit(BiscuitDto);

        bool DeleteBiscuit(int id);
    }
}