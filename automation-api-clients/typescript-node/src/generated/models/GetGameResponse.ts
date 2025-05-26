/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GetGameResponse = {
  pegiRating: GetGameResponse.pegiRating | null;
  pegiContent: Array<
    | 'BadLanguage'
    | 'Discrimination'
    | 'Drugs'
    | 'Fear'
    | 'Gambling'
    | 'Sex'
    | 'Violence'
    | 'InGamePurchases'
  >;
  id: string;
  createdAt: string;
  updatedAt: string;
  name: string;
  description: string | null;
  coverImageUrl: string | null;
  logoImageUrl: string | null;
  backgroundImageUrl: string | null;
  androidCallbackDeepLink: string | null;
  connectionsWebhookUrl: string | null;
  eventTrackingUrl: string | null;
  chainIds: Array<number>;
  depositor?: {
    id: string;
    createdAt: string;
    updatedAt: string;
    externalId: string;
    address: string;
    gameId: string;
  } | null;
  developers: Array<{
    role: 'Owner' | 'Admin' | 'Viewer' | null;
    id: string;
    developerId: string;
    gameId: string;
    developer: {
      id: string;
      name: string | null;
      email: string;
      createdAt: string;
      lastSeenAt: string | null;
      supabaseId: string | null;
    };
  }>;
  contracts: Array<{
    type: 'ERC20' | 'ERC721' | 'ERC1155' | 'CUSTOM' | 'SEAPORT' | 'UNISWAPV2';
    id: string;
    createdAt: string;
    updatedAt: string;
    externalId: string;
    address: string;
    name: string | null;
    chainId: number;
    gameId: string | null;
    abi: any;
    hasCustomAbi: boolean;
  }>;
  policies: Array<{
    model: 'ContractFunctions' | 'AccountFunctions';
    type: 'PayForUser' | 'ChargeCustomToken';
    rateType?: 'Fixed' | 'Dynamic' | null;
    id: string;
    createdAt: string;
    updatedAt: string;
    externalId: string;
    name: string;
    chainId: number;
    paymasterId: string | null;
    gameId: string;
    token: string | null;
    amount: string | null;
    depositorId: string | null;
  }>;
};
export namespace GetGameResponse {
  export enum pegiRating {
    THREE = 'Three',
    SEVEN = 'Seven',
    TWELVE = 'Twelve',
    SIXTEEN = 'Sixteen',
    EIGHTEEN = 'Eighteen',
  }
}
