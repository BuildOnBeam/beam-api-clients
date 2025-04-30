/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type AddContractRequestInput = {
  address: string;
  chainId: number;
  name: string;
  /**
   * The ABI of the contract. If not provided, one will be taken from Block Explorer Verification Source.
   */
  abi?: any;
};
