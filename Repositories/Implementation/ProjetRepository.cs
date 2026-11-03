using TestRepositotyV9.Data;
using TestRepositotyV9.Models;
using TestRepositotyV9.Repositories.Generic;
using TestRepositotyV9.Repositories.Interface;

namespace TestRepositotyV9.Repositories.Implementation;

public class ProjetRepository : Repository<Projet, int>, IProjetRepository          {
    public ProjetRepository(TestRepositotyV9Context context) : base(context)
    {
    }
}
