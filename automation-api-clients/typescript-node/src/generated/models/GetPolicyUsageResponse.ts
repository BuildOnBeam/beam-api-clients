/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetPolicyUsageResponse = {
  totalTransactionFeeInUSD: string;
  totalTransactionFee: string;
  averageTransactionFee: string;
  transactionCount: number;
  chainId?: number;
  policy: {
    id: string;
    name: string;
    model: GetPolicyUsageResponse.model;
    chainId: number;
  };
  periods: Array<{
    totalTransactionFeeInUSD: string;
    totalTransactionFee: string;
    averageTransactionFee: string;
    transactionCount: number;
    start: number;
    end: number;
  }>;
};

export namespace GetPolicyUsageResponse {

  export enum model {
    CONTRACT_FUNCTIONS = 'ContractFunctions',
    ACCOUNT_FUNCTIONS = 'AccountFunctions',
  }


}

