/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GetAssetResponseV2 = {
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
  rarity?: GetAssetResponseV2.rarity | null;
  rarityScore?: number | null;
  attributes?: Array<{
    displayType?: string | null;
    maxValue?: number | null;
    rarity?: number | null;
    type?: string | null;
    value?: string | null;
  }> | null;
  chainId: number;
};
export namespace GetAssetResponseV2 {
  export enum rarity {
    COMMON = 'Common',
    UNCOMMON = 'Uncommon',
    RARE = 'Rare',
    VERY_RARE = 'VeryRare',
    EXTREMELY_RARE = 'ExtremelyRare',
  }
}
