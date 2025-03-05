/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type TransferAssetRequestInputV2 = {
  assets: Array<{
    receiverEntityId?: string;
    receiverWalletAddress?: string;
    assetAddress: string;
    assetId: string;
    amountToTransfer?: number;
  }>;
  optimistic?: boolean;
  sponsor?: boolean;
  policyId?: string | null;
  chainId?: number;
};
