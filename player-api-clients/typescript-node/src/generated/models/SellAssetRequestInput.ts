/* generated using openapi-typescript-codegen -- do not edit */
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
  /**
   * Operation processing type. If Execute is used, Operation will be executed automatically right after User signs it. If you prefer to have more control, use SignOnly then Process it using ProcessOperation.
   */
  operationProcessing?: SellAssetRequestInput.operationProcessing;
  /**
   * Auth Provider for the user to use. If it's Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI.
   */
  authProvider?: SellAssetRequestInput.authProvider | null;
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
    SOPH = 'SOPH',
    WBEAM = 'WBEAM',
    WSOPH = 'WSOPH',
    RAT = 'RAT',
    USDC = 'USDC',
  }
  /**
   * Operation processing type. If Execute is used, Operation will be executed automatically right after User signs it. If you prefer to have more control, use SignOnly then Process it using ProcessOperation.
   */
  export enum operationProcessing {
    SIGN_ONLY = 'SignOnly',
    EXECUTE = 'Execute',
  }
  /**
   * Auth Provider for the user to use. If it's Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI.
   */
  export enum authProvider {
    ANY = 'Any',
    GOOGLE = 'Google',
    DISCORD = 'Discord',
    APPLE = 'Apple',
  }
}
