/* generated using openapi-typescript-codegen -- do no edit */
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
  operationProcessing?: ConvertTokenRequestInput.operationProcessing;
};

export namespace ConvertTokenRequestInput {
  export enum operationProcessing {
    SIGN_ONLY = 'SignOnly',
    EXECUTE = 'Execute',
  }
}
