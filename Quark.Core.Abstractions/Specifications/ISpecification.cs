using Quark.Core.Abstractions.Contracts;
using System.Linq.Expressions;

namespace Quark.Core.Abstractions.Specifications;

public interface ISpecification<T> where T : class, IEntity
{
    Expression<Func<T, bool>> Criteria { get; }
    List<Expression<Func<T, object>>> Includes { get; }
    List<string> IncludeStrings { get; }
}