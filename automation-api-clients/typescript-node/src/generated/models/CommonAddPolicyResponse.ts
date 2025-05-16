/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CommonAddPolicyResponse = {
  id: string;
  chainId: number;
  token: string | null;
  amount: string | null;
  rateType: CommonAddPolicyResponse.rateType | null;
  depositorId: string | null;
};

export namespace CommonAddPolicyResponse {

  export enum rateType {
    FIXED = 'Fixed',
    DYNAMIC = 'Dynamic',
  }


}

