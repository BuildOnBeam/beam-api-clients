/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { ReadContractRequest } from '../models/ReadContractRequest';
import type { ReadContractResonse } from '../models/ReadContractResonse';
import type { CancelablePromise } from '../core/CancelablePromise';
import type { BaseHttpRequest } from '../core/BaseHttpRequest';
export class ContractService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}
  /**
   * Calls a readable contract function
   * @param contractAddress
   * @param requestBody
   * @returns ReadContractResonse
   * @throws ApiError
   */
  public readContract(
    contractAddress: string,
    requestBody: ReadContractRequest,
  ): CancelablePromise<ReadContractResonse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/contract/{contractAddress}/read',
      path: {
        contractAddress: contractAddress,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
}
