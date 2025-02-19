/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GenerateSessionUrlRequestInput = {
  address: string;
  suggestedExpiry?: string | null;
  /**
   * Auth Provider for the user to use. If it's Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI.
   */
  authProvider?: GenerateSessionUrlRequestInput.authProvider | null;
  chainId?: number;
};

export namespace GenerateSessionUrlRequestInput {
  /**
   * Auth Provider for the user to use. If it's Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI.
   */
  export enum authProvider {
    ANY = 'Any',
    GOOGLE = 'Google',
    DISCORD = 'Discord',
    APPLE = 'Apple',
  }
}
