using System;
using System.Linq;

namespace AdjustStringProperty
{
    public static class StringExtensionMethod
    {
        /// <summary>
        ///Replace Multiple Spaces With Single
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string ReplaceMultipleSpacesWithSingle(this string input)
        {
            return string.Join(" ", input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        private static string ReplaceString(this string obj)
        {
            return obj.Replace((char)1603, (char)1705)
                .Replace((char)1609, (char)1740)
                .Replace((char)1610, (char)1740);
        }
        public static TModel AdjustStringProperties<TModel>(this TModel model)
        {
            if (model == null) return model;

            var stringProperties = typeof(TModel).GetProperties()
                .Where(y => y.PropertyType == typeof(string) && y.CanWrite);

            foreach (var stringProperty in stringProperties)
            {
                var currentValue = (string)stringProperty.GetValue(model, null);
                if (!string.IsNullOrEmpty(currentValue))
                {
                    var newValue = currentValue
                        .Trim()
                        .ReplaceMultipleSpacesWithSingle()
                        .ReplaceString();

                    stringProperty.SetValue(model, newValue, null);
                }
            }

            return model;
        }
    }
}