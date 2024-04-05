/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type RegenerateGameApiKeysResponse = {
  pegiRating: RegenerateGameApiKeysResponse.pegiRating | null;
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
  apiKeys: Array<{
    type: 'ReadOnly' | 'ReadAndWrite' | 'Regenerate' | 'Publishable';
    id: string;
    createdAt: any;
    updatedAt: any;
    apiKey: string;
    gameId: string;
  }>;
};

export namespace RegenerateGameApiKeysResponse {
  export enum pegiRating {
    THREE = 'Three',
    SEVEN = 'Seven',
    TWELVE = 'Twelve',
    SIXTEEN = 'Sixteen',
    EIGHTEEN = 'Eighteen',
  }
}
