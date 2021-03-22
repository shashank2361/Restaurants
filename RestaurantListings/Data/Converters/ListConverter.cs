using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RestaurantListings.Data.Converters
{
    public class ListConverter<TValueType> : ValueConverter<List<TValueType>, string>
    {
        public ListConverter(ConverterMappingHints mappingHints = null)
            : base(
                v => JsonSerializer.Serialize(v, null),
                v => JsonSerializer.Deserialize<List<TValueType>>(v, null),
                mappingHints)
        {
        }

        public class Comparer : ValueComparer<List<TValueType>>
        {
            public Comparer()
                : base(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => System.HashCode.Combine(a, v.GetHashCode())),
                    c => c.ToList())
            {
            }
        }
    }
}
