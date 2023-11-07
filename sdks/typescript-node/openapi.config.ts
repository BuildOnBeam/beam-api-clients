import * as OpenAPI from 'openapi-typescript-codegen';

OpenAPI.generate({
  input: 'https://api.testnet.onbeam.com/api/game-json',
  output: './src/generated',
  clientName: 'ApiClient',
  httpClient: 'node',
  indent: '2',
});
