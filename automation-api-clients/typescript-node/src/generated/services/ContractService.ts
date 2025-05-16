/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { AddContractRequestInput } from '../models/AddContractRequestInput';
import type { AddContractResponse } from '../models/AddContractResponse';
import type { GameContractsResponse } from '../models/GameContractsResponse';
import type { GetVerificationStatusRequestInput } from '../models/GetVerificationStatusRequestInput';
import type { GetVerificationStatusResponse } from '../models/GetVerificationStatusResponse';
import type { ReadContractRequest } from '../models/ReadContractRequest';
import type { ReadContractResonse } from '../models/ReadContractResonse';
import type { RemoveContractResponse } from '../models/RemoveContractResponse';

import type { CancelablePromise } from '../core/CancelablePromise';
import type { BaseHttpRequest } from '../core/BaseHttpRequest';

export class ContractService {

  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Get the verification status of a contract
   * @param requestBody
   * @returns GetVerificationStatusResponse Contract verification status
   * @throws ApiError
   */
  public getVerificationStatus(
    requestBody: GetVerificationStatusRequestInput,
  ): CancelablePromise<GetVerificationStatusResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/contract/get-verification-status',
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Get a list of Contracts added to your Game
   * @param includeAbis
   * @returns GameContractsResponse List of Contracts added to your Game
   * @throws ApiError
   */
  public getGameContracts(
    includeAbis?: boolean,
  ): CancelablePromise<GameContractsResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/contract',
      query: {
        'includeAbis': includeAbis,
      },
    });
  }

  /**
   * Add a new contract to the game
   * @param requestBody
   * @returns AddContractResponse The contract was successfully added to the game
   * @throws ApiError
   */
  public addContractToGame(
    requestBody: AddContractRequestInput,
  ): CancelablePromise<AddContractResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/contract',
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Delete a contract from a game
   * @param chainId
   * @param address
   * @returns RemoveContractResponse The contract was successfully deleted from the game
   * @throws ApiError
   */
  public removeContractFromGame(
    chainId: number,
    address: string,
  ): CancelablePromise<RemoveContractResponse> {
    return this.httpRequest.request({
      method: 'DELETE',
      url: '/v1/contract/{address}/{chainId}',
      path: {
        'chainId': chainId,
        'address': address,
      },
    });
  }

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
        'contractAddress': contractAddress,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

}
