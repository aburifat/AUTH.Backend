namespace AUTH.Backend.Repository.Models;

public interface IBaseEntity : IEntity
{
    void OnCreate();
    void OnUpdate();
    void OnDelete();
}
