/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { GenerateSessionUrlRequestInput } from '../models/GenerateSessionUrlRequestInput';
import type { GenerateSessionUrlResponse } from '../models/GenerateSessionUrlResponse';
import type { GetSessionRequestResponse } from '../models/GetSessionRequestResponse';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class SessionsService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * @param entityId
   * @param requestBody
   * @returns GenerateSessionUrlResponse
   * @throws ApiError
   */
  public createSessionRequest(
    entityId: string,
    requestBody: GenerateSessionUrlRequestInput,
  ): CancelablePromise<GenerateSessionUrlResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/self-custody/sessions/users/{entityId}/request',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * @param entityId
   * @param chainId
   * @returns GetSessionRequestResponse
   * @throws ApiError
   */
  public getActiveSession(
    entityId: string,
    chainId?: number,
  ): CancelablePromise<GetSessionRequestResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/self-custody/sessions/users/{entityId}/active',
      path: {
        entityId: entityId,
      },
      query: {
        chainId: chainId,
      },
    });
  }
}
