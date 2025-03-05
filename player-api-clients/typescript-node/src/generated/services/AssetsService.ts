/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { GetAssetResponse } from '../models/GetAssetResponse';
import type { GetAssetsForContractBodyInput } from '../models/GetAssetsForContractBodyInput';
import type { GetAssetsForContractResponse } from '../models/GetAssetsForContractResponse';
import type { GetAssetsForUserBodyInput } from '../models/GetAssetsForUserBodyInput';
import type { GetAssetsForUserResponse } from '../models/GetAssetsForUserResponse';
import type { GetAttributesResponse } from '../models/GetAttributesResponse';
import type { GetOwnerAssetsBodyInput } from '../models/GetOwnerAssetsBodyInput';
import type { GetOwnerAssetsResponse } from '../models/GetOwnerAssetsResponse';
import type { GetOwnersResponse } from '../models/GetOwnersResponse';
import type { GetUserCurrenciesResponse } from '../models/GetUserCurrenciesResponse';
import type { GetUserNativeCurrencyResponse } from '../models/GetUserNativeCurrencyResponse';
import type { PlayerOperationResponse } from '../models/PlayerOperationResponse';
import type { TransferAssetRequestInput } from '../models/TransferAssetRequestInput';
import type { TransferNativeTokenRequestInput } from '../models/TransferNativeTokenRequestInput';
import type { TransferTokenRequestInput } from '../models/TransferTokenRequestInput';
import type { CancelablePromise } from '../core/CancelablePromise';
import type { BaseHttpRequest } from '../core/BaseHttpRequest';
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
        'entityId': entityId,
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
        'entityId': entityId,
      },
      query: {
        'chainId': chainId,
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
        'entityId': entityId,
      },
      query: {
        'chainId': chainId,
      },
    });
  }
  /**
   * Transfer an asset (NFT assets, ERC721 / ERC1155)
   * @param entityId
   * @param requestBody
   * @returns PlayerOperationResponse
   * @throws ApiError
   */
  public transferAsset(
    entityId: string,
    requestBody: TransferAssetRequestInput,
  ): CancelablePromise<PlayerOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/assets/users/{entityId}/transfer-asset',
      path: {
        'entityId': entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
  /**
   * Transfer a token (token assets, ERC20)
   * @param entityId
   * @param requestBody
   * @returns PlayerOperationResponse
   * @throws ApiError
   */
  public transferToken(
    entityId: string,
    requestBody: TransferTokenRequestInput,
  ): CancelablePromise<PlayerOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/assets/users/{entityId}/transfer-token',
      path: {
        'entityId': entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
  /**
   * Transfer the native token
   * @param entityId
   * @param requestBody
   * @returns PlayerOperationResponse
   * @throws ApiError
   */
  public transferNativeToken(
    entityId: string,
    requestBody: TransferNativeTokenRequestInput,
  ): CancelablePromise<PlayerOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/assets/users/{entityId}/transfer-native',
      path: {
        'entityId': entityId,
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
  public getAssetsForContract(
    assetAddress: string,
    requestBody: GetAssetsForContractBodyInput,
  ): CancelablePromise<GetAssetsForContractResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/assets/{assetAddress}/assets',
      path: {
        'assetAddress': assetAddress,
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
   * @param entityId If true, will always return 'owners' record for this User if he owns the asset
   * @param owners If true, will return all owners of the asset
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
      url: '/v1/player/assets/{assetAddress}/assets/{assetId}',
      path: {
        'assetAddress': assetAddress,
        'assetId': assetId,
      },
      query: {
        'chainId': chainId,
        'entityId': entityId,
        'owners': owners,
      },
    });
  }
  /**
   * @param assetAddress
   * @param chainId
   * @returns GetAttributesResponse
   * @throws ApiError
   */
  public getAttributes(
    assetAddress: string,
    chainId: number,
  ): CancelablePromise<GetAttributesResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/assets/{assetAddress}/attributes',
      path: {
        'assetAddress': assetAddress,
      },
      query: {
        'chainId': chainId,
      },
    });
  }
  /**
   * @param assetAddress
   * @param chainId
   * @param limit
   * @param offset
   * @returns GetOwnersResponse
   * @throws ApiError
   */
  public getOwners(
    assetAddress: string,
    chainId: number,
    limit: number = 10,
    offset: number = 0,
  ): CancelablePromise<GetOwnersResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/assets/{assetAddress}/owners',
      path: {
        'assetAddress': assetAddress,
      },
      query: {
        'chainId': chainId,
        'limit': limit,
        'offset': offset,
      },
    });
  }
  /**
   * @param assetAddress
   * @param ownerAddress
   * @param requestBody
   * @returns GetOwnerAssetsResponse
   * @throws ApiError
   */
  public getOwnerAssets(
    assetAddress: string,
    ownerAddress: string,
    requestBody: GetOwnerAssetsBodyInput,
  ): CancelablePromise<GetOwnerAssetsResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/assets/{assetAddress}/owners/{ownerAddress}/assets',
      path: {
        'assetAddress': assetAddress,
        'ownerAddress': ownerAddress,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
}
