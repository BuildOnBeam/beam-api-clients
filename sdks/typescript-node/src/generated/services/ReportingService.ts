/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { GetAllGasUsageResponse } from '../models/GetAllGasUsageResponse';
import type { GetGasUsageResponse } from '../models/GetGasUsageResponse';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class ReportingService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Get the total gas usage for your game
   * @returns GetAllGasUsageResponse
   * @throws ApiError
   */
  public getTotalGameUsage(): CancelablePromise<GetAllGasUsageResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/reporting/gas',
    });
  }

  /**
   * Get total gas usage for single chain
   * @param chainId
   * @returns GetGasUsageResponse
   * @throws ApiError
   */
  public getTotalGameUsageForChain(
    chainId: number,
  ): CancelablePromise<GetGasUsageResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/reporting/gas/{chainId}',
      path: {
        chainId: chainId,
      },
    });
  }

  /**
   * Get gas usage from a single policy
   * @param policyId
   * @returns GetGasUsageResponse
   * @throws ApiError
   */
  public getPolicyUsage(
    policyId: string,
  ): CancelablePromise<GetGasUsageResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/reporting/gas/policies/{policyId}',
      path: {
        policyId: policyId,
      },
    });
  }
}
