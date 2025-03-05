/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GetTransactionsResponseV2 = {
  data: Array<{
    id: string;
    createdAt: string;
    updatedAt: string;
    chainId: number;
    intent: {
      interactions?: Array<{
        to?: string;
        value?: string;
        contract?: string;
        functionName?: string;
        functionArgs?: Array<any>;
      }> | null;
      hash?: string | null;
    };
    /**
     * The transaction object exists if you created the transaction deterministically and contains information about the on-chain transaction
     */
    transaction?: {
      createdAt: string;
      blockNumber?: number;
      hash?: string;
      gasUsed?: string;
      gasFee?: string;
      status?: number;
      logs?: Array<{
        blockNumber: number;
        blockHash: string;
        transactionIndex: number;
        removed: boolean;
        address: string;
        data: string;
        topics: Array<string>;
        transactionHash: string;
        logIndex: number;
        orphaned?: boolean | null;
      }>;
    } | null;
  }>;
  pagination: {
    count: number;
    limit?: number;
    offset?: number;
  };
};

