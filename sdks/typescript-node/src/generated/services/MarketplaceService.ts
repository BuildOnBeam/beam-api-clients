/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { AcceptAssetOfferRequestInput } from '../models/AcceptAssetOfferRequestInput';
import type { AcceptOfferResponse } from '../models/AcceptOfferResponse';
import type { BuyAssetRequestInput } from '../models/BuyAssetRequestInput';
import type { BuyAssetResponse } from '../models/BuyAssetResponse';
import type { CancelAssetListingRequestInput } from '../models/CancelAssetListingRequestInput';
import type { CancelAssetOfferRequestInput } from '../models/CancelAssetOfferRequestInput';
import type { CancelOfferResponse } from '../models/CancelOfferResponse';
import type { CreateAssetOfferRequestInput } from '../models/CreateAssetOfferRequestInput';
import type { CreateOfferResponse } from '../models/CreateOfferResponse';
import type { GetAssetListingsResponse } from '../models/GetAssetListingsResponse';
import type { GetAssetOffersResponse } from '../models/GetAssetOffersResponse';
import type { GetAssetsBodyInput } from '../models/GetAssetsBodyInput';
import type { GetChainCurrenciesResponse } from '../models/GetChainCurrenciesResponse';
import type { SellAssetRequestInput } from '../models/SellAssetRequestInput';
import type { SellAssetResponse } from '../models/SellAssetResponse';

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
  public getListedAssetsPost(
    requestBody: GetAssetsBodyInput,
  ): CancelablePromise<GetAssetListingsResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/marketplace',
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * @deprecated
   * Get all listed assets for a game (NFT assets, e.g. ERC721 / ERC1155)
   * This endpoint is deprecated. Use POST route instead.
   * @param gameId
   * @param limit
   * @param offset
   * @param filter
   * @param sort
   * @returns GetAssetListingsResponse
   * @throws ApiError
   */
  public getListedAssets(
    gameId?: string,
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
  ): CancelablePromise<GetAssetListingsResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/marketplace',
      path: {
        gameId: gameId,
      },
      query: {
        limit: limit,
        offset: offset,
        filter: filter,
        sort: sort,
      },
    });
  }

  /**
   * Get all the assets listed by a profile (NFT assets, e.g. ERC721 / ERC1155)
   * @param entityId
   * @param requestBody
   * @returns GetAssetListingsResponse
   * @throws ApiError
   */
  public getListedAssetsForProfilePost(
    entityId: string,
    requestBody: GetAssetsBodyInput,
  ): CancelablePromise<GetAssetListingsResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/marketplace/profiles/{entityId}',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * @deprecated
   * Get all the assets listed by a profile (NFT assets, e.g. ERC721 / ERC1155)
   * This endpoint is deprecated. Use POST route instead.
   * @param entityId
   * @param limit
   * @param offset
   * @param filter
   * @param sort
   * @returns GetAssetListingsResponse
   * @throws ApiError
   */
  public getListedAssetsForProfile(
    entityId: string,
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
  ): CancelablePromise<GetAssetListingsResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/marketplace/profiles/{entityId}',
      path: {
        entityId: entityId,
      },
      query: {
        limit: limit,
        offset: offset,
        filter: filter,
        sort: sort,
      },
    });
  }

  /**
   * List an asset for sale
   * @param entityId
   * @param requestBody
   * @returns SellAssetResponse
   * @throws ApiError
   */
  public listAsset(
    entityId: string,
    requestBody: SellAssetRequestInput,
  ): CancelablePromise<SellAssetResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/marketplace/profiles/{entityId}/listing',
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
   * @returns BuyAssetResponse
   * @throws ApiError
   */
  public buyListedAsset(
    entityId: string,
    orderId: string,
    requestBody: BuyAssetRequestInput,
  ): CancelablePromise<BuyAssetResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/marketplace/profiles/{entityId}/listing/{orderId}',
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
   * @returns BuyAssetResponse
   * @throws ApiError
   */
  public cancelListing(
    entityId: string,
    orderId: string,
    requestBody: CancelAssetListingRequestInput,
  ): CancelablePromise<BuyAssetResponse> {
    return this.httpRequest.request({
      method: 'DELETE',
      url: '/v1/marketplace/profiles/{entityId}/listing/{orderId}',
      path: {
        entityId: entityId,
        orderId: orderId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }

  /**
   * Make an offer for an asset
   * @param entityId
   * @param requestBody
   * @returns CreateOfferResponse
   * @throws ApiError
   */
  public createAssetOffer(
    entityId: string,
    requestBody: CreateAssetOfferRequestInput,
  ): CancelablePromise<CreateOfferResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/marketplace/profiles/{entityId}/offers',
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
   * @returns GetAssetOffersResponse
   * @throws ApiError
   */
  public getPlayerOffers(
    entityId: string,
    chainId?: number,
  ): CancelablePromise<GetAssetOffersResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/marketplace/profiles/{entityId}/offers',
      path: {
        entityId: entityId,
      },
      query: {
        chainId: chainId,
      },
    });
  }

  /**
   * Get all asset offers that player created
   * @param entityId
   * @param marketplaceId
   * @param chainId
   * @returns GetAssetOffersResponse
   * @throws ApiError
   */
  public getPlayerAssetOffers(
    entityId: string,
    marketplaceId: string,
    chainId?: number,
  ): CancelablePromise<GetAssetOffersResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/marketplace/profiles/{entityId}/offers/asset/{marketplaceId}',
      path: {
        entityId: entityId,
        marketplaceId: marketplaceId,
      },
      query: {
        chainId: chainId,
      },
    });
  }

  /**
   * Accept an offer for an asset
   * @param entityId
   * @param offerId
   * @param requestBody
   * @returns AcceptOfferResponse
   * @throws ApiError
   */
  public acceptAssetOffer(
    entityId: string,
    offerId: string,
    requestBody: AcceptAssetOfferRequestInput,
  ): CancelablePromise<AcceptOfferResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/marketplace/profiles/{entityId}/offers/{offerId}/accept',
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
   * @returns CancelOfferResponse
   * @throws ApiError
   */
  public cancelAssetOffer(
    entityId: string,
    offerId: string,
    requestBody: CancelAssetOfferRequestInput,
  ): CancelablePromise<CancelOfferResponse> {
    return this.httpRequest.request({
      method: 'DELETE',
      url: '/v1/marketplace/profiles/{entityId}/offers/{offerId}',
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
   * @param marketplaceId
   * @returns GetAssetOffersResponse
   * @throws ApiError
   */
  public getAssetOffers(
    marketplaceId: string,
  ): CancelablePromise<GetAssetOffersResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/marketplace/offers/asset/{marketplaceId}',
      path: {
        marketplaceId: marketplaceId,
      },
    });
  }

  /**
   * @param chainId
   * @returns GetChainCurrenciesResponse
   * @throws ApiError
   */
  public getChainCurrencies(
    chainId: number,
  ): CancelablePromise<GetChainCurrenciesResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/marketplace/chain-currencies/{chainId}',
      path: {
        chainId: chainId,
      },
    });
  }
}
