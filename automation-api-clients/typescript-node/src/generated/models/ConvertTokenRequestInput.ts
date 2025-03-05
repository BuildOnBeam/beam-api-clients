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
};
