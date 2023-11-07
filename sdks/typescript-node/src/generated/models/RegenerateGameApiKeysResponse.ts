/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type RegenerateGameApiKeysResponse = {
  id: string;
  createdAt: any;
  updatedAt: any;
  name: string;
  description: string | null;
  coverImageUrl: string | null;
  logoImageUrl: string | null;
  chainIds: number[];
  apiKeys: Array<{
    type: 'ReadOnly' | 'ReadAndWrite' | 'Regenerate';
    id: string;
    createdAt: any;
    updatedAt: any;
    apiKey: string;
    gameId: string;
  }>;
};
