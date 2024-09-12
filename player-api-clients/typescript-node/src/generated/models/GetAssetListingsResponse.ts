/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetAssetListingsResponse = {
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
        symbol?:
          | 'BEAM'
          | 'IMX'
          | 'SOPH'
          | 'WBEAM'
          | 'WIMX'
          | 'WSOPH'
          | 'RAT'
          | 'USDC'
          | null;
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
    validFrom?: string | null;
    validUntil?: string | null;
    quantityFilled?: number;
    quantityRemaining?: number;
    expiresAt?: string | null;
    createdAt?: string | null;
    updatedAt?: string | null;
  }>;
  continuation?: string | null;
};
