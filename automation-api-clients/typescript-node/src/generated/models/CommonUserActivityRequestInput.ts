/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type CommonUserActivityRequestInput = {
  limit?: number;
  types?: Array<
    'ask' | 'ask_cancel' | 'bid' | 'bid_cancel' | 'sale' | 'mint' | 'transfer'
  > | null;
  chainId?: number;
  continuation?: string | null;
};
