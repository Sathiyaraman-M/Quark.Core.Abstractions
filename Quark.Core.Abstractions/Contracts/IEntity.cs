namespace Quark.Core.Abstractions.Contracts;

public interface IEntity
{

}

public interface IEntity<TId> : IEntity
{
    TId Id { get; set; }
}