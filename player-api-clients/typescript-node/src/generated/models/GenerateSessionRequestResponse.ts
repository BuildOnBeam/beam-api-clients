/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GenerateSessionRequestResponse = {
  status: GenerateSessionRequestResponse.status;
  id: string;
  createdAt: string;
  updatedAt: string | null;
  chainId: number;
  openfortId: string | null;
  address: string;
  url: string;
};
export namespace GenerateSessionRequestResponse {
  export enum status {
    PENDING = 'Pending',
    ACCEPTED = 'Accepted',
    ERROR = 'Error',
  }
}
