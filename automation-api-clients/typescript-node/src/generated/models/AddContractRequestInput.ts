/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type AddContractRequestInput = {
  address: string;
  type: AddContractRequestInput.type;
  chainId: number;
  name: string;
};

export namespace AddContractRequestInput {
  export enum type {
    ERC20 = 'ERC20',
    ERC721 = 'ERC721',
    ERC1155 = 'ERC1155',
    SEAPORT = 'SEAPORT',
    UNISWAPV2 = 'UNISWAPV2',
    WETH = 'WETH',
  }
}
