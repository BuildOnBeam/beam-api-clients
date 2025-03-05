/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type UpdateProfileResponse = {
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
    createdAt: string;
    updatedAt: string;
    externalId: string;
    address: string;
    chainId: number;
    profileId: string | null;
    userId: string | null;
  }>;
};

