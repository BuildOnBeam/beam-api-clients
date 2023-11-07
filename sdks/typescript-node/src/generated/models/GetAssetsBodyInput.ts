/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetAssetsBodyInput = {
  filter?: {
    attributes?: Array<{
      type?: string | null;
      value?: string | null;
    }> | null;
    sellTypes?: Array<
      'AscendingAuction' | 'DescendingAuction' | 'FixedPrice' | 'NotForSale'
    > | null;
  };
  sort?: {
    rarityScore?: GetAssetsBodyInput.rarityScore | null;
    start?: GetAssetsBodyInput.start | null;
    end?: GetAssetsBodyInput.end | null;
    createdAt?: GetAssetsBodyInput.createdAt | null;
    fixedPriceNumber?: GetAssetsBodyInput.fixedPriceNumber | null;
    startPriceNumber?: GetAssetsBodyInput.startPriceNumber | null;
    endPriceNumber?: GetAssetsBodyInput.endPriceNumber | null;
  };
  limit: any;
  offset: string;
};

export namespace GetAssetsBodyInput {
  export enum rarityScore {
    ASC = 'ASC',
    DESC = 'DESC',
  }

  export enum start {
    ASC = 'ASC',
    DESC = 'DESC',
  }

  export enum end {
    ASC = 'ASC',
    DESC = 'DESC',
  }

  export enum createdAt {
    ASC = 'ASC',
    DESC = 'DESC',
  }

  export enum fixedPriceNumber {
    ASC = 'ASC',
    DESC = 'DESC',
  }

  export enum startPriceNumber {
    ASC = 'ASC',
    DESC = 'DESC',
  }

  export enum endPriceNumber {
    ASC = 'ASC',
    DESC = 'DESC',
  }
}
