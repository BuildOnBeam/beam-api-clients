/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { ConfirmOperationRequest } from '../models/ConfirmOperationRequest';
import type { CreateOperationRequestInput } from '../models/CreateOperationRequestInput';
import type { OperationResponse } from '../models/OperationResponse';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class OperationService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Returns operation data for given id. Used by Game SDKs to get transaction results.
   * @param opId
   * @returns OperationResponse
   * @throws ApiError
   */
  public getOperation(opId: string): CancelablePromise<OperationResponse> {
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
   * @returns OperationResponse
   * @throws ApiError
   */
  public processOperationForSelfCustody(
    opId: string,
    requestBody: ConfirmOperationRequest,
  ): CancelablePromise<OperationResponse> {
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
   * @returns OperationResponse
   * @throws ApiError
   */
  public createOperation(
    requestBody: CreateOperationRequestInput,
  ): CancelablePromise<OperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/self-custody/operation',
      body: requestBody,
      mediaType: 'application/json',
    });
  }
}
