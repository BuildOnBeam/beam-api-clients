/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type CreateConnectionRequestResponse = {
  status: CreateConnectionRequestResponse.status;
  id: string;
  createdAt: string;
  updatedAt: string | null;
  url: string;
};
export namespace CreateConnectionRequestResponse {
  export enum status {
    PENDING = 'Pending',
    CONNECTED = 'Connected',
    ERROR = 'Error',
  }
}
