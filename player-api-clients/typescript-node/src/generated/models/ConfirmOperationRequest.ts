/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type ConfirmOperationRequest = {
  status: ConfirmOperationRequest.status;
  actions?: Array<{
    id: string;
    signature: string;
  }> | null;
};
export namespace ConfirmOperationRequest {
  export enum status {
    PENDING = 'Pending',
    SIGNED = 'Signed',
    REJECTED = 'Rejected',
    EXECUTED = 'Executed',
    ERROR = 'Error',
  }
}
