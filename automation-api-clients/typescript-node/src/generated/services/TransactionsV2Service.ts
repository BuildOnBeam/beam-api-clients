/* generated using openapi-typescript-codegen -- do not edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { CreateTransactionRequestInputV2 } from '../models/CreateTransactionRequestInputV2';
import type { GetTransactionsResponseV2 } from '../models/GetTransactionsResponseV2';
import type { TransactionResponse } from '../models/TransactionResponse';
import type { CancelablePromise } from '../core/CancelablePromise';
import type { BaseHttpRequest } from '../core/BaseHttpRequest';
export class TransactionsV2Service {
  constructor(public readonly httpRequest: BaseHttpRequest) {}
  /**
   * Get a paginated list of transactions from your game
   * @param limit
   * @param offset
   * @returns GetTransactionsResponseV2
   * @throws ApiError
   */
  public getTransactionsV2(
    limit = 10,
    offset = 0,
  ): CancelablePromise<GetTransactionsResponseV2> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v2/transactions',
      query: {
        limit: limit,
        offset: offset,
      },
    });
  }
  /**
   * Getting a transaction
   * @param transactionId
   * @returns TransactionResponse
   * @throws ApiError
   */
  public getTransactionV2(
    transactionId: string,
  ): CancelablePromise<TransactionResponse> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v2/transactions/{transactionId}',
      path: {
        transactionId: transactionId,
      },
    });
  }
  /**
   * Get a paginated list of transactions created on behalf of a profile
   * @param entityId
   * @param limit
   * @param offset
   * @returns GetTransactionsResponseV2
   * @throws ApiError
   */
  public getProfileTransactionsV2(
    entityId: string,
    limit = 10,
    offset = 0,
  ): CancelablePromise<GetTransactionsResponseV2> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v2/transactions/profiles/{entityId}',
      path: {
        entityId: entityId,
      },
      query: {
        limit: limit,
        offset: offset,
      },
    });
  }
  /**
   * Creating a new transaction on behalf of a profile
   * @param entityId
   * @param requestBody
   * @returns TransactionResponse
   * @throws ApiError
   */
  public createProfileTransactionV2(
    entityId: string,
    requestBody: CreateTransactionRequestInputV2,
  ): CancelablePromise<TransactionResponse> {
    return this.httpRequest.request({
      method: 'POST',
      url: '/v2/transactions/profiles/{entityId}',
      path: {
        entityId: entityId,
      },
      body: requestBody,
      mediaType: 'application/json',
    });
  }
}
