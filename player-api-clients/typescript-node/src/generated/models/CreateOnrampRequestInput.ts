/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CreateOnrampRequestInput = {
  token?: CreateOnrampRequestInput.token;
  tokenAmount?: string;
  fiatAmount?: string;
  paymentCurrency?: string;
  canChangeAmount?: boolean;
  chainId?: number;
};

export namespace CreateOnrampRequestInput {
  export enum token {
    BEAM = 'BEAM',
  }
}
