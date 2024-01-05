/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetAssetListingsResponseV2 = {
  data: Array<{
    id: string;
    side: string;
    status?: 'active' | 'inactive' | 'expired' | 'canceled' | 'filled' | null;
    assetAddress: string;
    assetId: string;
    contractKind: string;
    maker: string;
    price?: {
      currency?: {
        address: string;
        symbol?: 'BEAM' | 'WBEAM' | 'USDC' | 'USDT' | null;
        decimals: number;
      } | null;
      amount?: {
        raw: string;
        decimal: number;
        usd: number;
        native: number;
      } | null;
      netAmount?: {
        raw: string;
        decimal: number;
        usd: number;
        native: number;
      } | null;
    } | null;
    validFrom?: any;
    validUntil?: any;
    quantityFilled?: number;
    quantityRemaining?: number;
    expiresAt?: any;
    createdAt?: any;
    updatedAt?: any;
  }>;
  continuation?: string | null;
};
