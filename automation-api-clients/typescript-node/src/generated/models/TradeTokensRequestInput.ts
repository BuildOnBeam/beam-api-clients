/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type TradeTokensRequestInput = {
  initiator: {
    entityId: string;
    tokens: Array<{
      assetAddress: string;
      amount: string;
      tokenId?: string;
    }>;
  };
  counterparty: {
    entityId: string;
    tokens: Array<{
      assetAddress: string;
      amount: string;
      tokenId?: string;
    }>;
  };
  sponsor?: boolean;
  policyId?: string | null;
  chainId?: number;
};

