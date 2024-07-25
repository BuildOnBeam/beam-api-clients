/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { CommonAddPolicyRequestInput } from '../models/CommonAddPolicyRequestInput';
import type { CommonAddPolicyResponse } from '../models/CommonAddPolicyResponse';
import type { CommonGetPoliciesResponse } from '../models/CommonGetPoliciesResponse';
import type { CommonRemovePolicyResponse } from '../models/CommonRemovePolicyResponse';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class PolicyService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Add a new policy to sponsor web3 actions
   * @param requestBody
   * @returns CommonAddPolicyResponse Policy was successfully created
   * @throws ApiError
   */
  public createPolicy(
    requestBody: CommonAddPolicyRequestInput,
  ): CancelablePromise<CommonAddPolicyResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/policies',
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Get a list of policies
   * @returns CommonGetPoliciesResponse
   * @throws ApiError
   */
  public getPolicies(): CancelablePromise<CommonGetPoliciesResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/policies',
    });
  }

  /**
   * Removing a policy that sponsors web3 actions
   * @param policyId
   * @returns CommonRemovePolicyResponse Policy was successfully deleted
   * @throws ApiError
   */
  public deletePolicy(
    policyId: string,
  ): CancelablePromise<CommonRemovePolicyResponse> {
    return this.httpRequest.request({
      method: 'DELETE',
      url: '/v1/policies/{policyId}',
      path: {
        policyId: policyId,
      },
    });
  }
}
