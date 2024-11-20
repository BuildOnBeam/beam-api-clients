/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetAssetsForContractResponseV2 = {
  data: Array<{
    name: string;
    imageUrl: string;
    assetType: string;
    assetAddress: string;
    assetId: string;
    supply: number;
    rarity?:
      | 'Common'
      | 'Uncommon'
      | 'Rare'
      | 'VeryRare'
      | 'ExtremelyRare'
      | null;
    rarityScore?: number | null;
    updatedAt?: string | null;
    mintedAt?: string | null;
    attributes?: Array<{
      displayType?: string | null;
      maxValue?: number | null;
      rarity?: number | null;
      type?: string | null;
      value?: string | null;
    }> | null;
    chainId?: number;
  }>;
  continuation?: string | null;
};
