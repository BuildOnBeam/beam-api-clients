/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GetSessionRequestResponse = {
  status: GetSessionRequestResponse.status;
  id: string;
  createdAt: string;
  updatedAt: string | null;
  chainId: number;
  openfortId: string | null;
  address: string;
  contracts: Array<string>;
};
export namespace GetSessionRequestResponse {
  export enum status {
    PENDING = 'Pending',
    ACCEPTED = 'Accepted',
    ERROR = 'Error',
  }
}
