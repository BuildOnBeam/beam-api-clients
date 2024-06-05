/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CommonOperationResponse = {
  status: CommonOperationResponse.status;
  id: string;
  createdAt: string;
  updatedAt: string | null;
  gameId: string;
  userId: string;
  chainId: number;
  url: string;
  transactions: Array<{
    type: 'OpenfortTransaction' | 'OpenfortReservoirOrder';
    status: 'Pending' | 'Rejected' | 'Executed' | 'Error';
    id: string;
    externalId: string | null;
    signature: string | null;
    operationId: string | null;
    data?: (string | number | boolean | Record<string, any>) | null;
    hash: string;
  }>;
};

export namespace CommonOperationResponse {
  export enum status {
    PENDING = 'Pending',
    REJECTED = 'Rejected',
    EXECUTED = 'Executed',
    ERROR = 'Error',
  }
}
