/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { GenerateSessionRequestResponse } from '../models/GenerateSessionRequestResponse';
import type { GenerateSessionUrlRequestInput } from '../models/GenerateSessionUrlRequestInput';
import type { GetActiveSessionResponse } from '../models/GetActiveSessionResponse';
import type { GetActiveSessionResponseV2 } from '../models/GetActiveSessionResponseV2';
import type { GetActiveSessionsResponse } from '../models/GetActiveSessionsResponse';
import type { GetSessionRequestResponse } from '../models/GetSessionRequestResponse';
import type { PlayerOperationResponse } from '../models/PlayerOperationResponse';
import type { RevokeSessionRequestInput } from '../models/RevokeSessionRequestInput';
import type { CancelablePromise } from '../core/CancelablePromise';
import type { BaseHttpRequest } from '../core/BaseHttpRequest';
export class SessionsService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}
  /**
   * @deprecated
   * @param entityId
   * @param requestBody
   * @returns GenerateSessionRequestResponse
   * @throws ApiError
   */
  public createSessionRequest(
    entityId: string,
    requestBody: GenerateSessionUrlRequestInput,
  ): CancelablePromise<GenerateSessionRequestResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/sessions/users/{entityId}/request',
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
   * @returns PlayerOperationResponse
   * @throws ApiError
   */
  public revokeSession(
    entityId: string,
    requestBody: RevokeSessionRequestInput,
  ): CancelablePromise<PlayerOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/sessions/users/{entityId}/revoke',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
  /**
   * @param requestId
   * @returns GetSessionRequestResponse
   * @throws ApiError
   */
  public getSessionRequest(
    requestId: string,
  ): CancelablePromise<GetSessionRequestResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/sessions/request/{requestId}',
      path: {
        requestId: requestId,
      },
    });
  }
  /**
   * @param entityId
   * @param chainId
   * @returns GetActiveSessionsResponse
   * @throws ApiError
   */
  public getAllActiveSessions(
    entityId: string,
    chainId?: number,
  ): CancelablePromise<GetActiveSessionsResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/sessions/users/{entityId}/active',
      path: {
        entityId: entityId,
      },
      query: {
        chainId: chainId,
      },
    });
  }
  /**
   * @deprecated
   * @param entityId
   * @param accountAddress
   * @param chainId
   * @returns GetActiveSessionResponse
   * @throws ApiError
   */
  public getActiveSession(
    entityId: string,
    accountAddress: string,
    chainId?: number,
  ): CancelablePromise<GetActiveSessionResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/sessions/users/{entityId}/{accountAddress}/active',
      path: {
        entityId: entityId,
        accountAddress: accountAddress,
      },
      query: {
        chainId: chainId,
      },
    });
  }
  /**
   * @param requestBody
   * @returns GenerateSessionRequestResponse
   * @throws ApiError
   */
  public createSessionRequestV2(
    requestBody: GenerateSessionUrlRequestInput,
  ): CancelablePromise<GenerateSessionRequestResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v2/player/sessions/request',
      body: requestBody,
      mediaType: 'application/json',
    });
  }
  /**
   * @param entityId
   * @param accountAddress
   * @param chainId
   * @returns GetActiveSessionResponseV2
   * @throws ApiError
   */
  public getActiveSessionV2(
    entityId: string,
    accountAddress: string,
    chainId?: number,
  ): CancelablePromise<GetActiveSessionResponseV2> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v2/player/sessions/users/{entityId}/{accountAddress}/active',
      path: {
        entityId: entityId,
        accountAddress: accountAddress,
      },
      query: {
        chainId: chainId,
      },
    });
  }
}
