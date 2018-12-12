using System;
using Core;
using Generic;
using Database;

namespace Repository
{
    public class SetRepository:ICRUD<Core.Set>
    {
        SetEntity setEntity;
        public SetRepository()
        {
            setEntity = new SetEntity();
        }

        public int Create(Core.Set set)
        {
            return setEntity.Create(set);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Core.Set Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}