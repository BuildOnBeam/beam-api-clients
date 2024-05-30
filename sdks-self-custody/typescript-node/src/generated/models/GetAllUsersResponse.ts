/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetAllUsersResponse = {
  data: Array<{
    externalEntityId: string;
    userId: string;
    gameId: string;
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
  }>;
  pagination: {
    count: number;
    limit?: number;
    offset?: number;
  };
};
