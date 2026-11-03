using TestRepositotyV9.Data;
using TestRepositotyV9.Models;
using TestRepositotyV9.Repositories.Generic;
using TestRepositotyV9.Repositories.Interface;

namespace TestRepositotyV9.Repositories.Implementation;

public class PasseportRepository : Repository<Passeport, int>, IPasseportRepository          {
    public PasseportRepository(TestRepositotyV9Context context) : base(context)
    {
    }
}
