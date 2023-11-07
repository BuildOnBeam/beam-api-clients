/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetAssetListingsResponse = {
  data: Array<{
    marketplaceId: string;
    price: string | null;
    sellType: string;
    startPrice: string | null;
    endPrice: string | null;
    platformFee: number;
    royaltyFee: number;
    currency: string;
    startTime: string | null;
    endTime: string | null;
    quantityListed: number;
    quantityFilled: number;
    quantityAvailable: number;
    orderId: string;
    expiresAt: string;
    sellerAddress: string;
    sellerEntityId?: string;
    contractId: string;
    nft: {
      marketplaceId: string;
      name: string;
      imageUrl: string | null;
      assetType: string;
      assetAddress: string;
      assetId: string;
      rarity?:
        | 'Common'
        | 'ExtremelyRare'
        | 'Rare'
        | 'Uncommon'
        | 'VeryRare'
        | null;
      rarityScore?: number | null;
      attributes?: Array<{
        type?: string | null;
        value?: string | null;
        rarity?: number | null;
        displayType?: string | null;
        maxValue?: number | null;
      }> | null;
      chainId?: number;
    };
  }>;
  pagination: {
    count: number;
    limit?: number;
    offset?: number;
  };
};
