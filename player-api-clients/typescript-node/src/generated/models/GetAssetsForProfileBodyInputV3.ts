/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetAssetsForProfileBodyInputV3 = {
  sortDirection?: GetAssetsForProfileBodyInputV3.sortDirection;
  sortBy?: GetAssetsForProfileBodyInputV3.sortBy;
  contract?: string | null;
  includeAttributes?: boolean | null;
  continuation?: string | null;
  chainId?: number;
  limit?: number;
};

export namespace GetAssetsForProfileBodyInputV3 {
  export enum sortDirection {
    ASC = 'asc',
    DESC = 'desc',
  }

  export enum sortBy {
    ACQUIRED_AT = 'acquiredAt',
    LAST_APPRAISAL_VALUE = 'lastAppraisalValue',
  }
}
