/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { AcceptAssetOfferRequestInput } from '../models/AcceptAssetOfferRequestInput';
import type { BuyAssetRequestInput } from '../models/BuyAssetRequestInput';
import type { CancelAssetListingRequestInput } from '../models/CancelAssetListingRequestInput';
import type { CancelAssetOfferRequestInput } from '../models/CancelAssetOfferRequestInput';
import type { CommonOperationResponse } from '../models/CommonOperationResponse';
import type { CreateAssetOfferRequestInput } from '../models/CreateAssetOfferRequestInput';
import type { GetAssetListingsResponse } from '../models/GetAssetListingsResponse';
import type { GetChainCurrenciesResponse } from '../models/GetChainCurrenciesResponse';
import type { GetListedAssetsBodyInput } from '../models/GetListedAssetsBodyInput';
import type { SellAssetRequestInput } from '../models/SellAssetRequestInput';

import type { BaseHttpRequest } from '../core/BaseHttpRequest';
import type { CancelablePromise } from '../core/CancelablePromise';

export class MarketplaceService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * Get all listed assets for a game (NFT assets, e.g. ERC721 / ERC1155)
   * @param requestBody
   * @returns GetAssetListingsResponse
   * @throws ApiError
   */
  public getListedAssets(
    requestBody: GetListedAssetsBodyInput,
  ): CancelablePromise<GetAssetListingsResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/self-custody/marketplace',
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Get all the assets listed by a profile (NFT assets, e.g. ERC721 / ERC1155)
   * @param entityId
   * @param requestBody
   * @returns GetAssetListingsResponse
   * @throws ApiError
   */
  public getListedAssetsForProfile(
    entityId: string,
    requestBody: GetListedAssetsBodyInput,
  ): CancelablePromise<GetAssetListingsResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/self-custody/marketplace/users/{entityId}',
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
   * @returns CommonOperationResponse
   * @throws ApiError
   */
  public listAsset(
    entityId: string,
    requestBody: SellAssetRequestInput,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/self-custody/marketplace/users/{entityId}/listing',
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
   * @returns CommonOperationResponse
   * @throws ApiError
   */
  public buyListedAsset(
    entityId: string,
    orderId: string,
    requestBody: BuyAssetRequestInput,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/self-custody/marketplace/users/{entityId}/listing/{orderId}',
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
   * @returns CommonOperationResponse
   * @throws ApiError
   */
  public cancelListing(
    entityId: string,
    orderId: string,
    requestBody: CancelAssetListingRequestInput,
    chainId?: number,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'DELETE',
      url: '/v1/self-custody/marketplace/users/{entityId}/listing/{orderId}',
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
   * @returns CommonOperationResponse
   * @throws ApiError
   */
  public createAssetOffer(
    entityId: string,
    requestBody: CreateAssetOfferRequestInput,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/self-custody/marketplace/users/{entityId}/offers',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Get all offers that player created
   * @param entityId
   * @param chainId
   * @param continuation
   * @returns GetAssetListingsResponse
   * @throws ApiError
   */
  public getPlayerOffers(
    entityId: string,
    chainId?: number,
    continuation?: string,
  ): CancelablePromise<GetAssetListingsResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/self-custody/marketplace/users/{entityId}/offers',
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
   * @returns GetAssetListingsResponse
   * @throws ApiError
   */
  public getPlayerAssetOffers(
    entityId: string,
    assetAddress: string,
    assetId: string,
    chainId?: number,
    continuation?: string,
  ): CancelablePromise<GetAssetListingsResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/self-custody/marketplace/users/{entityId}/offers/asset/{assetAddress}/{assetId}',
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
   * @param requestBody
   * @returns CommonOperationResponse
   * @throws ApiError
   */
  public acceptAssetOffer(
    entityId: string,
    requestBody: AcceptAssetOfferRequestInput,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/self-custody/marketplace/users/{entityId}/offers/{offerId}/accept',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Cancel an offer for an asset
   * @param entityId
   * @param requestBody
   * @returns CommonOperationResponse
   * @throws ApiError
   */
  public cancelAssetOffer(
    entityId: string,
    requestBody: CancelAssetOfferRequestInput,
  ): CancelablePromise<CommonOperationResponse> {
    return this.httpRequest.request({
      method: 'DELETE',
      url: '/v1/self-custody/marketplace/users/{entityId}/offers/{offerId}',
      path: {
        entityId: entityId,
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
   * @returns GetAssetListingsResponse
   * @throws ApiError
   */
  public getAssetOffers(
    assetAddress: string,
    assetId: string,
    chainId?: number,
    continuation?: string,
  ): CancelablePromise<GetAssetListingsResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/self-custody/marketplace/offers/asset/{assetAddress}/{assetId}',
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
   * @returns GetChainCurrenciesResponse
   * @throws ApiError
   */
  public getChainCurrencies(
    chainId: number,
  ): CancelablePromise<GetChainCurrenciesResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/self-custody/marketplace/chain-currencies/{chainId}',
      path: {
        chainId: chainId,
      },
    });
  }
}
