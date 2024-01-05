/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type SellAssetRequestInputV2 = {
  assetAddress: string;
  assetId: string;
  quantity: number;
  price: string;
  startTime?: string | null;
  endTime?: string | null;
  sellType: SellAssetRequestInputV2.sellType;
  currency?: SellAssetRequestInputV2.currency;
  sponsor?: boolean;
  policyId?: string | null;
  chainId?: number;
};

export namespace SellAssetRequestInputV2 {
  export enum sellType {
    FIXED_PRICE = 'FixedPrice',
    DESCENDING_AUCTION = 'DescendingAuction',
    ASCENDING_AUCTION = 'AscendingAuction',
    NOT_FOR_SALE = 'NotForSale',
  }

  export enum currency {
    BEAM = 'BEAM',
    WBEAM = 'WBEAM',
    USDC = 'USDC',
    USDT = 'USDT',
  }
}
