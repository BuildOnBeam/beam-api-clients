/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { CommonStatsRequestInput } from '../models/CommonStatsRequestInput';
import type { CommonStatsResponse } from '../models/CommonStatsResponse';
import type { CancelablePromise } from '../core/CancelablePromise';
import type { BaseHttpRequest } from '../core/BaseHttpRequest';
export class StatsService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}
  /**
   * Get contract stats
   * @param assetAddress
   * @param requestBody
   * @returns CommonStatsResponse
   * @throws ApiError
   */
  public getContractStats(
    assetAddress: string,
    requestBody: CommonStatsRequestInput,
  ): CancelablePromise<CommonStatsResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/stats/{assetAddress}',
      path: {
        'assetAddress': assetAddress,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
  /**
   * Get asset stats
   * @param assetAddress
   * @param assetId
   * @param requestBody
   * @returns CommonStatsResponse
   * @throws ApiError
   */
  public getAssetStats(
    assetAddress: string,
    assetId: string,
    requestBody: CommonStatsRequestInput,
  ): CancelablePromise<CommonStatsResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/stats/{assetAddress}/assets/{assetId}',
      path: {
        'assetAddress': assetAddress,
        'assetId': assetId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
}
