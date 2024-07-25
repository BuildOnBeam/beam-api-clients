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
};

export namespace ConfirmOperationRequest {
  export enum status {
    SIGNED = 'Signed',
    PENDING = 'Pending',
    REJECTED = 'Rejected',
    EXECUTED = 'Executed',
    ERROR = 'Error',
  }
}
