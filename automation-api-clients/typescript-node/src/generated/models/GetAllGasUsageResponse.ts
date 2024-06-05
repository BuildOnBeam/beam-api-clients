/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetAllGasUsageResponse = {
  chains: Array<{
    policies: Array<{
      totalTransactionFeeInUSD: string;
      totalTransactionFee: string;
      averageTransactionFee: string;
      transactionCount: number;
      chainId?: number;
      policy: {
        id: string;
        name: string;
        model: 'ContractFunctions' | 'AccountFunctions';
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
    }>;
    summary: {
      totalTransactionFeeInUSD: string;
      totalTransactionFee: string;
      averageTransactionFee: string;
      transactionCount: number;
      chainId?: number;
      profilesCount: number;
    };
  }>;
};
