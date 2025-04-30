/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type GameContractsResponse = {
  type: GameContractsResponse.type;
  address: string;
  chainId: number;
  name: string | null;
  abi?: any;
  hasCustomAbi: boolean;
  createdAt: string;
  updatedAt: string;
};
export namespace GameContractsResponse {
  export enum type {
    ERC20 = 'ERC20',
    ERC721 = 'ERC721',
    ERC1155 = 'ERC1155',
    CUSTOM = 'CUSTOM',
    SEAPORT = 'SEAPORT',
    UNISWAPV2 = 'UNISWAPV2',
  }
}
