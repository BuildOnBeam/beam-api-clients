/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type UpdateGameResponse = {
  pegiRating: UpdateGameResponse.pegiRating | null;
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
  chainIds: number[];
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
  }>;
  policies: Array<{
    model: 'ContractFunctions' | 'AccountFunctions';
    type: 'PayForUser' | 'ChargeCustomToken';
    rateType: 'Fixed' | 'Dynamic' | null;
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

export namespace UpdateGameResponse {
  export enum pegiRating {
    THREE = 'Three',
    SEVEN = 'Seven',
    TWELVE = 'Twelve',
    SIXTEEN = 'Sixteen',
    EIGHTEEN = 'Eighteen',
  }
}
