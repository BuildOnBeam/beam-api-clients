/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { AddContractRequestInput } from '../models/AddContractRequestInput';
import type { AddContractResponse } from '../models/AddContractResponse';
import type { GetGameResponse } from '../models/GetGameResponse';
import type { RegenerateGameApiKeysRequestInput } from '../models/RegenerateGameApiKeysRequestInput';
import type { RegenerateGameApiKeysResponse } from '../models/RegenerateGameApiKeysResponse';
import type { RemoveContractResponse } from '../models/RemoveContractResponse';
import type { UpdateGameRequestInput } from '../models/UpdateGameRequestInput';
import type { UpdateGameResponse } from '../models/UpdateGameResponse';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class GameService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Get information about your game
   * @returns GetGameResponse Game response (including contracts & policies)
   * @throws ApiError
   */
  public getGame(): CancelablePromise<GetGameResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/game',
    });
  }

  /**
   * Updating name, description and/or coverImageUrl
   * @param requestBody
   * @returns UpdateGameResponse Game was successfully updated
   * @throws ApiError
   */
  public updateGame(
    requestBody: UpdateGameRequestInput,
  ): CancelablePromise<UpdateGameResponse> {
    return this.httpRequest.request({
      method: 'PATCH',
      url: '/v1/game',
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Regenerate API keys
   * @param requestBody
   * @returns RegenerateGameApiKeysResponse Old keys were revoked and new ones were generated successfully
   * @throws ApiError
   */
  public regenerateApiKeys(
    requestBody: RegenerateGameApiKeysRequestInput,
  ): CancelablePromise<RegenerateGameApiKeysResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/game/regenerate-api-keys',
      body: requestBody,
      mediaType: 'application/json',
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
      url: '/v1/game/contracts',
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
      url: '/v1/game/contracts/{address}/{chainId}',
      path: {
        chainId: chainId,
        address: address,
      },
    });
  }
}
