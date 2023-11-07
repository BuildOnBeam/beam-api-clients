/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type TransferAssetRequestInput = {
  assets: Array<{
    receiverEntityId?: string;
    receiverWalletAddress?: string;
    assetAddress: string;
    assetId: string;
    amountToTransfer?: number;
  }>;
  optimistic?: boolean;
  sponsor?: boolean;
  policyId?: string;
  chainId?: number;
};
