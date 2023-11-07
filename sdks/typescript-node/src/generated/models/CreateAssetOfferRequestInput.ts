/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CreateAssetOfferRequestInput = {
  marketplaceId: string;
  quantity: number;
  price: string;
  startTime?: string;
  endTime?: string;
  currency?: CreateAssetOfferRequestInput.currency;
  chainId?: number;
};

export namespace CreateAssetOfferRequestInput {
  export enum currency {
    AVAX = 'Avax',
    BEAM = 'Beam',
    ETH = 'Eth',
    MATIC = 'Matic',
    MC = 'Mc',
    USDC = 'Usdc',
    USDT = 'Usdt',
    WAVAX = 'Wavax',
    WBEAM = 'Wbeam',
    WETH = 'Weth',
    WMATIC = 'Wmatic',
    WMC = 'Wmc',
  }
}
