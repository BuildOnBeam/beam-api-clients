/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type CancelAssetOfferRequestInput = {
  optimistic?: boolean;
  sponsor?: boolean;
  policyId?: string | null;
  /**
   * Operation processing type. If Execute is used, Operation will be executed automatically right after User signs it. If you prefer to have more control, use SignOnly then Process it using ProcessOperation.
   */
  operationProcessing?: CancelAssetOfferRequestInput.operationProcessing;
  /**
   * Auth Provider for the user to use. If it's Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI.
   */
  authProvider?: CancelAssetOfferRequestInput.authProvider | null;
  chainId?: number;
};
export namespace CancelAssetOfferRequestInput {
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
