/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type AcceptAssetOfferRequestInput = {
  quantity: number;
  optimistic?: boolean;
  sponsor?: boolean;
  policyId?: string | null;
  chainId?: number;
  operationProcessing?: AcceptAssetOfferRequestInput.operationProcessing;
  operationId?: string | null;
};

export namespace AcceptAssetOfferRequestInput {
  export enum operationProcessing {
    SIGN_ONLY = 'SignOnly',
    EXECUTE = 'Execute',
  }
}
