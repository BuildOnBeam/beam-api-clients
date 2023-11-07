/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetAssetsResponse = {
  data: Array<{
    marketplaceId: string;
    name: string;
    imageUrl: string | null;
    assetType: string;
    assetAddress: string;
    assetId: string;
    quantity: number;
    owners: Array<{
      address: string;
      entityId?: string;
      quantity: number;
    }>;
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
  }>;
  pagination: {
    count: number;
    limit?: number;
    offset?: number;
  };
};
