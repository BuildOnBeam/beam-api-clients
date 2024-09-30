/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { MigrateRequestInput } from '../models/MigrateRequestInput';
import type { MigrateResponse } from '../models/MigrateResponse';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class MigrationService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Migrate all the native token, ERC20 tokens and NFTs registered for your game from an Automation API profile to a Player API user
   * @param requestBody
   * @returns MigrateResponse
   * @throws ApiError
   */
  public migrateProfileAssets(
    requestBody: MigrateRequestInput,
  ): CancelablePromise<MigrateResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/migration/migrate',
      body: requestBody,
      mediaType: 'application/json',
    });
  }
}
