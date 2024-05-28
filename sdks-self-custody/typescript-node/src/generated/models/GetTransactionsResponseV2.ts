/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetTransactionsResponseV2 = {
  data: Array<{
    id: string;
    createdAt: any;
    updatedAt: any;
    chainId: number;
    intent: {
      interactions?: Array<{
        to?: string;
        value?: string;
        contract?: string;
        functionName?: string;
        functionArgs?: any[];
      }> | null;
      hash?: string | null;
    };
    /**
     * The transaction object exists if you created the transaction deterministically and contains information about the on-chain transaction
     */
    transaction?: {
      createdAt: any;
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
        topics: string[];
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
