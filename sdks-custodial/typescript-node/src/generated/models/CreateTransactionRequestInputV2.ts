/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CreateTransactionRequestInputV2 = {
  interactions: Array<{
    contractAddress: string;
    functionName: string;
    functionArgs?: any[];
    value?: string;
  }>;
  optimistic?: boolean;
  sponsor?: boolean;
  policyId?: string | null;
  chainId?: number;
};
