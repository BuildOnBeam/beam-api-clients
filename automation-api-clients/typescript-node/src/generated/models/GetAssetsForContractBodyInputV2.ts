/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GetAssetsForContractBodyInputV2 = {
  continuation?: string | null;
  chainId?: number;
  minRarityRank?: number | null;
  maxRarityRank?: number | null;
  minFloorAskPrice?: number | null;
  maxFloorAskPrice?: number | null;
  includeAttributes?: boolean | null;
  attributes?: Array<{
    key: string;
    value: string;
  }> | null;
  sortDirection?: GetAssetsForContractBodyInputV2.sortDirection;
  sortBy?: GetAssetsForContractBodyInputV2.sortBy;
  limit?: number;
};
export namespace GetAssetsForContractBodyInputV2 {
  export enum sortDirection {
    ASC = 'asc',
    DESC = 'desc',
  }
  export enum sortBy {
    FLOOR_ASK_PRICE = 'floorAskPrice',
    TOKEN_ID = 'tokenId',
    RARITY = 'rarity',
    UPDATED_AT = 'updatedAt',
    MINTED_AT = 'mintedAt',
  }
}

