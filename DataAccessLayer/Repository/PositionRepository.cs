using _01_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class PositionRepository : BaseRepository<Position>
    {
        internal PositionRepository(TaskManagerContext context)
            : base(context)
        {

        }
    }
}
