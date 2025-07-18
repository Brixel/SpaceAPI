using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace SpaceAPI.Host
{
    public class AdditionalParametersDocumentFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument openApiDoc, DocumentFilterContext context)
        {
            foreach (var schema in context.SchemaRepository.Schemas.Where(schema => schema.Value.AdditionalProperties == null))
            {
                schema.Value.AdditionalPropertiesAllowed = true;
            }
        }
    }
}