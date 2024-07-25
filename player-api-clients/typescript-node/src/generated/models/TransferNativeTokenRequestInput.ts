/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type TransferNativeTokenRequestInput = {
  receiverEntityId?: string;
  receiverWalletAddress?: string;
  amountToTransfer: string;
  optimistic?: boolean;
  sponsor?: boolean;
  policyId?: string | null;
  chainId?: number;
  operationProcessing?: TransferNativeTokenRequestInput.operationProcessing;
  operationId?: string | null;
};

export namespace TransferNativeTokenRequestInput {
  export enum operationProcessing {
    SIGN_ONLY = 'SignOnly',
    EXECUTE = 'Execute',
  }
}
