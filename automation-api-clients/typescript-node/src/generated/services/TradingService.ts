/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { TradeTokensRequestInput } from '../models/TradeTokensRequestInput';
import type { TransactionResponse } from '../models/TransactionResponse';
import type { CancelablePromise } from '../core/CancelablePromise';
import type { BaseHttpRequest } from '../core/BaseHttpRequest';
export class TradingService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}
  /**
   * @param requestBody
   * @returns TransactionResponse
   * @throws ApiError
   */
  public tradeAssets(
    requestBody: TradeTokensRequestInput,
  ): CancelablePromise<TransactionResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/trading/trade',
      body: requestBody,
      mediaType: 'application/json',
    });
  }
}
