/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CreateProfileResponse = {
  id: string;
  createdAt: string;
  updatedAt: string;
  externalId: string;
  externalEntityId: string;
  gameId: string;
  userId: string | null;
  userConnectionCreatedAt?: string | null;
  wallets: Array<{
    id: string;
    createdAt: any;
    updatedAt: any;
    externalId: string;
    address: string;
    chainId: number;
    profileId: string | null;
    userId: string | null;
  }>;
};
