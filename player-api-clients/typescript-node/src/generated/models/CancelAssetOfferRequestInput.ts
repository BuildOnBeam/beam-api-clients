/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CancelAssetOfferRequestInput = {
  optimistic?: boolean;
  sponsor?: boolean;
  policyId?: string | null;
  operationProcessing?: CancelAssetOfferRequestInput.operationProcessing;
  operationId?: string | null;
  chainId?: number;
};

export namespace CancelAssetOfferRequestInput {
  export enum operationProcessing {
    SIGN_ONLY = 'SignOnly',
    EXECUTE = 'Execute',
  }
}
