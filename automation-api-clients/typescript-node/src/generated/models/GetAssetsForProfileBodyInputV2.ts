/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GetAssetsForProfileBodyInputV2 = {
  sortDirection?: GetAssetsForProfileBodyInputV2.sortDirection;
  sortBy?: GetAssetsForProfileBodyInputV2.sortBy;
  contract?: string | null;
  includeAttributes?: boolean | null;
  continuation?: string | null;
  chainId?: number;
  limit?: number;
};
export namespace GetAssetsForProfileBodyInputV2 {
  export enum sortDirection {
    ASC = 'asc',
    DESC = 'desc',
  }
  export enum sortBy {
    ACQUIRED_AT = 'acquiredAt',
    LAST_APPRAISAL_VALUE = 'lastAppraisalValue',
  }
}

