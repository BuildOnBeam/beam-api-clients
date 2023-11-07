/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type AddContractResponse = {
  type: AddContractResponse.type;
  id: string;
  createdAt: any;
  updatedAt: any;
  externalId: string;
  address: string;
  name: string | null;
  chainId: number;
  gameId: string | null;
};

export namespace AddContractResponse {
  export enum type {
    ERC20 = 'ERC20',
    ERC721 = 'ERC721',
    ERC1155 = 'ERC1155',
    SEAPORT = 'SEAPORT',
    UNISWAPV2 = 'UNISWAPV2',
    WETH = 'WETH',
  }
}
