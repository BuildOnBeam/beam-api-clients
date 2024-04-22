/* generated using openapi-typescript-codegen -- do no edit */
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
  backgroundImageUrl: string | null;
  logoImageUrl: string | null;
  chainIds: number[];
  depositor?: {
    id: string;
    createdAt: any;
    updatedAt: any;
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
      createdAt: any;
      lastSeenAt: any;
      externalId: string | null;
    };
  }>;
  contracts: Array<{
    type: 'ERC20' | 'ERC721' | 'ERC1155' | 'SEAPORT' | 'UNISWAPV2' | 'WETH';
    id: string;
    createdAt: any;
    updatedAt: any;
    externalId: string;
    address: string;
    name: string | null;
    chainId: number;
    gameId: string | null;
    abi: string | number | boolean | Record<string, any>;
  }>;
  policies: Array<{
    model: 'ContractFunctions' | 'AccountFunctions';
    type: 'PayForUser' | 'ChargeCustomToken';
    rateType?: 'Fixed' | 'Dynamic' | null;
    id: string;
    createdAt: any;
    updatedAt: any;
    externalId: string;
    name: string;
    chainId: number;
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
