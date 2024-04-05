/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetWebhooksForGameResponse = {
  webhooks: Array<{
    id: string;
    url: string;
    createdAt: any;
    events: 'TokenTransfers'[];
    contract: string;
    /**
     * Signature that can be used to validate whether data comes from Beam API
     */
    signature: string;
    chainId?: number;
  }>;
};
