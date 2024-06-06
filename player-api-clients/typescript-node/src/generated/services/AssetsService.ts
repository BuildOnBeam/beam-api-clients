/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { CommonOperationResponse } from '../models/CommonOperationResponse';
import type { GetAssetResponse } from '../models/GetAssetResponse';
import type { GetAssetsForContractBodyInput } from '../models/GetAssetsForContractBodyInput';
import type { GetAssetsForContractResponse } from '../models/GetAssetsForContractResponse';
import type { GetAssetsForUserBodyInput } from '../models/GetAssetsForUserBodyInput';
import type { GetAssetsForUserResponse } from '../models/GetAssetsForUserResponse';
import type { GetUserCurrenciesResponse } from '../models/GetUserCurrenciesResponse';
import type { GetUserNativeCurrencyResponse } from '../models/GetUserNativeCurrencyResponse';
import type { TransferAssetRequestInput } from '../models/TransferAssetRequestInput';
import type { TransferNativeTokenRequestInput } from '../models/TransferNativeTokenRequestInput';
import type { TransferTokenRequestInput } from '../models/TransferTokenRequestInput';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class AssetsService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Get all the assets of a profile (NFT assets, e.g. ERC721 / ERC1155)
   * @param entityId
   * @param requestBody
   * @returns GetAssetsForUserResponse
   * @throws ApiError
   */
  public getUserAssetsForGamePost(
    entityId: string,
    requestBody: GetAssetsForUserBodyInput,
  ): CancelablePromise<GetAssetsForUserResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/assets/users/{entityId}',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Get all the currencies owned by an account (ERC20)
   * @param entityId
   * @param chainId
   * @returns GetUserCurrenciesResponse
   * @throws ApiError
   */
  public getUserCurrencies(
    entityId: string,
    chainId?: number,
  ): CancelablePromise<GetUserCurrenciesResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/assets/users/{entityId}/currencies',
      path: {
        entityId: entityId,
      },
      query: {
        chainId: chainId,
      },
    });
  }

  /**
   * Get the native token balance
   * @param entityId
   * @param chainId
   * @returns GetUserNativeCurrencyResponse
   * @throws ApiError
   */
  public getUserNativeCurrency(
    entityId: string,
    chainId?: number,
  ): CancelablePromise<GetUserNativeCurrencyResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/assets/users/{entityId}/native',
      path: {
        entityId: entityId,
      },
      query: {
        chainId: chainId,
      },
    });
  }

  /**
   * Transfer an asset (NFT assets, ERC721 / ERC1155)
   * @param entityId
   * @param requestBody
   * @returns CommonOperationResponse
   * @throws ApiError
   */
  public transferAsset(
    entityId: string,
    requestBody: TransferAssetRequestInput,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/assets/users/{entityId}/transfer-asset',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Transfer a token (token assets, ERC20)
   * @param entityId
   * @param requestBody
   * @returns CommonOperationResponse
   * @throws ApiError
   */
  public transferToken(
    entityId: string,
    requestBody: TransferTokenRequestInput,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/assets/users/{entityId}/transfer-token',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Transfer the native token (BEAM)
   * @param entityId
   * @param requestBody
   * @returns CommonOperationResponse
   * @throws ApiError
   */
  public transferNativeToken(
    entityId: string,
    requestBody: TransferNativeTokenRequestInput,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/assets/users/{entityId}/transfer-native',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Get all the assets of contract (NFT assets, e.g. ERC721 / ERC1155)
   * @param assetAddress
   * @param requestBody
   * @returns GetAssetsForContractResponse
   * @throws ApiError
   */
  public getContractAssetsPost(
    assetAddress: string,
    requestBody: GetAssetsForContractBodyInput,
  ): CancelablePromise<GetAssetsForContractResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/assets/{assetAddress}',
      path: {
        assetAddress: assetAddress,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Get a single NFT (e.g. ERC721 / ERC1155)
   * @param assetAddress
   * @param assetId
   * @param chainId
   * @param entityId
   * @param owners If true, will return owners of the token
   * @returns GetAssetResponse
   * @throws ApiError
   */
  public getAsset(
    assetAddress: string,
    assetId: string,
    chainId?: number,
    entityId?: string,
    owners?: boolean,
  ): CancelablePromise<GetAssetResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/assets/{assetAddress}/{assetId}',
      path: {
        assetAddress: assetAddress,
        assetId: assetId,
      },
      query: {
        chainId: chainId,
        entityId: entityId,
        owners: owners,
      },
    });
  }
}
