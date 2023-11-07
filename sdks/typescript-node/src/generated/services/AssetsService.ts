/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { GetAssetResponse } from '../models/GetAssetResponse';
import type { GetAssetsBodyInput } from '../models/GetAssetsBodyInput';
import type { GetAssetsResponse } from '../models/GetAssetsResponse';
import type { GetProfileCurrenciesResponse } from '../models/GetProfileCurrenciesResponse';
import type { GetProfileNativeCurrencyResponse } from '../models/GetProfileNativeCurrencyResponse';
import type { TransferAssetRequestInput } from '../models/TransferAssetRequestInput';
import type { TransferAssetResponse } from '../models/TransferAssetResponse';
import type { TransferNativeTokenRequestInput } from '../models/TransferNativeTokenRequestInput';
import type { TransferTokenRequestInput } from '../models/TransferTokenRequestInput';
import type { TransferTokenResponse } from '../models/TransferTokenResponse';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class AssetsService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Get all the assets of a profile (NFT assets, e.g. ERC721 / ERC1155)
   * @param entityId
   * @param requestBody
   * @param chainId
   * @returns GetAssetsResponse
   * @throws ApiError
   */
  public getProfileAssetsForGamePost(
    entityId: string,
    requestBody: GetAssetsBodyInput,
    chainId?: number,
  ): CancelablePromise<GetAssetsResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/assets/profiles/{entityId}',
      path: {
        entityId: entityId,
      },
      query: {
        chainId: chainId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * @deprecated
   * Get all the assets of a profile (NFT assets, e.g. ERC721 / ERC1155)
   * This endpoint is deprecated. Use POST route instead.
   * @param entityId
   * @param chainId
   * @param limit
   * @param offset
   * @param filter
   * @param sort
   * @returns GetAssetsResponse
   * @throws ApiError
   */
  public getProfileAssetsForGame(
    entityId: string,
    chainId?: number,
    limit?: number,
    offset?: number,
    filter?: {
      attributes?: Array<{
        type?: string | null;
        value?: string | null;
      }> | null;
      sellTypes?: Array<
        'AscendingAuction' | 'DescendingAuction' | 'FixedPrice' | 'NotForSale'
      > | null;
      currencies?: Array<
        | 'Avax'
        | 'Beam'
        | 'Eth'
        | 'Matic'
        | 'Mc'
        | 'Usdc'
        | 'Usdt'
        | 'Wavax'
        | 'Wbeam'
        | 'Weth'
        | 'Wmatic'
        | 'Wmc'
      > | null;
      rarities?: Array<
        'Common' | 'ExtremelyRare' | 'Rare' | 'Uncommon' | 'VeryRare'
      > | null;
    },
    sort?: {
      rarityScore?: 'ASC' | 'DESC' | null;
      start?: 'ASC' | 'DESC' | null;
      end?: 'ASC' | 'DESC' | null;
      createdAt?: 'ASC' | 'DESC' | null;
      fixedPriceNumber?: 'ASC' | 'DESC' | null;
      startPriceNumber?: 'ASC' | 'DESC' | null;
      endPriceNumber?: 'ASC' | 'DESC' | null;
    },
  ): CancelablePromise<GetAssetsResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/assets/profiles/{entityId}',
      path: {
        entityId: entityId,
      },
      query: {
        chainId: chainId,
        limit: limit,
        offset: offset,
        filter: filter,
        sort: sort,
      },
    });
  }

  /**
   * Get all the currencies owned by an account (ERC20)
   * @param entityId
   * @param chainId
   * @returns GetProfileCurrenciesResponse
   * @throws ApiError
   */
  public getProfileCurrencies(
    entityId: string,
    chainId?: number,
  ): CancelablePromise<GetProfileCurrenciesResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/assets/profiles/{entityId}/currencies',
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
   * @returns GetProfileNativeCurrencyResponse
   * @throws ApiError
   */
  public getProfileNativeCurrency(
    entityId: string,
    chainId?: number,
  ): CancelablePromise<GetProfileNativeCurrencyResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/assets/profiles/{entityId}/native',
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
   * @returns TransferAssetResponse
   * @throws ApiError
   */
  public transferAsset(
    entityId: string,
    requestBody: TransferAssetRequestInput,
  ): CancelablePromise<TransferAssetResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/assets/profiles/{entityId}/transfer-asset',
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
   * @returns TransferTokenResponse
   * @throws ApiError
   */
  public transferToken(
    entityId: string,
    requestBody: TransferTokenRequestInput,
  ): CancelablePromise<TransferTokenResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/assets/profiles/{entityId}/transfer-token',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Transfer the native token (MC)
   * @param entityId
   * @param requestBody
   * @returns TransferTokenResponse
   * @throws ApiError
   */
  public transferNativeToken(
    entityId: string,
    requestBody: TransferNativeTokenRequestInput,
  ): CancelablePromise<TransferTokenResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/assets/profiles/{entityId}/transfer-native',
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
   * @param chainId
   * @returns GetAssetsResponse
   * @throws ApiError
   */
  public getContractAssetsPost(
    assetAddress: string,
    requestBody: GetAssetsBodyInput,
    chainId?: number,
  ): CancelablePromise<GetAssetsResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/assets/{assetAddress}',
      path: {
        assetAddress: assetAddress,
      },
      query: {
        chainId: chainId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * @deprecated
   * Get all the assets of contract (NFT assets, e.g. ERC721 / ERC1155)
   * This endpoint is deprecated. Use POST route instead.
   * @param assetAddress
   * @param chainId
   * @param limit
   * @param offset
   * @param filter
   * @param sort
   * @returns GetAssetsResponse
   * @throws ApiError
   */
  public getContractAssets(
    assetAddress: string,
    chainId?: number,
    limit?: number,
    offset?: number,
    filter?: {
      attributes?: Array<{
        type?: string | null;
        value?: string | null;
      }> | null;
      sellTypes?: Array<
        'AscendingAuction' | 'DescendingAuction' | 'FixedPrice' | 'NotForSale'
      > | null;
      currencies?: Array<
        | 'Avax'
        | 'Beam'
        | 'Eth'
        | 'Matic'
        | 'Mc'
        | 'Usdc'
        | 'Usdt'
        | 'Wavax'
        | 'Wbeam'
        | 'Weth'
        | 'Wmatic'
        | 'Wmc'
      > | null;
      rarities?: Array<
        'Common' | 'ExtremelyRare' | 'Rare' | 'Uncommon' | 'VeryRare'
      > | null;
    },
    sort?: {
      rarityScore?: 'ASC' | 'DESC' | null;
      start?: 'ASC' | 'DESC' | null;
      end?: 'ASC' | 'DESC' | null;
      createdAt?: 'ASC' | 'DESC' | null;
      fixedPriceNumber?: 'ASC' | 'DESC' | null;
      startPriceNumber?: 'ASC' | 'DESC' | null;
      endPriceNumber?: 'ASC' | 'DESC' | null;
    },
  ): CancelablePromise<GetAssetsResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/assets/{assetAddress}',
      path: {
        assetAddress: assetAddress,
      },
      query: {
        chainId: chainId,
        limit: limit,
        offset: offset,
        filter: filter,
        sort: sort,
      },
    });
  }

  /**
   * Get a single NFT (e.g. ERC721 / ERC1155)
   * @param assetAddress
   * @param assetId
   * @param chainId
   * @param entityId
   * @returns GetAssetResponse
   * @throws ApiError
   */
  public getAsset(
    assetAddress: string,
    assetId: string,
    chainId?: number,
    entityId?: string,
  ): CancelablePromise<GetAssetResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/assets/{assetAddress}/{assetId}',
      path: {
        assetAddress: assetAddress,
        assetId: assetId,
      },
      query: {
        chainId: chainId,
        entityId: entityId,
      },
    });
  }
}
