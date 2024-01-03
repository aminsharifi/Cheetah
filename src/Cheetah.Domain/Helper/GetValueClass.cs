using DNTPersianUtils.Core;
using System.Formats.Asn1;
using System.Reflection;

namespace Cheetah.Domain.Helper
{
    public static class GetEntity
    {
        public static IEnumerable<FieldInfo[]> Values()
        {
            var _classes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.IsClass)
                .Where(y => y.BaseType.Name == nameof(BaseEntity));

            foreach (var _class in _classes)
            {
                yield return _class.GetFields();
            }
        }
    }
}
