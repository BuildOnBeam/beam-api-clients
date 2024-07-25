/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CommonAddPolicyRequestInput = {
  tokenAddress: string;
  amount: number;
  rateType: CommonAddPolicyRequestInput.rateType;
  chainId?: number;
};

export namespace CommonAddPolicyRequestInput {
  export enum rateType {
    FIXED = 'Fixed',
    DYNAMIC = 'Dynamic',
  }
}
