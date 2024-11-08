/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { AcceptAssetOfferRequestInputV2 } from '../models/AcceptAssetOfferRequestInputV2';
import type { BuyAssetRequestInputV2 } from '../models/BuyAssetRequestInputV2';
import type { CancelAssetListingRequestInputV2 } from '../models/CancelAssetListingRequestInputV2';
import type { CancelAssetOfferRequestInputV2 } from '../models/CancelAssetOfferRequestInputV2';
import type { CreateAssetOfferRequestInputV2 } from '../models/CreateAssetOfferRequestInputV2';
import type { CreateOfferResponseV2 } from '../models/CreateOfferResponseV2';
import type { GetAssetListingsResponseV2 } from '../models/GetAssetListingsResponseV2';
import type { GetChainCurrenciesResponseV2 } from '../models/GetChainCurrenciesResponseV2';
import type { GetListedAssetsBodyInputV2 } from '../models/GetListedAssetsBodyInputV2';
import type { RefreshContractRequestBody } from '../models/RefreshContractRequestBody';
import type { RefreshTokenRequestBody } from '../models/RefreshTokenRequestBody';
import type { SellAssetRequestInputV2 } from '../models/SellAssetRequestInputV2';
import type { SellAssetResponseV2 } from '../models/SellAssetResponseV2';
import type { TransactionResponse } from '../models/TransactionResponse';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class MarketplaceV2Service {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Get all listed assets for a game (NFT assets, e.g. ERC721 / ERC1155)
   * @param requestBody
   * @returns GetAssetListingsResponseV2
   * @throws ApiError
   */
  public getListedAssetsPostV2(
    requestBody: GetListedAssetsBodyInputV2,
  ): CancelablePromise<GetAssetListingsResponseV2> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v2/marketplace',
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Get all the assets listed by a profile (NFT assets, e.g. ERC721 / ERC1155)
   * @param entityId
   * @param requestBody
   * @returns GetAssetListingsResponseV2
   * @throws ApiError
   */
  public getListedAssetsForProfilePostV2(
    entityId: string,
    requestBody: GetListedAssetsBodyInputV2,
  ): CancelablePromise<GetAssetListingsResponseV2> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v2/marketplace/profiles/{entityId}',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * List an asset for sale
   * @param entityId
   * @param requestBody
   * @returns SellAssetResponseV2
   * @throws ApiError
   */
  public listAssetV2(
    entityId: string,
    requestBody: SellAssetRequestInputV2,
  ): CancelablePromise<SellAssetResponseV2> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v2/marketplace/profiles/{entityId}/listing',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Buy listed asset
   * @param entityId
   * @param orderId
   * @param requestBody
   * @returns TransactionResponse
   * @throws ApiError
   */
  public buyListedAssetV2(
    entityId: string,
    orderId: string,
    requestBody: BuyAssetRequestInputV2,
  ): CancelablePromise<TransactionResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v2/marketplace/profiles/{entityId}/listing/{orderId}',
      path: {
        entityId: entityId,
        orderId: orderId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Cancel asset listing
   * @param entityId
   * @param orderId
   * @param requestBody
   * @param chainId
   * @returns TransactionResponse
   * @throws ApiError
   */
  public cancelListingV2(
    entityId: string,
    orderId: string,
    requestBody: CancelAssetListingRequestInputV2,
    chainId?: number,
  ): CancelablePromise<TransactionResponse> {
    return this.httpRequest.request({
      method: 'DELETE',
      url: '/v2/marketplace/profiles/{entityId}/listing/{orderId}',
      path: {
        entityId: entityId,
        orderId: orderId,
      },
      query: {
        chainId: chainId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Make an offer for an asset
   * @param entityId
   * @param requestBody
   * @returns CreateOfferResponseV2
   * @throws ApiError
   */
  public createAssetOfferV2(
    entityId: string,
    requestBody: CreateAssetOfferRequestInputV2,
  ): CancelablePromise<CreateOfferResponseV2> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v2/marketplace/profiles/{entityId}/offers',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Get all offers that a profile created
   * @param entityId
   * @param chainId
   * @param continuation
   * @returns GetAssetListingsResponseV2
   * @throws ApiError
   */
  public getPlayerOffersV2(
    entityId: string,
    chainId?: number,
    continuation?: string,
  ): CancelablePromise<GetAssetListingsResponseV2> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v2/marketplace/profiles/{entityId}/offers',
      path: {
        entityId: entityId,
      },
      query: {
        chainId: chainId,
        continuation: continuation,
      },
    });
  }

  /**
   * Get all asset offers that player created
   * @param entityId
   * @param assetAddress
   * @param assetId
   * @param chainId
   * @param continuation
   * @returns GetAssetListingsResponseV2
   * @throws ApiError
   */
  public getPlayerAssetOffersV2(
    entityId: string,
    assetAddress: string,
    assetId: string,
    chainId?: number,
    continuation?: string,
  ): CancelablePromise<GetAssetListingsResponseV2> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v2/marketplace/profiles/{entityId}/offers/asset/{assetAddress}/{assetId}',
      path: {
        entityId: entityId,
        assetAddress: assetAddress,
        assetId: assetId,
      },
      query: {
        chainId: chainId,
        continuation: continuation,
      },
    });
  }

  /**
   * Accept an offer for an asset
   * @param entityId
   * @param offerId
   * @param requestBody
   * @returns TransactionResponse
   * @throws ApiError
   */
  public acceptAssetOfferV2(
    entityId: string,
    offerId: string,
    requestBody: AcceptAssetOfferRequestInputV2,
  ): CancelablePromise<TransactionResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v2/marketplace/profiles/{entityId}/offers/{offerId}/accept',
      path: {
        entityId: entityId,
        offerId: offerId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Cancel an offer for an asset
   * @param entityId
   * @param offerId
   * @param requestBody
   * @returns TransactionResponse
   * @throws ApiError
   */
  public cancelAssetOfferV2(
    entityId: string,
    offerId: string,
    requestBody: CancelAssetOfferRequestInputV2,
  ): CancelablePromise<TransactionResponse> {
    return this.httpRequest.request({
      method: 'DELETE',
      url: '/v2/marketplace/profiles/{entityId}/offers/{offerId}',
      path: {
        entityId: entityId,
        offerId: offerId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Get all offers for an asset
   * @param assetAddress
   * @param assetId
   * @param chainId
   * @param continuation
   * @returns GetAssetListingsResponseV2
   * @throws ApiError
   */
  public getAssetOffersV2(
    assetAddress: string,
    assetId: string,
    chainId?: number,
    continuation?: string,
  ): CancelablePromise<GetAssetListingsResponseV2> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v2/marketplace/offers/asset/{assetAddress}/{assetId}',
      path: {
        assetAddress: assetAddress,
        assetId: assetId,
      },
      query: {
        chainId: chainId,
        continuation: continuation,
      },
    });
  }

  /**
   * Get available currencies for given chain
   * @param chainId
   * @returns GetChainCurrenciesResponseV2
   * @throws ApiError
   */
  public getChainCurrenciesV2(
    chainId: number,
  ): CancelablePromise<GetChainCurrenciesResponseV2> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v2/marketplace/chain-currencies/{chainId}',
      query: {
        chainId: chainId,
      },
    });
  }

  /**
   * Schedule a token refresh in the indexer
   * @param requestBody
   * @returns any
   * @throws ApiError
   */
  public refreshToken(
    requestBody: RefreshTokenRequestBody,
  ): CancelablePromise<any> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v2/marketplace/refresh/token',
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Schedule a contract refresh in the indexer
   * @param requestBody
   * @returns any
   * @throws ApiError
   */
  public refreshContract(
    requestBody: RefreshContractRequestBody,
  ): CancelablePromise<any> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v2/marketplace/refresh/contract',
      body: requestBody,
      mediaType: 'application/json',
    });
  }
}
