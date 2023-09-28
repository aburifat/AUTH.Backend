namespace AUTH.Backend.Domains.Models;

public interface IBaseEntity : IEntity
{
    void OnCreate();

    void OnUpdate();

    void OnDelete();

}