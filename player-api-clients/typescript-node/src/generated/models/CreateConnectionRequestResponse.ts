/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type CreateConnectionRequestResponse = {
  status: CreateConnectionRequestResponse.status;
  authProvider: CreateConnectionRequestResponse.authProvider;
  id: string;
  createdAt: string;
  updatedAt: string | null;
  entityId: string | null;
  gameId: string;
  url: string;
};
export namespace CreateConnectionRequestResponse {
  export enum status {
    PENDING = 'Pending',
    CONNECTED = 'Connected',
    ERROR = 'Error',
  }
  export enum authProvider {
    ANY = 'Any',
    GOOGLE = 'Google',
    DISCORD = 'Discord',
    APPLE = 'Apple',
  }
}
