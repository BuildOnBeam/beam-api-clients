/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CommonContractActivityRequestInput = {
  limit?: number;
  types?: Array<
    'ask' | 'ask_cancel' | 'bid' | 'bid_cancel' | 'sale' | 'mint' | 'transfer'
  > | null;
  chainId?: number;
};
