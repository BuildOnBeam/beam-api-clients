import {
  AssetsService,
  ChainService,
  GameService,
  ProfilesService,
  TransactionsService,
} from './generated';
import { ApiClient } from './generated/ApiClient';

export class Beam {
  private client: ApiClient;

  constructor(
    private readonly apiKey: string,
    private readonly basePath = 'https://api.testnet.onbeam.com',
  ) {
    this.client = new ApiClient({
      BASE: this.basePath,
      HEADERS: {
        'x-api-key': this.apiKey,
      },
    });
  }

  public get game(): GameService {
    return this.client.game;
  }

  public get profiles(): ProfilesService {
    return this.client.profiles;
  }

  public get transactions(): TransactionsService {
    return this.client.transactions;
  }

  public get assets(): AssetsService {
    return this.client.assets;
  }

  public get chain(): ChainService {
    return this.client.chain;
  }
}
