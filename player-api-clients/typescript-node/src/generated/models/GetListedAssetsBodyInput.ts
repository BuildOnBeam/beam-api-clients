/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GetListedAssetsBodyInput = {
  assetAddresses?: Array<string> | null;
  sortBy?: GetListedAssetsBodyInput.sortBy;
  /**
   * If using `createdAt` for sorting, only `desc` is allowed.
   */
  sortDirection?: GetListedAssetsBodyInput.sortDirection;
  limit?: number;
  chainId?: number;
  continuation?: string | null;
};
export namespace GetListedAssetsBodyInput {
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
