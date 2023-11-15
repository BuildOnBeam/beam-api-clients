/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetPoliciesResponse = {
  data: Array<{
    id: string;
    name: string;
    chainId: number;
    token: string | null;
    amount: string | null;
    model: 'ContractFunctions' | 'AccountFunctions';
    type: 'PayForUser' | 'ChargeCustomToken';
  }>;
};
