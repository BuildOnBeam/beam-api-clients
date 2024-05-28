/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetPoliciesResponse = {
  data: Array<{
    id: string;
    rateType: 'Fixed' | 'Dynamic' | null;
    amount: string | null;
    token: string | null;
    depositorId: string | null;
  }>;
};
