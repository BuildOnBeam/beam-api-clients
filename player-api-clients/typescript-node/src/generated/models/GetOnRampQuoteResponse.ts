/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GetOnRampQuoteResponse = {
  quote: {
    input: {
      paymentCurrency: string;
      fiatAmount: string;
    };
    output: {
      tokenAdress: string;
      tokenAmount: string;
    };
  };
};
