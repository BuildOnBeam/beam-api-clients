/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { AddPolicyRequestInput } from '../models/AddPolicyRequestInput';
import type { AddPolicyResponse } from '../models/AddPolicyResponse';
import type { RemovePolicyResponse } from '../models/RemovePolicyResponse';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class PolicyService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Add a new policy to sponsor web3 actions
   * @param requestBody
   * @returns AddPolicyResponse Policy was successfully created
   * @throws ApiError
   */
  public createPolicy(
    requestBody: AddPolicyRequestInput,
  ): CancelablePromise<AddPolicyResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/policies',
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Get a list of policies
   * @returns any
   * @throws ApiError
   */
  public getPolicies(): CancelablePromise<any> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/policies',
    });
  }

  /**
   * Removing a policy that sponsors web3 actions
   * @param policyId
   * @returns RemovePolicyResponse Policy was successfully deleted
   * @throws ApiError
   */
  public deletePolicy(
    policyId: string,
  ): CancelablePromise<RemovePolicyResponse> {
    return this.httpRequest.request({
      method: 'DELETE',
      url: '/v1/policies/{policyId}',
      path: {
        policyId: policyId,
      },
    });
  }
}
