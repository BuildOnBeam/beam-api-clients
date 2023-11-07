/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetAssetOffersResponse = {
  data: Array<{
    orderId: string;
    kind: 'SignedCollectionOrder' | 'SignedSingleOrder';
    currency:
      | 'Avax'
      | 'Beam'
      | 'Eth'
      | 'Matic'
      | 'Mc'
      | 'Usdc'
      | 'Usdt'
      | 'Wavax'
      | 'Wbeam'
      | 'Weth'
      | 'Wmatic'
      | 'Wmc';
    quantity: number;
    quantityFilled: number;
    quantityAvailable: number;
    offerer: string;
    offererEntityId: string;
    tokenAmount: string;
    tokenAmountNumber: number;
    startTime: string;
    endTime: string;
  }>;
};
