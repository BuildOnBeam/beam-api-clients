/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CommonOperationResponse = {
  status: CommonOperationResponse.status;
  processing: CommonOperationResponse.processing;
  id: string;
  createdAt: string;
  updatedAt: string | null;
  gameId: string;
  userId: string;
  chainId: number;
  url: string;
  transactions: Array<{
    type:
      | 'OpenfortTransaction'
      | 'OpenfortReservoirOrder'
      | 'OpenfortRevokeSession';
    status: 'Pending' | 'Signed' | 'Rejected' | 'Executed' | 'Error';
    id: string;
    externalId: string | null;
    signature: string | null;
    transactionHash: string | null;
    operationId: string | null;
    data?: any;
    hash: string;
  }>;
};

export namespace CommonOperationResponse {
  export enum status {
    SIGNED = 'Signed',
    PENDING = 'Pending',
    REJECTED = 'Rejected',
    EXECUTED = 'Executed',
    ERROR = 'Error',
  }

  export enum processing {
    SIGN_ONLY = 'SignOnly',
    EXECUTE = 'Execute',
  }
}
