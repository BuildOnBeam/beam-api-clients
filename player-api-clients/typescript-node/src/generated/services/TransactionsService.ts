/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { CreateTransactionRequestInput } from '../models/CreateTransactionRequestInput';
import type { GetTransactionResponse } from '../models/GetTransactionResponse';
import type { GetTransactionsResponse } from '../models/GetTransactionsResponse';
import type { PlayerOperationResponse } from '../models/PlayerOperationResponse';
import type { CancelablePromise } from '../core/CancelablePromise';
import type { BaseHttpRequest } from '../core/BaseHttpRequest';
export class TransactionsService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}
  /**
   * Get a paginated list of transactions from your game
   * @param limit
   * @param offset
   * @returns GetTransactionsResponse
   * @throws ApiError
   */
  public getTransactions(
    limit: number = 10,
    offset: number = 0,
  ): CancelablePromise<GetTransactionsResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/transactions',
      query: {
        'limit': limit,
        'offset': offset,
      },
    });
  }
  /**
   * Getting a transaction
   * @param transactionId
   * @returns GetTransactionResponse
   * @throws ApiError
   */
  public getTransaction(
    transactionId: string,
  ): CancelablePromise<GetTransactionResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/transactions/{transactionId}',
      path: {
        'transactionId': transactionId,
      },
    });
  }
  /**
   * Get a paginated list of transactions created on behalf of a user
   * @param entityId
   * @param limit
   * @param offset
   * @returns GetTransactionsResponse
   * @throws ApiError
   */
  public getUserTransactions(
    entityId: string,
    limit: number = 10,
    offset: number = 0,
  ): CancelablePromise<GetTransactionsResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/player/transactions/users/{entityId}',
      path: {
        'entityId': entityId,
      },
      query: {
        'limit': limit,
        'offset': offset,
      },
    });
  }
  /**
   * Creating a new transaction on behalf of a user
   * @param entityId
   * @param requestBody
   * @returns PlayerOperationResponse
   * @throws ApiError
   */
  public createUserTransaction(
    entityId: string,
    requestBody: CreateTransactionRequestInput,
  ): CancelablePromise<PlayerOperationResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v1/player/transactions/users/{entityId}',
      path: {
        'entityId': entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
}
