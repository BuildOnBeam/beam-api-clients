import { ApiClient } from './generated/ApiClient';

export class Beam extends ApiClient {
  constructor(
    protected readonly apiKey: string,
    protected readonly basePath = 'https://api.beta.onbeam.com',
  ) {
    super({
      BASE: basePath,
      HEADERS: {
        'x-api-key': apiKey,
      },
    });
  }
}
