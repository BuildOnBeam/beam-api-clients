/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type ConvertTokenRequestInput = {
  tokenIn: string;
  tokenOut: string;
  amountIn: string;
  amountOut: string;
  receiverEntityId?: string;
  receiverWalletAddress?: string;
  optimistic?: boolean;
  sponsor?: boolean;
  policyId?: string | null;
  chainId?: number;
  /**
   * Operation processing type. If Execute is used, Operation will be executed automatically right after User signs it. If you prefer to have more control, use SignOnly then Process it using ProcessOperation.
   */
  operationProcessing?: ConvertTokenRequestInput.operationProcessing;
  /**
   * Auth Provider for the user to use. If it's Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI.
   */
  authProvider?: ConvertTokenRequestInput.authProvider | null;
};
export namespace ConvertTokenRequestInput {
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
