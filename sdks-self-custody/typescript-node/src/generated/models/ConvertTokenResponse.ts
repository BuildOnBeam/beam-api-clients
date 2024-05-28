/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type ConvertTokenResponse = {
  status: ConvertTokenResponse.status;
  type: ConvertTokenResponse.type;
  transactionHash?: string;
  explorerUrl?: string;
};

export namespace ConvertTokenResponse {
  export enum status {
    PENDING = 'pending',
    SUCCESS = 'success',
  }

  export enum type {
    CUSTODIAL = 'custodial',
    SELF_CUSTODIAL = 'self-custodial',
  }
}
