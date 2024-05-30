/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type OperationResponse = {
  status: OperationResponse.status;
  id: string;
  createdAt: string;
  updatedAt: string | null;
  gameId: string;
  userId: string;
  chainId: number;
  url: string;
  game: {
    pegiRating: OperationResponse.pegiRating | null;
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
    createdAt: any;
    updatedAt: any;
    name: string;
    description: string | null;
    coverImageUrl: string | null;
    logoImageUrl: string | null;
    backgroundImageUrl: string | null;
    chainIds: number[];
  };
  transactions: Array<{
    type: 'OpenfortTransaction' | 'OpenfortReservoirOrder';
    status: 'Pending' | 'Rejected' | 'Executed' | 'Error';
    id: string;
    externalId: string | null;
    signature: string | null;
    operationId: string | null;
    data: string | number | boolean | Record<string, any>;
  }>;
};

export namespace OperationResponse {
  export enum status {
    PENDING = 'Pending',
    REJECTED = 'Rejected',
    EXECUTED = 'Executed',
    ERROR = 'Error',
  }

  export enum pegiRating {
    THREE = 'Three',
    SEVEN = 'Seven',
    TWELVE = 'Twelve',
    SIXTEEN = 'Sixteen',
    EIGHTEEN = 'Eighteen',
  }
}
