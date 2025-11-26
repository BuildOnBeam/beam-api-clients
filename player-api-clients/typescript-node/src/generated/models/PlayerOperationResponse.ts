/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export type PlayerOperationResponse = {
  status: PlayerOperationResponse.status;
  processing: PlayerOperationResponse.processing;
  authProvider: PlayerOperationResponse.authProvider;
  id: string;
  createdAt: string;
  updatedAt: string | null;
  gameId: string;
  userId: string;
  chainId: number;
  actions: Array<{
    type:
      | 'FiatOnRamp'
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
    context?: any;
    signature?: {
      type: 'Message' | 'TypedData';
      id: string;
      data?: any;
      signature: string | null;
      actionId: string | null;
      hash?: string | null;
    } | null;
    transaction?: {
      status: 'Pending' | 'Signed' | 'Rejected' | 'Executed' | 'Error';
      id: string;
      openfortId: string | null;
      sponsored: boolean;
      actionId: string | null;
      hash: string | null;
    } | null;
  }>;
  url: string;
  /**
   * Legacy transactions property. Please deprecate the usage and move to the OperationResponse.Actions[] array instead.
   * @deprecated
   */
  transactions: Array<any>;
};
export namespace PlayerOperationResponse {
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
  export enum authProvider {
    ANY = 'Any',
    GOOGLE = 'Google',
    DISCORD = 'Discord',
    APPLE = 'Apple',
  }
}
