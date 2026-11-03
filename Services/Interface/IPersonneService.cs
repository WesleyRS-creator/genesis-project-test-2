namespace TestRepositotyV9.Services.Interface;

using Models;
using Models.Dto;
using Generic;
using Services.Generic;

public interface IPersonneService : IService<Personne, int, PersonneDto> 
{
}
