/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type SellAssetRequestInput = {
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
  sellType: SellAssetRequestInput.sellType;
  currency?: SellAssetRequestInput.currency;
  sponsor?: boolean;
  policyId?: string | null;
  chainId?: number;
  operationProcessing?: SellAssetRequestInput.operationProcessing;
  operationId?: string | null;
};

export namespace SellAssetRequestInput {
  export enum sellType {
    FIXED_PRICE = 'FixedPrice',
    DESCENDING_AUCTION = 'DescendingAuction',
    ASCENDING_AUCTION = 'AscendingAuction',
    NOT_FOR_SALE = 'NotForSale',
  }

  export enum currency {
    BEAM = 'BEAM',
    IMX = 'IMX',
    SOPH = 'SOPH',
    WBEAM = 'WBEAM',
    WIMX = 'WIMX',
    WSOPH = 'WSOPH',
    RAT = 'RAT',
    USDC = 'USDC',
  }

  export enum operationProcessing {
    SIGN_ONLY = 'SignOnly',
    EXECUTE = 'Execute',
  }
}
