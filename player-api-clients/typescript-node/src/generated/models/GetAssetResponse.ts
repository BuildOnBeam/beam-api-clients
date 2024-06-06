/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetAssetResponse = {
  name: string;
  imageUrl: string;
  assetType: string;
  assetAddress: string;
  assetId: string;
  supply: number;
  owners: Array<{
    address: string;
    quantity: number;
    entityId?: string;
  }> | null;
  rarity?: GetAssetResponse.rarity | null;
  rarityScore?: number | null;
  attributes?: Array<{
    displayType?: string | null;
    maxValue?: number | null;
    rarity?: number | null;
    type?: string | null;
    value?: string | null;
  }> | null;
  chainId?: number;
};

export namespace GetAssetResponse {
  export enum rarity {
    COMMON = 'Common',
    UNCOMMON = 'Uncommon',
    RARE = 'Rare',
    VERY_RARE = 'VeryRare',
    EXTREMELY_RARE = 'ExtremelyRare',
  }
}
