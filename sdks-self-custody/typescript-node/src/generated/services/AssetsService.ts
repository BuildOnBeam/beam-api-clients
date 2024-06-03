/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { CommonOperationResponse } from '../models/CommonOperationResponse';
import type { GetAssetResponseV3 } from '../models/GetAssetResponseV3';
import type { GetAssetsForContractBodyInputV3 } from '../models/GetAssetsForContractBodyInputV3';
import type { GetAssetsForContractResponseV3 } from '../models/GetAssetsForContractResponseV3';
import type { GetAssetsForProfileBodyInputV3 } from '../models/GetAssetsForProfileBodyInputV3';
import type { GetAssetsForProfileResponseV3 } from '../models/GetAssetsForProfileResponseV3';
import type { GetProfileCurrenciesResponseV3 } from '../models/GetProfileCurrenciesResponseV3';
import type { GetProfileNativeCurrencyResponseV3 } from '../models/GetProfileNativeCurrencyResponseV3';
import type { TransferAssetRequestInputV3 } from '../models/TransferAssetRequestInputV3';
import type { TransferNativeTokenRequestInputV3 } from '../models/TransferNativeTokenRequestInputV3';
import type { TransferTokenRequestInputV3 } from '../models/TransferTokenRequestInputV3';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class AssetsService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Get all the assets of a profile (NFT assets, e.g. ERC721 / ERC1155)
   * @param entityId
   * @param requestBody
   * @returns GetAssetsForProfileResponseV3
   * @throws ApiError
   */
  public getProfileAssetsForGamePostV3(
    entityId: string,
    requestBody: GetAssetsForProfileBodyInputV3,
  ): CancelablePromise<GetAssetsForProfileResponseV3> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/self-custody/assets/users/{entityId}',
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
   * @returns GetProfileCurrenciesResponseV3
   * @throws ApiError
   */
  public getProfileCurrenciesV3(
    entityId: string,
    chainId?: number,
  ): CancelablePromise<GetProfileCurrenciesResponseV3> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/self-custody/assets/users/{entityId}/currencies',
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
   * @returns GetProfileNativeCurrencyResponseV3
   * @throws ApiError
   */
  public getProfileNativeCurrencyV3(
    entityId: string,
    chainId?: number,
  ): CancelablePromise<GetProfileNativeCurrencyResponseV3> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/self-custody/assets/users/{entityId}/native',
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
  public transferAssetV3(
    entityId: string,
    requestBody: TransferAssetRequestInputV3,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/self-custody/assets/users/{entityId}/transfer-asset',
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
  public transferTokenV3(
    entityId: string,
    requestBody: TransferTokenRequestInputV3,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/self-custody/assets/users/{entityId}/transfer-token',
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
  public transferNativeTokenV3(
    entityId: string,
    requestBody: TransferNativeTokenRequestInputV3,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/self-custody/assets/users/{entityId}/transfer-native',
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
   * @returns GetAssetsForContractResponseV3
   * @throws ApiError
   */
  public getContractAssetsPostV3(
    assetAddress: string,
    requestBody: GetAssetsForContractBodyInputV3,
  ): CancelablePromise<GetAssetsForContractResponseV3> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/self-custody/assets/{assetAddress}',
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
   * @returns GetAssetResponseV3
   * @throws ApiError
   */
  public getAssetV3(
    assetAddress: string,
    assetId: string,
    chainId?: number,
    entityId?: string,
    owners?: boolean,
  ): CancelablePromise<GetAssetResponseV3> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/self-custody/assets/{assetAddress}/{assetId}',
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
