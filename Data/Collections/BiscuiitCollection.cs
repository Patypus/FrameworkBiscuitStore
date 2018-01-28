using System;
using System.Collections.Generic;
using System.Text;
using Data.Dtos;
using Data.Context;

namespace Data.Collections
{
    public class BiscuitCollection : IBiscuitCollection
    {
        private readonly IDataContext _context;

        public BiscuitCollection(IDataContext context)
        {
            _context = context;
        }

        public BiscuitDto AddBiscuit(BiscuitDto )
        {
            throw new NotImplementedException();
        }

        public bool DeleteBiscuit(int id)
        {
            throw new NotImplementedException();
        }

        public List<BiscuitDto> GetAllBiscuits()
        {
            throw new NotImplementedException();
        }

        public BiscuitDto GetBiscuitById(int biscuitId)
        {
            throw new NotImplementedException();
        }

        public BiscuitDto UpdateBiscuit(BiscuitDto )
        {
            throw new NotImplementedException();
        }
    }
}
