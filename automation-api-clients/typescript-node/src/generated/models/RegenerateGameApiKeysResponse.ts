/* generated using openapi-typescript-codegen -- do not edit */
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
  backgroundImageUrl: string | null;
  androidCallbackDeepLink: string | null;
  connectionsWebhookUrl: string | null;
  eventTrackingUrl: string | null;
  chainIds: Array<number>;
  apiKeys: Array<{
    type: 'Regenerate' | 'Publishable' | 'Secret';
    id: string;
    createdAt: string;
    updatedAt: string;
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
