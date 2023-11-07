/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type TransferAssetResponse = {
  status: TransferAssetResponse.status;
  type: TransferAssetResponse.type;
  payloadToSign?: string;
  transactionHash?: string;
  explorerUrl?: string;
};

export namespace TransferAssetResponse {
  export enum status {
    PENDING = 'pending',
    SUCCESS = 'success',
  }

  export enum type {
    CUSTODIAL = 'custodial',
    SELF_CUSTODIAL = 'self-custodial',
  }
}
