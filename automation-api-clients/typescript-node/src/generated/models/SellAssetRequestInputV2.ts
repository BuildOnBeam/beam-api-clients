/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type SellAssetRequestInputV2 = {
  assetAddress: string;
  assetId: string;
  quantity: number;
  price: string;
  /**
   * Date time string with YYYY-MM-DDTHH:mm:ss.sssZ format or Unix timestamp in milliseconds
   */
  startTime?: string | null;
  /**
   * Date time string with YYYY-MM-DDTHH:mm:ss.sssZ format or Unix timestamp in milliseconds
   */
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
    SOPH = 'SOPH',
    WBEAM = 'WBEAM',
    WSOPH = 'WSOPH',
    RAT = 'RAT',
    USDC = 'USDC',
  }
}
