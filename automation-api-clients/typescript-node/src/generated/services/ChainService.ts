/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { CreateTransactionRequestInputV2 } from '../models/CreateTransactionRequestInputV2';
import type { GetChainResponse } from '../models/GetChainResponse';
import type { GetEstimateResponse } from '../models/GetEstimateResponse';
import type { CancelablePromise } from '../core/CancelablePromise';
import type { BaseHttpRequest } from '../core/BaseHttpRequest';
export class ChainService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}
  /**
   * @param chainId
   * @returns GetChainResponse
   * @throws ApiError
   */
  public chain(chainId?: number): CancelablePromise<GetChainResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/chain',
      query: {
        chainId: chainId,
      },
    });
  }
  /**
   * Estimate gas fee for a transaction on behalf of a profile
   * @param entityId
   * @param requestBody
   * @returns GetEstimateResponse
   * @throws ApiError
   */
  public estimateProfileTransactionGas(
    entityId: string,
    requestBody: CreateTransactionRequestInputV2,
  ): CancelablePromise<GetEstimateResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/chain/estimate/profiles/{entityId}/transaction',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
}
