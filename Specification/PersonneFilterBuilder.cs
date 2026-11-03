namespace TestRepositotyV9.Specification;

using System.Linq.Expressions;
using TestRepositotyV9.Models;
using TestRepositotyV9.Models.Dto;
using TestRepositotyV9.Utils;

public sealed class PersonneFilterBuilder : FilterBuilder<Personne, PersonneDto>
{
    public override PersonneFilterBuilder Build(PersonneDto dto)
    {
    	AddRange(e => e.DateNaissance,  dto.DateNaissanceMin,  dto.DateNaissanceMax);
    	AddEquals(e => e.DateNaissance, dto.DateNaissance);
    

    	AddEquals(e => e.Id, dto.Id);

    	AddRange(e => e.NumeroSs,  dto.NumeroSsMin,  dto.NumeroSsMax);
    	AddEquals(e => e.NumeroSs, dto.NumeroSs);
    

    	AddLike(e => e.Nom, dto.Nom);
    	

    	AddLike(e => e.Prenom, dto.Prenom);
    	

    	AddLike(e => e.Biographie, dto.Biographie);
    	
    	
        return this;
    }
}
