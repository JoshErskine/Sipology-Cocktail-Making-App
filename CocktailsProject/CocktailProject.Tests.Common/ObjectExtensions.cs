using System.Linq.Expressions;

namespace EntityFrameworkIntroduction.Tests.Common
{
    public static class ObjectExtensions
    {
        public static void ForceSet<T, TProp>(this T obj, Expression<Func<T, TProp>> propertySelector, TProp val)
        {
            typeof(T)
                .GetProperty(((MemberExpression)propertySelector.Body).Member.Name)
                .SetValue(obj, val);
        }
    }
}
