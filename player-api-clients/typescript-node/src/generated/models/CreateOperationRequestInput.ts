/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CreateOperationRequestInput = {
  entityId: string;
  transactions: Array<{
    data?: any;
    type:
      | 'OpenfortTransaction'
      | 'OpenfortReservoirOrder'
      | 'OpenfortRevokeSession';
  }> | null;
  chainId?: number;
  operationProcessing?: CreateOperationRequestInput.operationProcessing;
  operationId?: string | null;
};

export namespace CreateOperationRequestInput {
  export enum operationProcessing {
    SIGN_ONLY = 'SignOnly',
    EXECUTE = 'Execute',
  }
}
