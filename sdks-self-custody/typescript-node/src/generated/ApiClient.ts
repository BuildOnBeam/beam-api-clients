/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { BaseHttpRequest } from './core/BaseHttpRequest';
import { NodeHttpRequest } from './core/NodeHttpRequest';
import type { OpenAPIConfig } from './core/OpenAPI';

import { AssetsService } from './services/AssetsService';
import { ExchangeService } from './services/ExchangeService';
import { HealthService } from './services/HealthService';
import { MarketplaceService } from './services/MarketplaceService';
import { OperationService } from './services/OperationService';
import { SessionsService } from './services/SessionsService';
import { TransactionsService } from './services/TransactionsService';
import { UsersService } from './services/UsersService';

type HttpRequestConstructor = new (config: OpenAPIConfig) => BaseHttpRequest;

export class ApiClient {
  public readonly assets: AssetsService;
  public readonly exchange: ExchangeService;
  public readonly health: HealthService;
  public readonly marketplace: MarketplaceService;
  public readonly operation: OperationService;
  public readonly sessions: SessionsService;
  public readonly transactions: TransactionsService;
  public readonly users: UsersService;

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
    this.exchange = new ExchangeService(this.request);
    this.health = new HealthService(this.request);
    this.marketplace = new MarketplaceService(this.request);
    this.operation = new OperationService(this.request);
    this.sessions = new SessionsService(this.request);
    this.transactions = new TransactionsService(this.request);
    this.users = new UsersService(this.request);
  }
}
