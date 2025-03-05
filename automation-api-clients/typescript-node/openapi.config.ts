import * as OpenAPI from 'openapi-typescript-codegen';

OpenAPI.generate({
  input: 'https://api.testnet.onbeam.com/api/automation-json',
  output: './src/generated',
  clientName: 'ApiClient',
  httpClient: 'fetch',
  indent: '2',
});
