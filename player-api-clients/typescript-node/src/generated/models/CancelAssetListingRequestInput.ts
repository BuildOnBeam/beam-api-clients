/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CancelAssetListingRequestInput = {
  optimistic?: boolean;
  sponsor?: boolean;
  policyId?: string | null;
  operationProcessing?: CancelAssetListingRequestInput.operationProcessing;
};

export namespace CancelAssetListingRequestInput {
  export enum operationProcessing {
    SIGN_ONLY = 'SignOnly',
    EXECUTE = 'Execute',
  }
}
