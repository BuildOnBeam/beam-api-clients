/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetListedAssetsBodyInputV2 = {
  assetAddresses?: string[] | null;
  sortBy?: GetListedAssetsBodyInputV2.sortBy;
  /**
   * If using `createdAt` for sorting, only `desc` is allowed.
   */
  sortDirection?: GetListedAssetsBodyInputV2.sortDirection;
  limit?: number;
  chainId?: number;
  continuation?: string | null;
};

export namespace GetListedAssetsBodyInputV2 {
  export enum sortBy {
    CREATED_AT = 'createdAt',
    UPDATED_AT = 'updatedAt',
    PRICE = 'price',
  }

  /**
   * If using `createdAt` for sorting, only `desc` is allowed.
   */
  export enum sortDirection {
    ASC = 'asc',
    DESC = 'desc',
  }
}
