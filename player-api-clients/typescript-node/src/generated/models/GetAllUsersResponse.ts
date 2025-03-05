/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GetAllUsersResponse = {
  data: Array<{
    id: string;
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
  }>;
  pagination: {
    count: number;
    limit?: number;
    offset?: number;
  };
};
