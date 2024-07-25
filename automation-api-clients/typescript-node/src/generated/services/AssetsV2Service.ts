/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { GetAssetResponseV2 } from '../models/GetAssetResponseV2';
import type { GetAssetsForContractBodyInputV2 } from '../models/GetAssetsForContractBodyInputV2';
import type { GetAssetsForContractResponseV2 } from '../models/GetAssetsForContractResponseV2';
import type { GetAssetsForProfileBodyInputV2 } from '../models/GetAssetsForProfileBodyInputV2';
import type { GetAssetsForProfileResponseV2 } from '../models/GetAssetsForProfileResponseV2';
import type { GetProfileCurrenciesResponseV2 } from '../models/GetProfileCurrenciesResponseV2';
import type { GetProfileNativeCurrencyResponseV2 } from '../models/GetProfileNativeCurrencyResponseV2';
import type { TransferAssetRequestInputV2 } from '../models/TransferAssetRequestInputV2';
import type { TransferAssetResponseV2 } from '../models/TransferAssetResponseV2';
import type { TransferNativeTokenRequestInputV2 } from '../models/TransferNativeTokenRequestInputV2';
import type { TransferTokenRequestInputV2 } from '../models/TransferTokenRequestInputV2';
import type { TransferTokenResponseV2 } from '../models/TransferTokenResponseV2';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class AssetsV2Service {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Get all the assets of a profile (NFT assets, e.g. ERC721 / ERC1155)
   * @param entityId
   * @param requestBody
   * @returns GetAssetsForProfileResponseV2
   * @throws ApiError
   */
  public getProfileAssetsForGamePostV2(
    entityId: string,
    requestBody: GetAssetsForProfileBodyInputV2,
  ): CancelablePromise<GetAssetsForProfileResponseV2> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v2/assets/profiles/{entityId}',
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
   * @returns GetProfileCurrenciesResponseV2
   * @throws ApiError
   */
  public getProfileCurrenciesV2(
    entityId: string,
    chainId?: number,
  ): CancelablePromise<GetProfileCurrenciesResponseV2> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v2/assets/profiles/{entityId}/currencies',
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
   * @returns GetProfileNativeCurrencyResponseV2
   * @throws ApiError
   */
  public getProfileNativeCurrencyV2(
    entityId: string,
    chainId?: number,
  ): CancelablePromise<GetProfileNativeCurrencyResponseV2> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v2/assets/profiles/{entityId}/native',
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
   * @returns TransferAssetResponseV2
   * @throws ApiError
   */
  public transferAssetV2(
    entityId: string,
    requestBody: TransferAssetRequestInputV2,
  ): CancelablePromise<TransferAssetResponseV2> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v2/assets/profiles/{entityId}/transfer-asset',
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
   * @returns TransferTokenResponseV2
   * @throws ApiError
   */
  public transferTokenV2(
    entityId: string,
    requestBody: TransferTokenRequestInputV2,
  ): CancelablePromise<TransferTokenResponseV2> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v2/assets/profiles/{entityId}/transfer-token',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Transfer the native token
   * @param entityId
   * @param requestBody
   * @returns TransferTokenResponseV2
   * @throws ApiError
   */
  public transferNativeTokenV2(
    entityId: string,
    requestBody: TransferNativeTokenRequestInputV2,
  ): CancelablePromise<TransferTokenResponseV2> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v2/assets/profiles/{entityId}/transfer-native',
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
   * @returns GetAssetsForContractResponseV2
   * @throws ApiError
   */
  public getContractAssetsPostV2(
    assetAddress: string,
    requestBody: GetAssetsForContractBodyInputV2,
  ): CancelablePromise<GetAssetsForContractResponseV2> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v2/assets/{assetAddress}',
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
   * @returns GetAssetResponseV2
   * @throws ApiError
   */
  public getAssetV2(
    assetAddress: string,
    assetId: string,
    chainId?: number,
    entityId?: string,
    owners?: boolean,
  ): CancelablePromise<GetAssetResponseV2> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v2/assets/{assetAddress}/{assetId}',
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
