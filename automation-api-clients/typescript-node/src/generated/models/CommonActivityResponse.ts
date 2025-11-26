/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type CommonActivityResponse = {
  data: Array<{
    createdAt?: string | null;
    contract: {
      address?: string | null;
    };
    transaction: {
      timestamp?: number | null;
      from?: string | null;
      to?: string | null;
      hash?: string | null;
    };
    asset: {
      id?: string | null;
      quantity?: number | null;
    };
    order?: {
      id?: string | null;
    } | null;
    type?:
      | 'ask'
      | 'ask_cancel'
      | 'bid'
      | 'bid_cancel'
      | 'sale'
      | 'mint'
      | 'transfer'
      | null;
  }>;
  continuation?: string | null;
};
