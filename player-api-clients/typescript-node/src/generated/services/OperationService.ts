/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { CommonOperationResponse } from '../models/CommonOperationResponse';
import type { ConfirmOperationRequest } from '../models/ConfirmOperationRequest';
import type { CreateOperationRequestInput } from '../models/CreateOperationRequestInput';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class OperationService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Returns operation data for given id. Used by Game SDKs to get transaction results.
   * @param opId
   * @returns CommonOperationResponse
   * @throws ApiError
   */
  public getOperation(
    opId: string,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/self-custody/operation/{opId}',
      path: {
        opId: opId,
      },
    });
  }

  /**
   * Updates operation result for given id
   * @param opId
   * @param requestBody
   * @returns CommonOperationResponse
   * @throws ApiError
   */
  public processOperation(
    opId: string,
    requestBody: ConfirmOperationRequest,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'PATCH',
      url: '/v1/self-custody/operation/{opId}',
      path: {
        opId: opId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Initializes an operation. Used by Game SDKs to get transaction results.
   * @param requestBody
   * @returns CommonOperationResponse
   * @throws ApiError
   */
  public createOperation(
    requestBody: CreateOperationRequestInput,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/self-custody/operation',
      body: requestBody,
      mediaType: 'application/json',
    });
  }
}
