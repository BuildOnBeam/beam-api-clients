/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type CommonOperationResponse = {
  status: CommonOperationResponse.status;
  processing: CommonOperationResponse.processing;
  id: string;
  createdAt: string;
  updatedAt: string | null;
  gameId: string;
  userId: string;
  chainId: number;
  actions: ({
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
    id: string;
    index: number;
    operationId: string | null;
  } & (
    | {
        type: 'TransferNFTs';
        context: {
          assets: Array<{
            receiverAddress: string;
            contractAddress: string;
            assetId: string;
            amount: number;
          }>;
        };
        signature: {
          type: 'Message';
          id: string;
          data: string;
          signature: string | null;
          actionId: string | null;
        } & {
          hash: string;
        };
        transaction: {
          status: 'Pending' | 'Signed' | 'Rejected' | 'Executed' | 'Error';
          id: string;
          openfortId: string | null;
          sponsored: boolean;
          actionId: string | null;
          hash: string | null;
        };
      }
    | {
        type: 'TransferToken';
        context: {
          amount: string;
          contractAddress: string;
          receiverAddress: string;
        };
        signature: {
          type: 'Message';
          id: string;
          data: string;
          signature: string | null;
          actionId: string | null;
        } & {
          hash: string;
        };
        transaction: {
          status: 'Pending' | 'Signed' | 'Rejected' | 'Executed' | 'Error';
          id: string;
          openfortId: string | null;
          sponsored: boolean;
          actionId: string | null;
          hash: string | null;
        };
      }
    | {
        type: 'MarketplaceCreateOffer';
        signature: {
          type: 'TypedData';
          id: string;
          data?: any;
          signature: string | null;
          actionId: string | null;
        } & {
          hash: string;
        };
        transaction: {
          status: 'Pending' | 'Signed' | 'Rejected' | 'Executed' | 'Error';
          id: string;
          openfortId: string | null;
          sponsored: boolean;
          actionId: string | null;
          hash: string | null;
        };
        context: {
          currencyAmount: string;
          currencyAddress: string;
          assetId: string;
          assetAddress: string;
        };
      }
    | {
        type: 'MarketplaceCancelOffer';
        signature: {
          type: 'Message';
          id: string;
          data: string;
          signature: string | null;
          actionId: string | null;
        } & {
          hash: string;
        };
        transaction: {
          status: 'Pending' | 'Signed' | 'Rejected' | 'Executed' | 'Error';
          id: string;
          openfortId: string | null;
          sponsored: boolean;
          actionId: string | null;
          hash: string | null;
        };
        context: {
          offerId: string;
        };
      }
    | {
        type: 'MarketplaceAcceptOffer';
        signature: {
          type: 'Message';
          id: string;
          data: string;
          signature: string | null;
          actionId: string | null;
        } & {
          hash: string;
        };
        transaction: {
          status: 'Pending' | 'Signed' | 'Rejected' | 'Executed' | 'Error';
          id: string;
          openfortId: string | null;
          sponsored: boolean;
          actionId: string | null;
          hash: string | null;
        };
        context: {
          offerId: string;
        };
      }
    | {
        type: 'MarketplaceListAsset';
        context: {
          assetAddress: string;
          assetId: string;
          currencyAddress: string;
          currencyAmount: string;
        };
        signature: {
          type: 'TypedData';
          id: string;
          data?: any;
          signature: string | null;
          actionId: string | null;
        } & {
          hash: string;
        };
      }
    | {
        type: 'MarketplaceBuyAsset';
        signature: {
          type: 'Message';
          id: string;
          data: string;
          signature: string | null;
          actionId: string | null;
        } & {
          hash: string;
        };
        transaction: {
          status: 'Pending' | 'Signed' | 'Rejected' | 'Executed' | 'Error';
          id: string;
          openfortId: string | null;
          sponsored: boolean;
          actionId: string | null;
          hash: string | null;
        };
        context: {
          orderId: string;
        };
      }
    | {
        type: 'MarketplaceCancelListing';
        signature: {
          type: 'Message';
          id: string;
          data: string;
          signature: string | null;
          actionId: string | null;
        } & {
          hash: string;
        };
        transaction: {
          status: 'Pending' | 'Signed' | 'Rejected' | 'Executed' | 'Error';
          id: string;
          openfortId: string | null;
          sponsored: boolean;
          actionId: string | null;
          hash: string | null;
        };
        context: {
          orderId: string;
        };
      }
    | {
        type: 'SessionRevoke';
        signature: {
          type: 'Message';
          id: string;
          data: string;
          signature: string | null;
          actionId: string | null;
        } & {
          hash: string;
        };
        transaction: {
          status: 'Pending' | 'Signed' | 'Rejected' | 'Executed' | 'Error';
          id: string;
          openfortId: string | null;
          sponsored: boolean;
          actionId: string | null;
          hash: string | null;
        };
        context: {
          sessionAddress: string;
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
          id: string;
          data: string;
          signature: string | null;
          actionId: string | null;
        } & {
          hash: string;
        };
        transaction: {
          status: 'Pending' | 'Signed' | 'Rejected' | 'Executed' | 'Error';
          id: string;
          openfortId: string | null;
          sponsored: boolean;
          actionId: string | null;
          hash: string | null;
        };
      }
    | {
        type: 'ExchangeWrap';
        context: {
          amount: string;
        };
        signature: {
          type: 'Message';
          id: string;
          data: string;
          signature: string | null;
          actionId: string | null;
        } & {
          hash: string;
        };
        transaction: {
          status: 'Pending' | 'Signed' | 'Rejected' | 'Executed' | 'Error';
          id: string;
          openfortId: string | null;
          sponsored: boolean;
          actionId: string | null;
          hash: string | null;
        };
      }
    | {
        type: 'ExchangeUnwrap';
        context: {
          amount: string;
        };
        signature: {
          type: 'Message';
          id: string;
          data: string;
          signature: string | null;
          actionId: string | null;
        } & {
          hash: string;
        };
        transaction: {
          status: 'Pending' | 'Signed' | 'Rejected' | 'Executed' | 'Error';
          id: string;
          openfortId: string | null;
          sponsored: boolean;
          actionId: string | null;
          hash: string | null;
        };
      }
    | {
        type: 'CustomTransaction';
        context: any;
        signature:
          | ({
              type: 'Message';
              id: string;
              data: string;
              signature: string | null;
              actionId: string | null;
            } & {
              hash: string;
            })
          | ({
              type: 'TypedData';
              id: string;
              data?: any;
              signature: string | null;
              actionId: string | null;
            } & {
              hash: string;
            });
        transaction: {
          status: 'Pending' | 'Signed' | 'Rejected' | 'Executed' | 'Error';
          id: string;
          openfortId: string | null;
          sponsored: boolean;
          actionId: string | null;
          hash: string | null;
        };
      }
    | {
        type: 'Sign';
        signature:
          | ({
              type: 'Message';
              id: string;
              data: string;
              signature: string | null;
              actionId: string | null;
            } & {
              hash: string;
            })
          | ({
              type: 'TypedData';
              id: string;
              data?: any;
              signature: string | null;
              actionId: string | null;
            } & {
              hash: string;
            });
      }
  ))[];
  transactions: Array<{
    status: 'Pending' | 'Signed' | 'Rejected' | 'Executed' | 'Error';
    id: string;
    openfortId: string | null;
    sponsored: boolean;
    actionId: string | null;
    hash: string;
    type:
      | 'OpenfortTransaction'
      | 'OpenfortReservoirOrder'
      | 'OpenfortRevokeSession'
      | null;
    externalId: string | null;
    signature: string | null;
    transactionHash: string | null;
    operationId: string | null;
    data?: any;
  }>;
  url: string;
};

export namespace CommonOperationResponse {
  export enum status {
    PENDING = 'Pending',
    SIGNED = 'Signed',
    REJECTED = 'Rejected',
    EXECUTED = 'Executed',
    ERROR = 'Error',
  }

  export enum processing {
    SIGN_ONLY = 'SignOnly',
    EXECUTE = 'Execute',
  }
}
