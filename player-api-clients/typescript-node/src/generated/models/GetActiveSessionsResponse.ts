/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GetActiveSessionsResponse = {
  sessions: Array<{
    id: string;
    isActive: boolean;
    startTime: string;
    endTime: string;
    sessionAddress: string;
  }>;
};
