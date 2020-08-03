using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace FairWorks.Core
{
    public static class ReflectionHelper
    {
        public static Type GetPropertyType<T>(string field)
        {
            var property = typeof(T).GetProperties().Where(x => x.Name == field).SingleOrDefault();
            return property?.PropertyType;
        }

        public static T GetPropertyValue<T>(object obj, string propertyName, T defaultValue = default)
        {
            var property = obj.GetType().GetProperty(propertyName);
            if (property != null)
            {
                return (T)property.GetValue(obj);
                //return value;
            }

            return defaultValue;
        }

        public static object GetPropertyValue(object obj, string propertyName)
        {
            var property = obj.GetType().GetProperty(propertyName);
            if (property != null)
                return property.GetValue(obj);

            return null;
        }

        public static void SetPropertyValue(object obj, string propertyName, object propertyValue)
        {
            var type = obj.GetType();
            var property = type.GetProperty(propertyName);
            property.SetValue(obj, propertyValue);
        }

        public static string GetMemberName(Expression expression)
        {
            switch (expression.NodeType)
            {
                case ExpressionType.MemberAccess:
                    return ((MemberExpression)expression).Member.Name;
                case ExpressionType.Convert:
                    return GetMemberName(((UnaryExpression)expression).Operand);
                default:
                    throw new NotSupportedException(expression.NodeType.ToString());
            }
        }
    }
}
