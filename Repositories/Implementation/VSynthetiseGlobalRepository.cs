using TestRepositotyV9.Data;
using TestRepositotyV9.Models;
using TestRepositotyV9.Repositories.Generic;
using TestRepositotyV9.Repositories.Interface;

namespace TestRepositotyV9.Repositories.Implementation;

public class VSynthetiseGlobalRepository : Repository<VSynthetiseGlobal, int>, IVSynthetiseGlobalRepository          {
    public VSynthetiseGlobalRepository(TestRepositotyV9Context context) : base(context)
    {
    }
}
