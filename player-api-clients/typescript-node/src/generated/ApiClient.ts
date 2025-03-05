/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { BaseHttpRequest } from './core/BaseHttpRequest';
import type { OpenAPIConfig } from './core/OpenAPI';
import { FetchHttpRequest } from './core/FetchHttpRequest';
import { ActivityService } from './services/ActivityService';
import { AssetsService } from './services/AssetsService';
import { ConnectorService } from './services/ConnectorService';
import { ExchangeService } from './services/ExchangeService';
import { HealthService } from './services/HealthService';
import { MarketplaceService } from './services/MarketplaceService';
import { OperationService } from './services/OperationService';
import { RampService } from './services/RampService';
import { SessionsService } from './services/SessionsService';
import { StatsService } from './services/StatsService';
import { TransactionsService } from './services/TransactionsService';
import { UsersService } from './services/UsersService';
type HttpRequestConstructor = new (config: OpenAPIConfig) => BaseHttpRequest;
export class ApiClient {
  public readonly activity: ActivityService;
  public readonly assets: AssetsService;
  public readonly connector: ConnectorService;
  public readonly exchange: ExchangeService;
  public readonly health: HealthService;
  public readonly marketplace: MarketplaceService;
  public readonly operation: OperationService;
  public readonly ramp: RampService;
  public readonly sessions: SessionsService;
  public readonly stats: StatsService;
  public readonly transactions: TransactionsService;
  public readonly users: UsersService;
  public readonly request: BaseHttpRequest;
  constructor(
    config?: Partial<OpenAPIConfig>,
    HttpRequest: HttpRequestConstructor = FetchHttpRequest,
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
    this.activity = new ActivityService(this.request);
    this.assets = new AssetsService(this.request);
    this.connector = new ConnectorService(this.request);
    this.exchange = new ExchangeService(this.request);
    this.health = new HealthService(this.request);
    this.marketplace = new MarketplaceService(this.request);
    this.operation = new OperationService(this.request);
    this.ramp = new RampService(this.request);
    this.sessions = new SessionsService(this.request);
    this.stats = new StatsService(this.request);
    this.transactions = new TransactionsService(this.request);
    this.users = new UsersService(this.request);
  }
}
