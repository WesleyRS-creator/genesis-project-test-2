using TestRepositotyV9.Data;
using TestRepositotyV9.Models;
using TestRepositotyV9.Repositories.Generic;
using TestRepositotyV9.Repositories.Interface;

namespace TestRepositotyV9.Repositories.Implementation;

public class VProjetsEtEquipeRepository : Repository<VProjetsEtEquipe, int>, IVProjetsEtEquipeRepository          {
    public VProjetsEtEquipeRepository(TestRepositotyV9Context context) : base(context)
    {
    }
}
