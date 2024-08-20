/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { GetGameResponse } from '../models/GetGameResponse';
import type { RegenerateGameApiKeysResponse } from '../models/RegenerateGameApiKeysResponse';

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
   * Regenerate all your API keys through the provided regenerate key. Note that existing keys will be invalidated immediately
   * @returns RegenerateGameApiKeysResponse Old keys were revoked and new ones were generated successfully
   * @throws ApiError
   */
  public regenerateApiKeys(): CancelablePromise<RegenerateGameApiKeysResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/game/regenerate-api-keys',
    });
  }
}
