/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GetAttributesResponse = {
  data: Array<{
    key: string;
    kind: 'string' | 'number' | 'date' | 'range';
    values?: Array<{
      count?: number | null;
      value: string;
    }> | null;
  }>;
};
