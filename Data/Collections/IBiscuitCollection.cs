using Data.Dtos;
using System.Collections.Generic;

namespace Data.Collections
{
    public interface IBiscuitCollection
    {
        List<BiscuitDto> GetAllBiscuits();

        BiscuitDto GetBiscuitById(int biscuitId);

        BiscuitDto AddBiscuit(BiscuitDto biscuitToAdd);

        BiscuitDto UpdateBiscuit(BiscuitDto biscuitToUpdate);

        bool DeleteBiscuit(int id);
    }
}