/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { CommonActivityResponse } from '../models/CommonActivityResponse';
import type { CommonAssetActivityRequestInput } from '../models/CommonAssetActivityRequestInput';
import type { CommonContractActivityRequestInput } from '../models/CommonContractActivityRequestInput';
import type { CommonUserActivityRequestInput } from '../models/CommonUserActivityRequestInput';

import type { CancelablePromise } from '../core/CancelablePromise';
import type { BaseHttpRequest } from '../core/BaseHttpRequest';

export class ActivityService {

  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Get profile activity
   * @param entityId
   * @param requestBody
   * @returns CommonActivityResponse
   * @throws ApiError
   */
  public getProfileActivity(
    entityId: string,
    requestBody: CommonUserActivityRequestInput,
  ): CancelablePromise<CommonActivityResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/automation/activity/profiles/{entityId}',
      path: {
        'entityId': entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Get contract activity
   * @param assetAddress
   * @param requestBody
   * @returns CommonActivityResponse
   * @throws ApiError
   */
  public getContractActivity(
    assetAddress: string,
    requestBody: CommonContractActivityRequestInput,
  ): CancelablePromise<CommonActivityResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/automation/activity/assets/{assetAddress}',
      path: {
        'assetAddress': assetAddress,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Get asset activity
   * @param assetAddress
   * @param assetId
   * @param requestBody
   * @returns CommonActivityResponse
   * @throws ApiError
   */
  public getAssetActivity(
    assetAddress: string,
    assetId: string,
    requestBody: CommonAssetActivityRequestInput,
  ): CancelablePromise<CommonActivityResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/automation/activity/assets/{assetAddress}/asset/{assetId}',
      path: {
        'assetAddress': assetAddress,
        'assetId': assetId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

}
