/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { CreateOnrampRequestInput } from '../models/CreateOnrampRequestInput';
import type { CreateOnrampRequestResponse } from '../models/CreateOnrampRequestResponse';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class RampService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * @param entityId
   * @param requestBody
   * @returns CreateOnrampRequestResponse
   * @throws ApiError
   */
  public createOnrampRequest(
    entityId: string,
    requestBody: CreateOnrampRequestInput,
  ): CancelablePromise<CreateOnrampRequestResponse> {
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
}
