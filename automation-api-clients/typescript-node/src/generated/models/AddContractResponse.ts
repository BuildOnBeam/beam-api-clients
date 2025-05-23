/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type AddContractResponse = {
  type: AddContractResponse.type;
  id: string;
  createdAt: string;
  updatedAt: string;
  externalId: string;
  address: string;
  name: string | null;
  chainId: number;
  gameId: string | null;
  abi: any;
  hasCustomAbi: boolean;
};
export namespace AddContractResponse {
  export enum type {
    ERC20 = 'ERC20',
    ERC721 = 'ERC721',
    ERC1155 = 'ERC1155',
    CUSTOM = 'CUSTOM',
    SEAPORT = 'SEAPORT',
    UNISWAPV2 = 'UNISWAPV2',
  }
}
