import * as OpenAPI from 'openapi-typescript-codegen';

OpenAPI.generate({
  input: 'https://api.beta.onbeam.com/api/player-json',
  output: './src/generated',
  clientName: 'ApiClient',
  httpClient: 'fetch',
  indent: '2',
});
