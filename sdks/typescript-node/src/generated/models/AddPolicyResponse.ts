/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type AddPolicyResponse = {
  id: string;
  chainId: number;
  token: string | null;
  amount: string | null;
  rateType: AddPolicyResponse.rateType | null;
};

export namespace AddPolicyResponse {
  export enum rateType {
    FIXED = 'Fixed',
    DYNAMIC = 'Dynamic',
  }
}
