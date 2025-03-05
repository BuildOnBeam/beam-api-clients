/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GetConnectionRequestResponse = {
  status: GetConnectionRequestResponse.status;
  id: string;
  createdAt: string;
  updatedAt: string | null;
};
export namespace GetConnectionRequestResponse {
  export enum status {
    PENDING = 'Pending',
    CONNECTED = 'Connected',
    ERROR = 'Error',
  }
}

