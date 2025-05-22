/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { CreateOnrampRequestInput } from '../models/CreateOnrampRequestInput';
import type { GetOnRampQuoteResponse } from '../models/GetOnRampQuoteResponse';
import type { PlayerOperationResponse } from '../models/PlayerOperationResponse';
import type { CancelablePromise } from '../core/CancelablePromise';
import type { BaseHttpRequest } from '../core/BaseHttpRequest';
export class RampService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}
  /**
   * @param entityId
   * @param requestBody
   * @returns PlayerOperationResponse
   * @throws ApiError
   */
  public createOnrampRequest(
    entityId: string,
    requestBody: CreateOnrampRequestInput,
  ): CancelablePromise<PlayerOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/ramp/on/{entityId}',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
  /**
   * @param entityId
   * @param requestBody
   * @returns GetOnRampQuoteResponse
   * @throws ApiError
   */
  public getOnRampQuote(
    entityId: string,
    requestBody: CreateOnrampRequestInput,
  ): CancelablePromise<GetOnRampQuoteResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/ramp/quote/on/{entityId}',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
}
