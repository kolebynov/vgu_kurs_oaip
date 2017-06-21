using Domain.Attributes;
using Domain.Model;
using Domain.Model.Abstract;
using Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace Domain.Concrete
{
    public static class DomainSchemas
    {
        public static Schema GetSchema<T>() =>
            GetSchema(typeof(T));
        public static Schema GetSchema(Type type)
        {
            if (_schemas.TryGetValue(type, out Schema schema))
                return schema;
            else
                return GenerateSchema(type);
        }
        public static Schema GetSchema(string name)
        {
            return _schemas.First(pair => pair.Value.Name == name).Value;
        }
        public static IEnumerable<Schema> GetSchemas()
        {
            return _schemas.Select(pair => pair.Value);
        }
        public static void GenerateAllSchemas()
        {
            GenerateSchema(typeof(BaseEntity));
            GenerateSchema(typeof(BaseLookup));
            GenerateSchema(typeof(BookedTour));
            GenerateSchema(typeof(City));
            GenerateSchema(typeof(Contact));
            GenerateSchema(typeof(Country));
            GenerateSchema(typeof(Gender));
            GenerateSchema(typeof(Tour));
        }

        private static Dictionary<Type, Schema> _schemas = new Dictionary<Type, Schema>();

        private static Schema GenerateSchema(Type type)
        {
            Schema schema = new Schema();
            schema.Name = type.Name;
            schema.Type = type;
            schema.Columns = GenerateEntityColumns(schema);
            schema.PrimaryColumn = GetPrimaryColumn(schema);
            schema.DisplayColumn = GetDisplayColumn(schema);
            _schemas[type] = schema;

            return schema;
        }
        private static List<EntityColumn> GenerateEntityColumns(Schema schema)
        {
            return schema.Type.GetProperties()
                .Where(property => property.GetCustomAttribute<ColumnAttribute>() != null ||
                    property.GetCustomAttribute<LookupFieldAttribute>() != null ||
                    property.GetCustomAttribute<NameColumnAttribute>() != null)
                .Select(property => 
                    new EntityColumn
                    {
                        Name = property.Name,
                        Type = property.PropertyType,
                        Schema = schema,
                        IsLookup = property.GetCustomAttribute<LookupFieldAttribute>() != null,
                        IsHidden = !property.GetCustomAttribute<HiddenInputAttribute>()?.DisplayValue ?? false,
                        IsNameColumn = property.GetCustomAttribute<NameColumnAttribute>() != null,
                        IsForeignKey = property.GetCustomAttribute<ForeignKeyAttribute>() != null,
                        IsRequired = property.GetCustomAttribute<RequiredAttribute>() != null
                    })
                .ToList();
        }
        private static EntityColumn GetPrimaryColumn(Schema schema)
        {
            try
            {
                var keyProperty = schema.Type.GetProperties().First(property =>
                    property.GetCustomAttribute<KeyAttribute>() != null);
                return schema.Columns.Find(column => column.Name == keyProperty.Name);
            }
            catch (InvalidOperationException exc)
            {
                throw new InvalidOperationException(string.Format(
                    DomainResources.PrimaryColumnNotFoundFormat, schema.Type.Name), exc);
            }
        }
        private static EntityColumn GetDisplayColumn(Schema schema)
        {
            DisplayColumnAttribute attr = schema.Type.GetCustomAttribute<DisplayColumnAttribute>();
            if (attr != null)
            {
                return schema.Columns.Find(column => column.Name == attr.DisplayColumn);
            }
            else
                return null;
        }
    }
}
