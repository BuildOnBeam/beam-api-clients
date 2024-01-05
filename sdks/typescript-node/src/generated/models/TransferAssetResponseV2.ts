/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type TransferAssetResponseV2 = {
  status: TransferAssetResponseV2.status;
  type: TransferAssetResponseV2.type;
  payloadToSign?: string;
  transactionHash?: string;
  explorerUrl?: string;
};

export namespace TransferAssetResponseV2 {
  export enum status {
    PENDING = 'pending',
    SUCCESS = 'success',
  }

  export enum type {
    CUSTODIAL = 'custodial',
    SELF_CUSTODIAL = 'self-custodial',
  }
}
