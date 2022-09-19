using LecConsumeWebAPI.Models;

namespace LecConsumeWebAPI.Services;

public interface IPetRepository
{
    Task<ICollection<Pet>> ReadAllAsync();
}
