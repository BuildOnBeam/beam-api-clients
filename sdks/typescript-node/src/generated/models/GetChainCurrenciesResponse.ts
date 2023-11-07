/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetChainCurrenciesResponse = {
  data: Array<{
    decimals: number;
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
    tokenAddress: string;
  }>;
};
