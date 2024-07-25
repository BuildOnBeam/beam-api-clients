/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetOwnersResponse = {
  data: Array<{
    address?: string | null;
    quantity?: number | null;
  }>;
  pagination: {
    count: number;
    limit?: number;
    offset?: number;
  };
};
