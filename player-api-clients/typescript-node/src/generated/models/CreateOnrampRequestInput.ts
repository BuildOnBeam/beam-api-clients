/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type CreateOnrampRequestInput = {
  platform?: CreateOnrampRequestInput.platform;
  token?: CreateOnrampRequestInput.token;
  tokenAmount?: string;
  fiatAmount?: string;
  paymentCurrency?: string;
  canChangeAmount?: boolean;
  chainId?: number;
  /**
   * Auth Provider for the user to use. If it's Any, user will be able to choose his preferred login method. Useful when you want to present social login choice in your UI.
   */
  authProvider?: CreateOnrampRequestInput.authProvider | null;
};
export namespace CreateOnrampRequestInput {
  export enum platform {
    TRANSAK = 'transak',
    THIRDWEB = 'thirdweb',
  }
  export enum token {
    BEAM = 'BEAM',
    FP = 'FP',
  }
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
