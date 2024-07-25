const fs = require('node:fs');

async function prefixOpenApiSchema(url, prefix, outputFile) {
  try {
    // Download the JSON file using fetch
    const response = await fetch(url);
    if (!response.ok) {
      throw new Error(`HTTP error! status: ${response.status}`);
    }
    const openApiSpec = await response.json();

    // Modify schemas and references
    if (openApiSpec.components?.schemas) {
      const schemas = openApiSpec.components.schemas;
      const modifiedSchemas = {};

      for (const [key, value] of Object.entries(schemas)) {
        const newKey = `${prefix}${key}`;
        modifiedSchemas[newKey] = value;

        // Update references within the schema
        const schemaString = JSON.stringify(value);
        const updatedSchemaString = schemaString.replace(
          /#\/components\/schemas\/(\w+)/g,
          `#/components/schemas/${prefix}$1`,
        );
        modifiedSchemas[newKey] = JSON.parse(updatedSchemaString);
      }

      openApiSpec.components.schemas = modifiedSchemas;
    }

    // Update references in paths
    if (openApiSpec.paths) {
      const paths = openApiSpec.paths;

      for (const path in paths) {
        const methods = paths[path];

        for (const method in methods) {
          const operation = methods[method];

          if (operation.requestBody?.content) {
            updateContentReferences(operation.requestBody.content, prefix);
          }

          if (operation.responses) {
            for (const response in operation.responses) {
              const content = operation.responses[response].content;
              if (content) {
                updateContentReferences(content, prefix);
              }
            }
          }

          if (operation.parameters) {
            operation.parameters.forEach((parameter) => {
              if (parameter.schema?.$ref) {
                parameter.schema.$ref = parameter.schema.$ref.replace(
                  /#\/components\/schemas\/(\w+)/g,
                  `#/components/schemas/${prefix}$1`,
                );
              }
            });
          }
        }
      }
    }

    // Write the modified JSON to a file
    fs.writeFileSync(outputFile, JSON.stringify(openApiSpec, null, 2));

    console.info(`Modified Open API specification saved to ${outputFile}`);
  } catch (error) {
    console.error(error);
  }
}

function updateContentReferences(content, prefix) {
  for (const type in content) {
    if (content[type].schema?.$ref) {
      content[type].schema.$ref = content[type].schema.$ref.replace(
        /#\/components\/schemas\/(\w+)/g,
        `#/components/schemas/${prefix}$1`,
      );
    }
  }
}

// Example usage:
// node prefixOpenApi.js 'https://example.com/openapi.json' 'MyPrefix' 'output.json'
const args = process.argv.slice(2);
if (args.length !== 3) {
  console.error('Usage: node prefixOpenApi.js <url> <prefix> <outputFile>');
  process.exit(1);
}

const [url, prefix, outputFile] = args;
prefixOpenApiSchema(url, prefix, outputFile);
