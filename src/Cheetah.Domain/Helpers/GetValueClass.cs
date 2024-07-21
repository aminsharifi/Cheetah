using Cheetah.Domain.Common;

namespace Cheetah.Domain.Helpers;

public static class GetEntity
{
    public static IEnumerable<FieldInfo[]> Values()
    {
        var _classes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(x => x.IsClass)
            .Where(x => !x.IsAbstract)
            .Where(y => (y.BaseType.Name == nameof(BaseEntity) || (y.BaseType.BaseType?.Name == nameof(BaseEntity))));

        foreach (var _class in _classes)
        {
            yield return _class.GetFields();
        }
    }
}
