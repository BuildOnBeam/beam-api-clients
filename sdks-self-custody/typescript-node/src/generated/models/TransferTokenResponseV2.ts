/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type TransferTokenResponseV2 = {
  status: TransferTokenResponseV2.status;
  type: TransferTokenResponseV2.type;
  payloadToSign?: string;
  transactionHash?: string;
  explorerUrl?: string;
};

export namespace TransferTokenResponseV2 {
  export enum status {
    PENDING = 'pending',
    SUCCESS = 'success',
  }

  export enum type {
    CUSTODIAL = 'custodial',
    SELF_CUSTODIAL = 'self-custodial',
  }
}
