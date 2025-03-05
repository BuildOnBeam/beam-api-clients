/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GetOwnerAssetsBodyInput = {
  sortDirection?: GetOwnerAssetsBodyInput.sortDirection;
  sortBy?: GetOwnerAssetsBodyInput.sortBy;
  includeAttributes?: boolean | null;
  continuation?: string | null;
  chainId?: number;
  limit?: number;
};
export namespace GetOwnerAssetsBodyInput {
  export enum sortDirection {
    ASC = 'asc',
    DESC = 'desc',
  }
  export enum sortBy {
    ACQUIRED_AT = 'acquiredAt',
    LAST_APPRAISAL_VALUE = 'lastAppraisalValue',
  }
}

