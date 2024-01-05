/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { BaseHttpRequest } from './core/BaseHttpRequest';
import { NodeHttpRequest } from './core/NodeHttpRequest';
import type { OpenAPIConfig } from './core/OpenAPI';

import { AssetsService } from './services/AssetsService';
import { AssetsV2Service } from './services/AssetsV2Service';
import { ChainService } from './services/ChainService';
import { ExchangeService } from './services/ExchangeService';
import { GameService } from './services/GameService';
import { HealthService } from './services/HealthService';
import { MarketplaceService } from './services/MarketplaceService';
import { MarketplaceV2Service } from './services/MarketplaceV2Service';
import { PolicyService } from './services/PolicyService';
import { ProfilesService } from './services/ProfilesService';
import { ReportingService } from './services/ReportingService';
import { TradingService } from './services/TradingService';
import { TransactionsService } from './services/TransactionsService';

type HttpRequestConstructor = new (_config: OpenAPIConfig) => BaseHttpRequest;

export class ApiClient {
  public readonly assets: AssetsService;
  public readonly assetsV2: AssetsV2Service;
  public readonly chain: ChainService;
  public readonly exchange: ExchangeService;
  public readonly game: GameService;
  public readonly health: HealthService;
  public readonly marketplace: MarketplaceService;
  public readonly marketplaceV2: MarketplaceV2Service;
  public readonly policy: PolicyService;
  public readonly profiles: ProfilesService;
  public readonly reporting: ReportingService;
  public readonly trading: TradingService;
  public readonly transactions: TransactionsService;

  public readonly request: BaseHttpRequest;

  constructor(
    config?: Partial<OpenAPIConfig>,
    HttpRequest: HttpRequestConstructor = NodeHttpRequest,
  ) {
    this.request = new HttpRequest({
      BASE: config?.BASE ?? '',
      VERSION: config?.VERSION ?? '1.0.0',
      WITH_CREDENTIALS: config?.WITH_CREDENTIALS ?? false,
      CREDENTIALS: config?.CREDENTIALS ?? 'include',
      TOKEN: config?.TOKEN,
      USERNAME: config?.USERNAME,
      PASSWORD: config?.PASSWORD,
      HEADERS: config?.HEADERS,
      ENCODE_PATH: config?.ENCODE_PATH,
    });

    this.assets = new AssetsService(this.request);
    this.assetsV2 = new AssetsV2Service(this.request);
    this.chain = new ChainService(this.request);
    this.exchange = new ExchangeService(this.request);
    this.game = new GameService(this.request);
    this.health = new HealthService(this.request);
    this.marketplace = new MarketplaceService(this.request);
    this.marketplaceV2 = new MarketplaceV2Service(this.request);
    this.policy = new PolicyService(this.request);
    this.profiles = new ProfilesService(this.request);
    this.reporting = new ReportingService(this.request);
    this.trading = new TradingService(this.request);
    this.transactions = new TransactionsService(this.request);
  }
}
