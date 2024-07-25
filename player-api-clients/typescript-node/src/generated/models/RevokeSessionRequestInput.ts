/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type RevokeSessionRequestInput = {
  address: string;
  operationId?: string | null;
  operationProcessing?: RevokeSessionRequestInput.operationProcessing;
  chainId?: number;
};

export namespace RevokeSessionRequestInput {
  export enum operationProcessing {
    SIGN_ONLY = 'SignOnly',
    EXECUTE = 'Execute',
  }
}
