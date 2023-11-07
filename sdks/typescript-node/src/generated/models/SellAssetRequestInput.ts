/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type SellAssetRequestInput = {
  marketplaceId: string;
  quantity: number;
  price: string;
  startTime?: string;
  endTime?: string;
  sellType: SellAssetRequestInput.sellType;
  currency?: SellAssetRequestInput.currency;
  sponsor?: boolean;
  policyId?: string;
  chainId?: number;
};

export namespace SellAssetRequestInput {
  export enum sellType {
    FIXED_PRICE = 'FixedPrice',
    DESCENDING_AUCTION = 'DescendingAuction',
    ASCENDING_AUCTION = 'AscendingAuction',
    NOT_FOR_SALE = 'NotForSale',
  }

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
