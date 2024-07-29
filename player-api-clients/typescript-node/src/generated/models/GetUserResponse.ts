/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetUserResponse = {
  externalEntityId: string;
  userId: string;
  gameId: string;
  wallets: Array<{
    id: string;
    createdAt: string;
    updatedAt: string;
    externalId: string;
    address: string;
    chainId: number;
    profileId: string | null;
    userId: string | null;
  }>;
  entities: Array<{
    entityId: string;
  }>;
};
