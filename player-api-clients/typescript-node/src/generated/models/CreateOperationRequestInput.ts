/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CreateOperationRequestInput = {
  entityId: string;
  actions?:
    | ({
        type:
          | 'Sign'
          | 'SessionRevoke'
          | 'MarketplaceCreateOffer'
          | 'MarketplaceCancelOffer'
          | 'MarketplaceAcceptOffer'
          | 'MarketplaceBuyAsset'
          | 'MarketplaceListAsset'
          | 'MarketplaceCancelListing'
          | 'ExchangeConvert'
          | 'ExchangeWrap'
          | 'ExchangeUnwrap'
          | 'TransferNFTs'
          | 'TransferToken'
          | 'CustomTransaction';
      } & (
        | {
            type: 'TransferNFTs';
            signature: {
              type: 'Message';
              data: string;
            };
            transaction: {
              openfortId?: string | null;
              sponsored: boolean;
            };
            context: {
              assets: Array<{
                receiverAddress: string;
                contractAddress: string;
                assetId: string;
                amount: number;
              }>;
            };
          }
        | {
            type: 'TransferToken';
            signature: {
              type: 'Message';
              data: string;
            };
            transaction: {
              openfortId?: string | null;
              sponsored: boolean;
            };
            context: {
              amount: string;
              contractAddress: string;
              receiverAddress: string;
            };
          }
        | {
            type: 'MarketplaceCreateOffer';
            signature: {
              type: 'TypedData';
              data?: any;
            };
          }
        | {
            type: 'MarketplaceCancelOffer';
            signature: {
              type: 'Message';
              data: string;
            };
            transaction: {
              openfortId?: string | null;
              sponsored: boolean;
            };
          }
        | {
            type: 'MarketplaceAcceptOffer';
            signature: {
              type: 'Message';
              data: string;
            };
            transaction: {
              openfortId?: string | null;
              sponsored: boolean;
            };
          }
        | {
            type: 'MarketplaceListAsset';
            signature: {
              type: 'TypedData';
              data?: any;
            };
          }
        | {
            type: 'MarketplaceBuyAsset';
            signature: {
              type: 'Message';
              data: string;
            };
            transaction: {
              openfortId?: string | null;
              sponsored: boolean;
            };
          }
        | {
            type: 'MarketplaceCancelListing';
            signature: {
              type: 'Message';
              data: string;
            };
            transaction: {
              openfortId?: string | null;
              sponsored: boolean;
            };
          }
        | {
            type: 'SessionRevoke';
            signature: {
              type: 'Message';
              data: string;
            };
            transaction: {
              openfortId?: string | null;
              sponsored: boolean;
            };
          }
        | {
            type: 'ExchangeConvert';
            context: {
              input: {
                address: string;
                amount: string;
              };
              output: {
                address: string;
                amount: string;
              };
            };
            signature: {
              type: 'Message';
              data: string;
            };
            transaction: {
              openfortId?: string | null;
              sponsored: boolean;
            };
          }
        | {
            type: 'ExchangeWrap';
            context: {
              amount: string;
            };
            signature: {
              type: 'Message';
              data: string;
            };
            transaction: {
              openfortId?: string | null;
              sponsored: boolean;
            };
          }
        | {
            type: 'ExchangeUnwrap';
            context: {
              amount: string;
            };
            signature: {
              type: 'Message';
              data: string;
            };
            transaction: {
              openfortId?: string | null;
              sponsored: boolean;
            };
          }
        | {
            type: 'CustomTransaction';
            signature:
              | {
                  type: 'Message';
                  data: string;
                }
              | {
                  type: 'TypedData';
                  data?: any;
                };
            transaction: {
              openfortId?: string | null;
              sponsored: boolean;
            };
          }
        | {
            type: 'Sign';
            signature:
              | {
                  type: 'Message';
                  data: string;
                }
              | {
                  type: 'TypedData';
                  data?: any;
                };
          }
      ))[]
    | null;
  transactions?: Array<{
    data?: any;
    type:
      | 'OpenfortTransaction'
      | 'OpenfortReservoirOrder'
      | 'OpenfortRevokeSession';
  }> | null;
  chainId?: number;
  operationProcessing?: CreateOperationRequestInput.operationProcessing;
  operationId?: string | null;
};

export namespace CreateOperationRequestInput {
  export enum operationProcessing {
    SIGN_ONLY = 'SignOnly',
    EXECUTE = 'Execute',
  }
}
