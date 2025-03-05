/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type CreateAssetOfferRequestInputV2 = {
  assetAddress: string;
  assetId: string;
  quantity: number;
  price: string;
  startTime?: string;
  endTime?: string;
  currency?: CreateAssetOfferRequestInputV2.currency;
  chainId?: number;
};
export namespace CreateAssetOfferRequestInputV2 {
  export enum currency {
    WBEAM = 'WBEAM',
    WSOPH = 'WSOPH',
    RAT = 'RAT',
    USDC = 'USDC',
  }
}

