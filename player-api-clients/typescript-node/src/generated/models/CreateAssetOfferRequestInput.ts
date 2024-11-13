/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CreateAssetOfferRequestInput = {
  assetAddress: string;
  assetId: string;
  quantity: number;
  price: string;
  startTime?: string;
  endTime?: string;
  currency?: CreateAssetOfferRequestInput.currency;
  chainId?: number;
  operationProcessing?: CreateAssetOfferRequestInput.operationProcessing;
  operationId?: string | null;
};

export namespace CreateAssetOfferRequestInput {
  export enum currency {
    WBEAM = 'WBEAM',
    WSOPH = 'WSOPH',
    RAT = 'RAT',
    USDC = 'USDC',
  }

  export enum operationProcessing {
    SIGN_ONLY = 'SignOnly',
    EXECUTE = 'Execute',
  }
}
