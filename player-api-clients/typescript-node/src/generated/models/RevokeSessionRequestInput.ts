/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type RevokeSessionRequestInput = {
  address: string;
  sponsor?: boolean;
  policyId?: string | null;
  chainId?: number;
  operationProcessing?: RevokeSessionRequestInput.operationProcessing;
  operationId?: string | null;
};

export namespace RevokeSessionRequestInput {
  export enum operationProcessing {
    SIGN_ONLY = 'SignOnly',
    EXECUTE = 'Execute',
  }
}
