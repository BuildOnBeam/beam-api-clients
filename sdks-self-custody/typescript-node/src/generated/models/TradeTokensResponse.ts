/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type TradeTokensResponse = {
  status: TradeTokensResponse.status;
  type: TradeTokensResponse.type;
  transactionHash?: string;
  explorerUrl?: string;
};

export namespace TradeTokensResponse {
  export enum status {
    PENDING = 'pending',
    SUCCESS = 'success',
  }

  export enum type {
    CUSTODIAL = 'custodial',
    SELF_CUSTODIAL = 'self-custodial',
  }
}
