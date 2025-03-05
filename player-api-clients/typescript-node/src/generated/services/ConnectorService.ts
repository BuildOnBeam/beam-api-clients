/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { CreateConnectionRequestInput } from '../models/CreateConnectionRequestInput';
import type { CreateConnectionRequestResponse } from '../models/CreateConnectionRequestResponse';
import type { GetConnectionRequestResponse } from '../models/GetConnectionRequestResponse';
import type { CancelablePromise } from '../core/CancelablePromise';
import type { BaseHttpRequest } from '../core/BaseHttpRequest';
export class ConnectorService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}
  /**
   * @param requestBody
   * @returns CreateConnectionRequestResponse
   * @throws ApiError
   */
  public createConnectionRequest(
    requestBody: CreateConnectionRequestInput,
  ): CancelablePromise<CreateConnectionRequestResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/connection/request',
      body: requestBody,
      mediaType: 'application/json',
    });
  }
  /**
   * @param requestId
   * @returns GetConnectionRequestResponse
   * @throws ApiError
   */
  public getConnectionRequest(
    requestId: string,
  ): CancelablePromise<GetConnectionRequestResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/connection/request/{requestId}',
      path: {
        requestId: requestId,
      },
    });
  }
}
