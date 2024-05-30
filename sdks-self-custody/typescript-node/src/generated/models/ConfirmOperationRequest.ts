/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type ConfirmOperationRequest = {
  status: ConfirmOperationRequest.status;
  transactions?: Array<{
    id: string;
    signature: string;
  }> | null;
  error?: string | null;
  entityId: string;
  gameId: string;
};

export namespace ConfirmOperationRequest {
  export enum status {
    PENDING = 'Pending',
    REJECTED = 'Rejected',
    EXECUTED = 'Executed',
    ERROR = 'Error',
  }
}
