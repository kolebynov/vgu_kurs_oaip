using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Domain.Attributes;
using System.ComponentModel.DataAnnotations;
using Domain.Resources;

namespace Domain.Entity
{
    internal static class DomainSchemas
    {
        public static Schema GetSchema(Type type)
        {
            if (_schemas.TryGetValue(type, out Schema schema))
                return schema;
            else
                return GenerateSchema(type);
        }

        private static Dictionary<Type, Schema> _schemas = new Dictionary<Type, Schema>();

        private static Schema GenerateSchema(Type type)
        {
            Schema schema = new Schema();
            schema.Name = type.Name;
            schema.EntityType = type;
            schema.Columns = GenerateEntityColumns(schema);
            schema.PrimaryColumn = GetPrimaryColumn(schema);
            _schemas[type] = schema;

            return schema;
        }
        private static List<EntityColumn> GenerateEntityColumns(Schema schema)
        {
            return schema.EntityType.GetProperties()
                .Where(property =>
                    property.GetCustomAttribute<LookupFieldAttribute>() == null)
                .Select(property => 
                    new EntityColumn
                    {
                        Name = property.Name,
                        Type = property.PropertyType,
                        Schema = schema
                    })
                .ToList();
        }
        private static EntityColumn GetPrimaryColumn(Schema schema)
        {
            try
            {
                var keyProperty = schema.EntityType.GetProperties().First(property =>
                    property.GetCustomAttribute<KeyAttribute>() != null);
                return new EntityColumn
                {
                    Name = keyProperty.Name,
                    Schema = schema,
                    Type = keyProperty.PropertyType
                };
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException(string.Format(
                    DomainResources.PrimaryColumnNotFoundFormat, schema.EntityType.Name));
            }
        }
    }
}
