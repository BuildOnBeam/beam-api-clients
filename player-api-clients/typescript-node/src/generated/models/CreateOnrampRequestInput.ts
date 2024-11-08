/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CreateOnrampRequestInput = {
  token?: CreateOnrampRequestInput.token;
  tokenAmount?: string;
  fiatAmount?: string;
  paymentCurrency?: CreateOnrampRequestInput.paymentCurrency;
  chainId?: number;
};

export namespace CreateOnrampRequestInput {
  export enum token {
    BEAM = 'BEAM',
  }

  export enum paymentCurrency {
    USD = 'USD',
    EUR = 'EUR',
  }
}
