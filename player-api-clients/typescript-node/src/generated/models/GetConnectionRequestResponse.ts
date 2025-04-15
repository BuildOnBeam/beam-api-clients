/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GetConnectionRequestResponse = {
  status: GetConnectionRequestResponse.status;
  authProvider: GetConnectionRequestResponse.authProvider;
  id: string;
  createdAt: string;
  updatedAt: string | null;
  entityId: string | null;
  gameId: string;
};
export namespace GetConnectionRequestResponse {
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
