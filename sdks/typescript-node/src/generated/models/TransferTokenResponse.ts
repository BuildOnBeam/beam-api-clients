/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type TransferTokenResponse = {
  status: TransferTokenResponse.status;
  type: TransferTokenResponse.type;
  payloadToSign?: string;
  transactionHash?: string;
  explorerUrl?: string;
};

export namespace TransferTokenResponse {
  export enum status {
    PENDING = 'pending',
    SUCCESS = 'success',
  }

  export enum type {
    CUSTODIAL = 'custodial',
    SELF_CUSTODIAL = 'self-custodial',
  }
}
