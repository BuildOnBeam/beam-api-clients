/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type UpdateGameRequestInput = {
  name?: string;
  description?: string | null;
  coverImageUrl?: string | null;
  logoImageUrl?: string | null;
  pegiRating?: UpdateGameRequestInput.pegiRating | null;
  pegiContent?: Array<
    | 'BadLanguage'
    | 'Discrimination'
    | 'Drugs'
    | 'Fear'
    | 'Gambling'
    | 'Sex'
    | 'Violence'
    | 'InGamePurchases'
  >;
};

export namespace UpdateGameRequestInput {
  export enum pegiRating {
    THREE = 'Three',
    SEVEN = 'Seven',
    TWELVE = 'Twelve',
    SIXTEEN = 'Sixteen',
    EIGHTEEN = 'Eighteen',
  }
}
