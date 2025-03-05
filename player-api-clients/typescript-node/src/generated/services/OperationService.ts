/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { ConfirmOperationRequest } from '../models/ConfirmOperationRequest';
import type { PlayerOperationResponse } from '../models/PlayerOperationResponse';
import type { CancelablePromise } from '../core/CancelablePromise';
import type { BaseHttpRequest } from '../core/BaseHttpRequest';
export class OperationService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}
  /**
   * Returns operation data for given id. Used by Game SDKs to get transaction results.
   * @param opId
   * @returns PlayerOperationResponse
   * @throws ApiError
   */
  public getOperation(
    opId: string,
  ): CancelablePromise<PlayerOperationResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/operation/{opId}',
      path: {
        'opId': opId,
      },
    });
  }
  /**
   * Updates operation result for given id
   * @param opId
   * @param requestBody
   * @returns PlayerOperationResponse
   * @throws ApiError
   */
  public processOperation(
    opId: string,
    requestBody: ConfirmOperationRequest,
  ): CancelablePromise<PlayerOperationResponse> {
    return this.httpRequest.request({
      method: 'PATCH',
      url: '/v1/player/operation/{opId}',
      path: {
        'opId': opId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
  /**
   * Delete an operation
   * @param opId
   * @returns PlayerOperationResponse
   * @throws ApiError
   */
  public deleteOperation(
    opId: string,
  ): CancelablePromise<PlayerOperationResponse> {
    return this.httpRequest.request({
      method: 'DELETE',
      url: '/v1/player/operation/{opId}',
      path: {
        'opId': opId,
      },
    });
  }
  /**
   * Executes operation for given id
   * @param opId
   * @returns PlayerOperationResponse
   * @throws ApiError
   */
  public executeSignedOperation(
    opId: string,
  ): CancelablePromise<PlayerOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/operation/{opId}/execute',
      path: {
        'opId': opId,
      },
    });
  }
}
