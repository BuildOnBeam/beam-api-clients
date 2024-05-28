/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type AddPolicyRequestInput = {
  tokenAddress: string;
  amount: number;
  rateType: AddPolicyRequestInput.rateType;
  chainId?: number;
};

export namespace AddPolicyRequestInput {
  export enum rateType {
    FIXED = 'Fixed',
    DYNAMIC = 'Dynamic',
  }
}
